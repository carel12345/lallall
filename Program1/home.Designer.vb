<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.Panelmenuadmin = New System.Windows.Forms.Panel()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnlaporan = New System.Windows.Forms.Button()
        Me.btnhistory = New System.Windows.Forms.Button()
        Me.btnpembayaran = New System.Windows.Forms.Button()
        Me.Panelmenudatasiswa = New System.Windows.Forms.Panel()
        Me.btnpetugas = New System.Windows.Forms.Button()
        Me.btnsiswa = New System.Windows.Forms.Button()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panelhome = New System.Windows.Forms.Panel()
        Me.btnadmin = New System.Windows.Forms.Button()
        Me.Panelmenuadmin.SuspendLayout()
        Me.Panelmenudatasiswa.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panelmenuadmin
        '
        Me.Panelmenuadmin.AutoScroll = True
        Me.Panelmenuadmin.BackColor = System.Drawing.Color.AliceBlue
        Me.Panelmenuadmin.Controls.Add(Me.btnkeluar)
        Me.Panelmenuadmin.Controls.Add(Me.btnlaporan)
        Me.Panelmenuadmin.Controls.Add(Me.btnhistory)
        Me.Panelmenuadmin.Controls.Add(Me.btnpembayaran)
        Me.Panelmenuadmin.Controls.Add(Me.Panelmenudatasiswa)
        Me.Panelmenuadmin.Controls.Add(Me.btnmenu)
        Me.Panelmenuadmin.Controls.Add(Me.Panel3)
        Me.Panelmenuadmin.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panelmenuadmin.Location = New System.Drawing.Point(0, 0)
        Me.Panelmenuadmin.Name = "Panelmenuadmin"
        Me.Panelmenuadmin.Size = New System.Drawing.Size(150, 491)
        Me.Panelmenuadmin.TabIndex = 0
        '
        'btnkeluar
        '
        Me.btnkeluar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnkeluar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnkeluar.FlatAppearance.BorderSize = 0
        Me.btnkeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnkeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkeluar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnkeluar.Location = New System.Drawing.Point(0, 454)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnkeluar.Size = New System.Drawing.Size(133, 59)
        Me.btnkeluar.TabIndex = 7
        Me.btnkeluar.Text = "KELUAR"
        Me.btnkeluar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnkeluar.UseVisualStyleBackColor = False
        '
        'btnlaporan
        '
        Me.btnlaporan.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnlaporan.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnlaporan.FlatAppearance.BorderSize = 0
        Me.btnlaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlaporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlaporan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnlaporan.Location = New System.Drawing.Point(0, 395)
        Me.btnlaporan.Name = "btnlaporan"
        Me.btnlaporan.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnlaporan.Size = New System.Drawing.Size(133, 59)
        Me.btnlaporan.TabIndex = 6
        Me.btnlaporan.Text = "LAPORAN"
        Me.btnlaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlaporan.UseVisualStyleBackColor = False
        '
        'btnhistory
        '
        Me.btnhistory.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnhistory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnhistory.FlatAppearance.BorderSize = 0
        Me.btnhistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhistory.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnhistory.Location = New System.Drawing.Point(0, 336)
        Me.btnhistory.Name = "btnhistory"
        Me.btnhistory.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnhistory.Size = New System.Drawing.Size(133, 59)
        Me.btnhistory.TabIndex = 5
        Me.btnhistory.Text = "HISTORI PEMBAYARAN"
        Me.btnhistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhistory.UseVisualStyleBackColor = False
        '
        'btnpembayaran
        '
        Me.btnpembayaran.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnpembayaran.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnpembayaran.FlatAppearance.BorderSize = 0
        Me.btnpembayaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpembayaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpembayaran.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnpembayaran.Location = New System.Drawing.Point(0, 277)
        Me.btnpembayaran.Name = "btnpembayaran"
        Me.btnpembayaran.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnpembayaran.Size = New System.Drawing.Size(133, 59)
        Me.btnpembayaran.TabIndex = 4
        Me.btnpembayaran.Text = "TRANSAKSI PEMBAYARAN"
        Me.btnpembayaran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnpembayaran.UseVisualStyleBackColor = False
        '
        'Panelmenudatasiswa
        '
        Me.Panelmenudatasiswa.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panelmenudatasiswa.Controls.Add(Me.btnadmin)
        Me.Panelmenudatasiswa.Controls.Add(Me.btnpetugas)
        Me.Panelmenudatasiswa.Controls.Add(Me.btnsiswa)
        Me.Panelmenudatasiswa.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panelmenudatasiswa.Location = New System.Drawing.Point(0, 153)
        Me.Panelmenudatasiswa.Name = "Panelmenudatasiswa"
        Me.Panelmenudatasiswa.Size = New System.Drawing.Size(133, 124)
        Me.Panelmenudatasiswa.TabIndex = 3
        '
        'btnpetugas
        '
        Me.btnpetugas.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnpetugas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnpetugas.FlatAppearance.BorderSize = 0
        Me.btnpetugas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpetugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpetugas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnpetugas.Location = New System.Drawing.Point(0, 40)
        Me.btnpetugas.Name = "btnpetugas"
        Me.btnpetugas.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnpetugas.Size = New System.Drawing.Size(133, 40)
        Me.btnpetugas.TabIndex = 1
        Me.btnpetugas.Text = "CRUD PETUGAS"
        Me.btnpetugas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnpetugas.UseVisualStyleBackColor = False
        '
        'btnsiswa
        '
        Me.btnsiswa.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnsiswa.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnsiswa.FlatAppearance.BorderSize = 0
        Me.btnsiswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsiswa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsiswa.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnsiswa.Location = New System.Drawing.Point(0, 0)
        Me.btnsiswa.Name = "btnsiswa"
        Me.btnsiswa.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnsiswa.Size = New System.Drawing.Size(133, 40)
        Me.btnsiswa.TabIndex = 0
        Me.btnsiswa.Text = "CRUD SISWA"
        Me.btnsiswa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsiswa.UseVisualStyleBackColor = False
        '
        'btnmenu
        '
        Me.btnmenu.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnmenu.FlatAppearance.BorderSize = 0
        Me.btnmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmenu.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnmenu.Location = New System.Drawing.Point(0, 94)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnmenu.Size = New System.Drawing.Size(133, 59)
        Me.btnmenu.TabIndex = 2
        Me.btnmenu.Text = "MENU"
        Me.btnmenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmenu.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(133, 94)
        Me.Panel3.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(150, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(670, 94)
        Me.Panel2.TabIndex = 1
        '
        'Panelhome
        '
        Me.Panelhome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panelhome.Location = New System.Drawing.Point(150, 94)
        Me.Panelhome.Name = "Panelhome"
        Me.Panelhome.Size = New System.Drawing.Size(670, 397)
        Me.Panelhome.TabIndex = 2
        '
        'btnadmin
        '
        Me.btnadmin.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnadmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnadmin.FlatAppearance.BorderSize = 0
        Me.btnadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadmin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnadmin.Location = New System.Drawing.Point(0, 80)
        Me.btnadmin.Name = "btnadmin"
        Me.btnadmin.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnadmin.Size = New System.Drawing.Size(133, 40)
        Me.btnadmin.TabIndex = 2
        Me.btnadmin.Text = "CRUD ADMIN"
        Me.btnadmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnadmin.UseVisualStyleBackColor = False
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 491)
        Me.Controls.Add(Me.Panelhome)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panelmenuadmin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "home"
        Me.Text = "home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panelmenuadmin.ResumeLayout(False)
        Me.Panelmenudatasiswa.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panelmenuadmin As System.Windows.Forms.Panel
    Friend WithEvents Panelmenudatasiswa As System.Windows.Forms.Panel
    Friend WithEvents btnmenu As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnhistory As System.Windows.Forms.Button
    Friend WithEvents btnpembayaran As System.Windows.Forms.Button
    Friend WithEvents btnpetugas As System.Windows.Forms.Button
    Friend WithEvents btnsiswa As System.Windows.Forms.Button
    Friend WithEvents Panelhome As System.Windows.Forms.Panel
    Friend WithEvents btnlaporan As System.Windows.Forms.Button
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btnadmin As System.Windows.Forms.Button
End Class
