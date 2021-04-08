<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formutama
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnloginsebagaiadmin = New System.Windows.Forms.Button()
        Me.btnloginsebagaipetugas = New System.Windows.Forms.Button()
        Me.btnloginsebagaisiswa = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(420, 10)
        Me.Panel1.TabIndex = 6
        '
        'btnloginsebagaiadmin
        '
        Me.btnloginsebagaiadmin.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnloginsebagaiadmin.FlatAppearance.BorderSize = 0
        Me.btnloginsebagaiadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnloginsebagaiadmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnloginsebagaiadmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnloginsebagaiadmin.Location = New System.Drawing.Point(104, 95)
        Me.btnloginsebagaiadmin.Name = "btnloginsebagaiadmin"
        Me.btnloginsebagaiadmin.Size = New System.Drawing.Size(207, 23)
        Me.btnloginsebagaiadmin.TabIndex = 7
        Me.btnloginsebagaiadmin.Text = "LOGIN SEBAGAI ADMIN"
        Me.btnloginsebagaiadmin.UseVisualStyleBackColor = False
        '
        'btnloginsebagaipetugas
        '
        Me.btnloginsebagaipetugas.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnloginsebagaipetugas.FlatAppearance.BorderSize = 0
        Me.btnloginsebagaipetugas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnloginsebagaipetugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnloginsebagaipetugas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnloginsebagaipetugas.Location = New System.Drawing.Point(104, 147)
        Me.btnloginsebagaipetugas.Name = "btnloginsebagaipetugas"
        Me.btnloginsebagaipetugas.Size = New System.Drawing.Size(207, 23)
        Me.btnloginsebagaipetugas.TabIndex = 8
        Me.btnloginsebagaipetugas.Text = "LOGIN SEBAGAI PETUGAS"
        Me.btnloginsebagaipetugas.UseVisualStyleBackColor = False
        '
        'btnloginsebagaisiswa
        '
        Me.btnloginsebagaisiswa.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnloginsebagaisiswa.FlatAppearance.BorderSize = 0
        Me.btnloginsebagaisiswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnloginsebagaisiswa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnloginsebagaisiswa.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnloginsebagaisiswa.Location = New System.Drawing.Point(104, 198)
        Me.btnloginsebagaisiswa.Name = "btnloginsebagaisiswa"
        Me.btnloginsebagaisiswa.Size = New System.Drawing.Size(207, 23)
        Me.btnloginsebagaisiswa.TabIndex = 9
        Me.btnloginsebagaisiswa.Text = "LOGIN SEBAGAI SISWA"
        Me.btnloginsebagaisiswa.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(42, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 39)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "PEMBAYARAN SPP"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(146, 246)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(124, 23)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "CLOSE"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Formutama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 325)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnloginsebagaisiswa)
        Me.Controls.Add(Me.btnloginsebagaipetugas)
        Me.Controls.Add(Me.btnloginsebagaiadmin)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(420, 325)
        Me.MinimumSize = New System.Drawing.Size(420, 325)
        Me.Name = "Formutama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnloginsebagaiadmin As System.Windows.Forms.Button
    Friend WithEvents btnloginsebagaipetugas As System.Windows.Forms.Button
    Friend WithEvents btnloginsebagaisiswa As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
