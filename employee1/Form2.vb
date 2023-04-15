Imports System.Data.OleDb

Public Class form_thanks


    Private Sub thanksform_load(sender As Object, e As EventArgs) Handles MyBase.Load
        update_dgv()
    End Sub



    Private Sub dgv_cell(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        If e.RowIndex >= 0 Then
            dgv.Rows(e.RowIndex).Selected = True

        End If
    End Sub

    Private Sub add_button(sender As Object, e As EventArgs) Handles add_btn.Click
        ' Get the values from the textboxes and DateTimePicker
        Try
            Dim newOrder As String = order_text.Text
            Dim newRecord As String = record_text.Text
            Dim newTime As DateTime = datepicker.Value.Date
            Dim newNote As String = notes_text.Text
            thanks_crud.CreateRecord(newOrder, newRecord, newTime, newNote)
            update_dgv()
        Catch

            MsgBox("الرجاء ادخال قيم صحيحة",, "!!تنبيه")

        End Try
        order_text.Text = ""
        record_text.Text = ""
        datepicker.Value = DateTime.Now
        notes_text.Text = ""

    End Sub


    Private Sub delete_butoun(sender As Object, e As EventArgs) Handles delete_btn.Click
        ' Check if a row is selected
        If dgv.SelectedRows.Count > 0 Then
            ' Get the ID of the selected row
            Dim recordID As Integer = CInt(dgv.SelectedRows(0).Cells("ID").Value)
            ' Delete the record from the database
            thanks_crud.DeleteRecord(recordID)
            ' Remove the row from the DataGridView
            dgv.Rows.Remove(dgv.SelectedRows(0))
            update_dgv()
        Else
            MsgBox("الرجاء تجديد صف كامل لحذفه")
        End If

    End Sub

    Private Sub filter_button(sender As Object, e As EventArgs) Handles filter_btn.Click

        update_dgv(filter_text.Text)

    End Sub

    Private Sub update_dgv(Optional record_num As String = "رقم القيد")
        dgv.Rows.Clear()
        Dim dttable As New DataTable
        If record_num = "رقم القيد" Then

            dttable = thanks_crud.ReadRecords()
        Else
            dttable = thanks_crud.FilterRecords(record_num)
        End If


        For Each row As DataRow In dttable.Rows
            dgv.Rows.Add(row("timeadd"), row("ID"), row("order_num"), row("record_num"), row("notes"))
        Next

    End Sub

    Private Sub filter_text_click(sender As Object, e As EventArgs) Handles filter_text.Click
        filter_text.Text = ""
    End Sub
    Private Sub filter_text_lost_focus(sender As Object, e As EventArgs) Handles filter_text.LostFocus
        If filter_text.Text = "" Then
            filter_text.Text = "رقم القيد"
        End If

    End Sub

    Private Sub filter_text_TextChanged(sender As Object, e As EventArgs) Handles filter_text.TextChanged

    End Sub
End Class