<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormArtworxParent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCustomersToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuctionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BidProcessingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuctionQueriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomersToolStripMenuItem, Me.ItemsToolStripMenuItem, Me.AuctionToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'CustomersToolStripMenuItem
        '
        Me.CustomersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewCustomersToolStripMenuItem, Me.ViewCustomersToolStripMenuItem1})
        Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.CustomersToolStripMenuItem.Text = "Customers"
        '
        'ViewCustomersToolStripMenuItem
        '
        Me.ViewCustomersToolStripMenuItem.Name = "ViewCustomersToolStripMenuItem"
        Me.ViewCustomersToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ViewCustomersToolStripMenuItem.Text = "Customers and Items"
        '
        'ViewCustomersToolStripMenuItem1
        '
        Me.ViewCustomersToolStripMenuItem1.Name = "ViewCustomersToolStripMenuItem1"
        Me.ViewCustomersToolStripMenuItem1.Size = New System.Drawing.Size(186, 22)
        Me.ViewCustomersToolStripMenuItem1.Text = "View Customers"
        '
        'ItemsToolStripMenuItem
        '
        Me.ItemsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewItemsToolStripMenuItem})
        Me.ItemsToolStripMenuItem.Name = "ItemsToolStripMenuItem"
        Me.ItemsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ItemsToolStripMenuItem.Text = "Items"
        '
        'ViewItemsToolStripMenuItem
        '
        Me.ViewItemsToolStripMenuItem.Name = "ViewItemsToolStripMenuItem"
        Me.ViewItemsToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ViewItemsToolStripMenuItem.Text = "View Items"
        '
        'AuctionToolStripMenuItem
        '
        Me.AuctionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BidProcessingToolStripMenuItem, Me.AuctionQueriesToolStripMenuItem})
        Me.AuctionToolStripMenuItem.Name = "AuctionToolStripMenuItem"
        Me.AuctionToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.AuctionToolStripMenuItem.Text = "Auction"
        '
        'BidProcessingToolStripMenuItem
        '
        Me.BidProcessingToolStripMenuItem.Name = "BidProcessingToolStripMenuItem"
        Me.BidProcessingToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.BidProcessingToolStripMenuItem.Text = "Create Bid"
        '
        'AuctionQueriesToolStripMenuItem
        '
        Me.AuctionQueriesToolStripMenuItem.Name = "AuctionQueriesToolStripMenuItem"
        Me.AuctionQueriesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AuctionQueriesToolStripMenuItem.Text = "Accept Bid"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'FormArtworxParent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "FormArtworxParent"
        Me.Text = "Artworx Auctions"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents CustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewCustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewItemsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AuctionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BidProcessingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AuctionQueriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewCustomersToolStripMenuItem1 As ToolStripMenuItem
End Class
