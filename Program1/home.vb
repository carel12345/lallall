Public Class home

    Private Sub home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        hidesubmenu()
    End Sub

    Private Sub hidesubmenu()
        Panelmenudatasiswa.Visible = False
    End Sub

    Private Sub showsubmenu(ByVal submenu As Panel)
        If submenu.Visible = False Then
            hidesubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub btnmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmenu.Click
        showsubmenu(Panelmenudatasiswa)
    End Sub

    Private Sub btnsiswa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsiswa.Click
        hidesubmenu()
        openchlidform(New crudsiswa)
    End Sub

    Private Sub btnpetugas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpetugas.Click
        hidesubmenu()
        openchlidform(New crudpetugas)
    End Sub

    Private Sub btnadmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadmin.Click
        hidesubmenu()
    End Sub

    Private currentform As Form = Nothing
    Private Sub openchlidform(ByVal childform As Form)
        If currentform IsNot Nothing Then currentform.Close()
        currentform = childform
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        Panelhome.Controls.Add(childform)
        Panelhome.Tag = childform
        childform.BringToFront()
        childform.Show()
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Me.Close()
        loginadmin.Show()
    End Sub
End Class