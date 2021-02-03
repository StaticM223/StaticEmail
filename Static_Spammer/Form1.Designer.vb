<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGmailUsername = New System.Windows.Forms.TextBox()
        Me.txtGmailPassword = New System.Windows.Forms.TextBox()
        Me.txtNumOfEmails = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmailBody = New System.Windows.Forms.TextBox()
        Me.txtEmailToSpam = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSpam = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblProgressBar = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmailSubject = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnf1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label13 = New System.Windows.Forms.Label()
        CType(Me.txtNumOfEmails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(177, 57)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Sender Gmail:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(176, 98)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Sender Password:"
        '
        'txtGmailUsername
        '
        Me.txtGmailUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtGmailUsername.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtGmailUsername.Location = New System.Drawing.Point(284, 54)
        Me.txtGmailUsername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGmailUsername.Name = "txtGmailUsername"
        Me.txtGmailUsername.Size = New System.Drawing.Size(209, 23)
        Me.txtGmailUsername.TabIndex = 14
        '
        'txtGmailPassword
        '
        Me.txtGmailPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtGmailPassword.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtGmailPassword.Location = New System.Drawing.Point(284, 95)
        Me.txtGmailPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGmailPassword.Name = "txtGmailPassword"
        Me.txtGmailPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtGmailPassword.Size = New System.Drawing.Size(209, 23)
        Me.txtGmailPassword.TabIndex = 16
        '
        'txtNumOfEmails
        '
        Me.txtNumOfEmails.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtNumOfEmails.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtNumOfEmails.Location = New System.Drawing.Point(504, 186)
        Me.txtNumOfEmails.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumOfEmails.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtNumOfEmails.Name = "txtNumOfEmails"
        Me.txtNumOfEmails.Size = New System.Drawing.Size(59, 23)
        Me.txtNumOfEmails.TabIndex = 11
        Me.txtNumOfEmails.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(501, 163)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Email #"
        '
        'txtEmailBody
        '
        Me.txtEmailBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtEmailBody.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtEmailBody.Location = New System.Drawing.Point(573, 103)
        Me.txtEmailBody.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailBody.Multiline = True
        Me.txtEmailBody.Name = "txtEmailBody"
        Me.txtEmailBody.Size = New System.Drawing.Size(224, 106)
        Me.txtEmailBody.TabIndex = 9
        '
        'txtEmailToSpam
        '
        Me.txtEmailToSpam.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtEmailToSpam.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtEmailToSpam.Location = New System.Drawing.Point(588, 54)
        Me.txtEmailToSpam.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailToSpam.Name = "txtEmailToSpam"
        Me.txtEmailToSpam.Size = New System.Drawing.Size(209, 23)
        Me.txtEmailToSpam.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(501, 103)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 15)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Email Body:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(501, 57)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Email to Spam:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(177, 25)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Sender Information"
        '
        'btnSpam
        '
        Me.btnSpam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSpam.ForeColor = System.Drawing.Color.Gray
        Me.btnSpam.Location = New System.Drawing.Point(179, 122)
        Me.btnSpam.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSpam.Name = "btnSpam"
        Me.btnSpam.Size = New System.Drawing.Size(100, 25)
        Me.btnSpam.TabIndex = 18
        Me.btnSpam.Text = "Spam Email"
        Me.btnSpam.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.Gray
        Me.btnExit.Location = New System.Drawing.Point(393, 122)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 25)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit Program"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(180, 180)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(313, 26)
        Me.ProgressBar1.TabIndex = 21
        '
        'lblProgressBar
        '
        Me.lblProgressBar.AutoSize = True
        Me.lblProgressBar.BackColor = System.Drawing.Color.Transparent
        Me.lblProgressBar.Location = New System.Drawing.Point(286, 163)
        Me.lblProgressBar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProgressBar.Name = "lblProgressBar"
        Me.lblProgressBar.Size = New System.Drawing.Size(91, 15)
        Me.lblProgressBar.TabIndex = 20
        Me.lblProgressBar.Text = "Status: Stopped"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(501, 25)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Email Information"
        '
        'txtEmailSubject
        '
        Me.txtEmailSubject.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtEmailSubject.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtEmailSubject.Location = New System.Drawing.Point(588, 78)
        Me.txtEmailSubject.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailSubject.Name = "txtEmailSubject"
        Me.txtEmailSubject.Size = New System.Drawing.Size(209, 23)
        Me.txtEmailSubject.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(501, 81)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 15)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Email Subject:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnf1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.txtEmailSubject)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lblProgressBar)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.txtGmailUsername)
        Me.Panel1.Controls.Add(Me.btnSpam)
        Me.Panel1.Controls.Add(Me.txtGmailPassword)
        Me.Panel1.Controls.Add(Me.txtNumOfEmails)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtEmailBody)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtEmailToSpam)
        Me.Panel1.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Panel1.ForeColor = System.Drawing.Color.Gray
        Me.Panel1.Location = New System.Drawing.Point(12, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 223)
        Me.Panel1.TabIndex = 23
        '
        'btnf1
        '
        Me.btnf1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnf1.ForeColor = System.Drawing.Color.Gray
        Me.btnf1.Location = New System.Drawing.Point(343, 13)
        Me.btnf1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnf1.Name = "btnf1"
        Me.btnf1.Size = New System.Drawing.Size(100, 25)
        Me.btnf1.TabIndex = 71
        Me.btnf1.Text = "More then one"
        Me.btnf1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 16)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 190)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.label13.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.ForeColor = System.Drawing.Color.White
        Me.label13.Location = New System.Drawing.Point(366, 3)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(109, 15)
        Me.label13.TabIndex = 23
        Me.label13.Text = "Static Spammer 1.2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(832, 256)
        Me.Controls.Add(Me.label13)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spammer v 1.2"
        CType(Me.txtNumOfEmails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGmailUsername As TextBox
    Friend WithEvents txtGmailPassword As TextBox
    Friend WithEvents txtNumOfEmails As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmailBody As TextBox
    Friend WithEvents txtEmailToSpam As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnSpam As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblProgressBar As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmailSubject As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel1 As Panel
    Private WithEvents label13 As Label
    Friend WithEvents btnf1 As Button
End Class
