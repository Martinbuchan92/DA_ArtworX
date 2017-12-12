Imports ArtworxDAC
Imports System.Data.SqlClient

Public Class BOBase
    
#Region "private constants"
    protected const CN_LastUpdateUser As String = "LastUpdateUser"
    Protected Const CN_RowState As String = "RowState"
#End Region

#Region "fields"
    Public Enum EntityStateEnum
        UnChanged
        Added
        Deleted
        Modified
    End Enum
#End Region

    Private _EntityState As EntityStateEnum
    Protected Property EntityState() As EntityStateEnum
        Get
            Return _EntityState
        End Get
        Set(ByVal value As EntityStateEnum)
            _EntityState = value
        End Set
    End Property

    Protected ReadOnly Property IsDirty() As Boolean
        Get
            Return (Me.EntityState <> EntityStateEnum.UnChanged)
        End Get
    End Property

    Protected Sub DataStateChanged(ByVal dataState As EntityStateEnum)
        ' if the state is deleted mark it deleted
        If dataState = EntityStateEnum.Deleted Then
            Me.EntityState = dataState
        End If

        ' only set data states if the existing state is unchanged
        If Me.EntityState = EntityStateEnum.UnChanged OrElse
                dataState = EntityStateEnum.UnChanged Then
            Me.EntityState = dataState
        End If
    End Sub

#Region "constructors"
    Public Sub New()
        EntityState = EntityStateEnum.Added
    End Sub
#End Region


End Class
