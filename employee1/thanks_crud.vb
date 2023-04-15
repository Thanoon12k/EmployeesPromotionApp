Imports System.Data.OleDb


Module thanks_crud

    ' Create a new record in the database
    Public Sub CreateRecord(orderNum As String, recordNum As String, timeAdd As Date, notes As String)
        Using conn As New OleDbConnection(connstring)
            conn.Open()
            Dim sql As String = "INSERT INTO thanks (order_num, record_num, timeadd, notes) VALUES (@orderNum, @recordNum, @timeAdd, @notes)"
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@orderNum", orderNum)
                cmd.Parameters.AddWithValue("@recordNum", recordNum)
                cmd.Parameters.AddWithValue("@timeAdd", timeAdd)
                cmd.Parameters.AddWithValue("@notes", notes)
                cmd.ExecuteNonQuery()
            End Using

        End Using
    End Sub

    ' Read records from the database
    Public Function ReadRecords() As DataTable
        Dim dt As New DataTable()
        Using conn As New OleDbConnection(connstring)
            conn.Open()
            Dim sql As String = "SELECT * FROM thanks"
            Using cmd As New OleDbCommand(sql, conn)
                Dim da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    ' Update a record in the database
    Public Sub UpdateRecord(recordID As Integer, orderNum As String, recordNum As String, timeAdd As Date, notes As String)
        Using conn As New OleDbConnection(connstring)
            conn.Open()
            Dim sql As String = "UPDATE table_name SET order_num = @orderNum, record_num = @recordNum, timeadd = @timeAdd, notes = @notes WHERE ID = @ID"
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@orderNum", orderNum)
                cmd.Parameters.AddWithValue("@recordNum", recordNum)
                cmd.Parameters.AddWithValue("@timeAdd", timeAdd)
                cmd.Parameters.AddWithValue("@notes", notes)
                cmd.Parameters.AddWithValue("@ID", recordID)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Delete a record from the database
    Public Sub DeleteRecord(recordID As Integer)
        Using conn As New OleDbConnection(connstring)
            conn.Open()
            Dim sql As String = "DELETE FROM thanks WHERE ID = @ID"
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@ID", recordID)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Function FilterRecords(recordNumFilter As String) As DataTable
        Dim dt As New DataTable()
        Using conn As New OleDbConnection(connstring)
            conn.Open()
            Dim sql As String = "SELECT * FROM thanks"
            If Not String.IsNullOrEmpty(recordNumFilter) Then
                sql += " WHERE record_num = @recordNum"
            End If
            Using cmd As New OleDbCommand(sql, conn)
                If Not String.IsNullOrEmpty(recordNumFilter) Then
                    cmd.Parameters.AddWithValue("@recordNum", recordNumFilter)
                End If
                Dim da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function
End Module
