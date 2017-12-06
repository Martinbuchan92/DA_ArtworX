﻿Public Class Item
    Inherits BOBase

    Dim _itemID As Integer
    Dim _categoryID As Integer
    Dim _name As String
    Dim _description As String
    Dim _artist As String
    Dim _startPrice As Decimal
    Dim _soldPrice As Decimal
    Dim _soldToID As String

#Region "Constants"
    Private Const CN_itemID As String = "itemID"
    Private Const CN_categoryID As String = "categoryID"
    Private Const CN_name As String = "name"
    Private Const CN_description As String = "description"
    Private Const CN_artist As String = "artist"
    Private Const CN_startPrice As String = "startPrice"
    Private Const CN_soldPrice As String = "soldPrice"
    Private Const CN_soldToID As String = "soldToID"
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
                i.soldPrice = .Item(CN_soldPrice.ToString)
                i.soldToID = .Item(CN_soldToID.ToString)
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
            If _description <> value Then
                _description = value
                Me.DataStateChanged(EntityStateEnum.Modified)
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
            Return Decimal.Round(_startPrice, 2)
        End Get
        Set(ByVal value As Decimal)
            If _startPrice <> value Then
                _startPrice = value
                Me.DataStateChanged(EntityStateEnum.Modified)
            End If
        End Set
    End Property

    Public Property soldPrice() As Decimal
        Get
            Return Decimal.Round(_soldPrice, 2)
        End Get
        Set(ByVal value As Decimal)
            If _soldPrice <> value Then
                _soldPrice = value
                Me.DataStateChanged(EntityStateEnum.Modified)
            End If
        End Set
    End Property

    Public Property soldToID() As String
        Get
            Return _soldToID
        End Get
        Set(ByVal value As String)
            If _soldToID <> value Then
                _soldToID = value
                Me.DataStateChanged(EntityStateEnum.Modified)
            End If
        End Set
    End Property
#End Region
End Class