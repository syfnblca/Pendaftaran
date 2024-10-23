Imports MySql.Data.MySqlClient
Module MdKoneksi
    Dim constring = "Server=localhost; Database=dblatihan; User=root; Password=root"
    Public Koneksi As New MySqlConnection(constring)

    Public da As MySqlDataAdapter = Nothing
    Public cmd As MySqlCommand = Nothing
    Public dt As New DataTable
    Public dr As MySqlDataReader

    Public ketemu As Boolean = False

    Public Sub konek()
        Try
            If Not Koneksi Is Nothing Then Koneksi.Close()
            Koneksi.Open()
            'MsgBox("Koneksi Berhasil Dilakukan")
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Function Diskonek()
        Koneksi.Close()
        Return Koneksi
    End Function

End Module
