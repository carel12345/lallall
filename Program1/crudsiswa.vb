Public Class crudsiswa

    Sub kosongkan()
        txtnisn.Text = ""
        txtnis.Text = ""
        txtnama.Text = ""
        txtpassword.Text = ""
        cmdkelas.Text = ""
        txtalamat.Text = ""
        txtnotelp.Text = ""
        txtspp.Text = ""
    End Sub

    Sub matikan()
        txtnisn.Enabled = False
        txtnis.Enabled = False
        txtnama.Enabled = False
        txtpassword.Enabled = False
        cmdkelas.Enabled = False
        txtalamat.Enabled = False
        txtnotelp.Enabled = False
        txtspp.Enabled = False
    End Sub

    Sub hidupkan()
        txtnisn.Enabled = True
        txtnis.Enabled = True
        txtnama.Enabled = True
        txtpassword.Enabled = True
        cmdkelas.Enabled = True
        txtalamat.Enabled = True
        txtnotelp.Enabled = True
        txtspp.Enabled = True
    End Sub


    Sub datagrid()
        dgvsiswa.Columns(0).Width = 150
        dgvsiswa.Columns(7).Width = 390
        dgvsiswa.Columns(4).Width = 50
        dgvsiswa.Columns(5).Width = 150
        dgvsiswa.Columns(2).Width = 150

    End Sub


    Sub tampilkandata()
        Call koneksi()
        DA = New OleDb.OleDbDataAdapter("select * from siswa", CONN)
        DS = New DataSet
        DA.Fill(DS)
        dgvsiswa.DataSource = DS.Tables(0)
        dgvsiswa.ReadOnly = True
    End Sub

    Private Sub crudsiswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call matikan()
        Call kosongkan()
        Call tampilkandata()
        Call datagrid()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Call hidupkan()
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        If txtnisn.Text = "" Or txtnis.Text = "" Or txtnama.Text = "" Then
            MsgBox("HARAP DATA DI ISI....")
            Exit Sub
        Else
            Call koneksi()
            CMD = New OleDb.OleDbCommand("select * from siswa where nisn='" & txtnisn.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Call koneksi()
                Dim simpan As String
                simpan = "insert into siswa values('" & txtnisn.Text & "','" & txtnis.Text & "','" & txtnama.Text & "','" & txtpassword.Text & "','" & cmdkelas.Text & "','" & txtalamat.Text & "','" & txtnotelp.Text & "','" & txtspp.Text & "')"
                CMD = New OleDb.OleDbCommand(simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("INPUT DATA SUKSES...")
            Else
                MsgBox("DATA TELAT SUDAH ADA...")
            End If
            Call kosongkan()
            Call matikan()
            Call tampilkandata()
        End If
    End Sub

    Private Sub dgvsiswa_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvsiswa.CellMouseClick
        On Error Resume Next
        txtnisn.Text = dgvsiswa.Rows(e.RowIndex).Cells(0).Value
        txtnis.Text = dgvsiswa.Rows(e.RowIndex).Cells(1).Value
        txtnama.Text = dgvsiswa.Rows(e.RowIndex).Cells(2).Value
        txtpassword.Text = dgvsiswa.Rows(e.RowIndex).Cells(3).Value
        cmdkelas.Text = dgvsiswa.Rows(e.RowIndex).Cells(4).Value
        txtalamat.Text = dgvsiswa.Rows(e.RowIndex).Cells(5).Value
        txtnotelp.Text = dgvsiswa.Rows(e.RowIndex).Cells(6).Value
        txtspp.Text = dgvsiswa.Rows(e.RowIndex).Cells(7).Value

        Call hidupkan()
        txtnisn.Enabled = False
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        If txtnisn.Text = "" Or txtnis.Text = "" Or txtnama.Text = "" Then
            MsgBox("DATA TIDAK LENGKAP...")
            Exit Sub
        Else
            Call koneksi()
            CMD = New OleDb.OleDbCommand("update siswa set [nis]='" & txtnis.Text & "',[nama]='" & txtnama.Text & "',[password]='" & txtpassword.Text & "',[kelas]='" & cmdkelas.Text & "',[alamat]='" & txtalamat.Text & "',[no_telp]='" & txtnotelp.Text & "',[spp]='" & txtspp.Text & "' where [nisn]='" & txtnisn.Text & "'", CONN)
            CMD.ExecuteNonQuery()
            MsgBox("DATA BERHASIL DI UPDATE...")
        End If
        Call matikan()
        Call kosongkan()
        Call tampilkandata()
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        If txtnisn.Text = "" Then
            MsgBox("TIDAK ADA DATA YANG TERHAPUS...")
            Exit Sub
        Else
            If MessageBox.Show("ANDA YAKIN INGIN MENGHAPUS DATA INI", "KONFIRMASI", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                Call koneksi()
                CMD = New OleDb.OleDbCommand("delete from siswa where nisn='" & txtnisn.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                MsgBox("DATA TELAH TERHAPUS....")
                Call matikan()
                Call kosongkan()
                Call tampilkandata()
            Else
                Call matikan()
                Call kosongkan()
            End If
        End If
    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        Call matikan()
        Call kosongkan()
    End Sub
End Class