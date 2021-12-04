
using System;
using System.Net;
using System.Net.Mail;
using Template.BL.Models;

namespace Tamplate.Bl.Helper
{
    public static class MailHelper
    {
        public static string MailSender(MailVM model)
        {
            try
            {
                using (var smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential("zekahassan11@gmail.com", "Your Password");
                    smtp.Send("zekahassan11@gmail.com", model.EMail, model.Title, model.Message);
                }

                return " Mail Sent Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }    
}