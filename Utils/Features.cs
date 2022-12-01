using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tour.Utils
{
    public class Features
    {
        private static Features instance;

        public static Features Instance
        {
            get { if (instance == null) instance = new Features(); return Features.instance; }
            private set { Features.instance = value; }
        }
        private Features()
        {

        }

        public void SendMail(List<string> listto = null, string sub = "", string message = "", List<Attachment> listatt = null)
        {
            foreach (string to in listto)
            {
                MailMessage mailmess = new MailMessage("blueseamailtest@gmail.com", to, sub, message);
                if (listatt != null)
                {
                    foreach (Attachment att in listatt)
                    {
                        if (att != null)
                        {
                            mailmess.Attachments.Add(att);
                        }
                    }
                }


                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("blueseamailtest@gmail.com", "ccoefyxvchwcugez");
                client.Send(mailmess);
            }

        }


    }
}
