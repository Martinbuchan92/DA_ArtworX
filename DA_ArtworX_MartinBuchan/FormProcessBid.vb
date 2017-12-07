Imports ArtworxBOC

Public Class FormProcessBid
    Private c As List(Of ArtworxBOC.Customer)
    Private i As List(Of ArtworxBOC.Item)
    Private b As List(Of ArtworxBOC.Bid)

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub FormProcessBid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c = ArtworxBOC.Customer.Create()
        b = ArtworxBOC.Bid.Create()
        i = ArtworxBOC.Item.Create()

        For Each person In c
            cmbSelectCustomer.Items.Add(person.customerID)
            lblCreditStatus.Text = person.creditStatus
        Next

        For Each bid In b

        Next

        For Each item In i
            cmbSelectItem.Items.Add(item.name)
            lblHighestBid.Text = "$0000"
        Next

    End Sub
End Class