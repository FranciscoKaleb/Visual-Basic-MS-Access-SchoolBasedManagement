Module DatabaseConnection
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source =  " & Application.StartupPath & "\BASICinVB.NET.mdb;")
End Module
