Imports ArtworxBOC

Public Class FormSellItem
    Dim i As List(Of Item)
    Dim b As List(Of Bid)
    Dim customerID As String
    Dim highestBid As String
    Dim itemID As Integer

    Private Sub FormSellItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        i = Item.Create
        b = Bid.Create

        For Each item In i
            If item.soldToID Is Nothing Then
                CmbItem.Items.Add(item.name)
            End If
        Next
    End Sub

    Private Sub CmbItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbItem.SelectedIndexChanged
        itemID = i.Item(CmbItem.SelectedIndex).itemID
        highestBid = Bid.Bidhighestforitem(itemID)
        customerID = Bid.CustIDForHighestBid(itemID)

        Me.TxtHighestBid.Text = highestBid
        Me.TxtCustomerID.Text = customerID

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim success As Boolean
        success = Bid.setWinningBid(itemID, 0, 0)
        MsgBox(success.ToString)
    End Sub
End Class