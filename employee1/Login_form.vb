Public Class Login_form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "1" And TextBox2.Text = "1" Then
            main.Show()
            Me.Hide()
        Else
            MsgBox("اسم المستخدم او كلمة المرور غير صحيحة", vbOKOnly, "تسجيل الدخول")
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBox2.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class