﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UserName = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PerpustakaanDataSet = New Perpustakaan_Fix.PerpustakaanDataSet()
        Me.LoginTableAdapter = New Perpustakaan_Fix.PerpustakaanDataSetTableAdapters.loginTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerpustakaanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Snap ITC", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(92, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(608, 77)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Library"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label2.Location = New System.Drawing.Point(347, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label3.Location = New System.Drawing.Point(347, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 38)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'UserName
        '
        Me.UserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserName.Location = New System.Drawing.Point(531, 168)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(198, 34)
        Me.UserName.TabIndex = 3
        '
        'Password
        '
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.2!)
        Me.Password.Location = New System.Drawing.Point(531, 230)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(198, 34)
        Me.Password.TabIndex = 4
        Me.Password.UseSystemPasswordChar = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Button1.Font = New System.Drawing.Font("Tw Cen MT", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.AliceBlue
        Me.Button1.Location = New System.Drawing.Point(433, 313)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 51)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(44, 140)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(283, 269)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button2.Font = New System.Drawing.Font("Tw Cen MT", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.AliceBlue
        Me.Button2.Location = New System.Drawing.Point(631, 417)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 54)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Admin"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'LoginBindingSource
        '
        Me.LoginBindingSource.DataMember = "login"
        Me.LoginBindingSource.DataSource = Me.PerpustakaanDataSet
        '
        'PerpustakaanDataSet
        '
        Me.PerpustakaanDataSet.DataSetName = "PerpustakaanDataSet"
        Me.PerpustakaanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(803, 498)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerpustakaanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents UserName As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents PerpustakaanDataSet As PerpustakaanDataSet
    Friend WithEvents LoginBindingSource As BindingSource
    Friend WithEvents LoginTableAdapter As PerpustakaanDataSetTableAdapters.loginTableAdapter
End Class
