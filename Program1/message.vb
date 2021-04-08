Public Class message

    Private Sub btnkeluar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Formutama.Close()
        Me.Close()
    End Sub

    Private Sub btnkembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkembali.Click
        Me.Close()
        Formutama.Show()
    End Sub
End Class