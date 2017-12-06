Public Class Customer
    Inherits BOBase

    Dim _customerID As String
    Dim _userName As String
    Dim _password As String
    Dim _firstName As String
    Dim _lastName As String
    Dim _email As String
    Dim _phone As String
    Dim _address As String
    Dim _creditStatus As String
    Dim _accountNumber As String
    Dim _accountName As String
    Dim _swiftCode As String

#Region "Constants"
    Private Const CN_customerID As String = "customerID"
    Private Const CN_userName As String = "username"
    Private Const CN_password As String = "password"
    Private Const CN_firstName As String = "firstName"
    Private Const CN_lastName As String = "lastName"
    Private Const CN_email As String = "email"
    Private Const CN_phone As String = "phone"
    Private Const CN_address As String = "address"
    Private Const CN_creditStatus As String = "creditStatus"
    Private Const CN_accountNumber As String = "accountNumber"
    Private Const CN_accountName As String = "accountName"
    Private Const CN_swiftCode As String = "swiftCode"
#End Region

#Region "Constructors"
    Public Sub New()

    End Sub

    Public Sub New(ByVal customerID As String)

    End Sub
#End Region

#Region "Class Factory Methods"
    Public Shared Function Create(ByRef dt As DataTable) As DataTable
        Return ArtworxDAC.DAC.ExecuteDataTable(My.Settings.SP_CustomerList)
    End Function

    Public Shared Function Create(ByVal customerID As String) As Customer
        Dim c As Customer
        Dim dt As DataTable

        dt = ArtworxDAC.DAC.ExecuteDataTable(My.Settings.SP_CustomerGetByID, ArtworxDAC.DAC.Parameter(CN_customerID, customerID))
        c = New Customer()
        With dt.Rows(0)
            c.customerID = .Item(CN_customerID.ToString)
            c.userName = .Item(CN_userName.ToString)
            c.password = .Item(CN_password.ToString)
            c.firstName = .Item(CN_firstName.ToString)
            c.lastName = .Item(CN_lastName.ToString)
            c.email = .Item(CN_email.ToString)
            c.phone = .Item(CN_phone.ToString)
            c.address = .Item(CN_address.ToString)
            c.creditStatus = .Item(CN_creditStatus.ToString)
            c.accountNumber = .Item(CN_accountNumber.ToString)
            c._accountName = .Item(CN_accountName.ToString)
            c.swiftCode = .Item(CN_swiftCode.ToString)
        End With
        c.DataStateChanged(EntityStateEnum.UnChanged)
        Return c
    End Function

    Public Shared Function Create() As List(Of Customer)
        Dim cl As List(Of Customer)
        Dim dt As New DataTable
        Dim c As Customer
        Dim i As Integer

        dt = ArtworxDAC.DAC.ExecuteDataTable(My.Settings.SP_CustomerList)
        cl = New List(Of Customer)
        For i = 0 To dt.Rows.Count - 1
            c = New Customer()
            With dt.Rows(i)
                c.customerID = .Item(CN_customerID.ToString)
                c.userName = .Item(CN_userName.ToString)
                c.password = .Item(CN_password.ToString)
                c.firstName = .Item(CN_firstName.ToString)
                c.lastName = .Item(CN_lastName.ToString)
                c.email = .Item(CN_email.ToString)
                c.phone = .Item(CN_phone.ToString)
                c.address = .Item(CN_address.ToString)
                c.creditStatus = .Item(CN_creditStatus.ToString)
                c.accountNumber = .Item(CN_accountNumber.ToString)
                c._accountName = .Item(CN_accountName.ToString)
                c.swiftCode = .Item(CN_swiftCode.ToString)
            End With
            cl.Add(c)
        Next
        Return cl
    End Function

    Public Function Save() As Boolean
        Dim success As Boolean = False
        Dim dt As DataTable
        dt = ArtworxDAC.DAC.ExecuteDataTable(My.Settings.SP_CustomerSave,
            ArtworxDAC.DAC.Parameter(CN_customerID, customerID),
            ArtworxDAC.DAC.Parameter(CN_userName, userName),
            ArtworxDAC.DAC.Parameter(CN_password, password),
            ArtworxDAC.DAC.Parameter(CN_firstName, firstName),
            ArtworxDAC.DAC.Parameter(CN_lastName, lastName),
            ArtworxDAC.DAC.Parameter(CN_email, email),
            ArtworxDAC.DAC.Parameter(CN_phone, phone),
            ArtworxDAC.DAC.Parameter(CN_address, address),
            ArtworxDAC.DAC.Parameter(CN_creditStatus, creditStatus),
            ArtworxDAC.DAC.Parameter(CN_accountNumber, accountNumber),
            ArtworxDAC.DAC.Parameter(CN_accountName, accountName),
            ArtworxDAC.DAC.Parameter(CN_swiftCode, swiftCode))
        If EntityState = EntityStateEnum.Added Then
            customerID = CType(dt.Rows(0).Item(CN_customerID), String)
        End If
        Me.DataStateChanged(EntityStateEnum.UnChanged)
        success = True
        Return success
    End Function
#End Region

#Region "Property Procedures"
    Public Property customerID() As String
        Get
            Return _customerID
        End Get
        Set(ByVal value As String)
            If _customerID <> value Then
                _customerID = value
                Me.DataStateChanged(EntityStateEnum.Modified)
            End If
        End Set
    End Property

    Public Property userName() As String
        Get
            Return _userName
        End Get
        Set(ByVal value As String)
            If _userName <> value Then
                _userName = value
                Me.DataStateChanged(EntityStateEnum.Modified)
            End If
        End Set
    End Property

    Public Property password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            If _password <> value Then
                _password = value
                Me.DataStateChanged(EntityStateEnum.Modified)
            End If
        End Set
    End Property

    Public Property firstName() As String
        Get
            Return _firstName
        End Get
        Set(ByVal value As String)
            If _firstName <> value Then
                _firstName = value
                Me.DataStateChanged(EntityStateEnum.Modified)
            End If
        End Set
    End Property

    Public Property lastName() As String
        Get
            Return _lastName
        End Get
        Set(ByVal value As String)
            If _lastName <> value Then
                _lastName = value
                Me.DataStateChanged(EntityStateEnum.Modified)
            End If
        End Set
    End Property

    Public Property email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            If _email <> value Then
                _email = value
                Me.DataStateChanged(EntityStateEnum.Modified)
            End If
        End Set
    End Property

    Public Property phone() As String
        Get
            Return _phone
        End Get
        Set(ByVal value As String)
            If _phone <> value Then
                _phone = value
                Me.DataStateChanged(EntityStateEnum.Modified)
            End If
        End Set
    End Property

    Public Property address() As String
        Get
            Return _address
        End Get
        Set(ByVal value As String)
            If _address <> value Then
                _address = value
                Me.DataStateChanged(EntityStateEnum.Modified)
            End If
        End Set
    End Property

    Public Property creditStatus() As String
        Get
            Return _creditStatus
        End Get
        Set(ByVal value As String)
            If _creditStatus <> value Then
                _creditStatus = value
                Me.DataStateChanged(EntityStateEnum.Modified)
            End If
        End Set
    End Property

    Public Property accountNumber() As String
        Get
            Return _accountNumber
        End Get
        Set(ByVal value As String)
            If _accountNumber <> value Then
                _accountNumber = value
                Me.DataStateChanged(EntityStateEnum.Modified)
            End If
        End Set
    End Property

    Public Property accountName() As String
        Get
            Return _accountName
        End Get
        Set(ByVal value As String)
            If _accountName <> value Then
                _accountName = value
                Me.DataStateChanged(EntityStateEnum.Modified)
            End If
        End Set
    End Property

    Public Property swiftCode() As String
        Get
            Return _swiftCode
        End Get
        Set(ByVal value As String)
            If _swiftCode <> value Then
                _swiftCode = value
                Me.DataStateChanged(EntityStateEnum.Modified)
            End If
        End Set
    End Property
#End Region
End Class
