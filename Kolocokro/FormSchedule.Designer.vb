<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSchedule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSchedule))
        Me.CategorySchedule = New System.Windows.Forms.ComboBox()
        Me.rbScheduleLoop = New System.Windows.Forms.RadioButton()
        Me.rbScheduleCurrent = New System.Windows.Forms.RadioButton()
        Me.label3 = New System.Windows.Forms.Label()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaskName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentLoop = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResetLoop = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Worker = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.label4 = New System.Windows.Forms.Label()
        Me.btnScheduleStartLoop = New System.Windows.Forms.Button()
        Me.numericScheduleLoop = New System.Windows.Forms.NumericUpDown()
        Me.label2 = New System.Windows.Forms.Label()
        Me.btnScheduleReschedule = New System.Windows.Forms.Button()
        Me.lbScheduleLoop = New System.Windows.Forms.ListBox()
        Me.btnScheduleBack = New System.Windows.Forms.Button()
        Me.ErrorOutput = New System.Windows.Forms.Label()
        Me.lbScheduleLoopError = New System.Windows.Forms.ListBox()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.label5 = New System.Windows.Forms.Label()
        Me.btnScheduleDelete = New System.Windows.Forms.Button()
        Me.btnScheduleEdit = New System.Windows.Forms.Button()
        Me.btnScheduleAdd = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericScheduleLoop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CategorySchedule
        '
        Me.CategorySchedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategorySchedule.FormattingEnabled = True
        Me.CategorySchedule.Items.AddRange(New Object() {"Test1", "Test2", "Test3", "Test4", "Test5", "Test6", "Test7", "Test8", "Test9", "Test10", "Test11"})
        Me.CategorySchedule.Location = New System.Drawing.Point(498, 88)
        Me.CategorySchedule.Name = "CategorySchedule"
        Me.CategorySchedule.Size = New System.Drawing.Size(147, 21)
        Me.CategorySchedule.TabIndex = 27
        '
        'rbScheduleLoop
        '
        Me.rbScheduleLoop.AutoSize = True
        Me.rbScheduleLoop.Location = New System.Drawing.Point(193, 31)
        Me.rbScheduleLoop.Name = "rbScheduleLoop"
        Me.rbScheduleLoop.Size = New System.Drawing.Size(14, 13)
        Me.rbScheduleLoop.TabIndex = 2
        Me.rbScheduleLoop.TabStop = True
        Me.rbScheduleLoop.UseVisualStyleBackColor = True
        '
        'rbScheduleCurrent
        '
        Me.rbScheduleCurrent.AutoSize = True
        Me.rbScheduleCurrent.Location = New System.Drawing.Point(10, 31)
        Me.rbScheduleCurrent.Name = "rbScheduleCurrent"
        Me.rbScheduleCurrent.Size = New System.Drawing.Size(86, 17)
        Me.rbScheduleCurrent.TabIndex = 1
        Me.rbScheduleCurrent.TabStop = True
        Me.rbScheduleCurrent.Text = "Current Loop"
        Me.rbScheduleCurrent.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(3, 6)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(56, 13)
        Me.label3.TabIndex = 0
        Me.label3.Text = "Start Loop"
        '
        'dataGridView1
        '
        Me.dataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Time, Me.TaskName, Me.CurrentLoop, Me.ResetLoop, Me.Worker})
        Me.dataGridView1.Location = New System.Drawing.Point(0, 128)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.RowHeadersVisible = False
        Me.dataGridView1.RowTemplate.Height = 25
        Me.dataGridView1.Size = New System.Drawing.Size(697, 451)
        Me.dataGridView1.TabIndex = 29
        '
        'Time
        '
        Me.Time.HeaderText = "Time"
        Me.Time.Name = "Time"
        Me.Time.Width = 150
        '
        'TaskName
        '
        Me.TaskName.HeaderText = "Task Name"
        Me.TaskName.Name = "TaskName"
        Me.TaskName.Width = 150
        '
        'CurrentLoop
        '
        Me.CurrentLoop.HeaderText = "Current Loop"
        Me.CurrentLoop.Name = "CurrentLoop"
        Me.CurrentLoop.Width = 120
        '
        'ResetLoop
        '
        Me.ResetLoop.HeaderText = "Reset Loop"
        Me.ResetLoop.Name = "ResetLoop"
        Me.ResetLoop.Width = 120
        '
        'Worker
        '
        Me.Worker.HeaderText = "Worker"
        Me.Worker.Name = "Worker"
        Me.Worker.Width = 120
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(10, 107)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(63, 13)
        Me.label4.TabIndex = 5
        Me.label4.Text = "Action Logs"
        '
        'btnScheduleStartLoop
        '
        Me.btnScheduleStartLoop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnScheduleStartLoop.Location = New System.Drawing.Point(10, 67)
        Me.btnScheduleStartLoop.Name = "btnScheduleStartLoop"
        Me.btnScheduleStartLoop.Size = New System.Drawing.Size(303, 29)
        Me.btnScheduleStartLoop.TabIndex = 4
        Me.btnScheduleStartLoop.Text = "Start"
        Me.btnScheduleStartLoop.UseVisualStyleBackColor = True
        '
        'numericScheduleLoop
        '
        Me.numericScheduleLoop.Location = New System.Drawing.Point(210, 27)
        Me.numericScheduleLoop.Name = "numericScheduleLoop"
        Me.numericScheduleLoop.Size = New System.Drawing.Size(103, 20)
        Me.numericScheduleLoop.TabIndex = 3
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Rockwell", 9.75!)
        Me.label2.Location = New System.Drawing.Point(437, 91)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(62, 16)
        Me.label2.TabIndex = 28
        Me.label2.Text = "Category"
        '
        'btnScheduleReschedule
        '
        Me.btnScheduleReschedule.FlatAppearance.BorderSize = 0
        Me.btnScheduleReschedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScheduleReschedule.Image = Global.Kolocokro.My.Resources.Resources.scedule
        Me.btnScheduleReschedule.Location = New System.Drawing.Point(150, 84)
        Me.btnScheduleReschedule.Name = "btnScheduleReschedule"
        Me.btnScheduleReschedule.Size = New System.Drawing.Size(115, 38)
        Me.btnScheduleReschedule.TabIndex = 24
        Me.btnScheduleReschedule.Text = "  Reschedule"
        Me.btnScheduleReschedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnScheduleReschedule.UseVisualStyleBackColor = True
        '
        'lbScheduleLoop
        '
        Me.lbScheduleLoop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbScheduleLoop.FormattingEnabled = True
        Me.lbScheduleLoop.Location = New System.Drawing.Point(10, 123)
        Me.lbScheduleLoop.Name = "lbScheduleLoop"
        Me.lbScheduleLoop.Size = New System.Drawing.Size(303, 171)
        Me.lbScheduleLoop.TabIndex = 6
        '
        'btnScheduleBack
        '
        Me.btnScheduleBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnScheduleBack.Location = New System.Drawing.Point(954, 54)
        Me.btnScheduleBack.Name = "btnScheduleBack"
        Me.btnScheduleBack.Size = New System.Drawing.Size(103, 24)
        Me.btnScheduleBack.TabIndex = 22
        Me.btnScheduleBack.Text = "Back to Home"
        Me.btnScheduleBack.UseVisualStyleBackColor = True
        '
        'ErrorOutput
        '
        Me.ErrorOutput.AutoSize = True
        Me.ErrorOutput.Location = New System.Drawing.Point(10, 304)
        Me.ErrorOutput.Name = "ErrorOutput"
        Me.ErrorOutput.Size = New System.Drawing.Size(64, 13)
        Me.ErrorOutput.TabIndex = 7
        Me.ErrorOutput.Text = "Error Output"
        '
        'lbScheduleLoopError
        '
        Me.lbScheduleLoopError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbScheduleLoopError.FormattingEnabled = True
        Me.lbScheduleLoopError.Location = New System.Drawing.Point(10, 320)
        Me.lbScheduleLoopError.Name = "lbScheduleLoopError"
        Me.lbScheduleLoopError.Size = New System.Drawing.Size(303, 145)
        Me.lbScheduleLoopError.TabIndex = 6
        '
        'panel1
        '
        Me.panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.ErrorOutput)
        Me.panel1.Controls.Add(Me.lbScheduleLoopError)
        Me.panel1.Controls.Add(Me.lbScheduleLoop)
        Me.panel1.Controls.Add(Me.label5)
        Me.panel1.Controls.Add(Me.label4)
        Me.panel1.Controls.Add(Me.btnScheduleStartLoop)
        Me.panel1.Controls.Add(Me.numericScheduleLoop)
        Me.panel1.Controls.Add(Me.rbScheduleLoop)
        Me.panel1.Controls.Add(Me.rbScheduleCurrent)
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Location = New System.Drawing.Point(726, 84)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(331, 479)
        Me.panel1.TabIndex = 20
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(269, 107)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(47, 13)
        Me.label5.TabIndex = 5
        Me.label5.Text = "Stopped"
        '
        'btnScheduleDelete
        '
        Me.btnScheduleDelete.FlatAppearance.BorderSize = 0
        Me.btnScheduleDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScheduleDelete.Location = New System.Drawing.Point(271, 84)
        Me.btnScheduleDelete.Name = "btnScheduleDelete"
        Me.btnScheduleDelete.Size = New System.Drawing.Size(85, 38)
        Me.btnScheduleDelete.TabIndex = 23
        Me.btnScheduleDelete.Text = "  Delete"
        Me.btnScheduleDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnScheduleDelete.UseVisualStyleBackColor = True
        '
        'btnScheduleEdit
        '
        Me.btnScheduleEdit.FlatAppearance.BorderSize = 0
        Me.btnScheduleEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScheduleEdit.Location = New System.Drawing.Point(77, 84)
        Me.btnScheduleEdit.Name = "btnScheduleEdit"
        Me.btnScheduleEdit.Size = New System.Drawing.Size(67, 38)
        Me.btnScheduleEdit.TabIndex = 25
        Me.btnScheduleEdit.Text = "  Edit"
        Me.btnScheduleEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnScheduleEdit.UseVisualStyleBackColor = True
        '
        'btnScheduleAdd
        '
        Me.btnScheduleAdd.FlatAppearance.BorderSize = 0
        Me.btnScheduleAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScheduleAdd.Location = New System.Drawing.Point(4, 84)
        Me.btnScheduleAdd.Name = "btnScheduleAdd"
        Me.btnScheduleAdd.Size = New System.Drawing.Size(67, 38)
        Me.btnScheduleAdd.TabIndex = 26
        Me.btnScheduleAdd.Text = "  Add"
        Me.btnScheduleAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnScheduleAdd.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Impact", 18.0!)
        Me.label1.Location = New System.Drawing.Point(0, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(153, 29)
        Me.label1.TabIndex = 21
        Me.label1.Text = "Schedule Task"
        '
        'FormSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1099, 578)
        Me.Controls.Add(Me.CategorySchedule)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.btnScheduleReschedule)
        Me.Controls.Add(Me.btnScheduleBack)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.btnScheduleDelete)
        Me.Controls.Add(Me.btnScheduleEdit)
        Me.Controls.Add(Me.btnScheduleAdd)
        Me.Controls.Add(Me.label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSchedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSchedule"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericScheduleLoop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents CategorySchedule As ComboBox
    Private WithEvents rbScheduleLoop As RadioButton
    Private WithEvents rbScheduleCurrent As RadioButton
    Private WithEvents label3 As Label
    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents Time As DataGridViewTextBoxColumn
    Private WithEvents TaskName As DataGridViewTextBoxColumn
    Private WithEvents CurrentLoop As DataGridViewTextBoxColumn
    Private WithEvents ResetLoop As DataGridViewTextBoxColumn
    Private WithEvents Worker As DataGridViewTextBoxColumn
    Private WithEvents label4 As Label
    Private WithEvents btnScheduleStartLoop As Button
    Private WithEvents numericScheduleLoop As NumericUpDown
    Private WithEvents label2 As Label
    Private WithEvents btnScheduleReschedule As Button
    Private WithEvents lbScheduleLoop As ListBox
    Private WithEvents btnScheduleBack As Button
    Private WithEvents ErrorOutput As Label
    Private WithEvents lbScheduleLoopError As ListBox
    Private WithEvents panel1 As Panel
    Private WithEvents label5 As Label
    Private WithEvents btnScheduleDelete As Button
    Private WithEvents btnScheduleEdit As Button
    Private WithEvents btnScheduleAdd As Button
    Private WithEvents label1 As Label
End Class
