<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BOOKING_ADD
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
        Me.cmb_bill_id = New System.Windows.Forms.ComboBox()
        Me.cmb_hotel_id = New System.Windows.Forms.ComboBox()
        Me.cmb_room_id = New System.Windows.Forms.ComboBox()
        Me.cmb_guest_id = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dep_dtp = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.arr_dtp = New System.Windows.Forms.DateTimePicker()
        Me.g_id = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.booking_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmb_bill_id
        '
        Me.cmb_bill_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_bill_id.FormattingEnabled = True
        Me.cmb_bill_id.Location = New System.Drawing.Point(278, 344)
        Me.cmb_bill_id.Name = "cmb_bill_id"
        Me.cmb_bill_id.Size = New System.Drawing.Size(300, 33)
        Me.cmb_bill_id.TabIndex = 152
        '
        'cmb_hotel_id
        '
        Me.cmb_hotel_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_hotel_id.FormattingEnabled = True
        Me.cmb_hotel_id.Location = New System.Drawing.Point(278, 292)
        Me.cmb_hotel_id.Name = "cmb_hotel_id"
        Me.cmb_hotel_id.Size = New System.Drawing.Size(300, 33)
        Me.cmb_hotel_id.TabIndex = 151
        '
        'cmb_room_id
        '
        Me.cmb_room_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_room_id.FormattingEnabled = True
        Me.cmb_room_id.Location = New System.Drawing.Point(278, 236)
        Me.cmb_room_id.Name = "cmb_room_id"
        Me.cmb_room_id.Size = New System.Drawing.Size(300, 33)
        Me.cmb_room_id.TabIndex = 150
        '
        'cmb_guest_id
        '
        Me.cmb_guest_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_guest_id.FormattingEnabled = True
        Me.cmb_guest_id.Location = New System.Drawing.Point(278, 182)
        Me.cmb_guest_id.Name = "cmb_guest_id"
        Me.cmb_guest_id.Size = New System.Drawing.Size(300, 33)
        Me.cmb_guest_id.TabIndex = 149
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 478)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(197, 29)
        Me.Label10.TabIndex = 148
        Me.Label10.Text = "Departure Date:"
        '
        'dep_dtp
        '
        Me.dep_dtp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dep_dtp.Location = New System.Drawing.Point(237, 478)
        Me.dep_dtp.Name = "dep_dtp"
        Me.dep_dtp.Size = New System.Drawing.Size(367, 30)
        Me.dep_dtp.TabIndex = 147
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(47, 413)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 29)
        Me.Label5.TabIndex = 146
        Me.Label5.Text = "Arrival Date:"
        '
        'arr_dtp
        '
        Me.arr_dtp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arr_dtp.Location = New System.Drawing.Point(237, 411)
        Me.arr_dtp.Name = "arr_dtp"
        Me.arr_dtp.Size = New System.Drawing.Size(367, 30)
        Me.arr_dtp.TabIndex = 145
        '
        'g_id
        '
        Me.g_id.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.g_id.AutoSize = True
        Me.g_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g_id.Location = New System.Drawing.Point(95, 127)
        Me.g_id.Name = "g_id"
        Me.g_id.Size = New System.Drawing.Size(148, 29)
        Me.g_id.TabIndex = 144
        Me.g_id.Text = "Booking ID:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(143, 348)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 29)
        Me.Label6.TabIndex = 143
        Me.Label6.Text = "Bill ID:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(131, 292)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 29)
        Me.Label4.TabIndex = 142
        Me.Label4.Text = "Hotel ID:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(124, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 29)
        Me.Label3.TabIndex = 141
        Me.Label3.Text = "Room ID:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(103, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 29)
        Me.Label2.TabIndex = 140
        Me.Label2.Text = "GUEST ID:"
        '
        'booking_id
        '
        Me.booking_id.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.booking_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.booking_id.Location = New System.Drawing.Point(278, 121)
        Me.booking_id.Name = "booking_id"
        Me.booking_id.Size = New System.Drawing.Size(300, 38)
        Me.booking_id.TabIndex = 139
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Salmon
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(29, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(575, 52)
        Me.Label1.TabIndex = 138
        Me.Label1.Text = "BOOKING INFORMATION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(41, 563)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(204, 50)
        Me.btnClear.TabIndex = 154
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(376, 563)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(204, 50)
        Me.btnCreate.TabIndex = 153
        Me.btnCreate.Text = "CREATE"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'BOOKING_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 666)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.cmb_bill_id)
        Me.Controls.Add(Me.cmb_hotel_id)
        Me.Controls.Add(Me.cmb_room_id)
        Me.Controls.Add(Me.cmb_guest_id)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dep_dtp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.arr_dtp)
        Me.Controls.Add(Me.g_id)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.booking_id)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BOOKING_ADD"
        Me.Text = "BOOKING_ADD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_bill_id As ComboBox
    Friend WithEvents cmb_hotel_id As ComboBox
    Friend WithEvents cmb_room_id As ComboBox
    Friend WithEvents cmb_guest_id As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dep_dtp As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents arr_dtp As DateTimePicker
    Friend WithEvents g_id As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents booking_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCreate As Button
End Class
