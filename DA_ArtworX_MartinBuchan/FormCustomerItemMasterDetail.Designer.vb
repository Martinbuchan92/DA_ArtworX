<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCustomerItemMasterDetail
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
        Dim AccountNameLabel As System.Windows.Forms.Label
        Dim AccountNumberLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CreditStatusLabel As System.Windows.Forms.Label
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim SwiftCodeLabel As System.Windows.Forms.Label
        Dim UserNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCustomerItemMasterDetail))
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CustomerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AccountNameTextBox = New System.Windows.Forms.TextBox()
        Me.AccountNumberTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CreditStatusTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.SwiftCodeTextBox = New System.Windows.Forms.TextBox()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.ItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        AccountNameLabel = New System.Windows.Forms.Label()
        AccountNumberLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CreditStatusLabel = New System.Windows.Forms.Label()
        CustomerIDLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        SwiftCodeLabel = New System.Windows.Forms.Label()
        UserNameLabel = New System.Windows.Forms.Label()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerBindingNavigator.SuspendLayout()
        CType(Me.ItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AccountNameLabel
        '
        AccountNameLabel.AutoSize = True
        AccountNameLabel.Location = New System.Drawing.Point(42, 54)
        AccountNameLabel.Name = "AccountNameLabel"
        AccountNameLabel.Size = New System.Drawing.Size(80, 13)
        AccountNameLabel.TabIndex = 1
        AccountNameLabel.Text = "account Name:"
        '
        'AccountNumberLabel
        '
        AccountNumberLabel.AutoSize = True
        AccountNumberLabel.Location = New System.Drawing.Point(42, 80)
        AccountNumberLabel.Name = "AccountNumberLabel"
        AccountNumberLabel.Size = New System.Drawing.Size(89, 13)
        AccountNumberLabel.TabIndex = 3
        AccountNumberLabel.Text = "account Number:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(42, 106)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(47, 13)
        AddressLabel.TabIndex = 5
        AddressLabel.Text = "address:"
        '
        'CreditStatusLabel
        '
        CreditStatusLabel.AutoSize = True
        CreditStatusLabel.Location = New System.Drawing.Point(42, 132)
        CreditStatusLabel.Name = "CreditStatusLabel"
        CreditStatusLabel.Size = New System.Drawing.Size(69, 13)
        CreditStatusLabel.TabIndex = 7
        CreditStatusLabel.Text = "credit Status:"
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(42, 158)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(67, 13)
        CustomerIDLabel.TabIndex = 9
        CustomerIDLabel.Text = "customer ID:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(42, 184)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 11
        EmailLabel.Text = "email:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(42, 210)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(57, 13)
        FirstNameLabel.TabIndex = 13
        FirstNameLabel.Text = "first Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(42, 236)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(57, 13)
        LastNameLabel.TabIndex = 15
        LastNameLabel.Text = "last Name:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(42, 262)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(55, 13)
        PasswordLabel.TabIndex = 17
        PasswordLabel.Text = "password:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(42, 288)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(40, 13)
        PhoneLabel.TabIndex = 19
        PhoneLabel.Text = "phone:"
        '
        'SwiftCodeLabel
        '
        SwiftCodeLabel.AutoSize = True
        SwiftCodeLabel.Location = New System.Drawing.Point(42, 314)
        SwiftCodeLabel.Name = "SwiftCodeLabel"
        SwiftCodeLabel.Size = New System.Drawing.Size(59, 13)
        SwiftCodeLabel.TabIndex = 21
        SwiftCodeLabel.Text = "swift Code:"
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.Location = New System.Drawing.Point(42, 340)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(61, 13)
        UserNameLabel.TabIndex = 23
        UserNameLabel.Text = "user Name:"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataSource = GetType(ArtworxBOC.Customer)
        '
        'CustomerBindingNavigator
        '
        Me.CustomerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomerBindingNavigator.BindingSource = Me.CustomerBindingSource
        Me.CustomerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustomerBindingNavigatorSaveItem})
        Me.CustomerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomerBindingNavigator.Name = "CustomerBindingNavigator"
        Me.CustomerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomerBindingNavigator.Size = New System.Drawing.Size(650, 25)
        Me.CustomerBindingNavigator.TabIndex = 0
        Me.CustomerBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CustomerBindingNavigatorSaveItem
        '
        Me.CustomerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomerBindingNavigatorSaveItem.Enabled = False
        Me.CustomerBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomerBindingNavigatorSaveItem.Name = "CustomerBindingNavigatorSaveItem"
        Me.CustomerBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CustomerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AccountNameTextBox
        '
        Me.AccountNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "accountName", True))
        Me.AccountNameTextBox.Location = New System.Drawing.Point(137, 51)
        Me.AccountNameTextBox.Name = "AccountNameTextBox"
        Me.AccountNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AccountNameTextBox.TabIndex = 2
        '
        'AccountNumberTextBox
        '
        Me.AccountNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "accountNumber", True))
        Me.AccountNumberTextBox.Location = New System.Drawing.Point(137, 77)
        Me.AccountNumberTextBox.Name = "AccountNumberTextBox"
        Me.AccountNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AccountNumberTextBox.TabIndex = 4
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(137, 103)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AddressTextBox.TabIndex = 6
        '
        'CreditStatusTextBox
        '
        Me.CreditStatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "creditStatus", True))
        Me.CreditStatusTextBox.Location = New System.Drawing.Point(137, 129)
        Me.CreditStatusTextBox.Name = "CreditStatusTextBox"
        Me.CreditStatusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CreditStatusTextBox.TabIndex = 8
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "customerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(137, 155)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustomerIDTextBox.TabIndex = 10
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(137, 181)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 12
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "firstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(137, 207)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 14
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "lastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(137, 233)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTextBox.TabIndex = 16
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(137, 259)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 18
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(137, 285)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PhoneTextBox.TabIndex = 20
        '
        'SwiftCodeTextBox
        '
        Me.SwiftCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "swiftCode", True))
        Me.SwiftCodeTextBox.Location = New System.Drawing.Point(137, 311)
        Me.SwiftCodeTextBox.Name = "SwiftCodeTextBox"
        Me.SwiftCodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SwiftCodeTextBox.TabIndex = 22
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "userName", True))
        Me.UserNameTextBox.Location = New System.Drawing.Point(137, 337)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UserNameTextBox.TabIndex = 24
        '
        'ItemBindingSource
        '
        Me.ItemBindingSource.DataSource = GetType(ArtworxBOC.Item)
        '
        'ItemDataGridView
        '
        Me.ItemDataGridView.AutoGenerateColumns = False
        Me.ItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.ItemDataGridView.DataSource = Me.ItemBindingSource
        Me.ItemDataGridView.Location = New System.Drawing.Point(310, 12)
        Me.ItemDataGridView.Name = "ItemDataGridView"
        Me.ItemDataGridView.Size = New System.Drawing.Size(300, 345)
        Me.ItemDataGridView.TabIndex = 25
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "itemID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "itemID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "categoryID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "categoryID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "description"
        Me.DataGridViewTextBoxColumn4.HeaderText = "description"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "artist"
        Me.DataGridViewTextBoxColumn5.HeaderText = "artist"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "startPrice"
        Me.DataGridViewTextBoxColumn6.HeaderText = "startPrice"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "soldPrice"
        Me.DataGridViewTextBoxColumn7.HeaderText = "soldPrice"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "soldToID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "soldToID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'FormCustomerItemMasterDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 399)
        Me.Controls.Add(Me.ItemDataGridView)
        Me.Controls.Add(AccountNameLabel)
        Me.Controls.Add(Me.AccountNameTextBox)
        Me.Controls.Add(AccountNumberLabel)
        Me.Controls.Add(Me.AccountNumberTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(CreditStatusLabel)
        Me.Controls.Add(Me.CreditStatusTextBox)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(SwiftCodeLabel)
        Me.Controls.Add(Me.SwiftCodeTextBox)
        Me.Controls.Add(UserNameLabel)
        Me.Controls.Add(Me.UserNameTextBox)
        Me.Controls.Add(Me.CustomerBindingNavigator)
        Me.Name = "FormCustomerItemMasterDetail"
        Me.Text = "Customer Items"
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerBindingNavigator.ResumeLayout(False)
        Me.CustomerBindingNavigator.PerformLayout()
        CType(Me.ItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CustomerBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AccountNameTextBox As TextBox
    Friend WithEvents AccountNumberTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CreditStatusTextBox As TextBox
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents SwiftCodeTextBox As TextBox
    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents ItemBindingSource As BindingSource
    Friend WithEvents ItemDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
