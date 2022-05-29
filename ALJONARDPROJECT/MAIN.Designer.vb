<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MAIN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MAIN))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconRoom = New FontAwesome.Sharp.IconButton()
        Me.iconBill = New FontAwesome.Sharp.IconButton()
        Me.iconHotel = New FontAwesome.Sharp.IconButton()
        Me.iconBook = New FontAwesome.Sharp.IconButton()
        Me.iconGuest = New FontAwesome.Sharp.IconButton()
        Me.iconEmp = New FontAwesome.Sharp.IconButton()
        Me.iconHome = New FontAwesome.Sharp.IconButton()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MAINPANEL = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MAINPANEL.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Panel1.Controls.Add(Me.IconRoom)
        Me.Panel1.Controls.Add(Me.iconBill)
        Me.Panel1.Controls.Add(Me.iconHotel)
        Me.Panel1.Controls.Add(Me.iconBook)
        Me.Panel1.Controls.Add(Me.iconGuest)
        Me.Panel1.Controls.Add(Me.iconEmp)
        Me.Panel1.Controls.Add(Me.iconHome)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(198, 770)
        Me.Panel1.TabIndex = 0
        '
        'IconRoom
        '
        Me.IconRoom.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.IconRoom.FlatAppearance.BorderSize = 0
        Me.IconRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconRoom.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconRoom.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.IconRoom.IconChar = FontAwesome.Sharp.IconChar.Bed
        Me.IconRoom.IconColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IconRoom.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconRoom.Location = New System.Drawing.Point(12, 495)
        Me.IconRoom.Name = "IconRoom"
        Me.IconRoom.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.IconRoom.Size = New System.Drawing.Size(183, 73)
        Me.IconRoom.TabIndex = 7
        Me.IconRoom.Text = "ROOM "
        Me.IconRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconRoom.UseVisualStyleBackColor = True
        '
        'iconBill
        '
        Me.iconBill.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.iconBill.FlatAppearance.BorderSize = 0
        Me.iconBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iconBill.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iconBill.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.iconBill.IconChar = FontAwesome.Sharp.IconChar.Receipt
        Me.iconBill.IconColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.iconBill.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconBill.Location = New System.Drawing.Point(12, 574)
        Me.iconBill.Name = "iconBill"
        Me.iconBill.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.iconBill.Size = New System.Drawing.Size(183, 73)
        Me.iconBill.TabIndex = 6
        Me.iconBill.Text = "BILL"
        Me.iconBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.iconBill.UseVisualStyleBackColor = True
        '
        'iconHotel
        '
        Me.iconHotel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.iconHotel.FlatAppearance.BorderSize = 0
        Me.iconHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iconHotel.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iconHotel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.iconHotel.IconChar = FontAwesome.Sharp.IconChar.Hotel
        Me.iconHotel.IconColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.iconHotel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconHotel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconHotel.Location = New System.Drawing.Point(12, 416)
        Me.iconHotel.Name = "iconHotel"
        Me.iconHotel.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.iconHotel.Size = New System.Drawing.Size(183, 73)
        Me.iconHotel.TabIndex = 5
        Me.iconHotel.Text = "HOTEL INFO"
        Me.iconHotel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconHotel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.iconHotel.UseVisualStyleBackColor = True
        '
        'iconBook
        '
        Me.iconBook.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.iconBook.FlatAppearance.BorderSize = 0
        Me.iconBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iconBook.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iconBook.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.iconBook.IconChar = FontAwesome.Sharp.IconChar.AddressBook
        Me.iconBook.IconColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.iconBook.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconBook.Location = New System.Drawing.Point(12, 337)
        Me.iconBook.Name = "iconBook"
        Me.iconBook.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.iconBook.Size = New System.Drawing.Size(183, 73)
        Me.iconBook.TabIndex = 4
        Me.iconBook.Text = "BOOKING"
        Me.iconBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.iconBook.UseVisualStyleBackColor = True
        '
        'iconGuest
        '
        Me.iconGuest.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.iconGuest.FlatAppearance.BorderSize = 0
        Me.iconGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iconGuest.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iconGuest.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.iconGuest.IconChar = FontAwesome.Sharp.IconChar.User
        Me.iconGuest.IconColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.iconGuest.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconGuest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconGuest.Location = New System.Drawing.Point(12, 179)
        Me.iconGuest.Name = "iconGuest"
        Me.iconGuest.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.iconGuest.Size = New System.Drawing.Size(183, 73)
        Me.iconGuest.TabIndex = 3
        Me.iconGuest.Text = "GUEST"
        Me.iconGuest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconGuest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.iconGuest.UseVisualStyleBackColor = True
        '
        'iconEmp
        '
        Me.iconEmp.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.iconEmp.FlatAppearance.BorderSize = 0
        Me.iconEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iconEmp.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iconEmp.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.iconEmp.IconChar = FontAwesome.Sharp.IconChar.UserCog
        Me.iconEmp.IconColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.iconEmp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconEmp.IconSize = 45
        Me.iconEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconEmp.Location = New System.Drawing.Point(3, 258)
        Me.iconEmp.Name = "iconEmp"
        Me.iconEmp.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.iconEmp.Size = New System.Drawing.Size(192, 73)
        Me.iconEmp.TabIndex = 2
        Me.iconEmp.Text = "EMPLOYEE"
        Me.iconEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.iconEmp.UseVisualStyleBackColor = True
        '
        'iconHome
        '
        Me.iconHome.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.iconHome.FlatAppearance.BorderSize = 0
        Me.iconHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iconHome.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iconHome.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.iconHome.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.iconHome.IconColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.iconHome.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconHome.Location = New System.Drawing.Point(12, 100)
        Me.iconHome.Name = "iconHome"
        Me.iconHome.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.iconHome.Size = New System.Drawing.Size(183, 73)
        Me.iconHome.TabIndex = 1
        Me.iconHome.Text = "HOME"
        Me.iconHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.iconHome.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.PictureBox1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(198, 100)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(192, 91)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MAINPANEL
        '
        Me.MAINPANEL.BackColor = System.Drawing.Color.PowderBlue
        Me.MAINPANEL.Controls.Add(Me.PictureBox2)
        Me.MAINPANEL.Location = New System.Drawing.Point(201, 0)
        Me.MAINPANEL.Name = "MAINPANEL"
        Me.MAINPANEL.Size = New System.Drawing.Size(1134, 770)
        Me.MAINPANEL.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(207, 152)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(708, 464)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'MAIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1340, 770)
        Me.Controls.Add(Me.MAINPANEL)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "MAIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HOTEL DE LUNA SYSTEM"
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MAINPANEL.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents iconHome As FontAwesome.Sharp.IconButton
    Friend WithEvents iconHotel As FontAwesome.Sharp.IconButton
    Friend WithEvents iconBook As FontAwesome.Sharp.IconButton
    Friend WithEvents iconGuest As FontAwesome.Sharp.IconButton
    Friend WithEvents iconEmp As FontAwesome.Sharp.IconButton
    Friend WithEvents iconBill As FontAwesome.Sharp.IconButton
    Friend WithEvents MAINPANEL As Panel
    Friend WithEvents IconRoom As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox2 As PictureBox
End Class
