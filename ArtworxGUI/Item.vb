Public Class Item
    Inherits BOBase

    Private _itemID As Integer
    Private _categoryID As Integer
    Private _name As String
    Private _description As String
    Private _artist As String
    Private _startPrice As Nullable(Of Decimal)
    Private _soldPrice As Nullable(Of Decimal)
    Private _soldToID As String
    Private _highestBid As Nullable(Of Decimal)

#Region "Constants"
    Private Const CN_itemID As String = "itemID"
    Private Const CN_categoryID As String = "categoryID"
    Private Const CN_name As String = "name"
    Private Const CN_description As String = "description"
    Private Const CN_artist As String = "artist"
    Private Const CN_startPrice As String = "startPrice"
    Private Const CN_soldPrice As String = "soldPrice"
    Private Const CN_soldToID As String = "soldToID"

    Private Const CN_highestBid As String = "HighestBid"
    Private Const CN_spItemID As String = "Item_ID"

#End Region

#Region "Constructors"
    Public Sub New()

    End Sub

    Public Sub New(ByVal itemID As Integer)

    End Sub
#End Region

#Region "Class Factory Methods"
    Public Shared Function Create(ByRef dt As DataTable) As DataTable
        Return ArtworxDAC.DAC.ExecuteDataTable(My.Settings.SP_ItemList)
    End Function

    Public Shared Function Create(ByVal itemID As String) As Item
        Dim i As Item
        Dim dt As DataTable

        dt = ArtworxDAC.DAC.ExecuteDataTable(My.Settings.SP_ItemGetByID, ArtworxDAC.DAC.Parameter(CN_itemID, itemID))
        i = New Item()
        With dt.Rows(0)
            i.itemID = .Item(CN_itemID.ToString)
            i.categoryID = .Item(CN_categoryID.ToString)
            i.name = .Item(CN_name.ToString)
            i.description = .Item(CN_description.ToString)
            i.artist = .Item(CN_artist.ToString)
            i.startPrice = .Item(CN_startPrice.ToString)
            i.soldPrice = .Item(CN_soldPrice.ToString)
            i.soldToID = .Item(CN_soldToID.ToString)
        End With
        i.DataStateChanged(EntityStateEnum.UnChanged)
        Return i
    End Function

    Public Shared Function Create() As List(Of Item)
        Dim il As List(Of Item)
        Dim dt As New DataTable
        Dim i As Item
        Dim n As Integer

        dt = ArtworxDAC.DAC.ExecuteDataTable(My.Settings.SP_ItemList)
        il = New List(Of Item)
        For n = 0 To dt.Rows.Count - 1
            i = New Item()
            With dt.Rows(n)
                i.itemID = .Item(CN_itemID.ToString)
                i.categoryID = .Item(CN_categoryID.ToString)
                i.name = .Item(CN_name.ToString)
                i.description = .Item(CN_description.ToString)
                i.artist = .Item(CN_artist.ToString)
                i.startPrice = .Item(CN_startPrice.ToString)
                If .Item(CN_soldPrice) IsNot DBNull.Value Then
                    i.soldPrice = CType(.Item(CN_soldPrice), Decimal)
                End If
                If .Item(CN_soldToID) IsNot DBNull.Value Then
                    i.soldToID = CType(.Item(CN_soldToID), Decimal)
                End If

            End With
            il.Add(i)
        Next
        Return il
    End Function

    Public Function Save() As Boolean
        Dim success As Boolean = False
        Dim dt As DataTable
        dt = ArtworxDAC.DAC.ExecuteDataTable(My.Settings.SP_ItemSave,
            ArtworxDAC.DAC.Parameter(CN_itemID, itemID),
            ArtworxDAC.DAC.Parameter(CN_categoryID, categoryID),
            ArtworxDAC.DAC.Parameter(CN_name, name),
            ArtworxDAC.DAC.Parameter(CN_description, description),
            ArtworxDAC.DAC.Parameter(CN_artist, artist),
            ArtworxDAC.DAC.Parameter(CN_startPrice, startPrice),
            ArtworxDAC.DAC.Parameter(CN_soldPrice, soldPrice),
            ArtworxDAC.DAC.Parameter(CN_soldToID, soldToID))
        If EntityState = EntityStateEnum.Added Then
            itemID = CType(dt.Rows(0).Item(CN_itemID), String)
        End If
        Me.DataStateChanged(EntityStateEnum.UnChanged)
        success = True
        Return success
    End Function

    Public Shared Function GetItemsByCustomer(ByVal customerID As String) As List(Of Item)
        Dim il As List(Of Item) = New List(Of Item)
        Dim rl As List(Of Item) = New List(Of Item)
        il = Item.Create()

        For Each item In il
            If Not String.IsNullOrEmpty(item.soldToID) Then
                If item.soldToID.Equals(customerID) Then
                    rl.Add(item)
                End If
            End If
        Next
        Return rl
    End Function

    Public Shared Function gethighestBid(ByVal itemID As Integer) As Decimal
        Dim highestBid As Decimal
        Dim b As List(Of Bid) = ArtworxBOC.Bid.Create()
        Dim i As List(Of Item) = ArtworxBOC.Item.Create()

        'Dim dt As DataTable
        'dt = ArtworxDAC.DAC.ExecuteDataTable(My.Settings.SP_BidHighestForItem,
        '    ArtworxDAC.DAC.Parameter(CN_highestBid, highestBid),
        '    ArtworxDAC.DAC.Parameter(CN_spItemID, itemID))
        'highestBid = CType(dt.Rows(0).Item(0), Integer)

        For Each bid In b
            For Each item In i

            Next
        Next

        Return highestBid
    End Function
#End Region

#Region "Property Procedures"
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

    Public Property categoryID() As Integer
        Get
            Return _categoryID
        End Get
        Set(ByVal value As Integer)
            If _categoryID <> value Then
                _categoryID = value
                Me.DataStateChanged(EntityStateEnum.Modified)
            End If
        End Set
    End Property

    Public Property name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            If _name <> value Then
                _name = value
                Me.DataStateChanged(EntityStateEnum.Modified)
            End If
        End Set
    End Property

    Public Property description() As String
        Get
            Return _description
        End Get
        Set(ByVal value As String)
            If IsDBNull(value) Then
                _description = String.Empty
            Else
                If _description <> value Then
                    _description = value
                    Me.DataStateChanged(EntityStateEnum.Modified)
                End If
            End If
        End Set
    End Property

    Public Property artist() As String
        Get
            Return _artist
        End Get
        Set(ByVal value As String)
            If _artist <> value Then
                _artist = value
                Me.DataStateChanged(EntityStateEnum.Modified)
            End If
        End Set
    End Property

    Public Property startPrice() As Decimal
        Get
            If _startPrice.HasValue AND _startPrice >= 1000 then
                Return Decimal.Round(_startPrice.Value, 2)
            End If
            Return 100000.0
        End Get
        Set(ByVal value As Decimal)
            If _startPrice <> value Then
                _startPrice = value
                Me.DataStateChanged(EntityStateEnum.Modified)
            End If
        End Set
    End Property

    Public Property soldPrice() As Nullable(Of Decimal)
        Get
            If _soldPrice.HasValue Then
                Return Decimal.Round(_soldPrice.Value, 2)
            End If
            Return 0.00
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            If (_soldPrice.HasValue <> value.HasValue) OrElse
                (_soldPrice.HasValue AndAlso
                value.HasValue AndAlso
                _soldPrice.Value <> value.Value) Then
                _soldPrice = value
                Me.DataStateChanged(EntityStateEnum.Modified)

            Else
                _soldPrice = 0.0
            End If
        End Set
    End Property

    Public Property soldToID() As String
        Get
            Return _soldToID
        End Get
        Set(ByVal value As String)
            If IsDBNull(value) Then
                _soldToID = String.Empty
            Else
                If _soldToID <> value Then
                    _soldToID = value
                    Me.DataStateChanged(EntityStateEnum.Modified)
                End If
            End If
        End Set
    End Property
#End Region
End Class
