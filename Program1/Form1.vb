Public Class Formutama

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Private Sub btnloginsebagaiadmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnloginsebagaiadmin.Click
        Me.Hide()
        loginadmin.Show()
    End Sub

    Private Sub btnloginsebagaipetugas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnloginsebagaipetugas.Click
        Me.Hide()
        loginpetugas.Show()
    End Sub

    Private Sub btnloginsebagaisiswa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnloginsebagaisiswa.Click
        Me.Hide()
        loginsiswa.Show()
    End Sub

    Private Sub Formutama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
