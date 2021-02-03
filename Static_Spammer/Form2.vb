Imports System.Net.Mail

Public Class Form2

    Dim thread As System.Threading.Thread

    Private Sub btnExit1_Click(sender As Object, e As EventArgs) Handles btnExit1.Click
        Me.Close()
    End Sub

    Private Sub isSendingEmail()

        txtEmailToSpam1.Enabled = False
        txtEmailBody1.Enabled = False
        txtEmailSubject1.Enabled = False
        txtEmailToSpam2.Enabled = False
        txtEmailBody2.Enabled = False
        txtEmailSubject2.Enabled = False
        txtEmailToSpam3.Enabled = False
        txtEmailBody3.Enabled = False
        txtEmailSubject3.Enabled = False
        txtEmailToSpam4.Enabled = False
        txtEmailBody4.Enabled = False
        txtEmailSubject4.Enabled = False
        txtEmailToSpam5.Enabled = False
        txtEmailBody5.Enabled = False
        txtEmailSubject5.Enabled = False
        txtEmailToSpam6.Enabled = False
        txtEmailBody6.Enabled = False
        txtEmailSubject6.Enabled = False
        txtGmailPassword1.Enabled = False
        txtGmailUsername1.Enabled = False
        txtNumOfEmails1.Enabled = False
        btnExit1.Enabled = False
        btnSpam1.Text = "Spamming.."
        btnSpam1.Enabled = False
        btnSpam2.Text = "Spamming.."
        btnSpam2.Enabled = False
        btnSpam3.Text = "Spamming.."
        btnSpam3.Enabled = False
        btnSpam4.Text = "Spamming.."
        btnSpam4.Enabled = False
        btnSpam5.Text = "Spamming.."
        btnSpam5.Enabled = False
        btnSpam6.Text = "Spamming.."
        btnSpam6.Enabled = False
    End Sub

    Private Sub finishedSendingEmail()

        txtEmailToSpam1.Invoke(Sub()
                                   txtEmailToSpam1.Enabled = True
                               End Sub)
        txtEmailBody1.Invoke(Sub()
                                 txtEmailBody1.Enabled = True
                             End Sub)
        txtEmailSubject1.Invoke(Sub()
                                    txtEmailSubject1.Enabled = True
                                End Sub)
        txtEmailToSpam2.Invoke(Sub()
                                   txtEmailToSpam2.Enabled = True
                               End Sub)
        txtEmailBody2.Invoke(Sub()
                                 txtEmailBody2.Enabled = True
                             End Sub)
        txtEmailSubject2.Invoke(Sub()
                                    txtEmailSubject2.Enabled = True
                                End Sub)
        txtEmailToSpam3.Invoke(Sub()
                                   txtEmailToSpam3.Enabled = True
                               End Sub)
        txtEmailBody3.Invoke(Sub()
                                 txtEmailBody3.Enabled = True
                             End Sub)
        txtEmailSubject3.Invoke(Sub()
                                    txtEmailSubject3.Enabled = True
                                End Sub)
        txtEmailToSpam4.Invoke(Sub()
                                   txtEmailToSpam4.Enabled = True
                               End Sub)
        txtEmailBody4.Invoke(Sub()
                                 txtEmailBody4.Enabled = True
                             End Sub)
        txtEmailSubject4.Invoke(Sub()
                                    txtEmailSubject4.Enabled = True
                                End Sub)
        txtEmailToSpam5.Invoke(Sub()
                                   txtEmailToSpam5.Enabled = True
                               End Sub)
        txtEmailBody5.Invoke(Sub()
                                 txtEmailBody5.Enabled = True
                             End Sub)
        txtEmailSubject5.Invoke(Sub()
                                    txtEmailSubject5.Enabled = True
                                End Sub)
        txtEmailToSpam6.Invoke(Sub()
                                   txtEmailToSpam6.Enabled = True
                               End Sub)
        txtEmailBody6.Invoke(Sub()
                                 txtEmailBody6.Enabled = True
                             End Sub)
        txtEmailSubject6.Invoke(Sub()
                                    txtEmailSubject6.Enabled = True
                                End Sub)
        txtGmailPassword1.Invoke(Sub()
                                     txtGmailPassword1.Enabled = True
                                 End Sub)
        txtGmailUsername1.Invoke(Sub()
                                     txtGmailUsername1.Enabled = True
                                 End Sub)
        txtNumOfEmails1.Invoke(Sub()
                                   txtNumOfEmails1.Enabled = True
                               End Sub)
        btnExit1.Invoke(Sub()
                            btnExit1.Enabled = True
                        End Sub)
        btnSpam1.Invoke(Sub()
                            btnSpam1.Text = "Spam Email"
                            btnSpam1.Enabled = True
                        End Sub)
        btnSpam2.Invoke(Sub()
                            btnSpam2.Text = "Spam Email"
                            btnSpam2.Enabled = True
                        End Sub)
        btnSpam3.Invoke(Sub()
                            btnSpam3.Text = "Spam Email"
                            btnSpam3.Enabled = True
                        End Sub)
        btnSpam4.Invoke(Sub()
                            btnSpam4.Text = "Spam Email"
                            btnSpam4.Enabled = True
                        End Sub)
        btnSpam5.Invoke(Sub()
                            btnSpam5.Text = "Spam Email"
                            btnSpam5.Enabled = True
                        End Sub)
        btnSpam6.Invoke(Sub()
                            btnSpam6.Text = "Spam Email"
                            btnSpam6.Enabled = True
                        End Sub)
        lblProgressBar1.Invoke(Sub()
                                   lblProgressBar1.Text = "Status: Completed"
                               End Sub)
    End Sub

    Private Sub btnSpam1_Click(sender As Object, e As EventArgs) Handles btnSpam1.Click

        If txtEmailBody1.Text = "" Or txtEmailToSpam1.Text = "" Or txtGmailUsername1.Text = "" Or txtGmailPassword1.Text = "" Or txtEmailSubject1.Text = "" Then
            MsgBox("Make sure all fields are filled in.", , "Missing Fields")
        Else
            isSendingEmail()
            thread = New System.Threading.Thread(AddressOf sendEmail1)
            thread.Start()
        End If


    End Sub

    Private Sub btnSpam2_Click(sender As Object, e As EventArgs) Handles btnSpam2.Click

        If txtEmailBody2.Text = "" Or txtEmailToSpam2.Text = "" Or txtGmailUsername1.Text = "" Or txtGmailPassword1.Text = "" Or txtEmailSubject2.Text = "" Then
            MsgBox("Make sure all fields are filled in.", , "Missing Fields")
        Else
            isSendingEmail()
            thread = New System.Threading.Thread(AddressOf sendEmail2)
            thread.Start()
        End If


    End Sub

    Private Sub btnSpam3_Click(sender As Object, e As EventArgs) Handles btnSpam3.Click

        If txtEmailBody3.Text = "" Or txtEmailToSpam3.Text = "" Or txtGmailUsername1.Text = "" Or txtGmailPassword1.Text = "" Or txtEmailSubject3.Text = "" Then
            MsgBox("Make sure all fields are filled in.", , "Missing Fields")
        Else
            isSendingEmail()
            thread = New System.Threading.Thread(AddressOf sendEmail3)
            thread.Start()
        End If


    End Sub
    Private Sub btnSpam4_Click(sender As Object, e As EventArgs) Handles btnSpam4.Click

        If txtEmailBody4.Text = "" Or txtEmailToSpam4.Text = "" Or txtGmailUsername1.Text = "" Or txtGmailPassword1.Text = "" Or txtEmailSubject4.Text = "" Then
            MsgBox("Make sure all fields are filled in.", , "Missing Fields")
        Else
            isSendingEmail()
            thread = New System.Threading.Thread(AddressOf sendEmail4)
            thread.Start()
        End If


    End Sub
    Private Sub btnSpam5_Click(sender As Object, e As EventArgs) Handles btnSpam5.Click

        If txtEmailBody5.Text = "" Or txtEmailToSpam5.Text = "" Or txtGmailUsername1.Text = "" Or txtGmailPassword1.Text = "" Or txtEmailSubject5.Text = "" Then
            MsgBox("Make sure all fields are filled in.", , "Missing Fields")
        Else
            isSendingEmail()
            thread = New System.Threading.Thread(AddressOf sendEmail5)
            thread.Start()
        End If


    End Sub
    Private Sub btnSpam6_Click(sender As Object, e As EventArgs) Handles btnSpam6.Click

        If txtEmailBody6.Text = "" Or txtEmailToSpam6.Text = "" Or txtGmailUsername1.Text = "" Or txtGmailPassword1.Text = "" Or txtEmailSubject6.Text = "" Then
            MsgBox("Make sure all fields are filled in.", , "Missing Fields")
        Else
            isSendingEmail()
            thread = New System.Threading.Thread(AddressOf sendEmail6)
            thread.Start()
        End If


    End Sub

    Private Sub sendEmail1()
        Try
            Dim Smtp_Server As New SmtpClient
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential(txtGmailUsername1.Text, txtGmailPassword1.Text)
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            Dim e_mail As New MailMessage()
            e_mail = New MailMessage()
            e_mail.From = New MailAddress(txtGmailUsername1.Text)
            e_mail.To.Add(txtEmailToSpam1.Text)
            e_mail.IsBodyHtml = False
            e_mail.Body = txtEmailBody1.Text

            For i As Integer = 1 To CInt(txtNumOfEmails1.Value)
                e_mail.Subject = txtEmailSubject1.Text + " - " + RandomString(7)
                Smtp_Server.Send(e_mail)
                lblProgressBar1.Invoke(Sub()
                                           lblProgressBar1.Text = "Status: Sending Emails " + CStr(i) + "/" + CStr(txtNumOfEmails1.Value)
                                           ProgressBar1.Value = i / CInt(txtNumOfEmails1.Value) * 100
                                       End Sub)
            Next
            MsgBox("Emails Sent!", , "Success!")
            finishedSendingEmail()
        Catch error_t As Exception
            MsgBox("Double check gmail login details. You may also have to to go https://myaccount.google.com/lesssecureapps and turn 'allow less secure apps' on.", , "Error!")
        End Try
    End Sub

    Private Sub sendEmail2()
        Try
            Dim Smtp_Server As New SmtpClient
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential(txtGmailUsername1.Text, txtGmailPassword1.Text)
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            Dim e_mail As New MailMessage()
            e_mail = New MailMessage()
            e_mail.From = New MailAddress(txtGmailUsername1.Text)
            e_mail.To.Add(txtEmailToSpam2.Text)
            e_mail.IsBodyHtml = False
            e_mail.Body = txtEmailBody2.Text

            For i As Integer = 1 To CInt(txtNumOfEmails1.Value)
                e_mail.Subject = txtEmailSubject2.Text + " - " + RandomString(7)
                Smtp_Server.Send(e_mail)
                lblProgressBar1.Invoke(Sub()
                                           lblProgressBar1.Text = "Status: Sending Emails " + CStr(i) + "/" + CStr(txtNumOfEmails1.Value)
                                           ProgressBar1.Value = i / CInt(txtNumOfEmails1.Value) * 100
                                       End Sub)
            Next
            MsgBox("Emails Sent!", , "Success!")
            finishedSendingEmail()
        Catch error_t As Exception
            MsgBox("Double check gmail login details. You may also have to to go https://myaccount.google.com/lesssecureapps and turn 'allow less secure apps' on.", , "Error!")
        End Try
    End Sub

    Private Sub sendEmail3()
        Try
            Dim Smtp_Server As New SmtpClient
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential(txtGmailUsername1.Text, txtGmailPassword1.Text)
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            Dim e_mail As New MailMessage()
            e_mail = New MailMessage()
            e_mail.From = New MailAddress(txtGmailUsername1.Text)
            e_mail.To.Add(txtEmailToSpam3.Text)
            e_mail.IsBodyHtml = False
            e_mail.Body = txtEmailBody3.Text

            For i As Integer = 1 To CInt(txtNumOfEmails1.Value)
                e_mail.Subject = txtEmailSubject3.Text + " - " + RandomString(7)
                Smtp_Server.Send(e_mail)
                lblProgressBar1.Invoke(Sub()
                                           lblProgressBar1.Text = "Status: Sending Emails " + CStr(i) + "/" + CStr(txtNumOfEmails1.Value)
                                           ProgressBar1.Value = i / CInt(txtNumOfEmails1.Value) * 100
                                       End Sub)
            Next
            MsgBox("Emails Sent!", , "Success!")
            finishedSendingEmail()
        Catch error_t As Exception
            MsgBox("Double check gmail login details. You may also have to to go https://myaccount.google.com/lesssecureapps and turn 'allow less secure apps' on.", , "Error!")
        End Try
    End Sub
    Private Sub sendEmail4()
        Try
            Dim Smtp_Server As New SmtpClient
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential(txtGmailUsername1.Text, txtGmailPassword1.Text)
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            Dim e_mail As New MailMessage()
            e_mail = New MailMessage()
            e_mail.From = New MailAddress(txtGmailUsername1.Text)
            e_mail.To.Add(txtEmailToSpam4.Text)
            e_mail.IsBodyHtml = False
            e_mail.Body = txtEmailBody4.Text

            For i As Integer = 1 To CInt(txtNumOfEmails1.Value)
                e_mail.Subject = txtEmailSubject4.Text + " - " + RandomString(7)
                Smtp_Server.Send(e_mail)
                lblProgressBar1.Invoke(Sub()
                                           lblProgressBar1.Text = "Status: Sending Emails " + CStr(i) + "/" + CStr(txtNumOfEmails1.Value)
                                           ProgressBar1.Value = i / CInt(txtNumOfEmails1.Value) * 100
                                       End Sub)
            Next
            MsgBox("Emails Sent!", , "Success!")
            finishedSendingEmail()
        Catch error_t As Exception
            MsgBox("Double check gmail login details. You may also have to to go https://myaccount.google.com/lesssecureapps and turn 'allow less secure apps' on.", , "Error!")
        End Try
    End Sub
    Private Sub sendEmail5()
        Try
            Dim Smtp_Server As New SmtpClient
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential(txtGmailUsername1.Text, txtGmailPassword1.Text)
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            Dim e_mail As New MailMessage()
            e_mail = New MailMessage()
            e_mail.From = New MailAddress(txtGmailUsername1.Text)
            e_mail.To.Add(txtEmailToSpam5.Text)
            e_mail.IsBodyHtml = False
            e_mail.Body = txtEmailBody5.Text

            For i As Integer = 1 To CInt(txtNumOfEmails1.Value)
                e_mail.Subject = txtEmailSubject5.Text + " - " + RandomString(7)
                Smtp_Server.Send(e_mail)
                lblProgressBar1.Invoke(Sub()
                                           lblProgressBar1.Text = "Status: Sending Emails " + CStr(i) + "/" + CStr(txtNumOfEmails1.Value)
                                           ProgressBar1.Value = i / CInt(txtNumOfEmails1.Value) * 100
                                       End Sub)
            Next
            MsgBox("Emails Sent!", , "Success!")
            finishedSendingEmail()
        Catch error_t As Exception
            MsgBox("Double check gmail login details. You may also have to to go https://myaccount.google.com/lesssecureapps and turn 'allow less secure apps' on.", , "Error!")
        End Try
    End Sub
    Private Sub sendEmail6()
        Try
            Dim Smtp_Server As New SmtpClient
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential(txtGmailUsername1.Text, txtGmailPassword1.Text)
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            Dim e_mail As New MailMessage()
            e_mail = New MailMessage()
            e_mail.From = New MailAddress(txtGmailUsername1.Text)
            e_mail.To.Add(txtEmailToSpam6.Text)
            e_mail.IsBodyHtml = False
            e_mail.Body = txtEmailBody6.Text

            For i As Integer = 1 To CInt(txtNumOfEmails1.Value)
                e_mail.Subject = txtEmailSubject6.Text + " - " + RandomString(7)
                Smtp_Server.Send(e_mail)
                lblProgressBar1.Invoke(Sub()
                                           lblProgressBar1.Text = "Status: Sending Emails " + CStr(i) + "/" + CStr(txtNumOfEmails1.Value)
                                           ProgressBar1.Value = i / CInt(txtNumOfEmails1.Value) * 100
                                       End Sub)
            Next
            MsgBox("Emails Sent!", , "Success!")
            finishedSendingEmail()
        Catch error_t As Exception
            MsgBox("Double check gmail login details. You may also have to to go https://myaccount.google.com/lesssecureapps and turn 'allow less secure apps' on.", , "Error!")
        End Try
    End Sub

    Private Function RandomString(ByRef Length As String) As String
        Dim str As String = Nothing
        Dim rnd As New Random
        For i As Integer = 0 To Length
            Dim chrInt As Integer = 0
            Do
                chrInt = rnd.Next(30, 122)
                If (chrInt >= 48 And chrInt <= 57) Or (chrInt >= 65 And chrInt <= 90) Or (chrInt >= 97 And chrInt <= 122) Then
                    Exit Do
                End If
            Loop
            str &= Chr(chrInt)
        Next
        Return str
    End Function

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

End Class
