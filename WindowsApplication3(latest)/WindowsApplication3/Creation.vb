Imports System.IO
Public Class Creation
    Dim action As String = ""
    Dim protocol As String = ""
    Dim sourceip As String = ""
    Dim destip As String = ""
    Dim sourceport As String = ""
    Dim destport As String = ""
    Dim direction As String = "-> "
    Dim rule As String = ""
    Dim modif As String = ""

    Private Sub Creation_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Start.Show()
    End Sub
    Private Sub preview_btn_Click_1(sender As Object, e As EventArgs) Handles preview_btn.Click
        If alert_rb.Checked Then
            action = "alert "
        ElseIf log_rb.Checked Then
            action = "log "
        ElseIf pass_rb.Checked Then
            action = "pass "
        ElseIf activate_rb.Checked Then
            action = "activate"
        ElseIf drop_rb.Checked Then
            action = "drop "
        ElseIf sdrop_rb.Checked Then
            action = "sdrop "
        ElseIf dynamic_rb.Checked Then
            action = "dynamic "
        ElseIf reject_rb.Checked Then
            action = "reject "
        End If

        If tcp_rb.Checked Then
            protocol = "TCP "
        ElseIf udp_rb.Checked Then
            protocol = "UDP "
        ElseIf icmp_rb.Checked Then
            protocol = "IMCP "
        ElseIf ip_rb.Checked Then
            protocol = "IP "
        End If

        sourceip = TextBox1.Text & " "
        destip = TextBox2.Text & " "
        sourceport = TextBox3.Text & " "
        destport = TextBox4.Text & " "
        If right_rb.Checked Then
            direction = "-> "
        ElseIf both_rb.Checked Then
            direction = "<> "
        End If

        modif = "(" & TextBox6.Text & ")"

        rule = action & protocol & sourceip & sourceport & direction & destip & destport & modif
        Me.ListBox1.Text = rule
        ListBox1.Items.Add(rule)

    End Sub
    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        Dim myStream As Stream
        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            myStream = saveFileDialog1.OpenFile()
            If (myStream IsNot Nothing) Then
                Dim saver As New System.IO.StreamWriter(myStream)
                Dim i As Integer
                For i = 0 To ListBox1.Items.Count - 1
                    saver.WriteLine(ListBox1.Items.Item(i))
                Next
                saver.Close()
                MsgBox(" Rules Successfully saved to File")
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        protocol = ""
        action = ""
        sourceip = ""
        direction = "-> "
        rule = ""
        ListBox1.Items.Clear()
        For Each ctl As Control In Panel3.Controls
            If TypeOf ctl Is RadioButton Then
                DirectCast(ctl, RadioButton).Checked = False
            End If
        Next
        For Each ctl As Control In Panel4.Controls
            If TypeOf ctl Is RadioButton Then
                DirectCast(ctl, RadioButton).Checked = False
            End If
        Next
        For Each ctl As Control In Panel5.Controls
            If TypeOf ctl Is RadioButton Then
                DirectCast(ctl, RadioButton).Checked = False
            End If
        Next
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myStream As Stream = Nothing
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "c:\Desktop"
        openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                myStream = openFileDialog1.OpenFile()
                If (myStream IsNot Nothing) Then
                    For Each line As String In File.ReadAllLines(openFileDialog1.FileName)
                        ListBox1.Items.Add(line)
                    Next
                End If
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox5.Text = ListBox1.SelectedItem
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim itemCount As Integer = ListBox1.Items.Count
        If itemCount = 0 Then

        Else
            ListBox1.Items(ListBox1.SelectedIndex) = TextBox5.Text
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class