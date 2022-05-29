<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BILL_UPDATE
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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.date_picker = New System.Windows.Forms.DateTimePicker()
        Me.g_id = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bill_id = New System.Windows.Forms.TextBox()
        Me.amount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_guest_id = New System.Windows.Forms.ComboBox()
        Me.cmb_room_id = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(37, 450)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(204, 50)
        Me.btnClear.TabIndex = 97
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(372, 450)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(204, 50)
        Me.btnUpdate.TabIndex = 95
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(112, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 29)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "Date:"
        '
        'date_picker
        '
        Me.date_picker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_picker.Location = New System.Drawing.Point(222, 234)
        Me.date_picker.Name = "date_picker"
        Me.date_picker.Size = New System.Drawing.Size(367, 30)
        Me.date_picker.TabIndex = 107
        '
        'g_id
        '
        Me.g_id.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.g_id.AutoSize = True
        Me.g_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_id.Location = New System.Drawing.Point(132, 122)
        Me.g_id.Name = "g_id"
        Me.g_id.Size = New System.Drawing.Size(90, 29)
        Me.g_id.TabIndex = 106
        Me.g_id.Text = "Bill ID:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(115, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 29)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Amount:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(74, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 29)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "GUEST ID:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(105, 347)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 29)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Room ID:"
        '
        'bill_id
        '
        Me.bill_id.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bill_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bill_id.Location = New System.Drawing.Point(275, 113)
        Me.bill_id.Name = "bill_id"
        Me.bill_id.Size = New System.Drawing.Size(297, 38)
        Me.bill_id.TabIndex = 102
        '
        'amount
        '
        Me.amount.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amount.Location = New System.Drawing.Point(275, 279)
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(297, 38)
        Me.amount.TabIndex = 101
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Salmon
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(30, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(572, 42)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "BILL INFORMATION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb_guest_id
        '
        Me.cmb_guest_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_guest_id.FormattingEnabled = True
        Me.cmb_guest_id.Location = New System.Drawing.Point(275, 176)
        Me.cmb_guest_id.Name = "cmb_guest_id"
        Me.cmb_guest_id.Size = New System.Drawing.Size(297, 33)
        Me.cmb_guest_id.TabIndex = 110
        '
        'cmb_room_id
        '
        Me.cmb_room_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_room_id.FormattingEnabled = True
        Me.cmb_room_id.Location = New System.Drawing.Point(279, 347)
        Me.cmb_room_id.Name = "cmb_room_id"
        Me.cmb_room_id.Size = New System.Drawing.Size(297, 33)
        Me.cmb_room_id.TabIndex = 109
        '
        'BILL_UPDATE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 538)
        Me.Controls.Add(Me.cmb_guest_id)
        Me.Controls.Add(Me.cmb_room_id)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.date_picker)
        Me.Controls.Add(Me.g_id)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bill_id)
        Me.Controls.Add(Me.amount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUpdate)
        Me.Name = "BILL_UPDATE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BILL_UPDATE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents date_picker As DateTimePicker
    Friend WithEvents g_id As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents bill_id As TextBox
    Friend WithEvents amount As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_guest_id As ComboBox
    Friend WithEvents cmb_room_id As ComboBox
End Class
