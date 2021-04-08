Public Class crudpetugas
    Sub hidupkanpetugas()
        txtidpetugas.Enabled = True
        txtnamapetugas.Enabled = True
        txtpasswordpetuagas.Enabled = True
    End Sub

    Sub matikanpetugas()
        txtidpetugas.Enabled = False
        txtnamapetugas.Enabled = False
        txtpasswordpetuagas.Enabled = False
    End Sub

    Sub kosongkanpetugas()
        txtidpetugas.Text = ""
        txtnamapetugas.Text = ""
        txtpasswordpetuagas.Text = ""
    End Sub


    Sub tampilkanpetugas()
        Call koneksi()
        DA = New OleDb.OleDbDataAdapter("select * from petugas", CONN)
        DS = New DataSet
        DA.Fill(DS)
        dgvpetugas.DataSource = DS.Tables(0)
        dgvpetugas.ReadOnly = True
    End Sub

    Sub datagridpetugas()
        dgvpetugas.Columns(0).Width = 60
        dgvpetugas.Columns(1).Width = 500
        dgvpetugas.Columns(2).Width = 517
    End Sub


    Private Sub crudpetugas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call kosongkanpetugas()
        Call matikanpetugas()
        Call tampilkanpetugas()
        Call datagridpetugas()
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Call hidupkanpetugas()
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        If txtidpetugas.Text = "" Or txtnamapetugas.Text = "" Or txtpasswordpetuagas.Text = "" Then
            MsgBox("HARAP DATA DI ISI....")
            Exit Sub
        Else
            Call koneksi()
            CMD = New OleDb.OleDbCommand("select * from petugas where id='" & txtidpetugas.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Call koneksi()
                Dim simpan As String
                simpan = "insert into petugas values('" & txtidpetugas.Text & "','" & txtnamapetugas.Text & "','" & txtpasswordpetuagas.Text & "')"
                CMD = New OleDb.OleDbCommand(simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("INPUT DATA SUKSES...")
            Else
                MsgBox("DATA TELAT SUDAH ADA...")
            End If
            Call kosongkanpetugas()
            Call matikanpetugas()
            Call tampilkanpetugas()
        End If
    End Sub

    Private Sub dgvpetugas_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvpetugas.CellMouseClick
        On Error Resume Next
        txtidpetugas.Text = dgvpetugas.Rows(e.RowIndex).Cells(0).Value
        txtnamapetugas.Text = dgvpetugas.Rows(e.RowIndex).Cells(1).Value
        txtpasswordpetuagas.Text = dgvpetugas.Rows(e.RowIndex).Cells(2).Value

        Call hidupkanpetugas()
        txtidpetugas.Enabled = False
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        If txtidpetugas.Text = "" Or txtnamapetugas.Text = "" Or txtpasswordpetuagas.Text = "" Then
            MsgBox("DATA TIDAK LENGKAP...")
            Exit Sub
        Else
            Call koneksi()
            CMD = New OleDb.OleDbCommand("update petugas set [username]='" & txtnamapetugas.Text & "',[password]='" & txtpasswordpetuagas.Text & "' where [id]='" & txtidpetugas.Text & "'", CONN)
            CMD.ExecuteNonQuery()
            MsgBox("DATA BERHASIL DI UPDATE...")
        End If
        Call matikanpetugas()
        Call kosongkanpetugas()
        Call tampilkanpetugas()
    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        Call kosongkanpetugas()
        Call matikanpetugas()
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        If txtidpetugas.Text = "" Then
            MsgBox("TIDAK ADA DATA YANG TERHAPUS...")
            Exit Sub
        Else
            If MessageBox.Show("ANDA YAKIN INGIN MENGHAPUS DATA INI", "KONFIRMASI", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                Call koneksi()
                CMD = New OleDb.OleDbCommand("delete from petugas where id='" & txtidpetugas.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                MsgBox("DATA TELAH TERHAPUS....")
                Call matikanpetugas()
                Call kosongkanpetugas()
                Call tampilkanpetugas()
            Else
                Call matikanpetugas()
                Call kosongkanpetugas()
            End If
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
End Class