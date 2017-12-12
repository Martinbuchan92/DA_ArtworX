Imports ArtWorxBOC
Public Class FormCustomers
    Private c As List(Of ArtworxBOC.Customer)
    Private index As Integer
    Private limit As Integer
    Private curRow As Integer

    Private Sub FormCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c = ArtworxBOC.Customer.Create()
        limit = c.Count - 1
        index = 0
        curRow = 0

        For Each person In c
            CmbSelectCustomer.Items.Add((person.firstName) + " " + (person.lastName) + ", " + (person.userName))
        Next
    End Sub

    Private Sub DisplayListData()
        Me.txtCustomerID.Text = c.Item(index).customerID
        Me.txtUsername.Text = c.Item(index).userName
        Me.txtPassword.Text = c.Item(index).password
        Me.txtFirstName.Text = c.Item(index).firstName
        Me.txtLastName.Text = c.Item(index).lastName
        Me.txtEmail.Text = c.Item(index).email
        Me.txtPhone.Text = c.Item(index).phone
        Me.txtAddress.Text = c.Item(index).address
        Me.txtCreditStatus.Text = c.Item(index).creditStatus
        Me.txtAccountName.Text = c.Item(index).accountName
        Me.txtAccountNumber.Text = c.Item(index).accountNumber
        Me.txtSwiftCode.Text = c.Item(index).swiftCode
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSelectCustomer.SelectedIndexChanged
        index = CmbSelectCustomer.SelectedIndex
        DisplayListData()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
