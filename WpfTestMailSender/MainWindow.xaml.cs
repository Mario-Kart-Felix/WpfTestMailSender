using System.Windows;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System;


namespace WpfTestMailSender
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class WpfMailSender : Window
    {

        public WpfMailSender()
        {
            InitializeComponent();
           
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            EmailSendServiceClass EMSC = new EmailSendServiceClass(
                UserNameTextBox.Text, 
                passwordBox.Password,
                tbTo.Text,
                tbHeaderMail.Text, 
                tbTextMail.Text
                );
            EMSC.SendMail();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddAttach.AddAttachment();
            lbAttach.Content=MailSet.addAttachAdr;
        }
    }
} 
