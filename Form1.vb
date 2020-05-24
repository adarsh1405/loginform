Public Class Form1
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Guna2CircleProgressBar1.Increment(1)
        Guna2Button1.Enabled = False
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Guna2CircleProgressBar1.Value = 0
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Guna2CircleProgressBar1_ValueChanged(sender As Object, e As EventArgs) Handles Guna2CircleProgressBar1.ValueChanged

    End Sub

    Private Sub Guna2TextBox1_MouseEnter(sender As Object, e As EventArgs) Handles Guna2TextBox1.MouseEnter
        If Guna2TextBox1.Text = "UserName" Then
            Guna2TextBox1.Text = ""
            Guna2TextBox1.ForeColor = Color.Black
        End If

    End Sub

    Private Sub Guna2TextBox1_MouseLeave(sender As Object, e As EventArgs) Handles Guna2TextBox1.MouseLeave
        If Guna2TextBox1.Text = "" Then
            Guna2TextBox1.Text = "UserName"
            Guna2TextBox1.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub Guna2TextBox2_MouseEnter(sender As Object, e As EventArgs) Handles Guna2TextBox2.MouseEnter
        If Guna2TextBox2.Text = "Password" Then
            Guna2TextBox2.Text = ""
            Guna2TextBox2.ForeColor = Color.Black
        End If

    End Sub

    Private Sub Guna2TextBox2_MouseLeave(sender As Object, e As EventArgs) Handles Guna2TextBox2.MouseLeave
        If Guna2TextBox2.Text = "" Then
            Guna2TextBox2.Text = "Password"
            Guna2TextBox2.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        msg.Show()
        Timer2.Stop()
    End Sub
End Class
