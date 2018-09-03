using System.Net;
using System.Net.Mail;



namespace WpfTestMailSender
{
    class EmailSendServiceClass
    {        
        MailSet.server srv = new MailSet.server();
        public EmailSendServiceClass(string user, string pass, string to, string textHeader, string textBody)
        {
            MailSet.user = user;
            MailSet.pass = pass;
            MailSet.textMessageCaption = textHeader;
            MailSet.textMesageBody = textBody;
            MailSet.toSend = to;
        }
        public void SendMail()
        {                       
            try
            {
                using (var message = new MailMessage(
                    MailSet.user,
                    MailSet.toSend,
                    MailSet.textMessageCaption,
                    MailSet.textMesageBody                   
                    ))
                    
                using (var client = new SmtpClient(srv.Yandex, srv.PortYandex)
                {
                    EnableSsl = true,
                    Credentials = new NetworkCredential(
                    MailSet.user,
                    MailSet.pass)})
                {
                    //тест вложений в письме
                    if (MailSet.addAttachAdr != null)
                    {
                        message.Attachments.Add(new Attachment
                            (MailSet.addAttachAdr));
                    }
                    client.Send(message);
                }
            }

            catch (SmtpException error)
            {
                var dlgErr = new SendEndWindow(error.Message);
                dlgErr.ShowDialog();
            }
            var dlg = new SendSuccesfull();
            dlg.ShowDialog();
        }
    }
  }

