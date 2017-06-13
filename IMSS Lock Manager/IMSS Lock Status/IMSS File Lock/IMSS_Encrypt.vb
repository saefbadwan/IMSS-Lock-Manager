Imports System.IO
Imports System.Security.Cryptography

Public Class IMSS_Encrypt


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
    Private Sub _IMSS_Encrypt()

    End Sub
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
            
            csCryptoStream = New CryptoStream(fsOutput, _
            cspRijndael.CreateEncryptor(bytKey, bytIV), _
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

            'If encrypting then delete the original unencrypted file.
            Dim fileOriginal As New FileInfo(strFileToEncrypt)
            fileOriginal.Delete()


            'Update the user when the file is done.
            Dim Wrap As String = Chr(13) + Chr(10)
            MainWindow._IMSS_LOCKFILE(_IMSS_TARGET.Replace(".", "_") & ".encrypt")
            Me.Close()

            'Catch file not found error.
        Catch When Err.Number = 53 'if file not found
            MsgBox("Please check to make sure the path and filename" + _
                    "are correct and if the file exists.", _
                     MsgBoxStyle.Exclamation, "Invalid Path or Filename")

            'Catch all other errors. And delete partial files.
        Catch ex As Exception
            fsInput.Close()
            fsOutput.Close()
            Dim fileDelete As New FileInfo(_IMSS_TARGET & ".encrypt")
            fileDelete.Delete()


            MsgBox("This file cannot be encrypted.", _
                    MsgBoxStyle.Exclamation, "Invalid File")
        End Try
    End Sub

#End Region
    Private Sub _IMSS_Lock_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Lock_Button.Click
        'Make sure the password is correct.
        If _IMSS_txtConPassEncrypt.Text = _IMSS_txtPassEncrypt.Text Then
            'Declare variables for the key and iv.
            'The key needs to hold 256 bits and the iv 128 bits.
            strFileToEncrypt = _IMSS_TARGET
            strOutputEncrypt = _IMSS_TARGET.Replace(".", "_") & ".encrypt"
            Dim bytKey As Byte()
            Dim bytIV As Byte()
            'Send the password to the CreateKey function.
            bytKey = CreateKey(_IMSS_txtPassEncrypt.Text)
            'Send the password to the CreateIV function.
            bytIV = CreateIV(_IMSS_txtPassEncrypt.Text)
            'Start the encryption.
            EncryptOrDecryptFile(_IMSS_TARGET, strOutputEncrypt, _
                                 bytKey, bytIV, CryptoAction.ActionEncrypt)
        Else
            MsgBox("Please re-enter your password.", MsgBoxStyle.Exclamation)
            _IMSS_txtPassEncrypt.Clear()
            _IMSS_txtConPassEncrypt.Clear()
        End If
    End Sub
  
    Private Sub _IMSS_Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Cancel_Button.Click
        Me.Close()
    End Sub
End Class