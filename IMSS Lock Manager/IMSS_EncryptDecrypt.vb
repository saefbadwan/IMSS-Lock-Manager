Imports System.IO
Imports System.Text
Imports System.Security.Cryptography

Public Class IMSS_EncryptDecrypt
    Private Sub EncryptFile(ByVal inputFile As String, ByVal outputFile As String, ByVal _IMSS_TargetPassword As String)

        Try
            Dim password As String = _IMSS_TargetPassword
            ' Your Key Here
            Dim UE As New UnicodeEncoding()
            Dim key As Byte() = UE.GetBytes(password)

            Dim cryptFile As String = outputFile
            Dim fsCrypt As New FileStream(cryptFile, FileMode.Create)

            Dim RMCrypto As New RijndaelManaged()

            Dim cs As New CryptoStream(fsCrypt, RMCrypto.CreateEncryptor(key, key), CryptoStreamMode.Write)

            Dim fsIn As New FileStream(inputFile, FileMode.Open)

            Dim data As Integer
            While (data = fsIn.ReadByte()) <> -1
                cs.WriteByte(CByte(data))
            End While


            fsIn.Close()
            cs.Close()
            fsCrypt.Close()
        Catch
            MessageBox.Show("Encryption failed!", "Error")
        End Try
    End Sub
    Private Sub DecryptFile(ByVal inputFile As String, ByVal outputFile As String)
        If True Then
            Dim password As String = "myKey123"
            ' Your Key Here
            Dim UE As New UnicodeEncoding()
            Dim key As Byte() = UE.GetBytes(password)

            Dim fsCrypt As New FileStream(inputFile, FileMode.Open)

            Dim RMCrypto As New RijndaelManaged()

            Dim cs As New CryptoStream(fsCrypt, RMCrypto.CreateDecryptor(key, key), CryptoStreamMode.Read)

            Dim fsOut As New FileStream(outputFile, FileMode.Create)

            Dim data As Integer
            While (data = cs.ReadByte()) <> -1
                fsOut.WriteByte(CByte(data))
            End While
            fsOut.Close()
            cs.Close()
            fsCrypt.Close()
        End If
    End Sub

End Class
