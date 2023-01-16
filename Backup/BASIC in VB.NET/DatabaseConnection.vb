Module DatabaseConnection
    Public con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\BASICinVB.NET.mdb;")
End Module
