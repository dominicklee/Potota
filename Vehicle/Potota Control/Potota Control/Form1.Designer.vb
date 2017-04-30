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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.grpReceiver = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbSpeedLF = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbECU = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbSonar = New System.Windows.Forms.ComboBox
        Me.lblRefreshCOM = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbLidar = New System.Windows.Forms.ComboBox
        Me.btnConnect = New System.Windows.Forms.Button
        Me.spLidar = New System.IO.Ports.SerialPort(Me.components)
        Me.spSonar = New System.IO.Ports.SerialPort(Me.components)
        Me.spECU = New System.IO.Ports.SerialPort(Me.components)
        Me.spSpeedLF = New System.IO.Ports.SerialPort(Me.components)
        Me.btnMinimize = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.valSpeed = New System.Windows.Forms.Label
        Me.valECUmode = New System.Windows.Forms.Label
        Me.valSonarRight = New System.Windows.Forms.Label
        Me.valSonarLeft = New System.Windows.Forms.Label
        Me.valSonarRear = New System.Windows.Forms.Label
        Me.valSonarFront = New System.Windows.Forms.Label
        Me.valLidar = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.updateLabels = New System.Windows.Forms.Timer(Me.components)
        Me.lblDataLogging = New System.Windows.Forms.Label
        Me.streamTimer = New System.Windows.Forms.Timer(Me.components)
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.grpReceiver.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpReceiver
        '
        Me.grpReceiver.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpReceiver.Controls.Add(Me.Label4)
        Me.grpReceiver.Controls.Add(Me.cbSpeedLF)
        Me.grpReceiver.Controls.Add(Me.Label2)
        Me.grpReceiver.Controls.Add(Me.cbECU)
        Me.grpReceiver.Controls.Add(Me.Label1)
        Me.grpReceiver.Controls.Add(Me.cbSonar)
        Me.grpReceiver.Controls.Add(Me.lblRefreshCOM)
        Me.grpReceiver.Controls.Add(Me.Label3)
        Me.grpReceiver.Controls.Add(Me.cbLidar)
        Me.grpReceiver.Controls.Add(Me.btnConnect)
        Me.grpReceiver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpReceiver.ForeColor = System.Drawing.Color.White
        Me.grpReceiver.Location = New System.Drawing.Point(151, 76)
        Me.grpReceiver.Name = "grpReceiver"
        Me.grpReceiver.Size = New System.Drawing.Size(362, 287)
        Me.grpReceiver.TabIndex = 7
        Me.grpReceiver.TabStop = False
        Me.grpReceiver.Text = "Connection Blocks"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Speed/LF COM:"
        '
        'cbSpeedLF
        '
        Me.cbSpeedLF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSpeedLF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSpeedLF.FormattingEnabled = True
        Me.cbSpeedLF.Location = New System.Drawing.Point(142, 127)
        Me.cbSpeedLF.Name = "cbSpeedLF"
        Me.cbSpeedLF.Size = New System.Drawing.Size(204, 24)
        Me.cbSpeedLF.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "ECU/RF COM:"
        '
        'cbECU
        '
        Me.cbECU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbECU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbECU.FormattingEnabled = True
        Me.cbECU.Location = New System.Drawing.Point(142, 97)
        Me.cbECU.Name = "cbECU"
        Me.cbECU.Size = New System.Drawing.Size(204, 24)
        Me.cbECU.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Sonars COM:"
        '
        'cbSonar
        '
        Me.cbSonar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSonar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSonar.FormattingEnabled = True
        Me.cbSonar.Location = New System.Drawing.Point(142, 67)
        Me.cbSonar.Name = "cbSonar"
        Me.cbSonar.Size = New System.Drawing.Size(204, 24)
        Me.cbSonar.TabIndex = 20
        '
        'lblRefreshCOM
        '
        Me.lblRefreshCOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblRefreshCOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefreshCOM.ForeColor = System.Drawing.Color.White
        Me.lblRefreshCOM.Location = New System.Drawing.Point(110, 178)
        Me.lblRefreshCOM.Name = "lblRefreshCOM"
        Me.lblRefreshCOM.Size = New System.Drawing.Size(110, 30)
        Me.lblRefreshCOM.TabIndex = 19
        Me.lblRefreshCOM.Text = "Refresh COM"
        Me.lblRefreshCOM.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Lidar Sweep COM:"
        '
        'cbLidar
        '
        Me.cbLidar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLidar.FormattingEnabled = True
        Me.cbLidar.Location = New System.Drawing.Point(142, 37)
        Me.cbLidar.Name = "cbLidar"
        Me.cbLidar.Size = New System.Drawing.Size(204, 24)
        Me.cbLidar.TabIndex = 17
        '
        'btnConnect
        '
        Me.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.ForeColor = System.Drawing.Color.White
        Me.btnConnect.Location = New System.Drawing.Point(226, 178)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(120, 30)
        Me.btnConnect.TabIndex = 5
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'spLidar
        '
        '
        'spSonar
        '
        '
        'spECU
        '
        '
        'spSpeedLF
        '
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.ForeColor = System.Drawing.Color.White
        Me.btnMinimize.Location = New System.Drawing.Point(957, 12)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(25, 25)
        Me.btnMinimize.TabIndex = 8
        Me.btnMinimize.Text = "__"
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = Global.Potota_Control.My.Resources.Resources.potota
        Me.PictureBox1.Location = New System.Drawing.Point(374, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(242, 81)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.valSpeed)
        Me.GroupBox1.Controls.Add(Me.valECUmode)
        Me.GroupBox1.Controls.Add(Me.valSonarRight)
        Me.GroupBox1.Controls.Add(Me.valSonarLeft)
        Me.GroupBox1.Controls.Add(Me.valSonarRear)
        Me.GroupBox1.Controls.Add(Me.valSonarFront)
        Me.GroupBox1.Controls.Add(Me.valLidar)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(528, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 287)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Incoming Data"
        '
        'valSpeed
        '
        Me.valSpeed.AutoSize = True
        Me.valSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valSpeed.Location = New System.Drawing.Point(116, 211)
        Me.valSpeed.Name = "valSpeed"
        Me.valSpeed.Size = New System.Drawing.Size(15, 16)
        Me.valSpeed.TabIndex = 36
        Me.valSpeed.Text = "0"
        '
        'valECUmode
        '
        Me.valECUmode.AutoSize = True
        Me.valECUmode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valECUmode.Location = New System.Drawing.Point(116, 184)
        Me.valECUmode.Name = "valECUmode"
        Me.valECUmode.Size = New System.Drawing.Size(15, 16)
        Me.valECUmode.TabIndex = 35
        Me.valECUmode.Text = "0"
        '
        'valSonarRight
        '
        Me.valSonarRight.AutoSize = True
        Me.valSonarRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valSonarRight.Location = New System.Drawing.Point(116, 155)
        Me.valSonarRight.Name = "valSonarRight"
        Me.valSonarRight.Size = New System.Drawing.Size(15, 16)
        Me.valSonarRight.TabIndex = 34
        Me.valSonarRight.Text = "0"
        '
        'valSonarLeft
        '
        Me.valSonarLeft.AutoSize = True
        Me.valSonarLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valSonarLeft.Location = New System.Drawing.Point(116, 129)
        Me.valSonarLeft.Name = "valSonarLeft"
        Me.valSonarLeft.Size = New System.Drawing.Size(15, 16)
        Me.valSonarLeft.TabIndex = 33
        Me.valSonarLeft.Text = "0"
        '
        'valSonarRear
        '
        Me.valSonarRear.AutoSize = True
        Me.valSonarRear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valSonarRear.Location = New System.Drawing.Point(116, 99)
        Me.valSonarRear.Name = "valSonarRear"
        Me.valSonarRear.Size = New System.Drawing.Size(15, 16)
        Me.valSonarRear.TabIndex = 32
        Me.valSonarRear.Text = "0"
        '
        'valSonarFront
        '
        Me.valSonarFront.AutoSize = True
        Me.valSonarFront.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valSonarFront.Location = New System.Drawing.Point(116, 70)
        Me.valSonarFront.Name = "valSonarFront"
        Me.valSonarFront.Size = New System.Drawing.Size(15, 16)
        Me.valSonarFront.TabIndex = 31
        Me.valSonarFront.Text = "0"
        '
        'valLidar
        '
        Me.valLidar.AutoSize = True
        Me.valLidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valLidar.Location = New System.Drawing.Point(116, 40)
        Me.valLidar.Name = "valLidar"
        Me.valLidar.Size = New System.Drawing.Size(15, 16)
        Me.valLidar.TabIndex = 30
        Me.valLidar.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(44, 211)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 16)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Speed:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(19, 184)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 16)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "ECU Mode:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 155)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 16)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Sonar Right:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Sonar Left:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Sonar Rear:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Sonar Front:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Lidar Value:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.lblDataLogging)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(151, 372)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(362, 172)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Logging"
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(100, 115)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(173, 30)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "Open Log"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(17, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 16)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Save to:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(80, 49)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(266, 26)
        Me.TextBox1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(528, 372)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(315, 172)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data Streaming"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(65, 115)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(184, 16)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "View Realtime on Mobile App"
        Me.Label13.Visible = False
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(163, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 30)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Stop"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(37, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 30)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'updateLabels
        '
        '
        'lblDataLogging
        '
        Me.lblDataLogging.AutoSize = True
        Me.lblDataLogging.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataLogging.Location = New System.Drawing.Point(77, 94)
        Me.lblDataLogging.Name = "lblDataLogging"
        Me.lblDataLogging.Size = New System.Drawing.Size(0, 16)
        Me.lblDataLogging.TabIndex = 22
        '
        'streamTimer
        '
        Me.streamTimer.Interval = 300
        '
        'WebBrowser1
        '
        Me.WebBrowser1.AllowWebBrowserDrop = False
        Me.WebBrowser1.Location = New System.Drawing.Point(861, 395)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(121, 87)
        Me.WebBrowser1.TabIndex = 13
        Me.WebBrowser1.Visible = False
        Me.WebBrowser1.WebBrowserShortcutsEnabled = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(994, 571)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.grpReceiver)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Potota Control"
        Me.grpReceiver.ResumeLayout(False)
        Me.grpReceiver.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpReceiver As System.Windows.Forms.GroupBox
    Friend WithEvents lblRefreshCOM As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbLidar As System.Windows.Forms.ComboBox
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbSonar As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbSpeedLF As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbECU As System.Windows.Forms.ComboBox
    Friend WithEvents spLidar As System.IO.Ports.SerialPort
    Friend WithEvents spSonar As System.IO.Ports.SerialPort
    Friend WithEvents spECU As System.IO.Ports.SerialPort
    Friend WithEvents spSpeedLF As System.IO.Ports.SerialPort
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents valSpeed As System.Windows.Forms.Label
    Friend WithEvents valECUmode As System.Windows.Forms.Label
    Friend WithEvents valSonarRight As System.Windows.Forms.Label
    Friend WithEvents valSonarLeft As System.Windows.Forms.Label
    Friend WithEvents valSonarRear As System.Windows.Forms.Label
    Friend WithEvents valSonarFront As System.Windows.Forms.Label
    Friend WithEvents valLidar As System.Windows.Forms.Label
    Friend WithEvents updateLabels As System.Windows.Forms.Timer
    Friend WithEvents lblDataLogging As System.Windows.Forms.Label
    Friend WithEvents streamTimer As System.Windows.Forms.Timer
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser

End Class
