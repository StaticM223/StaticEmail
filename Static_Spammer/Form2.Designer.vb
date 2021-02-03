<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.btnExit1 = New System.Windows.Forms.Button()
        Me.lblProgressBar1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.txtNumOfEmails1 = New System.Windows.Forms.NumericUpDown()
        Me.txtGmailUsername1 = New System.Windows.Forms.TextBox()
        Me.txtGmailPassword1 = New System.Windows.Forms.TextBox()
        Me.btnSpam1 = New System.Windows.Forms.Button()
        Me.txtEmailSubject6 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtEmailToSpam6 = New System.Windows.Forms.TextBox()
        Me.txtEmailSubject3 = New System.Windows.Forms.TextBox()
        Me.txtEmailToSpam3 = New System.Windows.Forms.TextBox()
        Me.txtEmailSubject5 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtEmailBody5 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtEmailToSpam5 = New System.Windows.Forms.TextBox()
        Me.txtEmailSubject4 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtEmailBody4 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtEmailToSpam4 = New System.Windows.Forms.TextBox()
        Me.txtEmailSubject2 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSpam6 = New System.Windows.Forms.Button()
        Me.btnSpam5 = New System.Windows.Forms.Button()
        Me.btnSpam3 = New System.Windows.Forms.Button()
        Me.btnSpam2 = New System.Windows.Forms.Button()
        Me.btnSpam4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtEmailBody6 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtEmailBody3 = New System.Windows.Forms.TextBox()
        Me.txtEmailBody2 = New System.Windows.Forms.TextBox()
        Me.txtEmailToSpam2 = New System.Windows.Forms.TextBox()
        Me.txtEmailSubject1 = New System.Windows.Forms.TextBox()
        Me.txtEmailBody1 = New System.Windows.Forms.TextBox()
        Me.txtEmailToSpam1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.txtNumOfEmails1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit1
        '
        Me.btnExit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit1.ForeColor = System.Drawing.Color.Gray
        Me.btnExit1.Location = New System.Drawing.Point(527, 152)
        Me.btnExit1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit1.Name = "btnExit1"
        Me.btnExit1.Size = New System.Drawing.Size(100, 25)
        Me.btnExit1.TabIndex = 70
        Me.btnExit1.Text = "Exit Program"
        Me.btnExit1.UseVisualStyleBackColor = True
        '
        'lblProgressBar1
        '
        Me.lblProgressBar1.AutoSize = True
        Me.lblProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.lblProgressBar1.Location = New System.Drawing.Point(366, 115)
        Me.lblProgressBar1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProgressBar1.Name = "lblProgressBar1"
        Me.lblProgressBar1.Size = New System.Drawing.Size(91, 15)
        Me.lblProgressBar1.TabIndex = 69
        Me.lblProgressBar1.Text = "Status: Stopped"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(195, 132)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(432, 13)
        Me.ProgressBar1.TabIndex = 68
        '
        'txtNumOfEmails1
        '
        Me.txtNumOfEmails1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtNumOfEmails1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtNumOfEmails1.Location = New System.Drawing.Point(195, 152)
        Me.txtNumOfEmails1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumOfEmails1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtNumOfEmails1.Name = "txtNumOfEmails1"
        Me.txtNumOfEmails1.Size = New System.Drawing.Size(148, 23)
        Me.txtNumOfEmails1.TabIndex = 67
        Me.txtNumOfEmails1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtGmailUsername1
        '
        Me.txtGmailUsername1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtGmailUsername1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtGmailUsername1.Location = New System.Drawing.Point(277, 52)
        Me.txtGmailUsername1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGmailUsername1.Name = "txtGmailUsername1"
        Me.txtGmailUsername1.Size = New System.Drawing.Size(350, 23)
        Me.txtGmailUsername1.TabIndex = 64
        '
        'txtGmailPassword1
        '
        Me.txtGmailPassword1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtGmailPassword1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtGmailPassword1.Location = New System.Drawing.Point(277, 90)
        Me.txtGmailPassword1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGmailPassword1.Name = "txtGmailPassword1"
        Me.txtGmailPassword1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtGmailPassword1.Size = New System.Drawing.Size(351, 23)
        Me.txtGmailPassword1.TabIndex = 66
        '
        'btnSpam1
        '
        Me.btnSpam1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSpam1.ForeColor = System.Drawing.Color.Gray
        Me.btnSpam1.Location = New System.Drawing.Point(15, 197)
        Me.btnSpam1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSpam1.Name = "btnSpam1"
        Me.btnSpam1.Size = New System.Drawing.Size(100, 25)
        Me.btnSpam1.TabIndex = 62
        Me.btnSpam1.Text = "Spam Email"
        Me.btnSpam1.UseVisualStyleBackColor = True
        '
        'txtEmailSubject6
        '
        Me.txtEmailSubject6.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtEmailSubject6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtEmailSubject6.Location = New System.Drawing.Point(419, 518)
        Me.txtEmailSubject6.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailSubject6.Name = "txtEmailSubject6"
        Me.txtEmailSubject6.Size = New System.Drawing.Size(209, 23)
        Me.txtEmailSubject6.TabIndex = 57
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label25.Location = New System.Drawing.Point(331, 521)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(84, 15)
        Me.Label25.TabIndex = 56
        Me.Label25.Text = "Email Subject:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label26.Location = New System.Drawing.Point(331, 494)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(88, 15)
        Me.Label26.TabIndex = 54
        Me.Label26.Text = "Email to Spam:"
        '
        'txtEmailToSpam6
        '
        Me.txtEmailToSpam6.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtEmailToSpam6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtEmailToSpam6.Location = New System.Drawing.Point(419, 491)
        Me.txtEmailToSpam6.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailToSpam6.Name = "txtEmailToSpam6"
        Me.txtEmailToSpam6.Size = New System.Drawing.Size(209, 23)
        Me.txtEmailToSpam6.TabIndex = 55
        '
        'txtEmailSubject3
        '
        Me.txtEmailSubject3.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtEmailSubject3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtEmailSubject3.Location = New System.Drawing.Point(100, 518)
        Me.txtEmailSubject3.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailSubject3.Name = "txtEmailSubject3"
        Me.txtEmailSubject3.Size = New System.Drawing.Size(209, 23)
        Me.txtEmailSubject3.TabIndex = 51
        '
        'txtEmailToSpam3
        '
        Me.txtEmailToSpam3.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtEmailToSpam3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtEmailToSpam3.Location = New System.Drawing.Point(100, 491)
        Me.txtEmailToSpam3.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailToSpam3.Name = "txtEmailToSpam3"
        Me.txtEmailToSpam3.Size = New System.Drawing.Size(209, 23)
        Me.txtEmailToSpam3.TabIndex = 49
        '
        'txtEmailSubject5
        '
        Me.txtEmailSubject5.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtEmailSubject5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtEmailSubject5.Location = New System.Drawing.Point(419, 386)
        Me.txtEmailSubject5.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailSubject5.Name = "txtEmailSubject5"
        Me.txtEmailSubject5.Size = New System.Drawing.Size(209, 23)
        Me.txtEmailSubject5.TabIndex = 45
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label19.Location = New System.Drawing.Point(331, 389)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 15)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "Email Subject:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label20.Location = New System.Drawing.Point(331, 362)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 15)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "Email to Spam:"
        '
        'txtEmailBody5
        '
        Me.txtEmailBody5.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtEmailBody5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtEmailBody5.Location = New System.Drawing.Point(419, 413)
        Me.txtEmailBody5.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailBody5.Multiline = True
        Me.txtEmailBody5.Name = "txtEmailBody5"
        Me.txtEmailBody5.Size = New System.Drawing.Size(209, 23)
        Me.txtEmailBody5.TabIndex = 47
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label21.Location = New System.Drawing.Point(331, 416)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(71, 15)
        Me.Label21.TabIndex = 46
        Me.Label21.Text = "Email Body:"
        '
        'txtEmailToSpam5
        '
        Me.txtEmailToSpam5.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtEmailToSpam5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtEmailToSpam5.Location = New System.Drawing.Point(419, 359)
        Me.txtEmailToSpam5.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailToSpam5.Name = "txtEmailToSpam5"
        Me.txtEmailToSpam5.Size = New System.Drawing.Size(209, 23)
        Me.txtEmailToSpam5.TabIndex = 43
        '
        'txtEmailSubject4
        '
        Me.txtEmailSubject4.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtEmailSubject4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtEmailSubject4.Location = New System.Drawing.Point(420, 253)
        Me.txtEmailSubject4.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailSubject4.Name = "txtEmailSubject4"
        Me.txtEmailSubject4.Size = New System.Drawing.Size(209, 23)
        Me.txtEmailSubject4.TabIndex = 39
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label16.Location = New System.Drawing.Point(332, 256)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 15)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Email Subject:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label17.Location = New System.Drawing.Point(332, 229)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 15)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Email to Spam:"
        '
        'txtEmailBody4
        '
        Me.txtEmailBody4.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtEmailBody4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtEmailBody4.Location = New System.Drawing.Point(420, 280)
        Me.txtEmailBody4.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailBody4.Multiline = True
        Me.txtEmailBody4.Name = "txtEmailBody4"
        Me.txtEmailBody4.Size = New System.Drawing.Size(209, 23)
        Me.txtEmailBody4.TabIndex = 41
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label18.Location = New System.Drawing.Point(332, 283)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 15)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "Email Body:"
        '
        'txtEmailToSpam4
        '
        Me.txtEmailToSpam4.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtEmailToSpam4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtEmailToSpam4.Location = New System.Drawing.Point(420, 226)
        Me.txtEmailToSpam4.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailToSpam4.Name = "txtEmailToSpam4"
        Me.txtEmailToSpam4.Size = New System.Drawing.Size(209, 23)
        Me.txtEmailToSpam4.TabIndex = 37
        '
        'txtEmailSubject2
        '
        Me.txtEmailSubject2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtEmailSubject2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtEmailSubject2.Location = New System.Drawing.Point(100, 386)
        Me.txtEmailSubject2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailSubject2.Name = "txtEmailSubject2"
        Me.txtEmailSubject2.Size = New System.Drawing.Size(209, 23)
        Me.txtEmailSubject2.TabIndex = 33
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnSpam6)
        Me.Panel1.Controls.Add(Me.btnSpam5)
        Me.Panel1.Controls.Add(Me.btnSpam3)
        Me.Panel1.Controls.Add(Me.btnSpam2)
        Me.Panel1.Controls.Add(Me.btnSpam4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label38)
        Me.Panel1.Controls.Add(Me.Label37)
        Me.Panel1.Controls.Add(Me.Label36)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label35)
        Me.Panel1.Controls.Add(Me.Label34)
        Me.Panel1.Controls.Add(Me.Label33)
        Me.Panel1.Controls.Add(Me.Label32)
        Me.Panel1.Controls.Add(Me.Label31)
        Me.Panel1.Controls.Add(Me.Label30)
        Me.Panel1.Controls.Add(Me.btnExit1)
        Me.Panel1.Controls.Add(Me.lblProgressBar1)
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Controls.Add(Me.txtNumOfEmails1)
        Me.Panel1.Controls.Add(Me.txtGmailUsername1)
        Me.Panel1.Controls.Add(Me.txtGmailPassword1)
        Me.Panel1.Controls.Add(Me.btnSpam1)
        Me.Panel1.Controls.Add(Me.txtEmailSubject6)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.txtEmailBody6)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.txtEmailToSpam6)
        Me.Panel1.Controls.Add(Me.txtEmailSubject3)
        Me.Panel1.Controls.Add(Me.txtEmailBody3)
        Me.Panel1.Controls.Add(Me.txtEmailToSpam3)
        Me.Panel1.Controls.Add(Me.txtEmailSubject5)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.txtEmailBody5)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.txtEmailToSpam5)
        Me.Panel1.Controls.Add(Me.txtEmailSubject4)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.txtEmailBody4)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.txtEmailToSpam4)
        Me.Panel1.Controls.Add(Me.txtEmailSubject2)
        Me.Panel1.Controls.Add(Me.txtEmailBody2)
        Me.Panel1.Controls.Add(Me.txtEmailToSpam2)
        Me.Panel1.Controls.Add(Me.txtEmailSubject1)
        Me.Panel1.Controls.Add(Me.txtEmailBody1)
        Me.Panel1.Controls.Add(Me.txtEmailToSpam1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Panel1.ForeColor = System.Drawing.Color.Gray
        Me.Panel1.Location = New System.Drawing.Point(12, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(637, 586)
        Me.Panel1.TabIndex = 24
        '
        'btnSpam6
        '
        Me.btnSpam6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSpam6.ForeColor = System.Drawing.Color.Gray
        Me.btnSpam6.Location = New System.Drawing.Point(334, 462)
        Me.btnSpam6.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSpam6.Name = "btnSpam6"
        Me.btnSpam6.Size = New System.Drawing.Size(100, 25)
        Me.btnSpam6.TabIndex = 88
        Me.btnSpam6.Text = "Spam Email"
        Me.btnSpam6.UseVisualStyleBackColor = True
        '
        'btnSpam5
        '
        Me.btnSpam5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSpam5.ForeColor = System.Drawing.Color.Gray
        Me.btnSpam5.Location = New System.Drawing.Point(334, 330)
        Me.btnSpam5.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSpam5.Name = "btnSpam5"
        Me.btnSpam5.Size = New System.Drawing.Size(100, 25)
        Me.btnSpam5.TabIndex = 87
        Me.btnSpam5.Text = "Spam Email"
        Me.btnSpam5.UseVisualStyleBackColor = True
        '
        'btnSpam3
        '
        Me.btnSpam3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSpam3.ForeColor = System.Drawing.Color.Gray
        Me.btnSpam3.Location = New System.Drawing.Point(15, 462)
        Me.btnSpam3.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSpam3.Name = "btnSpam3"
        Me.btnSpam3.Size = New System.Drawing.Size(100, 25)
        Me.btnSpam3.TabIndex = 86
        Me.btnSpam3.Text = "Spam Email"
        Me.btnSpam3.UseVisualStyleBackColor = True
        '
        'btnSpam2
        '
        Me.btnSpam2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSpam2.ForeColor = System.Drawing.Color.Gray
        Me.btnSpam2.Location = New System.Drawing.Point(15, 330)
        Me.btnSpam2.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSpam2.Name = "btnSpam2"
        Me.btnSpam2.Size = New System.Drawing.Size(100, 25)
        Me.btnSpam2.TabIndex = 85
        Me.btnSpam2.Text = "Spam Email"
        Me.btnSpam2.UseVisualStyleBackColor = True
        '
        'btnSpam4
        '
        Me.btnSpam4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSpam4.ForeColor = System.Drawing.Color.Gray
        Me.btnSpam4.Location = New System.Drawing.Point(334, 197)
        Me.btnSpam4.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSpam4.Name = "btnSpam4"
        Me.btnSpam4.Size = New System.Drawing.Size(100, 25)
        Me.btnSpam4.TabIndex = 84
        Me.btnSpam4.Text = "Spam Email"
        Me.btnSpam4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(192, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 15)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Made by: BryanJMoDz (aka Static)"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label38.Location = New System.Drawing.Point(192, 55)
        Me.Label38.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(83, 15)
        Me.Label38.TabIndex = 80
        Me.Label38.Text = "Sender Gmail:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label37.Location = New System.Drawing.Point(192, 93)
        Me.Label37.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(76, 15)
        Me.Label37.TabIndex = 81
        Me.Label37.Text = "Sender Pass:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label36.Location = New System.Drawing.Point(12, 494)
        Me.Label36.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(88, 15)
        Me.Label36.TabIndex = 77
        Me.Label36.Text = "Email to Spam:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(12, 521)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Email Subject:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(12, 545)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Email Body:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label35.Location = New System.Drawing.Point(12, 389)
        Me.Label35.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(84, 15)
        Me.Label35.TabIndex = 75
        Me.Label35.Text = "Email Subject:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label34.Location = New System.Drawing.Point(12, 362)
        Me.Label34.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(88, 15)
        Me.Label34.TabIndex = 74
        Me.Label34.Text = "Email to Spam:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label33.Location = New System.Drawing.Point(12, 416)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(71, 15)
        Me.Label33.TabIndex = 76
        Me.Label33.Text = "Email Body:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label32.Location = New System.Drawing.Point(12, 256)
        Me.Label32.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(84, 15)
        Me.Label32.TabIndex = 72
        Me.Label32.Text = "Email Subject:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label31.Location = New System.Drawing.Point(12, 229)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(88, 15)
        Me.Label31.TabIndex = 71
        Me.Label31.Text = "Email to Spam:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label30.Location = New System.Drawing.Point(12, 283)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(71, 15)
        Me.Label30.TabIndex = 73
        Me.Label30.Text = "Email Body:"
        '
        'txtEmailBody6
        '
        Me.txtEmailBody6.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtEmailBody6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtEmailBody6.Location = New System.Drawing.Point(419, 545)
        Me.txtEmailBody6.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailBody6.Multiline = True
        Me.txtEmailBody6.Name = "txtEmailBody6"
        Me.txtEmailBody6.Size = New System.Drawing.Size(209, 23)
        Me.txtEmailBody6.TabIndex = 59
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label27.Location = New System.Drawing.Point(331, 548)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(71, 15)
        Me.Label27.TabIndex = 58
        Me.Label27.Text = "Email Body:"
        '
        'txtEmailBody3
        '
        Me.txtEmailBody3.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtEmailBody3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtEmailBody3.Location = New System.Drawing.Point(100, 545)
        Me.txtEmailBody3.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailBody3.Multiline = True
        Me.txtEmailBody3.Name = "txtEmailBody3"
        Me.txtEmailBody3.Size = New System.Drawing.Size(209, 23)
        Me.txtEmailBody3.TabIndex = 53
        '
        'txtEmailBody2
        '
        Me.txtEmailBody2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtEmailBody2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtEmailBody2.Location = New System.Drawing.Point(100, 413)
        Me.txtEmailBody2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailBody2.Multiline = True
        Me.txtEmailBody2.Name = "txtEmailBody2"
        Me.txtEmailBody2.Size = New System.Drawing.Size(209, 23)
        Me.txtEmailBody2.TabIndex = 35
        '
        'txtEmailToSpam2
        '
        Me.txtEmailToSpam2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtEmailToSpam2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtEmailToSpam2.Location = New System.Drawing.Point(100, 359)
        Me.txtEmailToSpam2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailToSpam2.Name = "txtEmailToSpam2"
        Me.txtEmailToSpam2.Size = New System.Drawing.Size(209, 23)
        Me.txtEmailToSpam2.TabIndex = 31
        '
        'txtEmailSubject1
        '
        Me.txtEmailSubject1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtEmailSubject1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtEmailSubject1.Location = New System.Drawing.Point(100, 253)
        Me.txtEmailSubject1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailSubject1.Name = "txtEmailSubject1"
        Me.txtEmailSubject1.Size = New System.Drawing.Size(209, 23)
        Me.txtEmailSubject1.TabIndex = 26
        '
        'txtEmailBody1
        '
        Me.txtEmailBody1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtEmailBody1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtEmailBody1.Location = New System.Drawing.Point(100, 280)
        Me.txtEmailBody1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailBody1.Multiline = True
        Me.txtEmailBody1.Name = "txtEmailBody1"
        Me.txtEmailBody1.Size = New System.Drawing.Size(209, 23)
        Me.txtEmailBody1.TabIndex = 28
        '
        'txtEmailToSpam1
        '
        Me.txtEmailToSpam1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtEmailToSpam1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtEmailToSpam1.Location = New System.Drawing.Point(100, 226)
        Me.txtEmailToSpam1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailToSpam1.Name = "txtEmailToSpam1"
        Me.txtEmailToSpam1.Size = New System.Drawing.Size(209, 23)
        Me.txtEmailToSpam1.TabIndex = 24
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 170)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(286, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Static Spammer 1.2"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(662, 623)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.txtNumOfEmails1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit1 As Button
    Friend WithEvents lblProgressBar1 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents txtNumOfEmails1 As NumericUpDown
    Friend WithEvents txtGmailUsername1 As TextBox
    Friend WithEvents txtGmailPassword1 As TextBox
    Friend WithEvents btnSpam1 As Button
    Friend WithEvents txtEmailSubject6 As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents txtEmailToSpam6 As TextBox
    Friend WithEvents txtEmailSubject3 As TextBox
    Friend WithEvents txtEmailToSpam3 As TextBox
    Friend WithEvents txtEmailSubject5 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtEmailBody5 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtEmailToSpam5 As TextBox
    Friend WithEvents txtEmailSubject4 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtEmailBody4 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtEmailToSpam4 As TextBox
    Friend WithEvents txtEmailSubject2 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtEmailBody6 As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtEmailBody3 As TextBox
    Friend WithEvents txtEmailBody2 As TextBox
    Friend WithEvents txtEmailToSpam2 As TextBox
    Friend WithEvents txtEmailSubject1 As TextBox
    Friend WithEvents txtEmailBody1 As TextBox
    Friend WithEvents txtEmailToSpam1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSpam6 As Button
    Friend WithEvents btnSpam5 As Button
    Friend WithEvents btnSpam3 As Button
    Friend WithEvents btnSpam2 As Button
    Friend WithEvents btnSpam4 As Button
End Class
