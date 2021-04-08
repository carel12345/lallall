<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class crudsiswa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvsiswa = New System.Windows.Forms.DataGridView()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.cmdkelas = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Groupcrudsiswa = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtnotelp = New System.Windows.Forms.TextBox()
        Me.txtspp = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtnis = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtnisn = New System.Windows.Forms.TextBox()
        CType(Me.dgvsiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Groupcrudsiswa.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvsiswa
        '
        Me.dgvsiswa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvsiswa.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvsiswa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvsiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsiswa.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvsiswa.Location = New System.Drawing.Point(12, 246)
        Me.dgvsiswa.Name = "dgvsiswa"
        Me.dgvsiswa.RowHeadersVisible = False
        Me.dgvsiswa.Size = New System.Drawing.Size(646, 162)
        Me.dgvsiswa.TabIndex = 1
        '
        'btnsimpan
        '
        Me.btnsimpan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsimpan.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnsimpan.FlatAppearance.BorderSize = 0
        Me.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsimpan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnsimpan.Location = New System.Drawing.Point(157, 171)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnsimpan.TabIndex = 0
        Me.btnsimpan.Text = "SIMPAN"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'cmdkelas
        '
        Me.cmdkelas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdkelas.FormattingEnabled = True
        Me.cmdkelas.Items.AddRange(New Object() {"XII-RPL", "XII-AKL"})
        Me.cmdkelas.Location = New System.Drawing.Point(428, 34)
        Me.cmdkelas.Name = "cmdkelas"
        Me.cmdkelas.Size = New System.Drawing.Size(212, 21)
        Me.cmdkelas.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "NISN"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "NIS"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "NAMA"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "PASSWORD"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(340, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "KELAS"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(340, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "ALAMAT"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(340, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "NO TELP"
        '
        'btntambah
        '
        Me.btntambah.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btntambah.BackColor = System.Drawing.SystemColors.Highlight
        Me.btntambah.FlatAppearance.BorderSize = 0
        Me.btntambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntambah.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btntambah.Location = New System.Drawing.Point(76, 171)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 23)
        Me.btntambah.TabIndex = 19
        Me.btntambah.Text = "TAMBAH"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnedit.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnedit.FlatAppearance.BorderSize = 0
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnedit.Location = New System.Drawing.Point(238, 171)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 23)
        Me.btnedit.TabIndex = 20
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnbatal
        '
        Me.btnbatal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnbatal.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnbatal.FlatAppearance.BorderSize = 0
        Me.btnbatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbatal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnbatal.Location = New System.Drawing.Point(319, 171)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(75, 23)
        Me.btnbatal.TabIndex = 21
        Me.btnbatal.Text = "BATAL"
        Me.btnbatal.UseVisualStyleBackColor = False
        '
        'btnhapus
        '
        Me.btnhapus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnhapus.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnhapus.FlatAppearance.BorderSize = 0
        Me.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhapus.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnhapus.Location = New System.Drawing.Point(400, 171)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 23)
        Me.btnhapus.TabIndex = 22
        Me.btnhapus.Text = "HAPUS"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button6.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button6.Location = New System.Drawing.Point(481, 171)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 23
        Me.Button6.Text = "KELUAR"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Groupcrudsiswa
        '
        Me.Groupcrudsiswa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Groupcrudsiswa.Controls.Add(Me.Label9)
        Me.Groupcrudsiswa.Controls.Add(Me.txtnotelp)
        Me.Groupcrudsiswa.Controls.Add(Me.txtspp)
        Me.Groupcrudsiswa.Controls.Add(Me.txtalamat)
        Me.Groupcrudsiswa.Controls.Add(Me.txtpassword)
        Me.Groupcrudsiswa.Controls.Add(Me.txtnis)
        Me.Groupcrudsiswa.Controls.Add(Me.txtnama)
        Me.Groupcrudsiswa.Controls.Add(Me.txtnisn)
        Me.Groupcrudsiswa.Controls.Add(Me.Button6)
        Me.Groupcrudsiswa.Controls.Add(Me.btnhapus)
        Me.Groupcrudsiswa.Controls.Add(Me.btnbatal)
        Me.Groupcrudsiswa.Controls.Add(Me.btnedit)
        Me.Groupcrudsiswa.Controls.Add(Me.btntambah)
        Me.Groupcrudsiswa.Controls.Add(Me.Label8)
        Me.Groupcrudsiswa.Controls.Add(Me.Label7)
        Me.Groupcrudsiswa.Controls.Add(Me.Label6)
        Me.Groupcrudsiswa.Controls.Add(Me.Label5)
        Me.Groupcrudsiswa.Controls.Add(Me.Label4)
        Me.Groupcrudsiswa.Controls.Add(Me.Label3)
        Me.Groupcrudsiswa.Controls.Add(Me.Label2)
        Me.Groupcrudsiswa.Controls.Add(Me.cmdkelas)
        Me.Groupcrudsiswa.Controls.Add(Me.btnsimpan)
        Me.Groupcrudsiswa.Location = New System.Drawing.Point(12, 12)
        Me.Groupcrudsiswa.Name = "Groupcrudsiswa"
        Me.Groupcrudsiswa.Size = New System.Drawing.Size(646, 228)
        Me.Groupcrudsiswa.TabIndex = 0
        Me.Groupcrudsiswa.TabStop = False
        Me.Groupcrudsiswa.Text = "CRUD SISWA"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(340, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "SPP"
        '
        'txtnotelp
        '
        Me.txtnotelp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtnotelp.Location = New System.Drawing.Point(428, 96)
        Me.txtnotelp.Name = "txtnotelp"
        Me.txtnotelp.Size = New System.Drawing.Size(212, 20)
        Me.txtnotelp.TabIndex = 31
        '
        'txtspp
        '
        Me.txtspp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtspp.Location = New System.Drawing.Point(428, 127)
        Me.txtspp.Name = "txtspp"
        Me.txtspp.Size = New System.Drawing.Size(212, 20)
        Me.txtspp.TabIndex = 30
        '
        'txtalamat
        '
        Me.txtalamat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtalamat.Location = New System.Drawing.Point(428, 65)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(212, 20)
        Me.txtalamat.TabIndex = 29
        '
        'txtpassword
        '
        Me.txtpassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtpassword.Location = New System.Drawing.Point(101, 130)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(212, 20)
        Me.txtpassword.TabIndex = 28
        '
        'txtnis
        '
        Me.txtnis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtnis.Location = New System.Drawing.Point(101, 68)
        Me.txtnis.Name = "txtnis"
        Me.txtnis.Size = New System.Drawing.Size(212, 20)
        Me.txtnis.TabIndex = 27
        '
        'txtnama
        '
        Me.txtnama.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtnama.Location = New System.Drawing.Point(101, 99)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(212, 20)
        Me.txtnama.TabIndex = 26
        '
        'txtnisn
        '
        Me.txtnisn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtnisn.Location = New System.Drawing.Point(101, 38)
        Me.txtnisn.Name = "txtnisn"
        Me.txtnisn.Size = New System.Drawing.Size(212, 20)
        Me.txtnisn.TabIndex = 24
        '
        'crudsiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(670, 420)
        Me.Controls.Add(Me.dgvsiswa)
        Me.Controls.Add(Me.Groupcrudsiswa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "crudsiswa"
        Me.Text = "crudsiswa"
        CType(Me.dgvsiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Groupcrudsiswa.ResumeLayout(False)
        Me.Groupcrudsiswa.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvsiswa As System.Windows.Forms.DataGridView
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents cmdkelas As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Groupcrudsiswa As System.Windows.Forms.GroupBox
    Friend WithEvents txtnotelp As System.Windows.Forms.TextBox
    Friend WithEvents txtspp As System.Windows.Forms.TextBox
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtnis As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtnisn As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
