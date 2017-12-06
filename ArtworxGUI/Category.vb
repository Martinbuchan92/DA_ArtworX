Public Class Category
    Inherits BOBase

    Dim _categoryID As Integer
    Dim _name As String
    Dim _description As String

#Region "Constants"
    Private Const CN_categoryID As String = "categoryID"
    Private Const CN_name As String = "name"
    Private Const CN_description As String = "description"
#End Region

#Region "Constructors"
    Public Sub New()

    End Sub

    Public Sub New(ByVal categoryID As Integer)

    End Sub
#End Region

#Region "Class Factory Methods"
    Public Shared Function Create(ByRef dt As DataTable) As DataTable
        Return ArtworxDAC.DAC.ExecuteDataTable(My.Settings.SP_CategoryList)
    End Function

    Public Shared Function Create(ByVal categoryID As String) As Category
        Dim c As Category
        Dim dt As DataTable

        dt = ArtworxDAC.DAC.ExecuteDataTable(My.Settings.SP_CustomerGetByID, ArtworxDAC.DAC.Parameter(CN_categoryID, categoryID))
        c = New Category()
        With dt.Rows(0)
            c.categoryID = .Item(CN_categoryID.ToString)
            c.name = .Item(CN_name.ToString)
            c.description = .Item(CN_description.ToString)
        End With
        c.DataStateChanged(EntityStateEnum.UnChanged)
        Return c
    End Function

    Public Shared Function Create() As List(Of Category)
        Dim cl As List(Of Category)
        Dim dt As New DataTable
        Dim c As Category
        Dim i As Integer

        dt = ArtworxDAC.DAC.ExecuteDataTable(My.Settings.SP_CategoryList)
        cl = New List(Of Category)
        For i = 0 To dt.Rows.Count - 1
            c = New Category()
            With dt.Rows(i)
                c.categoryID = .Item(CN_categoryID.ToString)
                c.name = .Item(CN_name.ToString)
                c.description = .Item(CN_description.ToString)
            End With
            cl.Add(c)
        Next
        Return cl
    End Function

    Public Function Save() As Boolean
        Dim success As Boolean = False
        Dim dt As DataTable
        dt = ArtworxDAC.DAC.ExecuteDataTable(My.Settings.SP_CategoryList,
            ArtworxDAC.DAC.Parameter(CN_categoryID, categoryID),
            ArtworxDAC.DAC.Parameter(CN_name, name),
            ArtworxDAC.DAC.Parameter(CN_description, description))

        If EntityState = EntityStateEnum.Added Then
            CategoryID = CType(dt.Rows(0).Item(CN_categoryID), String)
        End If
        Me.DataStateChanged(EntityStateEnum.UnChanged)
        success = True
        Return success
    End Function
#End Region

#Region "Property Procedures"
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

#End Region

End Class
