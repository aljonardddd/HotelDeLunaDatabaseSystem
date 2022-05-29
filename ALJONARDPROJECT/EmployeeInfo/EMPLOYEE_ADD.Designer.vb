<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EMPLOYEE_ADD
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
        Me.g_id = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.emp_id = New System.Windows.Forms.TextBox()
        Me.emailAdd = New System.Windows.Forms.TextBox()
        Me.contactNum = New System.Windows.Forms.TextBox()
        Me.radfemale = New System.Windows.Forms.RadioButton()
        Me.radmale = New System.Windows.Forms.RadioButton()
        Me.age = New System.Windows.Forms.TextBox()
        Me.lastName = New System.Windows.Forms.TextBox()
        Me.firstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.salary = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.cmb_hotel_id = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'g_id
        '
        Me.g_id.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.g_id.AutoSize = True
        Me.g_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_id.Location = New System.Drawing.Point(64, 108)
        Me.g_id.Name = "g_id"
        Me.g_id.Size = New System.Drawing.Size(169, 29)
        Me.g_id.TabIndex = 85
        Me.g_id.Text = "Employee ID:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(43, 509)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(189, 29)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Email Address:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 458)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(201, 29)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "ContactNumber:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(124, 402)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 29)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Gender:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(161, 348)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 29)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Age:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(85, 290)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 29)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Last Name:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 29)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "First Name:"
        '
        'emp_id
        '
        Me.emp_id.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.emp_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_id.Location = New System.Drawing.Point(282, 102)
        Me.emp_id.Name = "emp_id"
        Me.emp_id.Size = New System.Drawing.Size(297, 38)
        Me.emp_id.TabIndex = 77
        '
        'emailAdd
        '
        Me.emailAdd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.emailAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailAdd.Location = New System.Drawing.Point(282, 500)
        Me.emailAdd.Name = "emailAdd"
        Me.emailAdd.Size = New System.Drawing.Size(297, 38)
        Me.emailAdd.TabIndex = 75
        '
        'contactNum
        '
        Me.contactNum.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.contactNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactNum.Location = New System.Drawing.Point(282, 443)
        Me.contactNum.Name = "contactNum"
        Me.contactNum.Size = New System.Drawing.Size(297, 38)
        Me.contactNum.TabIndex = 74
        '
        'radfemale
        '
        Me.radfemale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radfemale.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.radfemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radfemale.Location = New System.Drawing.Point(449, 388)
        Me.radfemale.Name = "radfemale"
        Me.radfemale.Size = New System.Drawing.Size(130, 43)
        Me.radfemale.TabIndex = 73
        Me.radfemale.TabStop = True
        Me.radfemale.Text = "Female"
        Me.radfemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radfemale.UseVisualStyleBackColor = False
        '
        'radmale
        '
        Me.radmale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radmale.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radmale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radmale.Location = New System.Drawing.Point(300, 388)
        Me.radmale.Name = "radmale"
        Me.radmale.Size = New System.Drawing.Size(99, 43)
        Me.radmale.TabIndex = 72
        Me.radmale.TabStop = True
        Me.radmale.Text = "Male"
        Me.radmale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radmale.UseVisualStyleBackColor = False
        '
        'age
        '
        Me.age.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.age.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.age.Location = New System.Drawing.Point(282, 339)
        Me.age.Name = "age"
        Me.age.Size = New System.Drawing.Size(297, 38)
        Me.age.TabIndex = 71
        '
        'lastName
        '
        Me.lastName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastName.Location = New System.Drawing.Point(282, 281)
        Me.lastName.Name = "lastName"
        Me.lastName.Size = New System.Drawing.Size(297, 38)
        Me.lastName.TabIndex = 70
        '
        'firstName
        '
        Me.firstName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.firstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstName.Location = New System.Drawing.Point(282, 220)
        Me.firstName.Name = "firstName"
        Me.firstName.Size = New System.Drawing.Size(297, 38)
        Me.firstName.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Salmon
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(33, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(572, 60)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "EMPLOYEE INFORMATION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(117, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 29)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Hotel ID:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(134, 558)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 29)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "Salary:"
        '
        'salary
        '
        Me.salary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.salary.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salary.Location = New System.Drawing.Point(282, 558)
        Me.salary.Name = "salary"
        Me.salary.Size = New System.Drawing.Size(297, 38)
        Me.salary.TabIndex = 88
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(49, 627)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(204, 50)
        Me.btnClear.TabIndex = 106
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(384, 627)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(204, 50)
        Me.btnCreate.TabIndex = 105
        Me.btnCreate.Text = "CREATE"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'cmb_hotel_id
        '
        Me.cmb_hotel_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_hotel_id.FormattingEnabled = True
        Me.cmb_hotel_id.Location = New System.Drawing.Point(282, 165)
        Me.cmb_hotel_id.Name = "cmb_hotel_id"
        Me.cmb_hotel_id.Size = New System.Drawing.Size(297, 33)
        Me.cmb_hotel_id.TabIndex = 107
        '
        'EMPLOYEE_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 698)
        Me.Controls.Add(Me.cmb_hotel_id)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.salary)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.g_id)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.emp_id)
        Me.Controls.Add(Me.emailAdd)
        Me.Controls.Add(Me.contactNum)
        Me.Controls.Add(Me.radfemale)
        Me.Controls.Add(Me.radmale)
        Me.Controls.Add(Me.age)
        Me.Controls.Add(Me.lastName)
        Me.Controls.Add(Me.firstName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EMPLOYEE_ADD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EMPLOYEE_ADD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents g_id As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents emp_id As TextBox
    Friend WithEvents emailAdd As TextBox
    Friend WithEvents contactNum As TextBox
    Friend WithEvents radfemale As RadioButton
    Friend WithEvents radmale As RadioButton
    Friend WithEvents age As TextBox
    Friend WithEvents lastName As TextBox
    Friend WithEvents firstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents salary As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents cmb_hotel_id As ComboBox
End Class
