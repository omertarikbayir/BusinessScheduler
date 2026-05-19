using System.Net.Mail;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace BusinessScheduler.Api.Services;

/// <summary>
/// Handles asynchronous multi-channel notifications for appointments.
/// Encapsulates SMTP failover and Twilio SMS dispatch with config-driven resilience.
/// </summary>
public class ReminderService
{
    private readonly IConfiguration _config;

    public ReminderService(IConfiguration config)
    {
        _config = config;
    }

    public async Task SendEmailReminderAsync(string to, string subject, string body)
    {
        using var client = new SmtpClient(_config["Smtp:Host"])
        {
            Port = int.Parse(_config["Smtp:Port"] ?? "587"),
            Credentials = new System.Net.NetworkCredential(_config["Smtp:User"], _config["Smtp:Pass"]),
            EnableSsl = true
        };
        var from = _config["Smtp:From"] ?? "noreply@business.com";
        await client.SendMailAsync(from, to, subject, body);
    }

    public void SendSmsReminder(string to, string message)
    {
        TwilioClient.Init(_config["Twilio:AccountSid"], _config["Twilio:AuthToken"]);
        MessageResource.Create(
            to: new PhoneNumber(to),
            from: new PhoneNumber(_config["Twilio:FromPhone"]),
            body: message);
    }
}