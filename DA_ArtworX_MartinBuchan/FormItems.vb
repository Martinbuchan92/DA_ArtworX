Imports ArtworxBOC
Public Class FormItems
    Private i As List(Of ArtworxBOC.Item)
    Private index As Integer
    Private limit As Integer
    Private curRow As Integer

    Private Sub FormItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        i = ArtworxBOC.Item.Create()
        index = 0
        curRow = 0

        For Each item In i
            CmbSelectItem.Items.Add(item.name + ", " + item.artist)
        Next
    End Sub

    Private Sub DisplayListData()
        Me.txtItemID.Text = i.Item(index).itemID
        Me.txtCategoryID.Text = i.Item(index).categoryID
        Me.txtName.Text = i.Item(index).name
        Me.txtDescription.Text = i.Item(index).description
        Me.txtArtist.Text = i.Item(index).artist
        Me.txtStartPrice.Text = i.Item(index).startPrice
        Me.txtSoldPrice.Text = i.Item(index).soldPrice
        Me.txtSoldTo.Text = i.Item(index).soldToID
    End Sub

    Private Sub CmbSelectItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSelectItem.SelectedIndexChanged
        index = CmbSelectItem.SelectedIndex
        DisplayListData()
        If Not txtSoldPrice.Text.Equals("0") Then
            lblSold.Visible = True
        Else
            lblSold.Visible = False
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class