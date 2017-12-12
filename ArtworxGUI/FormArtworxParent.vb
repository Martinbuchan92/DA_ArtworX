Imports System.Windows.Forms

Public Class FormArtworxParent
    Private m_ChildFormNumber As Integer

    Private Sub ViewCustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCustomersToolStripMenuItem.Click
        Dim f As New FormCustomerItemMasterDetail
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub BidProcessingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BidProcessingToolStripMenuItem.Click
        Dim f As New FormProcessBid
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ViewCustomersToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewCustomersToolStripMenuItem1.Click
        Dim f As New FormCustomers
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ViewItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewItemsToolStripMenuItem.Click
        Dim f As New FormItems
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub AuctionQueriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuctionQueriesToolStripMenuItem.Click
        Dim f As New FormSellItem
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
