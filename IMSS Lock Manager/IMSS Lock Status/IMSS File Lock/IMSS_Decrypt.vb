Imports System.IO
Imports System.Security.Cryptography

Public Class IMSS_Decrypt

    Public _IMSS_TARGET As String = String.Empty




#Region "4. Encrypt / Decrypt File "

    '****************************
    '** Encrypt/Decrypt File
    '****************************

    Private Enum CryptoAction
        'Define the enumeration for CryptoAction.
        ActionEncrypt = 1
        ActionDecrypt = 2
    End Enum

    Private Sub EncryptOrDecryptFile(ByVal strInputFile As String, _
                                     ByVal strOutputFile As String, _
                                     ByVal bytKey() As Byte, _
                                     ByVal bytIV() As Byte, _
                                     ByVal Direction As CryptoAction)
        Try 'In case of errors.

            'Setup file streams to handle input and output.
            fsInput = New System.IO.FileStream(strInputFile, FileMode.Open, _
                                               FileAccess.Read)
            fsOutput = New System.IO.FileStream(strOutputFile, FileMode.OpenOrCreate, _
                                                FileAccess.Write)
            fsOutput.SetLength(0) 'make sure fsOutput is empty

            'Declare variables for encrypt/decrypt process.
            Dim bytBuffer(4096) As Byte 'holds a block of bytes for processing
            Dim lngBytesProcessed As Long = 0 'running count of bytes processed
            Dim lngFileLength As Long = fsInput.Length 'the input file's length
            Dim intBytesInCurrentBlock As Integer 'current bytes being processed
            Dim csCryptoStream As CryptoStream
            'Declare your CryptoServiceProvider.
            Dim cspRijndael As New System.Security.Cryptography.RijndaelManaged
            'Setup Progress Bar


            'Determine if ecryption or decryption and setup CryptoStream.
            csCryptoStream = New CryptoStream(fsOutput, _
            cspRijndael.CreateDecryptor(bytKey, bytIV), _
            CryptoStreamMode.Write)

            'Use While to loop until all of the file is processed.
            While lngBytesProcessed < lngFileLength
                'Read file with the input filestream.
                intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 4096)
                'Write output file with the cryptostream.
                csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
                'Update lngBytesProcessed
                lngBytesProcessed = lngBytesProcessed + CLng(intBytesInCurrentBlock)
                'Update Progress Bar
            End While

            'Close FileStreams and CryptoStream.
            csCryptoStream.Close()
            fsInput.Close()
            fsOutput.Close()

            'If decrypting then delete the encrypted file.
                Dim fileEncrypted As New FileInfo(strFileToDecrypt)
                fileEncrypted.Delete()

            'Update the user when the file is done.
            Dim Wrap As String = Chr(13) + Chr(10)

            'Update the user when the file is done.
            MainWindow._IMSS_UNLOCKFILE(_IMSS_TARGET.Substring(0, _IMSS_TARGET.IndexOf(".")).Replace("_", "."))
            Me.Close()


            'Catch file not found error.
        Catch When Err.Number = 53 'if file not found
            MainWindow._IMSS_UNLOCKFILE(_IMSS_TARGET.Substring(0, _IMSS_TARGET.IndexOf(".")).Replace("_", "."))
            Me.Close()

            'Catch all other errors. And delete partial files.
        Catch
            fsInput.Close()
            fsOutput.Close()
            Dim fileDelete As New FileInfo(_IMSS_TARGET.Substring(0, _IMSS_TARGET.IndexOf(".")).Replace("_", ".")) ' encrypt
            fileDelete.Delete()
            _IMSS_Password_TextBox.Clear()
            MsgBox("Please check to make sure that you entered the correct" + _
                    " password.", MsgBoxStyle.Exclamation, Application.ProductName & " : Invalid Password")

        End Try
    End Sub

#End Region

    Private Sub _IMSS_UnLock_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_UnLock_Button.Click
        'Make sure the password is correct.
        If Not String.IsNullOrEmpty(_IMSS_Password_TextBox.Text) Then
            'Declare variables for the key and iv.
            'The key needs to hold 256 bits and the iv 128 bits.
            Dim bytKey As Byte()
            Dim bytIV As Byte()
            'Send the password to the CreateKey function.
            bytKey = CreateKey(_IMSS_Password_TextBox.Text)
            'Send the password to the CreateIV function.
            bytIV = CreateIV(_IMSS_Password_TextBox.Text)
            'Start the decryption.
            strFileToDecrypt = _IMSS_TARGET
            EncryptOrDecryptFile(strFileToDecrypt, _IMSS_TARGET.Substring(0, _IMSS_TARGET.IndexOf(".")).Replace("_", "."), _
                                 bytKey, bytIV, CryptoAction.ActionDecrypt)
        Else
            MsgBox("Please your password.", MsgBoxStyle.Exclamation)
            _IMSS_Password_TextBox.Clear()
            _IMSS_Password_TextBox.Clear()
        End If
    End Sub

    Private Sub _IMSS_Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Cancel_Button.Click
        Me.Close()
    End Sub

End Class