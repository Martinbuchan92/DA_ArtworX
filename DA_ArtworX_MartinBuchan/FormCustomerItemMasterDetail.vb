Imports ArtworxBOC
Imports DA_ArtworX_MartinBuchan



Public Class FormCustomerItemMasterDetail
    Implements IMDIChild

    Public Function ProcessAdd() As Boolean Implements IMDIChild.ProcessAdd
        Throw New NotImplementedException()
    End Function

    Public Function ProcessDelete() As Boolean Implements IMDIChild.ProcessDelete
        Throw New NotImplementedException()
    End Function

    Public Function ProcessEdit() As Boolean Implements IMDIChild.ProcessEdit
        Throw New NotImplementedException()
    End Function

    Public Function ProcessFind() As Boolean Implements IMDIChild.ProcessFind
        Throw New NotImplementedException()
    End Function

    Public Function ProcessUpdate() As Boolean Implements IMDIChild.ProcessUpdate
        Throw New NotImplementedException()
    End Function

    Public Function ProcessCancel() As Boolean Implements IMDIChild.ProcessCancel
        Throw New NotImplementedException()
    End Function

    Public Function MoveFirst() As Boolean Implements IMDIChild.MoveFirst
        Throw New NotImplementedException()
    End Function

    Public Function MovePrevious() As Boolean Implements IMDIChild.MovePrevious
        Throw New NotImplementedException()
    End Function

    Public Function MoveNext() As Boolean Implements IMDIChild.MoveNext
        Throw New NotImplementedException()
    End Function

    Public Function MoveLast() As Boolean Implements IMDIChild.MoveLast
        Throw New NotImplementedException()
    End Function

    Private Sub FormCustomerItemMasterDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CustomerBindingSource.DataSource = ArtworxBOC.Customer.Create()
        Dim customerID As String
        customerID = Me.CustomerIDTextBox.Text
        Me.ItemBindingSource.DataSource = ArtworxBOC.Item.GetItemsByCustomer(customerID)
    End Sub
End Class