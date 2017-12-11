Imports ArtworxDAC.DAC

Public Class Bid
    Inherits BOBase

    Dim _bidID As Integer
    Dim _itemID As Integer
    Dim _pickup As Boolean
    Dim _bidPrice As Decimal
    Dim _bidDate As Nullable(Of Date)
    Dim _bidCustomerID As String
    Dim _lastUpdateUser As String


#Region "Constants"
    Private Const CN_bidID As String = "bidID"
    Private Const CN_itemID As String = "itemID"
    Private Const CN_pickup As String = "pickup"
    Private Const CN_bidPrice As String = "bidPrice"
    Private Const CN_bidDate As String = "bidDate"
    Private Const CN_bidCustomerID As String = "bidCustomerID"
#End Region

#Region "Constructors"
    Public Sub New()
        EntityState = EntityStateEnum.Added
    End Sub
#End Region

#Region "Class Factory Methods"
    Public Shared Function Create(ByRef dt As DataTable) As DataTable
        Return ArtworxDAC.DAC.ExecuteDataTable(My.Settings.SP_BidList)
    End Function

    Public Shared Function Create(ByVal bidID As String) As Bid
        Dim c As Bid
        Dim dt As DataTable

        dt = ArtworxDAC.DAC.ExecuteDataTable(My.Settings.SP_BidGetById, ArtworxDAC.DAC.Parameter(CN_bidID, bidID))
        c = New Bid()
        With dt.Rows(0)
            c.bidID = .Item(CN_bidID.ToString)
            c.itemID = .Item(CN_itemID.ToString)
            c.pickup = .Item(CN_pickup.ToString)
            c.bidPrice = .Item(CN_bidPrice.ToString)
            c.bidDate = .Item(CN_bidDate.ToString)
            c.bidCustomerID = .Item(CN_bidCustomerID.ToString)
        End With
        c.DataStateChanged(EntityStateEnum.UnChanged)
        Return c
    End Function

    Public Shared Function Create() As List(Of Bid)
        Dim cl As List(Of Bid)
        Dim dt As New DataTable
        Dim c As Bid
        Dim i As Integer

        dt = ArtworxDAC.DAC.ExecuteDataTable(My.Settings.SP_BidList)
        cl = New List(Of Bid)
        For i = 0 To dt.Rows.Count - 1
            c = New Bid()
            With dt.Rows(i)
                c.bidID = .Item(CN_bidID.ToString)
                c.itemID = .Item(CN_itemID.ToString)
                c.pickup = .Item(CN_pickup.ToString)
                c.bidPrice = .Item(CN_bidPrice.ToString)
                c.bidDate = .Item(CN_bidDate.ToString)
                c.bidCustomerID = .Item(CN_bidCustomerID.ToString)
            End With
            cl.Add(c)
        Next
        Return cl
    End Function

    Public Shared Function CustIDForHighestBid(ByVal itemID As Integer) As String
        Dim customerID As String = ""
        Dim b As List(Of Bid) = Bid.Create()
        Dim i As List(Of Item) = Item.Create()

        For Each bid In b
            If itemID = bid.itemID Then
                If bid.bidPrice = Bidhighestforitem(itemID) Then
                    customerID = bid.bidCustomerID
                End If
            End If
        Next

        Return customerID
    End Function

    Public Shared Function Bidhighestforitem(ByVal itemID As Integer) As String
        Dim dt As New DataTable
        Dim hb As Decimal

        dt = ArtworxDAC.DAC.ExecuteDataTable(My.Settings.SP_BidHighestForItem, ArtworxDAC.DAC.Parameter("highestBid", 0), ArtworxDAC.DAC.Parameter("item_ID", itemID))
        If Not (dt Is Nothing) Then
            With dt.Rows(0)
                If .Item(0) IsNot DBNull.Value Then
                    hb = .Item(0)
                End If
            End With
        End If
        Return Format(hb, "c")
    End Function

    Public Shared Function setWinningBid(ByVal itemID As Integer, ByVal highestBid As Decimal, ByVal customerID As String) As Boolean
        Dim dt As New DataTable
        Dim success As Boolean = False
        dt = ArtworxDAC.DAC.ExecuteDataTable(My.Settings.SP_SetWinningBidForItem, ArtworxDAC.DAC.Parameter("HighestBid", highestBid), ArtworxDAC.DAC.Parameter("item_ID", itemID), ArtworxDAC.DAC.Parameter("Winning_Customer", 0))
        success = True
        Return success
    End Function

    Public Function Save() As Boolean
        Dim success As Boolean = False
        Dim dt As DataTable
        dt = ArtworxDAC.DAC.ExecuteDataTable(My.Settings.SP_BidSave,
            ArtworxDAC.DAC.Parameter("bid_ID", bidID),
            ArtworxDAC.DAC.Parameter("bid_itemID", itemID),
            ArtworxDAC.DAC.Parameter("bid_pickup", pickup),
            ArtworxDAC.DAC.Parameter("bid_bidPrice", bidPrice),
            ArtworxDAC.DAC.Parameter("bid_bidDate", bidDate),
            ArtworxDAC.DAC.Parameter("bid_bidCustomerID", bidCustomerID),
            ArtworxDAC.DAC.Parameter("LastUpdateUser", "mb"),
            ArtworxDAC.DAC.Parameter(CN_RowState, EntityState.ToString))
        If EntityState = EntityStateEnum.Added Then
            bidID = CType(dt.Rows(0).Item(CN_bidID), Integer)
        End If
        Me.DataStateChanged(EntityStateEnum.UnChanged)
        success = True
        Return success
    End Function
#End Region

#Region "Property Procedures"
    Public Property bidID() As Integer
        Get
            Return _bidID
        End Get
        Set(ByVal value As Integer)
            If _bidID <> value Then
                _bidID = value
                Me.DataStateChanged(EntityStateEnum.Modified)
            End If
        End Set
    End Property

    Public Property itemID() As Integer
        Get
            Return _itemID
        End Get
        Set(ByVal value As Integer)
            If _itemID <> value Then
                _itemID = value
                Me.DataStateChanged(EntityStateEnum.Modified)
            End If
        End Set
    End Property

    Public Property pickup() As Boolean
        Get
            Return _pickup
        End Get
        Set(ByVal value As Boolean)
            If _pickup <> value Then
                _pickup = value
                Me.DataStateChanged(EntityStateEnum.Modified)
            End If
        End Set
    End Property

    Public Property bidPrice() As Decimal
        Get
            Return Decimal.Round(_bidPrice, 2)
        End Get
        Set(ByVal value As Decimal)
            If _bidPrice <> value Then
                If value >= 1000000.0 Then
                    _bidPrice = value
                    Me.DataStateChanged(EntityStateEnum.Modified)
                Else
                    value = 1000000.0
                End If
            End If
        End Set
    End Property

    Public Property bidDate() As Nullable(Of Date)
        Get
            Return _bidDate
        End Get
        Set(ByVal value As Nullable(Of Date))
            If (bidDate.HasValue <> value.HasValue) OrElse
                    (bidDate.HasValue AndAlso
                    value.HasValue AndAlso
                    bidDate.Value <> value.Value) Then
                Me.DataStateChanged(EntityStateEnum.Modified)
                _bidDate = value
            End If
        End Set
    End Property

    Public Property bidCustomerID() As String
        Get
            Return _bidCustomerID
        End Get
        Set(ByVal value As String)
            If _bidCustomerID <> value Then
                _bidCustomerID = value
                Me.DataStateChanged(EntityStateEnum.Modified)
            End If
        End Set
    End Property
#End Region

End Class
