Imports ArtWorxBOC
Public Class FormCustomers
    Private c As List(Of ArtworxBOC.Customer)
    Private index As Integer
    Private limit As Integer
    Private curRow As Integer


    Private Enum DataEntryMode
        Browse
        Edit
    End Enum
    Private Mode As DataEntryMode

    Private Enum CursorDirection
        CursorFirst
        CursorPrevious
        CursorNext
        CursorLast
        CursorRefresh
    End Enum
    Private direction As CursorDirection

    Private Sub ClearTextBoxText()
        Dim ctrl As Control
        Dim t As TextBox
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is TextBox Then
                t = DirectCast(ctrl, TextBox)
                t.Text = String.Empty
            End If
            If TypeOf ctrl Is GroupBox Then
                Dim c As Control
                For Each c In ctrl.Controls
                    If TypeOf c Is TextBox Then
                        t = DirectCast(c, TextBox)
                        t.Text = String.Empty
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub SetTextBoxState(ByVal state As Boolean)
        Dim ctrl As Control
        Dim t As TextBox
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is TextBox Then
                t = DirectCast(ctrl, TextBox)
                t.ReadOnly = state
            End If
            If TypeOf ctrl Is GroupBox Then
                Dim c As Control
                For Each c In ctrl.Controls
                    If TypeOf c Is TextBox Then
                        t = DirectCast(c, TextBox)
                        t.ReadOnly = state
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub SetFormState(ByVal Mode As DataEntryMode)
        If Mode = DataEntryMode.Browse Then
            Me.btnAdd.Enabled = True
            Me.btnEdit.Enabled = True
            Me.btnUpdate.Enabled = False
            Me.btnDelete.Enabled = True
            Me.btnFind.Enabled = True
            Me.btnCancel.Enabled = False
            Me.btnFirst.Enabled = True
            Me.btnPrevious.Enabled = True
            Me.btnNext.Enabled = True
            Me.btnLast.Enabled = True
            Me.SetTextBoxState(True)
        Else
            Me.btnAdd.Enabled = False
            Me.btnEdit.Enabled = False
            Me.btnUpdate.Enabled = True
            Me.btnDelete.Enabled = False
            Me.btnFind.Enabled = False
            Me.btnCancel.Enabled = True
            Me.btnFirst.Enabled = False
            Me.btnPrevious.Enabled = False
            Me.btnNext.Enabled = False
            Me.btnLast.Enabled = False
            Me.SetTextBoxState(False)
        End If
    End Sub

    Private Sub FormCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetFormState(DataEntryMode.Browse)
        c = ArtworxBOC.Customer.Create()
        limit = c.Count - 1
        index = 0
        curRow = 0
        SetFormState(DataEntryMode.Browse)
        DisplayListData()

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

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        index = 0
        DisplayListData()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If index > 0 Then
            index = index - 1
            DisplayListData()

        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If index < limit Then
            index = index + 1
            DisplayListData()
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        index = limit
        DisplayListData()
        DataGridView1.DataSource = GetType(ArtworxBOC.Item)

    End Sub
End Class
