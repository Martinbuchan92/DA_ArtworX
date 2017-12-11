Imports ArtworxBOC

Public Class FormCustomerItemMasterDetail
    Dim c As New Customer

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub FormCustomerItemMasterDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CustomerBindingSource.DataSource = ArtworxBOC.Customer.Create()
        UpdateGrid()
    End Sub

    Private Sub UpdateGrid()
        Dim custID As String = Me.CustomerIDTextBox.Text
        Me.ItemBindingSource.DataSource = ArtworxBOC.Item.GetItemsByCustomer(custID)
        ItemDataGridView.AutoResizeColumns()
    End Sub

    'Private Sub BindingNavigatorMoveFirstItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveFirstItem.Click
    '    Me.UpdateGrid()
    'End Sub

    'Private Sub BindingNavigatorMovePreviousItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMovePreviousItem.Click
    '    Me.UpdateGrid()
    'End Sub

    'Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click
    '    Me.UpdateGrid()
    'End Sub

    'Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItem.Click
    '    Me.UpdateGrid()
    'End Sub

    ' Binding to navigators caused an error related to execution order
    Private Sub CustomerIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles CustomerIDTextBox.TextChanged
        Me.UpdateGrid
    End Sub
End Class