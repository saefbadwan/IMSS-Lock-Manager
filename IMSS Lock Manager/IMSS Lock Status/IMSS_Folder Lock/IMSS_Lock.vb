Public Class IMSS_Lock
    Public _IMSS_TARGET As String = String.Empty
    Private Sub _IMSS_Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Cancel_Button.Click
        Me.Close()
    End Sub

    Private Sub _IMSS_Lock_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Lock_Button.Click
        If _IMSS_CheckifPasswordIsCorrect() = True Then
            MainWindow._IMSS_LOCKDIR(_IMSS_TARGET, _IMSS_Password_Textbox.Text)
            Me.Close()
        Else
            MessageBox.Show("Password is incorrect or is empty", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            _IMSS_Password_Textbox.Clear()
            _IMSS_ConfrinPassword_TextBox.Clear()
            _IMSS_Password_Textbox.Focus()
        End If
    End Sub

    Private Function _IMSS_CheckifPasswordIsCorrect() As Boolean
        If Not String.IsNullOrEmpty(_IMSS_Password_Textbox.Text) And Not String.IsNullOrEmpty(_IMSS_ConfrinPassword_TextBox.Text) Then
            If _IMSS_Password_Textbox.Text.Equals(_IMSS_ConfrinPassword_TextBox.Text) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function
End Class