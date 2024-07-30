using System.Net.Mail;
using System.Net;


namespace CityInfo.API.Services
{
    public class CloudMailService : IMailService
    {
        private string _mailTo = string.Empty;
        private string _mailFrom = string.Empty;

        public CloudMailService(IConfiguration configuration)
        {
            _mailTo = configuration["mailSettings:mailToAddress"];
            _mailFrom = configuration["mailSettings:mailFromAddress"];
        }


        public void Send(string subject, string message)
        {
            // send mail - output to console window
            Console.WriteLine($"Mail from {_mailFrom} to {_mailTo}, with {nameof(CloudMailService)}.");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Message: {message}");
        }

        //var client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
        //{
        //    Credentials = new NetworkCredential("d0ec4d1ebe9c9a", "********3637"),
        //    EnableSsl = true
        //};

        //client.Send("from@example.com", "to@example.com", "Hello world", "testbody");
        //System.Console.WriteLine("Sent");
        //}
    }
}
