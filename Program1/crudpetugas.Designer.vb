<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class crudpetugas
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
        Me.txtpasswordpetuagas = New System.Windows.Forms.TextBox()
        Me.txtnamapetugas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvpetugas = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Groupcrudpetugas = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.txtidpetugas = New System.Windows.Forms.TextBox()
        CType(Me.dgvpetugas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Groupcrudpetugas.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtpasswordpetuagas
        '
        Me.txtpasswordpetuagas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtpasswordpetuagas.Location = New System.Drawing.Point(160, 134)
        Me.txtpasswordpetuagas.Name = "txtpasswordpetuagas"
        Me.txtpasswordpetuagas.Size = New System.Drawing.Size(432, 20)
        Me.txtpasswordpetuagas.TabIndex = 26
        '
        'txtnamapetugas
        '
        Me.txtnamapetugas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtnamapetugas.Location = New System.Drawing.Point(160, 88)
        Me.txtnamapetugas.Name = "txtnamapetugas"
        Me.txtnamapetugas.Size = New System.Drawing.Size(432, 20)
        Me.txtnamapetugas.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "PASSWORD"
        '
        'dgvpetugas
        '
        Me.dgvpetugas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvpetugas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvpetugas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvpetugas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpetugas.Location = New System.Drawing.Point(69, 232)
        Me.dgvpetugas.Name = "dgvpetugas"
        Me.dgvpetugas.RowHeadersVisible = False
        Me.dgvpetugas.Size = New System.Drawing.Size(535, 176)
        Me.dgvpetugas.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "NAMA"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "ID"
        '
        'Groupcrudpetugas
        '
        Me.Groupcrudpetugas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Groupcrudpetugas.Controls.Add(Me.Button6)
        Me.Groupcrudpetugas.Controls.Add(Me.btnhapus)
        Me.Groupcrudpetugas.Controls.Add(Me.btnbatal)
        Me.Groupcrudpetugas.Controls.Add(Me.btnedit)
        Me.Groupcrudpetugas.Controls.Add(Me.btntambah)
        Me.Groupcrudpetugas.Controls.Add(Me.btnsimpan)
        Me.Groupcrudpetugas.Controls.Add(Me.txtidpetugas)
        Me.Groupcrudpetugas.Controls.Add(Me.txtpasswordpetuagas)
        Me.Groupcrudpetugas.Controls.Add(Me.txtnamapetugas)
        Me.Groupcrudpetugas.Controls.Add(Me.Label5)
        Me.Groupcrudpetugas.Controls.Add(Me.Label4)
        Me.Groupcrudpetugas.Controls.Add(Me.Label1)
        Me.Groupcrudpetugas.Location = New System.Drawing.Point(12, 12)
        Me.Groupcrudpetugas.Name = "Groupcrudpetugas"
        Me.Groupcrudpetugas.Size = New System.Drawing.Size(646, 214)
        Me.Groupcrudpetugas.TabIndex = 2
        Me.Groupcrudpetugas.TabStop = False
        Me.Groupcrudpetugas.Text = "CRUD PETUGAS"
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button6.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button6.Location = New System.Drawing.Point(490, 172)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 34
        Me.Button6.Text = "KELUAR"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'btnhapus
        '
        Me.btnhapus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnhapus.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnhapus.FlatAppearance.BorderSize = 0
        Me.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhapus.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnhapus.Location = New System.Drawing.Point(409, 172)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 23)
        Me.btnhapus.TabIndex = 33
        Me.btnhapus.Text = "HAPUS"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnbatal
        '
        Me.btnbatal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnbatal.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnbatal.FlatAppearance.BorderSize = 0
        Me.btnbatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbatal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnbatal.Location = New System.Drawing.Point(328, 172)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(75, 23)
        Me.btnbatal.TabIndex = 32
        Me.btnbatal.Text = "BATAL"
        Me.btnbatal.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnedit.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnedit.FlatAppearance.BorderSize = 0
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnedit.Location = New System.Drawing.Point(247, 172)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 23)
        Me.btnedit.TabIndex = 31
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btntambah
        '
        Me.btntambah.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btntambah.BackColor = System.Drawing.SystemColors.Highlight
        Me.btntambah.FlatAppearance.BorderSize = 0
        Me.btntambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntambah.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btntambah.Location = New System.Drawing.Point(85, 172)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 23)
        Me.btntambah.TabIndex = 30
        Me.btntambah.Text = "TAMBAH"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'btnsimpan
        '
        Me.btnsimpan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsimpan.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnsimpan.FlatAppearance.BorderSize = 0
        Me.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsimpan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnsimpan.Location = New System.Drawing.Point(166, 172)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnsimpan.TabIndex = 29
        Me.btnsimpan.Text = "SIMPAN"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'txtidpetugas
        '
        Me.txtidpetugas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtidpetugas.Location = New System.Drawing.Point(160, 44)
        Me.txtidpetugas.Name = "txtidpetugas"
        Me.txtidpetugas.Size = New System.Drawing.Size(432, 20)
        Me.txtidpetugas.TabIndex = 28
        '
        'crudpetugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(670, 420)
        Me.Controls.Add(Me.dgvpetugas)
        Me.Controls.Add(Me.Groupcrudpetugas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "crudpetugas"
        Me.Text = "crudpetugas"
        CType(Me.dgvpetugas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Groupcrudpetugas.ResumeLayout(False)
        Me.Groupcrudpetugas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtpasswordpetuagas As System.Windows.Forms.TextBox
    Friend WithEvents txtnamapetugas As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvpetugas As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Groupcrudpetugas As System.Windows.Forms.GroupBox
    Friend WithEvents txtidpetugas As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
End Class
