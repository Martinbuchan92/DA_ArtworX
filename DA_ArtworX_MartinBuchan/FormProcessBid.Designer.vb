<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProcessBid
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbSelectItem = New System.Windows.Forms.ComboBox()
        Me.cmbSelectCustomer = New System.Windows.Forms.ComboBox()
        Me.lblHighestBid = New System.Windows.Forms.Label()
        Me.lblCreditStatus = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtSoldTo = New System.Windows.Forms.TextBox()
        Me.txtSoldPrice = New System.Windows.Forms.TextBox()
        Me.txtStartPrice = New System.Windows.Forms.TextBox()
        Me.txtArtist = New System.Windows.Forms.TextBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAcceptBid = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbSelectItem)
        Me.GroupBox1.Controls.Add(Me.cmbSelectCustomer)
        Me.GroupBox1.Controls.Add(Me.lblHighestBid)
        Me.GroupBox1.Controls.Add(Me.lblCreditStatus)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 23)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(896, 200)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inputs..."
        '
        'cmbSelectItem
        '
        Me.cmbSelectItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelectItem.FormattingEnabled = True
        Me.cmbSelectItem.Location = New System.Drawing.Point(222, 123)
        Me.cmbSelectItem.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmbSelectItem.Name = "cmbSelectItem"
        Me.cmbSelectItem.Size = New System.Drawing.Size(238, 33)
        Me.cmbSelectItem.TabIndex = 7
        '
        'cmbSelectCustomer
        '
        Me.cmbSelectCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelectCustomer.FormattingEnabled = True
        Me.cmbSelectCustomer.Location = New System.Drawing.Point(222, 50)
        Me.cmbSelectCustomer.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmbSelectCustomer.Name = "cmbSelectCustomer"
        Me.cmbSelectCustomer.Size = New System.Drawing.Size(238, 33)
        Me.cmbSelectCustomer.TabIndex = 6
        '
        'lblHighestBid
        '
        Me.lblHighestBid.AutoSize = True
        Me.lblHighestBid.Location = New System.Drawing.Point(662, 129)
        Me.lblHighestBid.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblHighestBid.Name = "lblHighestBid"
        Me.lblHighestBid.Size = New System.Drawing.Size(66, 25)
        Me.lblHighestBid.TabIndex = 5
        Me.lblHighestBid.Text = "$------"
        '
        'lblCreditStatus
        '
        Me.lblCreditStatus.AutoSize = True
        Me.lblCreditStatus.Location = New System.Drawing.Point(662, 56)
        Me.lblCreditStatus.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblCreditStatus.Name = "lblCreditStatus"
        Me.lblCreditStatus.Size = New System.Drawing.Size(106, 25)
        Me.lblCreditStatus.TabIndex = 4
        Me.lblCreditStatus.Text = "PENDING"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(482, 129)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Highest Bid:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(476, 56)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Credit Status:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 129)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select Item"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 56)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Customer"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtAmount)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 235)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox2.Size = New System.Drawing.Size(506, 192)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Enter Bid..."
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(222, 48)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(238, 31)
        Me.txtAmount.TabIndex = 3
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(222, 106)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(238, 31)
        Me.DateTimePicker1.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 117)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 54)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Amount"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtSoldTo)
        Me.GroupBox3.Controls.Add(Me.txtSoldPrice)
        Me.GroupBox3.Controls.Add(Me.txtStartPrice)
        Me.GroupBox3.Controls.Add(Me.txtArtist)
        Me.GroupBox3.Controls.Add(Me.txtCategory)
        Me.GroupBox3.Controls.Add(Me.txtDescription)
        Me.GroupBox3.Controls.Add(Me.txtName)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 438)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox3.Size = New System.Drawing.Size(896, 408)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Item Details..."
        '
        'txtSoldTo
        '
        Me.txtSoldTo.Location = New System.Drawing.Point(222, 329)
        Me.txtSoldTo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtSoldTo.Name = "txtSoldTo"
        Me.txtSoldTo.Size = New System.Drawing.Size(548, 31)
        Me.txtSoldTo.TabIndex = 13
        '
        'txtSoldPrice
        '
        Me.txtSoldPrice.Location = New System.Drawing.Point(222, 285)
        Me.txtSoldPrice.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtSoldPrice.Name = "txtSoldPrice"
        Me.txtSoldPrice.Size = New System.Drawing.Size(238, 31)
        Me.txtSoldPrice.TabIndex = 12
        '
        'txtStartPrice
        '
        Me.txtStartPrice.Location = New System.Drawing.Point(222, 240)
        Me.txtStartPrice.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtStartPrice.Name = "txtStartPrice"
        Me.txtStartPrice.Size = New System.Drawing.Size(238, 31)
        Me.txtStartPrice.TabIndex = 11
        '
        'txtArtist
        '
        Me.txtArtist.Location = New System.Drawing.Point(222, 196)
        Me.txtArtist.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtArtist.Name = "txtArtist"
        Me.txtArtist.Size = New System.Drawing.Size(548, 31)
        Me.txtArtist.TabIndex = 10
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(222, 152)
        Me.txtCategory.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(548, 31)
        Me.txtCategory.TabIndex = 9
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(222, 108)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(548, 31)
        Me.txtDescription.TabIndex = 8
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(222, 63)
        Me.txtName.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(548, 31)
        Me.txtName.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(44, 335)
        Me.Label13.Margin = New System.Windows.Forms.Padding(6, 0, 6, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 25)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Sold To"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(44, 290)
        Me.Label12.Margin = New System.Windows.Forms.Padding(6, 0, 6, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 25)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Sold Price"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(42, 246)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 25)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Start Price"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(44, 202)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 25)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Artist"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(44, 158)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 25)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Category"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(44, 113)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 25)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Description"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 69)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Name"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Location = New System.Drawing.Point(932, 23)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox4.Size = New System.Drawing.Size(482, 704)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Current Bids..."
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(6, 30)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(470, 668)
        Me.DataGridView1.TabIndex = 0
        '
        'btnAcceptBid
        '
        Me.btnAcceptBid.Location = New System.Drawing.Point(1172, 738)
        Me.btnAcceptBid.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnAcceptBid.Name = "btnAcceptBid"
        Me.btnAcceptBid.Size = New System.Drawing.Size(236, 44)
        Me.btnAcceptBid.TabIndex = 2
        Me.btnAcceptBid.Text = "Accept Bid"
        Me.btnAcceptBid.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(1172, 794)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(236, 44)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'FormProcessBid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1446, 867)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAcceptBid)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "FormProcessBid"
        Me.Text = "Create Bid"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cmbSelectItem As ComboBox
    Friend WithEvents cmbSelectCustomer As ComboBox
    Friend WithEvents lblHighestBid As Label
    Friend WithEvents lblCreditStatus As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSoldTo As TextBox
    Friend WithEvents txtSoldPrice As TextBox
    Friend WithEvents txtStartPrice As TextBox
    Friend WithEvents txtArtist As TextBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAcceptBid As Button
    Friend WithEvents btnClose As Button
End Class
