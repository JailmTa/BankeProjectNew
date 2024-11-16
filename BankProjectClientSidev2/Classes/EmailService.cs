using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BankProjectClientSidev2.Classes
{
    public class SendEmailRequest
    {
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public int Res { get; set; }
    }

    public class EmailService
    {
        private readonly static string _fromEmail = "jylmtlyt@gmail.com"; // Replace with your email
        private readonly static string _appPassword = "tics daqi balu qdyp";  // Replace with App Password

        private static int MakeRandowmNumber()
        {
            Random rand = new Random();
            int Num = rand.Next(100000, 1000000);
            return Num;
        }

        public static void SendEmail(SendEmailRequest request)
        {
            var fromAddress = new MailAddress(_fromEmail, "Jailm Taleea");
            var toAddress = new MailAddress(request.ToEmail);

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_fromEmail, _appPassword)
            };

            int Num = MakeRandowmNumber();


            // Use the external image URL in the HTML body, centered and resized
            var htmlBody = $@"
           <html>
<body style=""font-family: Arial, sans-serif; text-align: center; color: #333;"">
    <div style=""margin: 20px auto; width: 80%; max-width: 600px; border: 1px solid #e0e0e0; padding: 20px; border-radius: 8px;"">
        <div style=""text-align: center; margin-bottom: 20px;"">
            <img src=""https://img.freepik.com/free-vector/finances_53876-36636.jpg?semt=ais_hybrid"" alt=""King"" style=""width: 150px; height: auto;"" />
        </div>
        <h2 style=""color: #6c2dc7;"">Welcome back!</h2>
        <p>Use the verification code below to log in.</p>
        <div style=""font-size: 24px; font-weight: bold; padding: 15px; background-color: #f0f0f0; display: inline-block; border-radius: 8px;"">
            {Num}
        </div>
        <p style=""color: #999; margin-top: 20px; font-size: 12px;"">
            You received this email because you requested to log in to your account. If you didn’t request to log in, you can safely ignore this email.
        </p>
    </div>
</body>
</html>
";

            // Send the email
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = request.Subject,
                Body = htmlBody,
                IsBodyHtml = true
            })
            {
                request.Res = Num;
                smtp.Send(message);
            }
        }
    }


}
