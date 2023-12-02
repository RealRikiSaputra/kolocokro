<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.iconApp = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbLihat = New System.Windows.Forms.CheckBox()
        Me.cbRemember = New System.Windows.Forms.CheckBox()
        Me.bwLogin = New System.ComponentModel.BackgroundWorker()
        Me.tbMACAddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconApp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(239, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Login"
        '
        'tbUsername
        '
        Me.tbUsername.Location = New System.Drawing.Point(246, 89)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(209, 20)
        Me.tbUsername.TabIndex = 3
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(246, 151)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(209, 20)
        Me.tbPassword.TabIndex = 3
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(240, 302)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(113, 53)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(357, 390)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Kolocokro By R And D Team"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.Kolocokro.My.Resources.Resources.DENATURE
        Me.PictureBox1.Location = New System.Drawing.Point(326, 384)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'iconApp
        '
        Me.iconApp.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.iconApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.iconApp.Image = Global.Kolocokro.My.Resources.Resources.kolocokro
        Me.iconApp.Location = New System.Drawing.Point(12, 12)
        Me.iconApp.Name = "iconApp"
        Me.iconApp.Size = New System.Drawing.Size(186, 191)
        Me.iconApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconApp.TabIndex = 1
        Me.iconApp.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-1, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(217, 419)
        Me.Panel1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(246, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(246, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Password"
        '
        'cbLihat
        '
        Me.cbLihat.AutoSize = True
        Me.cbLihat.Location = New System.Drawing.Point(246, 227)
        Me.cbLihat.Name = "cbLihat"
        Me.cbLihat.Size = New System.Drawing.Size(98, 17)
        Me.cbLihat.TabIndex = 8
        Me.cbLihat.Text = "Lihat Password"
        Me.cbLihat.UseVisualStyleBackColor = True
        '
        'cbRemember
        '
        Me.cbRemember.AutoSize = True
        Me.cbRemember.Location = New System.Drawing.Point(246, 259)
        Me.cbRemember.Name = "cbRemember"
        Me.cbRemember.Size = New System.Drawing.Size(95, 17)
        Me.cbRemember.TabIndex = 8
        Me.cbRemember.Text = "Remember Me"
        Me.cbRemember.UseVisualStyleBackColor = True
        '
        'bwLogin
        '
        '
        'tbMACAddress
        '
        Me.tbMACAddress.Location = New System.Drawing.Point(246, 194)
        Me.tbMACAddress.Name = "tbMACAddress"
        Me.tbMACAddress.ReadOnly = True
        Me.tbMACAddress.Size = New System.Drawing.Size(98, 20)
        Me.tbMACAddress.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(246, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Serial Number"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 415)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbMACAddress)
        Me.Controls.Add(Me.cbRemember)
        Me.Controls.Add(Me.cbLihat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.iconApp)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kolocokro"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconApp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents iconApp As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label2 As Label
    Private WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbLihat As CheckBox
    Friend WithEvents cbRemember As CheckBox
    Friend WithEvents bwLogin As System.ComponentModel.BackgroundWorker
    Friend WithEvents tbMACAddress As TextBox
    Friend WithEvents Label5 As Label
End Class
