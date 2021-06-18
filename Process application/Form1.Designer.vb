<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNRIC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbB40 = New System.Windows.Forms.RadioButton()
        Me.rbM40 = New System.Windows.Forms.RadioButton()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbSalary = New System.Windows.Forms.GroupBox()
        Me.rbSalary3 = New System.Windows.Forms.RadioButton()
        Me.rbSalary2 = New System.Windows.Forms.RadioButton()
        Me.rbSalary1 = New System.Windows.Forms.RadioButton()
        Me.RbT20 = New System.Windows.Forms.RadioButton()
        Me.cbMother = New System.Windows.Forms.CheckBox()
        Me.cbFather = New System.Windows.Forms.CheckBox()
        Me.rbPrimary = New System.Windows.Forms.RadioButton()
        Me.rbSecondary = New System.Windows.Forms.RadioButton()
        Me.rbIPT = New System.Windows.Forms.RadioButton()
        Me.rbYes = New System.Windows.Forms.RadioButton()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbNoParents = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.gbSalary.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 68)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(122, 66)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(266, 20)
        Me.txtName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 104)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NRIC"
        '
        'txtNRIC
        '
        Me.txtNRIC.Location = New System.Drawing.Point(122, 102)
        Me.txtNRIC.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNRIC.Name = "txtNRIC"
        Me.txtNRIC.Size = New System.Drawing.Size(266, 20)
        Me.txtNRIC.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 133)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Education Level"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 256)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Parent's Salary"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 177)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Category"
        '
        'rbB40
        '
        Me.rbB40.AutoSize = True
        Me.rbB40.Location = New System.Drawing.Point(0, 18)
        Me.rbB40.Margin = New System.Windows.Forms.Padding(2)
        Me.rbB40.Name = "rbB40"
        Me.rbB40.Size = New System.Drawing.Size(44, 17)
        Me.rbB40.TabIndex = 10
        Me.rbB40.TabStop = True
        Me.rbB40.Text = "B40"
        Me.rbB40.UseVisualStyleBackColor = True
        '
        'rbM40
        '
        Me.rbM40.AutoSize = True
        Me.rbM40.Location = New System.Drawing.Point(52, 18)
        Me.rbM40.Margin = New System.Windows.Forms.Padding(2)
        Me.rbM40.Name = "rbM40"
        Me.rbM40.Size = New System.Drawing.Size(46, 17)
        Me.rbM40.TabIndex = 11
        Me.rbM40.TabStop = True
        Me.rbM40.Text = "M40"
        Me.rbM40.UseVisualStyleBackColor = True
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(125, 412)
        Me.BtnSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(56, 28)
        Me.BtnSubmit.TabIndex = 12
        Me.BtnSubmit.Text = "SUBMIT"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 216)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Parent's Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Gabriola", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(92, 21)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(230, 28)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "PERMOHONAN BANTUAN TELEFON PINTAR"
        '
        'gbSalary
        '
        Me.gbSalary.Controls.Add(Me.rbSalary3)
        Me.gbSalary.Controls.Add(Me.rbSalary2)
        Me.gbSalary.Controls.Add(Me.rbSalary1)
        Me.gbSalary.Location = New System.Drawing.Point(122, 248)
        Me.gbSalary.Margin = New System.Windows.Forms.Padding(2)
        Me.gbSalary.Name = "gbSalary"
        Me.gbSalary.Padding = New System.Windows.Forms.Padding(2)
        Me.gbSalary.Size = New System.Drawing.Size(187, 101)
        Me.gbSalary.TabIndex = 20
        Me.gbSalary.TabStop = False
        '
        'rbSalary3
        '
        Me.rbSalary3.AutoSize = True
        Me.rbSalary3.Location = New System.Drawing.Point(0, 79)
        Me.rbSalary3.Margin = New System.Windows.Forms.Padding(2)
        Me.rbSalary3.Name = "rbSalary3"
        Me.rbSalary3.Size = New System.Drawing.Size(107, 17)
        Me.rbSalary3.TabIndex = 2
        Me.rbSalary3.TabStop = True
        Me.rbSalary3.Text = "Below RM 20000"
        Me.rbSalary3.UseVisualStyleBackColor = True
        '
        'rbSalary2
        '
        Me.rbSalary2.AutoSize = True
        Me.rbSalary2.Location = New System.Drawing.Point(0, 43)
        Me.rbSalary2.Margin = New System.Windows.Forms.Padding(2)
        Me.rbSalary2.Name = "rbSalary2"
        Me.rbSalary2.Size = New System.Drawing.Size(101, 17)
        Me.rbSalary2.TabIndex = 1
        Me.rbSalary2.TabStop = True
        Me.rbSalary2.Text = "Below RM 8000"
        Me.rbSalary2.UseVisualStyleBackColor = True
        '
        'rbSalary1
        '
        Me.rbSalary1.AutoSize = True
        Me.rbSalary1.Location = New System.Drawing.Point(0, 6)
        Me.rbSalary1.Margin = New System.Windows.Forms.Padding(2)
        Me.rbSalary1.Name = "rbSalary1"
        Me.rbSalary1.Size = New System.Drawing.Size(101, 17)
        Me.rbSalary1.TabIndex = 0
        Me.rbSalary1.TabStop = True
        Me.rbSalary1.Text = "Below RM 2500"
        Me.rbSalary1.UseVisualStyleBackColor = True
        '
        'RbT20
        '
        Me.RbT20.AutoSize = True
        Me.RbT20.Location = New System.Drawing.Point(103, 18)
        Me.RbT20.Name = "RbT20"
        Me.RbT20.Size = New System.Drawing.Size(44, 17)
        Me.RbT20.TabIndex = 23
        Me.RbT20.TabStop = True
        Me.RbT20.Text = "T20"
        Me.RbT20.UseVisualStyleBackColor = True
        '
        'cbMother
        '
        Me.cbMother.AutoSize = True
        Me.cbMother.Location = New System.Drawing.Point(122, 216)
        Me.cbMother.Name = "cbMother"
        Me.cbMother.Size = New System.Drawing.Size(59, 17)
        Me.cbMother.TabIndex = 24
        Me.cbMother.Text = "Mother"
        Me.cbMother.UseVisualStyleBackColor = True
        '
        'cbFather
        '
        Me.cbFather.AutoSize = True
        Me.cbFather.Location = New System.Drawing.Point(197, 216)
        Me.cbFather.Name = "cbFather"
        Me.cbFather.Size = New System.Drawing.Size(56, 17)
        Me.cbFather.TabIndex = 25
        Me.cbFather.Text = "Father"
        Me.cbFather.UseVisualStyleBackColor = True
        '
        'rbPrimary
        '
        Me.rbPrimary.AutoSize = True
        Me.rbPrimary.Location = New System.Drawing.Point(123, 133)
        Me.rbPrimary.Name = "rbPrimary"
        Me.rbPrimary.Size = New System.Drawing.Size(95, 17)
        Me.rbPrimary.TabIndex = 26
        Me.rbPrimary.TabStop = True
        Me.rbPrimary.Text = "Primary School"
        Me.rbPrimary.UseVisualStyleBackColor = True
        '
        'rbSecondary
        '
        Me.rbSecondary.AutoSize = True
        Me.rbSecondary.Location = New System.Drawing.Point(220, 133)
        Me.rbSecondary.Name = "rbSecondary"
        Me.rbSecondary.Size = New System.Drawing.Size(112, 17)
        Me.rbSecondary.TabIndex = 27
        Me.rbSecondary.TabStop = True
        Me.rbSecondary.Text = "Secondary School"
        Me.rbSecondary.UseVisualStyleBackColor = True
        '
        'rbIPT
        '
        Me.rbIPT.AutoSize = True
        Me.rbIPT.Location = New System.Drawing.Point(338, 133)
        Me.rbIPT.Name = "rbIPT"
        Me.rbIPT.Size = New System.Drawing.Size(42, 17)
        Me.rbIPT.TabIndex = 28
        Me.rbIPT.TabStop = True
        Me.rbIPT.Text = "IPT"
        Me.rbIPT.UseVisualStyleBackColor = True
        '
        'rbYes
        '
        Me.rbYes.AutoSize = True
        Me.rbYes.Location = New System.Drawing.Point(15, 19)
        Me.rbYes.Name = "rbYes"
        Me.rbYes.Size = New System.Drawing.Size(43, 17)
        Me.rbYes.TabIndex = 29
        Me.rbYes.TabStop = True
        Me.rbYes.Text = "Yes"
        Me.rbYes.UseVisualStyleBackColor = True
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.Location = New System.Drawing.Point(71, 19)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(39, 17)
        Me.rbNo.TabIndex = 30
        Me.rbNo.TabStop = True
        Me.rbNo.Text = "No"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 369)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 26)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Received the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bantuan before?"
        '
        'cbNoParents
        '
        Me.cbNoParents.AutoSize = True
        Me.cbNoParents.Location = New System.Drawing.Point(268, 216)
        Me.cbNoParents.Name = "cbNoParents"
        Me.cbNoParents.Size = New System.Drawing.Size(79, 17)
        Me.cbNoParents.TabIndex = 32
        Me.cbNoParents.Text = "No Parents"
        Me.cbNoParents.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbB40)
        Me.GroupBox1.Controls.Add(Me.rbM40)
        Me.GroupBox1.Controls.Add(Me.RbT20)
        Me.GroupBox1.Location = New System.Drawing.Point(122, 156)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 47)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbNo)
        Me.GroupBox2.Controls.Add(Me.rbYes)
        Me.GroupBox2.Location = New System.Drawing.Point(122, 354)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(131, 52)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(193, 412)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(60, 27)
        Me.BtnExit.TabIndex = 35
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(399, 458)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbNoParents)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.rbIPT)
        Me.Controls.Add(Me.rbSecondary)
        Me.Controls.Add(Me.rbPrimary)
        Me.Controls.Add(Me.cbFather)
        Me.Controls.Add(Me.cbMother)
        Me.Controls.Add(Me.gbSalary)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNRIC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "BORANG PERMOHONAN"
        Me.gbSalary.ResumeLayout(False)
        Me.gbSalary.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNRIC As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rbB40 As RadioButton
    Friend WithEvents rbM40 As RadioButton
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents gbSalary As GroupBox
    Friend WithEvents rbSalary3 As RadioButton
    Friend WithEvents rbSalary2 As RadioButton
    Friend WithEvents rbSalary1 As RadioButton
    Friend WithEvents RbT20 As RadioButton
    Friend WithEvents cbMother As CheckBox
    Friend WithEvents cbFather As CheckBox
    Friend WithEvents rbPrimary As RadioButton
    Friend WithEvents rbSecondary As RadioButton
    Friend WithEvents rbIPT As RadioButton
    Friend WithEvents rbYes As RadioButton
    Friend WithEvents rbNo As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents cbNoParents As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnExit As Button
End Class
