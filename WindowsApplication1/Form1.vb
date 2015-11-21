Public Class StopWatch

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If millisec.Text < 59 Then
            millisec.Text = Val(millisec.Text) + 1
            If millisec.Text < 10 Then
                millisec.Text = "0" + millisec.Text
            End If
        Else
            millisec.Text = 0
            If sec.Text < 59 Then
                sec.Text = Val(sec.Text) + 1
                If sec.Text < 10 Then
                    sec.Text = "0" + sec.Text
                End If
            Else
                sec.Text = 0
                If min.Text < 59 Then
                    min.Text = Val(min.Text) + 1
                    If min.Text < 10 Then
                        min.Text = "0" + min.Text
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles start.Click
        If start.Text = "Start" Then
            Timer1.Enabled = True
            start.Text = "Lap"
        Else
            lstlap.Items.Add(min.Text & ":" & sec.Text & ":" & millisec.Text)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset.Click
        Timer1.Enabled = False
        millisec.Text = 0
        sec.Text = 0
        min.Text = 0
        start.Text = "Start"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit_btn.Click
        Dim ans As Integer
        ans = MessageBox.Show("Are you sure ?", "Exit", MessageBoxButtons.YesNo)
        If ans = vbYes Then
            End
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pause.Click
        Timer1.Enabled = False
        start.Text = "Start"
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
        Form2.Show()
    End Sub
    Sub main()
        If min.Text = 60 Then
            MessageBox.Show("You have used 1 hour free trial!!!!", "Warning", MessageBoxButtons.OK)
        End If
    End Sub
    
End Class
