Imports ArtworxBOC

Public Class FormProcessBid
    Private c As List(Of ArtworxBOC.Customer)
    Private i As List(Of ArtworxBOC.Item)
    Private b As List(Of ArtworxBOC.Bid) = Bid.Create()
    Private a As List(Of ArtworxBOC.Category)
    Private itemIndex As Integer
    Private custIndex As Integer

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub FormProcessBid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c = ArtworxBOC.Customer.Create()
        b = ArtworxBOC.Bid.Create()
        i = ArtworxBOC.Item.Create()
        a = ArtworxBOC.Category.Create()
        For Each person In c
            cmbSelectCustomer.Items.Add(person.customerID)
        Next

        For Each item In i
            cmbSelectItem.Items.Add(item.name)
        Next

    End Sub

    Private Sub DisplayListData()
        Me.txtName.Text = i.Item(itemIndex).name
        Me.txtDescription.Text = i.Item(itemIndex).description
        Me.txtArtist.Text = i.Item(itemIndex).artist
        Me.txtStartPrice.Text = i.Item(itemIndex).startPrice
        Me.txtSoldPrice.Text = i.Item(itemIndex).soldPrice
        Me.txtSoldTo.Text = i.Item(itemIndex).soldToID

        For Each category In a
            If category.categoryID = i.Item(itemIndex).categoryID Then
                Me.txtCategory.Text = category.name
            End If
        Next
    End Sub

    Private Sub cmbSelectCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelectCustomer.SelectedIndexChanged
        custIndex = cmbSelectCustomer.SelectedIndex
        lblCreditStatus.Text = c(custIndex).creditStatus.ToString
    End Sub

    Private Sub cmbSelectItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelectItem.SelectedIndexChanged
        itemIndex = cmbSelectItem.SelectedIndex
        DisplayListData()

        'If Not IsNothing(b) Then
        '    Dim highestBid = Item.gethighestBid(itemIndex)
        '    For Each bid In b
        '        If bid.bidID = highestBid Then
        '            lblHighestBid.Text = bid.bidPrice.ToString
        '        End If
        '    Next

        'Else
        '    MsgBox("no bids")
        'End If

    End Sub

    Private Sub btnAcceptBid_Click(sender As Object, e As EventArgs) Handles btnAcceptBid.Click
        Dim bidAmount As Decimal = txtAmount.Text
        Dim bidDate As String = System.DateTime.Today

        'TODO: This 0.0 should be the highest bid
        If txtAmount.Text > 0.0 Then
            Dim d As New Bid() With {
            .itemID = i(itemIndex).itemID,
            .pickup = False,
            .bidPrice = bidAmount,
            .bidDate = bidDate.ToString,
            .bidCustomerID = c(custIndex).customerID}
            b.Add(d)
            Dim success As Boolean = d.Save()
            MsgBox("Added bid " + success.ToString)
        Else
            MsgBox("Please enter a higher bid")
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        txtName.Text = Bid.Bidhighestforitem(1)

    End Sub
End Class