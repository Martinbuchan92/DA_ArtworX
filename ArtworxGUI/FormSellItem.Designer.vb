<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSellItem
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
        Me.CmbItem = New System.Windows.Forms.ComboBox()
        Me.TxtHighestBid = New System.Windows.Forms.TextBox()
        Me.TxtCustomerID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CmbItem
        '
        Me.CmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbItem.FormattingEnabled = True
        Me.CmbItem.Location = New System.Drawing.Point(114, 12)
        Me.CmbItem.Name = "CmbItem"
        Me.CmbItem.Size = New System.Drawing.Size(151, 21)
        Me.CmbItem.TabIndex = 0
        '
        'TxtHighestBid
        '
        Me.TxtHighestBid.Location = New System.Drawing.Point(114, 40)
        Me.TxtHighestBid.Name = "TxtHighestBid"
        Me.TxtHighestBid.Size = New System.Drawing.Size(151, 20)
        Me.TxtHighestBid.TabIndex = 1
        '
        'TxtCustomerID
        '
        Me.TxtCustomerID.Location = New System.Drawing.Point(114, 66)
        Me.TxtCustomerID.Name = "TxtCustomerID"
        Me.TxtCustomerID.Size = New System.Drawing.Size(151, 20)
        Me.TxtCustomerID.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Item"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Highest Bid"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 69)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Customer ID"
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(73, 119)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(111, 23)
        Me.btnConfirm.TabIndex = 6
        Me.btnConfirm.Text = "Confirm Sale"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(190, 119)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'FormSellItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 154)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCustomerID)
        Me.Controls.Add(Me.TxtHighestBid)
        Me.Controls.Add(Me.CmbItem)
        Me.Name = "FormSellItem"
        Me.Text = "Accept Bid"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbItem As ComboBox
    Friend WithEvents TxtHighestBid As TextBox
    Friend WithEvents TxtCustomerID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnClose As Button
End Class
