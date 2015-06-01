using System.Net.Mail;
using Code;
//using System.Web.Mail;
using System.Web.Helpers;
using System;
using System.Net;

public class MailHelper
{
    public static void SendMail(string to, string subject, string body, string fileAttachment = "")
    {
        try
        {
            WebMail.SmtpServer = ConfigurationWrapper.SMTP_SERVER;
            WebMail.From = ConfigurationWrapper.SMTP_FROM;
            WebMail.Password = ConfigurationWrapper.SMTP_PASSWORD;
            WebMail.SmtpPort = ConfigurationWrapper.SMTP_PORT;
            WebMail.UserName = ConfigurationWrapper.SMTP_USER;
            var filesList = new string[] { fileAttachment };
            WebMail.EnableSsl = true;
            WebMail.Send(to: to, bcc:"mohitdagar80@gmail.com",subject: subject, body: body, isBodyHtml: true);
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public static string SendCompanionMail(string to, string subject, string body, string fileAttachment = "")
    {
        string msg = string.Empty;
        try
        {
            //to = "sanjay@swarvandana.com";
            // to = "mohitdagar80@gmail.com";
            WebMail.SmtpServer = ConfigurationWrapper.SMTP_SERVER;
            WebMail.From = "chairman.svarvandana@gmail.com";
            WebMail.Password = "mercygod";
            WebMail.SmtpPort = ConfigurationWrapper.SMTP_PORT;
            WebMail.UserName = "chairman.svarvandana@gmail.com";
            var filesList = new string[] { fileAttachment };
            WebMail.EnableSsl = true;
            if (!string.IsNullOrEmpty(fileAttachment))
                WebMail.Send(to: to, subject: subject, body: body, isBodyHtml: true, filesToAttach: filesList);
            else
                WebMail.Send(to: to, subject: subject, body: body, isBodyHtml: true);
            msg = "Mail send successfully";
        }
        catch (Exception e)
        {
            msg = e.Message;
            //throw e;
        }
        return msg;
    }

    public static string BroadCastMail1(string to, string bcc, string subject, string body, string fileAttachment = "")
    {
        string msg = string.Empty;
        try
        {
            //to = "sanjay@swarvandana.com";
            // to = "mohitdagar80@gmail.com";
            WebMail.SmtpServer = ConfigurationWrapper.SMTP_SERVER;
            WebMail.From = "chairman.svarvandana@gmail.com";
            WebMail.Password = "mercygod";
            WebMail.SmtpPort = ConfigurationWrapper.SMTP_PORT;
            WebMail.UserName = "chairman.svarvandana@gmail.com";
            var filesList = new string[] { fileAttachment };
            WebMail.EnableSsl = true;
            if (!string.IsNullOrEmpty(fileAttachment))
                WebMail.Send(to: to, bcc: bcc, subject: subject, body: body, isBodyHtml: true, filesToAttach: filesList);
            else
                WebMail.Send(to: to, bcc: bcc, subject: subject, body: body, isBodyHtml: true);
            msg = "Mail send successfully";
        }
        catch (Exception e)
        {
            msg = e.Message;
            //throw e;
        }
        return msg;
    }

    public static string BroadCastMail2(string to, string bcc, string subject, string body, string fileAttachment = "")
    {
        string msg = string.Empty;
        try
        {
            //to = "sanjay@swarvandana.com";
            // to = "mohitdagar80@gmail.com";
            WebMail.SmtpServer = ConfigurationWrapper.SMTP_SERVER;
            WebMail.From = "svarvandana@gmail.com";
            WebMail.Password = "svarvandana@123";
            WebMail.SmtpPort = ConfigurationWrapper.SMTP_PORT;
            WebMail.UserName = "svarvandana@gmail.com";
            var filesList = new string[] { fileAttachment };
            WebMail.EnableSsl = true;
            if (!string.IsNullOrEmpty(fileAttachment))
                WebMail.Send(to: to, bcc: bcc, subject: subject, body: body, isBodyHtml: true, filesToAttach: filesList);
            else
                WebMail.Send(to: to, bcc: bcc, subject: subject, body: body, isBodyHtml: true);
            msg = "Mail send successfully";
        }
        catch (Exception e)
        {
            msg = e.Message;
            //throw e;
        }
        return msg;
    }


}
