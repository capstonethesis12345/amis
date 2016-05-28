Imports System.Security.Cryptography
Imports System.Text

Module Security
    Function getMD5(ByVal strToHash As String) As String

        Dim md5Obj As New MD5CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
        bytesToHash = md5Obj.ComputeHash(bytesToHash)
        Dim strResult As String = ""
        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next
        Return strResult
    End Function

End Module
