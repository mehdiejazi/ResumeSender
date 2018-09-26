using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ResumeSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<string> SplitComma(string strString)
        {
            List<string> lstReturned = new List<string>();

            string[] arrString = strString.Split(','.ToString().ToCharArray(), StringSplitOptions.None);

            foreach (string s in arrString)
            {
                s.Replace(",", "");
                lstReturned.Add(s);
            }
            return lstReturned;
        }

        private void btnTo_Click(object sender, EventArgs e)
        {
            myOpenFileDialog.Filter = "Email Addresses (*.txt)|*.txt";
            if (myOpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                List<string> lstsTo = new List<string>();
                string[] strLines = File.ReadAllLines(myOpenFileDialog.FileName);
                foreach (string item in strLines)
                {
                    lstTo.Items.Add(item);
                }

            }

        }

        private void btnAttachments_Click(object sender, EventArgs e)
        {
            myOpenFileDialog.Filter = "All Files (*.*)|*.*";
            if (myOpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lstAttachments.Items.Add(myOpenFileDialog.FileName);
            }
        }

        private bool SendMail(string strTo, string strBody, string strSubject, List<string> lstsAttachmens)
        {
            try
            {
                
                System.Net.Mail.MailMessage oMailMessage = new System.Net.Mail.MailMessage();

                oMailMessage.IsBodyHtml = true;
                oMailMessage.Priority = System.Net.Mail.MailPriority.Normal;
                oMailMessage.DeliveryNotificationOptions = System.Net.Mail.DeliveryNotificationOptions.OnFailure;

                System.Net.Mail.MailAddress oMailAddress = null;

                string strMail = textBox2.Text;
                string strName = textBox1.Text;
                oMailAddress = new System.Net.Mail.MailAddress(strMail, strName);
                //oMailAddress.DisplayName = "Mehdi Ejazi";

                oMailMessage.From = oMailAddress;
                oMailMessage.Sender = oMailAddress;
                //oMailMessage.ReplyTo = oMailAddress;

                oMailAddress = new System.Net.Mail.MailAddress(strTo);
                //oMailAddress.DisplayName = "Job Resume";

                oMailMessage.To.Add(oMailAddress);
                oMailMessage.SubjectEncoding = System.Text.Encoding.UTF8;
                oMailMessage.Subject = strSubject;

                oMailMessage.BodyEncoding = System.Text.Encoding.UTF8;
                oMailMessage.Body = strBody;

                foreach (string strAttFile in lstsAttachmens)
                {
                    System.Net.Mail.Attachment oAttachment = new System.Net.Mail.Attachment(strAttFile);
                    oMailMessage.Attachments.Add(oAttachment);
                }

                System.Net.Mail.SmtpClient oStmpClient = new System.Net.Mail.SmtpClient();
    
                oStmpClient.EnableSsl = true;
                oStmpClient.Timeout = 180000;

                //oStmpClient.Host;
                //oStmpClient.Port;
                //mailer.Host = "mail.youroutgoingsmtpserver.com";
                //mailer.Credentials = new System.Net.NetworkCredential("yourusername", "yourpassword");

                oStmpClient.Send(oMailMessage);
                return true;
            }
            catch
            {
                return false;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int intSentMail = 0;

        string strBody;

        private void myBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //lblProgress.Text = "0/" + lstTo.Items.Count.ToString();
            //myProgressBar.Maximum = lstTo.Items.Count;

            string _strBody;

            List<string> lstsAttachments = new List<string>();

            foreach (string item in lstAttachments.Items)
            {
                lstsAttachments.Add(item);
            }
            MessageBox.Show("Ready for send mails...");
            foreach (string item in lstTo.Items)
            {
                string strMail = item.Split(',')[0];
                string strTitle = item.Split(',')[1];
                _strBody = strBody.Replace("$$11$$", strTitle);
                if (SendMail(strMail, _strBody, txtSubject.Text, lstsAttachments) == true)
                {
                    intSentMail++;
                }
            }
        }

        private void myBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void myBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Complete");
            btnSend.Enabled = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            strBody = txtBody.Text;

            lblProgress.Text = "0/" + lstTo.Items.Count.ToString();
            myProgressBar.Maximum = lstTo.Items.Count;

            int intSentMail = 0;

            btnSend.Enabled = false;
            myBackgroundWorker.RunWorkerAsync();
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            lblProgress.Text = intSentMail.ToString() + " / " + lstTo.Items.Count.ToString();
            myProgressBar.Value = intSentMail;
        }
    }
}
