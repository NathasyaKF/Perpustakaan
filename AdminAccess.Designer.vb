<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminAccess
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminAccess))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.UserName = New System.Windows.Forms.TextBox()
        Me.sandi = New System.Windows.Forms.Label()
        Me.pengguna = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(81, 134)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(254, 242)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Button1.Font = New System.Drawing.Font("Tw Cen MT", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.AliceBlue
        Me.Button1.Location = New System.Drawing.Point(447, 306)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 51)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Password
        '
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.2!)
        Me.Password.Location = New System.Drawing.Point(545, 223)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(198, 34)
        Me.Password.TabIndex = 12
        Me.Password.UseSystemPasswordChar = True
        '
        'UserName
        '
        Me.UserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserName.Location = New System.Drawing.Point(545, 161)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(198, 34)
        Me.UserName.TabIndex = 11
        '
        'sandi
        '
        Me.sandi.AutoSize = True
        Me.sandi.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sandi.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.sandi.Location = New System.Drawing.Point(361, 219)
        Me.sandi.Name = "sandi"
        Me.sandi.Size = New System.Drawing.Size(138, 38)
        Me.sandi.TabIndex = 10
        Me.sandi.Text = "Password"
        '
        'pengguna
        '
        Me.pengguna.AutoSize = True
        Me.pengguna.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pengguna.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.pengguna.Location = New System.Drawing.Point(361, 157)
        Me.pengguna.Name = "pengguna"
        Me.pengguna.Size = New System.Drawing.Size(148, 38)
        Me.pengguna.TabIndex = 9
        Me.pengguna.Text = "Admin ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Snap ITC", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(154, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(507, 77)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Admin Access"
        '
        'AdminAccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.sandi)
        Me.Controls.Add(Me.pengguna)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AdminAccess"
        Me.Text = "AdminAccess"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Password As TextBox
    Friend WithEvents UserName As TextBox
    Friend WithEvents sandi As Label
    Friend WithEvents pengguna As Label
    Friend WithEvents Label1 As Label
End Class
