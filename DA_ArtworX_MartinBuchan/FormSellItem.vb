Imports ArtworxBOC

Public Class FormSellItem
    Dim i As List(Of Item)
    Dim b As List(Of Bid)
    Dim customerID As String
    Dim highestBid As String
    Dim itemIndex As Integer

    Private Sub FormSellItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        i = Item.Create
        b = Bid.Create

        For Each item In i
            CmbItem.Items.Add(item.name)
        Next
    End Sub

    Private Sub CmbItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbItem.SelectedIndexChanged
        itemIndex = CmbItem.SelectedIndex

        highestBid = Bid.Bidhighestforitem(i.Item(itemIndex).itemID, False)
        customerID = Bid.Bidhighestforitem(i.Item(itemIndex).itemID, True)
        Me.TxtHighestBid.Text = highestBid
        Me.TxtCustomerID.Text = customerID

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim success As Boolean
        success = Bid.setWinningBid(i.Item(itemIndex).itemID, 0, 0)
        MsgBox(success.ToString)
    End Sub
End Class