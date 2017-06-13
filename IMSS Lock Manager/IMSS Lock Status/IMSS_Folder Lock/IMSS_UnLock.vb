Imports System.Security.AccessControl

Public Class IMSS_UnLock
    Public _IMSS_TARGET As String = String.Empty
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _IMSS_Password_TextBox.Focus()
    End Sub
    Private Sub _IMSS_UnLock_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_UnLock_Button.Click
        If _IMSS_CheckPassword() = True Then
            MainWindow._IMSS_UNLOCKDIR(_IMSS_TARGET)
            Me.Close()
        Else
            MsgBox("Please check to make sure that you entered the correct" + _
         " password.", MsgBoxStyle.Exclamation, Application.ProductName & " : Invalid Password")
            _IMSS_LockWithAccessControl(_IMSS_TARGET & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}")
            _IMSS_Password_TextBox.Clear()
            _IMSS_Password_TextBox.Focus()
        End If
    End Sub

    Private Sub _IMSS_Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Cancel_Button.Click
        Me.Close()
    End Sub
    Private Function _IMSS_CheckPassword() As Boolean
        _IMSS_UnLockWithAccessControl(_IMSS_TARGET & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}")
        If IO.File.Exists(IO.Path.Combine(_IMSS_TARGET & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}", "_IMSS_Password.IMSS")) = True Then
            Dim _IMSS_TARGET_PASSWORD As String = IO.File.ReadAllText(IO.Path.Combine(_IMSS_TARGET & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}", "_IMSS_Password.IMSS"))
            If _IMSS_Password_TextBox.Text = _IMSS_TARGET_PASSWORD Then Return True Else Return False
        Else
            Return False
        End If
    End Function

    Private Sub _IMSS_UnLockWithAccessControl(ByVal _IMSS_TARGET As String)
        Dim fs As FileSystemSecurity = IO.File.GetAccessControl(_IMSS_TARGET)
        fs.RemoveAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
        IO.File.SetAccessControl(_IMSS_TARGET, fs)
    End Sub
    Private Sub _IMSS_LockWithAccessControl(ByVal _IMSS_TARGET As String)
        Dim fs As FileSystemSecurity = IO.File.GetAccessControl(_IMSS_TARGET)
        fs.AddAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
        IO.File.SetAccessControl(_IMSS_TARGET, fs)
    End Sub

End Class