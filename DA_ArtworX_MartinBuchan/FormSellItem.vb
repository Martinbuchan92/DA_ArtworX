Imports ArtworxBOC

Public Class FormSellItem
    Dim i As List(Of Item)
    Dim b As List(Of Bid)
    Dim customerID As String
    Dim highestBid As Decimal

    Private Sub FormSellItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        i = Item.Create
        b = Bid.Create

        For Each item In i
            CmbItem.Items.Add(item.name)
        Next
    End Sub

    Private Sub CmbItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbItem.SelectedIndexChanged

        highestBid = Item.gethighestBid(CmbItem.SelectedIndex)
        Me.TxtHighestBid.Text = highestBid

        For Each bid In b
            If bid.itemID.Equals(i.Item(CmbItem.SelectedIndex).itemID) Then
                If bid.bidPrice = highestBid Then
                    customerID = bid.bidCustomerID
                End If
            End If
        Next

        Me.TxtCustomerID.Text = customerID

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        'TODO: Add stuff

    End Sub
End Class