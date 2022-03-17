using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;



namespace Utilities
{
    public static class EMails
    {
        public static string SendMail(string To, string CC, string Bcc)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("repuestos@autrisa.com");
                message.To.Add(new MailAddress(To));
                message.CC.Add(new MailAddress(CC));
                message.Bcc.Add(new MailAddress(Bcc));
                message.Subject = "Test";
                message.IsBodyHtml = true; 
                message.Body = "<h3> Prueba de correo enviado fuera de red <h3>";
                smtp.Port = 587;
                smtp.Host = "SMTP.Office365.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("repuestos@autrisa.com", "R123456+");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                return ("Email send succes");
            }
            catch (Exception ex) 
            {
                return (ex.Message);
            }
        }
    }
}
