Module umum
    Public proses As New koneksi
    Public tabel As DataTable
    Public sqLstr As String
    Public namaUser As String
    Public idUser As String
    Function Aphostrophe(ByVal sval As String) As String
        Dim sRet As String
        sRet = sval.Replace("'", "''")

        sRet = "'" + sRet + "'"
        Return sRet
    End Function

End Module
