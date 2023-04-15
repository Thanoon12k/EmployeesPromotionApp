Imports System.Text

Public Class formInfo
    Private Sub formInfo_ForeColorChanged(sender As Object, e As EventArgs) Handles Me.ForeColorChanged

    End Sub

    Private Sub formInfo_Load(sender As Object, e As EventArgs) Handles Me.Load
        update_dgv()
    End Sub



    Private Sub update_dgv(Optional record_num As String = "رقم القيد")
        employees_dgrv.Rows.Clear()
        Dim dttable As New DataTable
        If record_num = "رقم القيد" Or record_num = "" Then

            dttable = employees_crud.ReadRecords()
        Else
            dttable = employees_crud.FilterRecords(record_num)
        End If


        For Each row As DataRow In dttable.Rows
            employees_dgrv.Rows.Add(row("ID"), row("record_num"), row("name"))
        Next

    End Sub

    Private Sub employees_dgrv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub filter_btn(sender As Object, e As EventArgs) Handles Button5.Click
        Dim ID As Integer = 0
        Dim strID As String
        strID = record_num_filter_txt.Text
        Dim dt As DataTable = employees_crud.FilterRecords(strID)
        If dt.Rows.Count > 0 Then
            Try
                ID = Integer.Parse(strID)
                Dim row As DataRow = dt.Rows(0)
                study_cmp.Text = row("study_level").ToString()
                name_txt.Text = row("name").ToString()
                birthday_dte.Value = DateTime.Parse(row("birthday").ToString())
                rank_cmp.Text = row("current_rank").ToString()
                class_cmp.Text = row("current_class").ToString()
                salary_txt.Text = row("employee_salary").ToString()
                new_rank_txt.Text = row("new_rank").ToString()
                new_class_txt.Text = row("new_class").ToString()
                new_salary_txt.Text = row("new_salary").ToString()
                joiningdt.Value = DateTime.Parse(row("joining_date").ToString())
                current_raisingdt.Value = DateTime.Parse(row("current_rising").ToString())
                current_promotiondt.Value = DateTime.Parse(row("current_promotion").ToString())
                next_risingdt.Value = DateTime.Parse(row("next_rising").ToString())
                next_promotiondt.Value = DateTime.Parse(row("next_promotion").ToString())
                nots_txt.Text = row("notes").ToString()
            Catch ex As Exception
                MsgBox("الرجاء ادخل رقم صحيح",, "خطأ في الادخال")
            End Try
        Else
            MessageBox.Show(" لا يوجد")
        End If
    End Sub

    Private Sub save_employee_btn_Click(sender As Object, e As EventArgs) Handles save_employee_btn.Click
        Dim employee_salary As String = "150"
        Dim new_salary As String = "300"
        salary_txt.Text = employee_salary
        Dim record_num As String = record_num_txt.Text
        Dim record_type As String = record_num_txt.Text
        Dim name As String = name_txt.Text
        Dim study_level As String = study_cmp.Text
        Dim birthday As Date = birthday_dte.Value.Date
        Dim current_rank As String = rank_cmp.Text
        Dim current_class As String = class_cmp.Text

        Dim new_rank As String = new_rank_txt.Text
        Dim new_class As String = new_class_txt.Text
        Dim joining_date As Date = joiningdt.Value.Date
        Dim current_rising As Date = current_raisingdt.Value.Date
        Dim current_promotion As Date = current_promotiondt.Value.Date
        Dim next_rising As Date = next_risingdt.Value.Date
        Dim next_promotion As Date = next_promotiondt.Value.Date
        Dim notes As String = nots_txt.Text

        Dim isValidInputs As Boolean = ValidateInputs(record_num, record_type, name, study_level, birthday, current_rank, current_class, joining_date, current_rising, current_promotion, next_rising, next_promotion, notes)

        If isValidInputs Then
            Dim result As DialogResult = MessageBox.Show("هل انت متاكد تريد حفظ معلومات الموظف ", "تأكيد الحفظ", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                employees_crud.CreateRecord(record_num, record_type, name, study_level, birthday, current_rank, current_class, employee_salary, new_rank, new_class, new_salary, joining_date, current_rising, current_promotion, next_rising, next_promotion, notes)
                update_dgv()
                salary_txt.Text = employee_salary
                new_salary_txt.Text = new_salary
                ClearInputs()

            End If


        End If




    End Sub

    Function ValidateInputs(ByVal record_num As String, ByVal record_type As String, ByVal name As String, ByVal study_level As String, ByVal birthday As String, ByVal current_rank As String, ByVal current_class As String, ByVal joining_date As String, ByVal current_rising As String, ByVal current_promotion As String, ByVal next_rising As String, ByVal next_promotion As String, ByVal notes As String) As String
        If String.IsNullOrEmpty(record_num) OrElse String.IsNullOrEmpty(record_type) OrElse String.IsNullOrEmpty(name) OrElse String.IsNullOrEmpty(study_level) OrElse String.IsNullOrEmpty(birthday) OrElse String.IsNullOrEmpty(current_rank) OrElse String.IsNullOrEmpty(current_class) OrElse String.IsNullOrEmpty(joining_date) OrElse String.IsNullOrEmpty(current_rising) OrElse String.IsNullOrEmpty(current_promotion) OrElse String.IsNullOrEmpty(next_rising) OrElse String.IsNullOrEmpty(next_promotion) OrElse String.IsNullOrEmpty(notes) Then

            Dim errorMessage As New StringBuilder()


            Try
                Integer.Parse(record_num)
            Catch

                errorMessage.AppendLine("الرجاء ادخال رقم صحيح لرقم القيد.")
            End Try


            If String.IsNullOrEmpty(record_type) Then
                errorMessage.AppendLine("اختر نوع القيد")
            End If

            If String.IsNullOrEmpty(name) Then
                errorMessage.AppendLine("اكتب الاسم")
            End If

            If String.IsNullOrEmpty(study_level) Then
                errorMessage.AppendLine("اختر التحصيل الدراسي")
            End If


            If String.IsNullOrEmpty(current_rank) Then
                errorMessage.AppendLine("اختر الدرجة")
            End If

            If String.IsNullOrEmpty(current_class) Then
                errorMessage.AppendLine("اختر الفئة")
            End If

            If String.IsNullOrEmpty(notes) Then
                errorMessage.AppendLine("اكتب ملاحظات")
            End If

            If errorMessage.Length > 0 Then
                MessageBox.Show(errorMessage.ToString(), "خطأ في الادخال ")
            Else
                MessageBox.Show("All fields are valid.", "Validation Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Return False
        Else
            Return True
        End If
    End Function


    Private Sub clear_employee_btn_Click(sender As Object, e As EventArgs) Handles clear_employee_btn.Click
        ClearInputs()
    End Sub


    Function ClearInputs()

        record_num_txt.Text = ""
        name_txt.Text = ""
        study_cmp.Text = ""
        birthday_dte.Value = DateTime.Now
        rank_cmp.Text = ""
        class_cmp.Text = ""
        new_salary_txt.Text = ""
        new_rank_txt.Text = ""
        new_class_txt.Text = ""
        joiningdt.Value = DateTime.Now
        current_raisingdt.Value = DateTime.Now
        current_promotiondt.Value = DateTime.Now
        next_risingdt.Value = DateTime.Now
        next_promotiondt.Value = DateTime.Now
        nots_txt.Text = ""

    End Function

    Private Sub employees_dgrv_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles employees_dgrv.CellContentClick
        If e.RowIndex >= 0 Then
            employees_dgrv.Rows(e.RowIndex).Selected = True

        End If
    End Sub
End Class
