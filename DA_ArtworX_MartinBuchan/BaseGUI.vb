Imports BPBOC

Public Class BaseGUI

#Region "protected fields"
    Protected AddNewMode As String = "AddNew"
    Protected BrowseMode As String = "Browse"
    Protected CancelMode As String = "Cancel"
    Protected DeleteMode As String = "Deleting"
    Protected EditMode As String = "Edit"
    Protected HasErrorsMode As String = "HasErrors"
    Protected UpdateMode As String = "Updating"
#End Region

#Region " Private properties "
    ''' <summary>
    ''' The MySettings object for each form
    ''' </summary>
    ''' <remarks></remarks>
    Private _settings As My.MySettings
    ''' <summary>
    ''' The read only MySettings object property procedure for each form
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private ReadOnly Property Settings() As System.Configuration.ApplicationSettingsBase
        Get
            If _settings Is Nothing Then
                _settings = New My.MySettings
            End If
            Return _settings
        End Get
    End Property
#End Region

#Region "protected properties"
    Public Enum DataEntryMode
        AddNew
        Browse
        Edit
    End Enum
    Protected Mode As DataEntryMode
    Protected Enum CursorDirection
        CursorFirst
        CursorPrevious
        CursorNext
        CursorLast
        CursorRefresh
    End Enum
    Protected direction As CursorDirection
#End Region

#Region "Form Events"

    Private Sub BaseGUI_FormClosed(ByVal sender As Object, _
                ByVal e As System.Windows.Forms.FormClosedEventArgs) _
                Handles Me.FormClosed
        ' save user settings
        SetSettings()
    End Sub

    Private Sub BaseGUI_Load(ByVal sender As System.Object, _
                ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AddEventHandlers(Me)
        'apply the saved user settings
        ApplySettings()
    End Sub

#End Region

#Region "Private Methods"
    Private Sub AddEventHandlers(ByVal container As Control)
        Dim c As Control
        For Each c In container.Controls
            If TypeOf c Is TextBox OrElse TypeOf c Is ComboBox Then
                AddHandler c.Enter, AddressOf ProcessEnter
                AddHandler c.Leave, AddressOf ProcessLeave
            End If
            If c.HasChildren Then
                AddEventHandlers(c)
            End If
        Next
    End Sub
    ''' <summary>
    ''' Handles Enter events for a form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ProcessEnter(ByVal sender As System.Object, _
                ByVal e As System.EventArgs)
        DirectCast(sender, Control).BackColor = Color.BlanchedAlmond
    End Sub


    ''' <summary>
    ''' Handles Leave events for a form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ProcessLeave(ByVal sender As System.Object, _
                ByVal e As System.EventArgs)
        DirectCast(sender, Control).BackColor = Color.FromKnownColor(KnownColor.Window)
    End Sub

#Region "Settings methods"
    ''' <summary>
    ''' Apply the settings for every form
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ApplySettings()
        Settings.SettingsKey = Me.Name                      ' make the settings apply to this form
        Dim theSettings As My.MySettings
        theSettings = DirectCast(Settings, My.MySettings)   ' get the settings from the read-only property

        If theSettings.FormSize <> Drawing.Size.Empty Then  ' apply them
            Me.Size = theSettings.FormSize
        End If
        If theSettings.FormLocation <> Drawing.Point.Empty Then
            Me.Location = theSettings.FormLocation
        End If
    End Sub

    ''' <summary>
    ''' Sets the settings for every form
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetSettings()
        Settings.SettingsKey = Me.Name                      ' make the settings apply to this form
        Dim theSettings As My.MySettings
        theSettings = DirectCast(Settings, My.MySettings)   ' get the settings from the read-only property
        If Me.WindowState = FormWindowState.Normal Then     ' retrieve the form size
            '          theSettings.FormSize = Me.Size
        Else
            '         theSettings.FormSize = Me.RestoreBounds.Size    ' use restore state with maximised or minimised 
        End If
        '    theSettings.FormLocation = Me.Location              ' retrieve the form location
        Settings.Save()
    End Sub
#End Region

#End Region

#Region "Protected Methods"
    ''' <summary>
    ''' Format text in form title bar
    ''' </summary>
    ''' <param name="titleExtension">Additional text to appear in title</param>
    ''' <remarks>The current form title may already have a title extension displayed with it. If so it is removed.</remarks>
    Protected Sub SetFormTitle(ByVal titleExtension As String)
        Dim separator As String = " - "
        Dim text As String = Me.Text
        If Me.Text.Contains(separator) Then
            text = text.Remove(Me.Text.IndexOf(separator))
        End If

        If String.IsNullOrEmpty(titleExtension) Then
            Me.Text = text
        Else
            Me.Text = text & separator & titleExtension
        End If
    End Sub


    Protected Sub ClearTextBoxText()
        Dim ctrl As Control
        Dim t As TextBox
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is TextBox Then
                t = DirectCast(ctrl, TextBox)
                t.Text = String.Empty
            End If
            If TypeOf ctrl Is GroupBox Then
                Dim c As Control
                For Each c In ctrl.Controls
                    If TypeOf c Is TextBox Then
                        t = DirectCast(c, TextBox)
                        t.Text = String.Empty
                    End If
                Next
            End If
        Next
    End Sub

    Protected Sub SetTextBoxState(ByVal state As Boolean)
        Dim ctrl As Control
        Dim t As TextBox
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is TextBox Then
                t = DirectCast(ctrl, TextBox)
                t.ReadOnly = state
            End If
            If TypeOf ctrl Is GroupBox Then
                Dim c As Control
                For Each c In ctrl.Controls
                    If TypeOf c Is TextBox Then
                        t = DirectCast(c, TextBox)
                        t.ReadOnly = state
                    End If
                Next
            End If
        Next
    End Sub
#End Region

End Class