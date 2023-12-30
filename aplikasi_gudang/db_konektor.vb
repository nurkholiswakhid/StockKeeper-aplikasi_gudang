Imports System.Data.OleDb
Module db_konektor
    Public conn As OleDbConnection
    Public Da As OleDbDataAdapter
    Public Ds As DataSet
    Public cmd As OleDbCommand
    Public Rd As OleDbDataReader
    Dim lokasiDB As String

    Public Sub koneksi()
        lokasiDB = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=db_gudang.accdb;"
        conn = New OleDbConnection(lokasiDB)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub
End Module
