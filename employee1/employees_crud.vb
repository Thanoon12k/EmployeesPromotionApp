Imports System.Data.OleDb


Module employees_crud

    ' Create a new record in the database
    Public Sub CreateRecord(record_num As String, record_type As String, name As String, study_level As String, birthday As Date, current_rank As String, current_class As String, employee_salary As String, new_rank As String, new_class As String, new_salary As String, joining_date As Date, current_rising As Date, current_promotion As Date, next_rising As Date, next_promotion As Date, notes As String)
        Using conn As New OleDbConnection(connstring)
            conn.Open()
            Dim sql As String = "INSERT INTO employees (record_num, record_type, name, study_level,birthday,current_rank,current_class,employee_salary,new_rank,new_class,new_salary,joining_date,current_rising,current_promotion,next_rising,next_promotion,notes) VALUES (@record_num,@record_type,@name,@study_level,@birthday,@current_rank,@current_class,@employee_salary,@new_rank,@new_class,@new_salary,@joining_date,@current_rising,@current_promotion,@next_rising,@next_promotion,@notes)"
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@record_num", record_num)
                cmd.Parameters.AddWithValue("@record_type", record_type)
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@study_level", study_level)
                cmd.Parameters.AddWithValue("@birthday", birthday)
                cmd.Parameters.AddWithValue("@current_rank", current_rank)
                cmd.Parameters.AddWithValue("@current_class", current_class)
                cmd.Parameters.AddWithValue("@employee_salary", employee_salary)
                cmd.Parameters.AddWithValue("@new_rank", new_rank)
                cmd.Parameters.AddWithValue("@new_class", new_class)
                cmd.Parameters.AddWithValue("@new_salary", new_salary)
                cmd.Parameters.AddWithValue("@joining_date", joining_date)

                cmd.Parameters.AddWithValue("@current_rising", current_rising)
                cmd.Parameters.AddWithValue("@current_promotion", current_promotion)
                cmd.Parameters.AddWithValue("@next_rising", next_rising)
                cmd.Parameters.AddWithValue("@next_promotion", next_promotion)

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
            Dim sql As String = "SELECT * FROM employees"
            Using cmd As New OleDbCommand(sql, conn)
                Dim da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    ' Update a record in the database
    Public Sub UpdateRecord(ID As Integer, record_num As String, record_type As String, name As String, study_level As String, birthday As Date, current_rank As String, current_class As String, employee_salary As String, new_rank As String, new_class As String, new_salary As String, joining_date As Date, current_rising As Date, current_promotion As Date, next_rising As Date, next_promotion As Date, notes As String)
        Using conn As New OleDbConnection(connstring)
            conn.Open()
            Dim sql As String = "UPDATE employees SET record_num = @record_num, record_type = @record_type, name = @name, study_level = @study_level, birthday = @birthday, current_rank = @current_rank, current_class = @current_class, salary = @salary, new_rank = @new_rank, new_class = @new_class, new_salary = @new_salary, joining_date = @joining_date, current_rising = @current_rising, current_promotion = @current_promotion, next_rising = @next_rising, next_promotion = @next_promotion, notes = @notes WHERE ID = @ID"
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@record_num", record_num)
                cmd.Parameters.AddWithValue("@record_type", record_type)
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@study_level", study_level)

                cmd.Parameters.AddWithValue("@birthday", birthday)
                cmd.Parameters.AddWithValue("@current_rank", current_rank)
                cmd.Parameters.AddWithValue("@current_class", current_class)
                cmd.Parameters.AddWithValue("@salary", employee_salary)

                cmd.Parameters.AddWithValue("@new_rank", new_rank)
                cmd.Parameters.AddWithValue("@new_class", new_class)
                cmd.Parameters.AddWithValue("@new_salary", new_salary)
                cmd.Parameters.AddWithValue("@joining_date", joining_date)

                cmd.Parameters.AddWithValue("@current_rising", current_rising)
                cmd.Parameters.AddWithValue("@current_promotion", current_promotion)
                cmd.Parameters.AddWithValue("@next_rising", next_rising)
                cmd.Parameters.AddWithValue("@next_promotion", next_promotion)

                cmd.Parameters.AddWithValue("@notes", notes)
                cmd.Parameters.AddWithValue("@ID", ID)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub


    ' Delete a record from the database
    Public Sub DeleteRecord(recordID As Integer)
        Using conn As New OleDbConnection(connstring)
            conn.Open()
            Dim sql As String = "DELETE FROM employees WHERE ID = @ID"
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
            Dim sql As String = "SELECT * FROM employees"
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
