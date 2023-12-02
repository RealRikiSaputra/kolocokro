<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProfile))
        Me.labelProfile = New System.Windows.Forms.Label()
        Me.btnAddProfile = New System.Windows.Forms.Button()
        Me.btnBackProfile = New System.Windows.Forms.Button()
        Me.addTask = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.editTask = New System.Windows.Forms.PictureBox()
        Me.salinTask = New System.Windows.Forms.PictureBox()
        Me.deleteTask = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbDaftarProfile = New System.Windows.Forms.TextBox()
        Me.tbNameProfile = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bwAddProfile = New System.ComponentModel.BackgroundWorker()
        CType(Me.addTask, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.editTask, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.salinTask, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deleteTask, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelProfile
        '
        Me.labelProfile.AutoSize = True
        Me.labelProfile.Font = New System.Drawing.Font("Impact", 20.25!)
        Me.labelProfile.Location = New System.Drawing.Point(8, 4)
        Me.labelProfile.Name = "labelProfile"
        Me.labelProfile.Size = New System.Drawing.Size(99, 34)
        Me.labelProfile.TabIndex = 18
        Me.labelProfile.Text = "PROFILE"
        '
        'btnAddProfile
        '
        Me.btnAddProfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddProfile.Location = New System.Drawing.Point(870, 86)
        Me.btnAddProfile.Name = "btnAddProfile"
        Me.btnAddProfile.Size = New System.Drawing.Size(108, 24)
        Me.btnAddProfile.TabIndex = 16
        Me.btnAddProfile.Text = "Add Profile"
        Me.btnAddProfile.UseVisualStyleBackColor = True
        '
        'btnBackProfile
        '
        Me.btnBackProfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBackProfile.Location = New System.Drawing.Point(984, 86)
        Me.btnBackProfile.Name = "btnBackProfile"
        Me.btnBackProfile.Size = New System.Drawing.Size(103, 24)
        Me.btnBackProfile.TabIndex = 17
        Me.btnBackProfile.Text = "Back to Home"
        Me.btnBackProfile.UseVisualStyleBackColor = True
        '
        'addTask
        '
        Me.addTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.addTask.Image = Global.Kolocokro.My.Resources.Resources.plus
        Me.addTask.Location = New System.Drawing.Point(14, 46)
        Me.addTask.Name = "addTask"
        Me.addTask.Size = New System.Drawing.Size(40, 40)
        Me.addTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.addTask.TabIndex = 41
        Me.addTask.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Image = Global.Kolocokro.My.Resources.Resources.import
        Me.PictureBox2.Location = New System.Drawing.Point(67, 46)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'editTask
        '
        Me.editTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.editTask.Image = Global.Kolocokro.My.Resources.Resources.edit
        Me.editTask.Location = New System.Drawing.Point(123, 46)
        Me.editTask.Name = "editTask"
        Me.editTask.Size = New System.Drawing.Size(40, 40)
        Me.editTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.editTask.TabIndex = 43
        Me.editTask.TabStop = False
        '
        'salinTask
        '
        Me.salinTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.salinTask.Image = Global.Kolocokro.My.Resources.Resources.salin
        Me.salinTask.Location = New System.Drawing.Point(179, 46)
        Me.salinTask.Name = "salinTask"
        Me.salinTask.Size = New System.Drawing.Size(40, 40)
        Me.salinTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.salinTask.TabIndex = 44
        Me.salinTask.TabStop = False
        '
        'deleteTask
        '
        Me.deleteTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.deleteTask.Image = Global.Kolocokro.My.Resources.Resources.remove
        Me.deleteTask.Location = New System.Drawing.Point(234, 46)
        Me.deleteTask.Name = "deleteTask"
        Me.deleteTask.Size = New System.Drawing.Size(40, 40)
        Me.deleteTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.deleteTask.TabIndex = 45
        Me.deleteTask.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(69, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Import"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Add"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(231, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Remove"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(184, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Copy"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(131, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Edit"
        '
        'tbDaftarProfile
        '
        Me.tbDaftarProfile.Location = New System.Drawing.Point(13, 125)
        Me.tbDaftarProfile.Multiline = True
        Me.tbDaftarProfile.Name = "tbDaftarProfile"
        Me.tbDaftarProfile.ReadOnly = True
        Me.tbDaftarProfile.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbDaftarProfile.Size = New System.Drawing.Size(1074, 441)
        Me.tbDaftarProfile.TabIndex = 52
        '
        'tbNameProfile
        '
        Me.tbNameProfile.Location = New System.Drawing.Point(700, 89)
        Me.tbNameProfile.Name = "tbNameProfile"
        Me.tbNameProfile.Size = New System.Drawing.Size(164, 20)
        Me.tbNameProfile.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(697, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 16)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Input Nama Profile Here"
        '
        'bwAddProfile
        '
        '
        'FormProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1099, 578)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbNameProfile)
        Me.Controls.Add(Me.tbDaftarProfile)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.deleteTask)
        Me.Controls.Add(Me.salinTask)
        Me.Controls.Add(Me.editTask)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.addTask)
        Me.Controls.Add(Me.labelProfile)
        Me.Controls.Add(Me.btnAddProfile)
        Me.Controls.Add(Me.btnBackProfile)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormProfile"
        CType(Me.addTask, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.editTask, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.salinTask, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deleteTask, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents labelProfile As Label
    Private WithEvents btnAddProfile As Button
    Private WithEvents btnBackProfile As Button
    Private WithEvents addTask As PictureBox
    Private WithEvents PictureBox2 As PictureBox
    Private WithEvents editTask As PictureBox
    Private WithEvents salinTask As PictureBox
    Private WithEvents deleteTask As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbDaftarProfile As TextBox
    Friend WithEvents tbNameProfile As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bwAddProfile As System.ComponentModel.BackgroundWorker
End Class
