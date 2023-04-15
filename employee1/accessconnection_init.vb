Imports System.Data.OleDb
Imports System.IO

Module accessconnection_init
    Dim dbPath As String = Application.StartupPath & "\data\thanksdata.accdb"
    Public connstring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPath & ";"
    Public conn As New OleDbConnection(connstring)

    Function connect()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Console.WriteLine("Connection opened successfully!")
            Return True

            ' Perform database operations here
        Catch ex As Exception
            Console.WriteLine("Error while connecting to database: " & ex.Message)
        Finally
            conn.Close()
            Console.WriteLine("Connection closed successfully!")
        End Try
        Return True


    End Function


End Module
