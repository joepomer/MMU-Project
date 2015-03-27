Public Class Rule_choice

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        If New_rb.Checked Then
            Creation.Show()
        ElseIf Edit_rb.Checked Then
            Edit_rule.Show()
        End If
    End Sub

    Private Sub New_rb_CheckedChanged(sender As Object, e As EventArgs) Handles New_rb.CheckedChanged

    End Sub
End Class