Public Class loginadmin

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        message.Show()
        Me.Close()
    End Sub

    Private Sub loginadmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call koneksi()
        Dim login As String
        login = "select * from admin where username='" & txtusername.Text & "' and password='" & txtpassword.Text & "'"
        CMD = New OleDb.OleDbCommand(login, CONN)
        DR = CMD.ExecuteReader
        If DR.Read Then
            MsgBox("LOGIN BERHASIL...")
            Me.Hide()
            home.Show()
            txtusername.Text = ""
            txtpassword.Text = ""
        Else
            MsgBox("USERNAME ATAU PASSWORD SALAH...")
            txtusername.Text = ""
            txtpassword.Text = ""
            txtusername.Focus()
        End If
    End Sub

    Private Sub txtusername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtusername.KeyPress
        If (e.KeyChar = Chr(13)) Then
            txtpassword.Focus()
        End If
    End Sub

    Private Sub txtpassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpassword.KeyPress
        If (e.KeyChar = Chr(13)) Then
            Button1.Focus()
        End If
    End Sub
End Class