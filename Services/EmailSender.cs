using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace KSIMonitor.Services {
    public interface IEmailSender : Microsoft.AspNetCore.Identity.UI.Services.IEmailSender {
        Task SendEmailAsync(string email, string name, string subject, string htmlMessage);
        Task SendEmailAsync(string toEmail, string toName, string fromEmail, string fromName, string subject, string htmlMessage);
    }

    public class EmailSenderOptions {
        public const string SectionName = "SendGrid";
        public string APIKey { get; set; }
        public string FromEmail { get; set; }
        public string FromName { get; set; }
    }

    public class EmailSender : IEmailSender {
        private readonly ILogger<EmailSender> logger;
        private readonly EmailSenderOptions options;

        public EmailSender(ILogger<EmailSender> logger, IOptions<EmailSenderOptions> optionsAccessor) {
            this.logger = logger;
            this.options = optionsAccessor.Value;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage) =>
            send(subject: subject, fromEmail: options.FromEmail, fromName: options.FromName, toEmail: email, toName: null, plainMessage: null, htmlMessage: htmlMessage);
        public Task SendEmailAsync(string email, string name, string subject, string htmlMessage) =>
            send(subject: subject, fromEmail: options.FromEmail, fromName: options.FromName, toEmail: email, toName: name, plainMessage: null, htmlMessage: htmlMessage);
        public Task SendEmailAsync(string toEmail, string toName, string fromEmail, string fromName, string subject, string htmlMessage) =>
            send(subject: subject, fromEmail: fromEmail, fromName: fromName, toEmail: toEmail, toName: toName, plainMessage: null, htmlMessage: htmlMessage);

        private async Task send(string subject, string fromEmail, string fromName, string toEmail, string toName, string plainMessage, string htmlMessage) {
            var client = new SendGridClient(options.APIKey);
            var request = new SendGridMessage() {
                Subject = subject,
                From = new EmailAddress(fromEmail, fromName),
                PlainTextContent = plainMessage,
                HtmlContent = htmlMessage,
            };
            request.AddTo(new EmailAddress(toEmail, toName));

            var response = await client.SendEmailAsync(request);

            if (response.IsSuccessStatusCode) {
                logger.LogInformation("Email successfully sent");
            } else {
                logger.LogError("Error sending email to {to}: StatusCode: {status}, Error Message: {message}",
                    toEmail, response.StatusCode, await response.Body.ReadAsStringAsync());
            }
        }
    }
}
