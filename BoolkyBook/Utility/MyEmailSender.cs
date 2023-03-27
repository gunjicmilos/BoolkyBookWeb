using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;
using MimeKit;

namespace BoolkyBook.Utility;

public class MyEmailSender : IEmailSender
{
    private readonly ILogger _logger;

    public MyEmailSender(ILogger<MyEmailSender> logger)
    {
        _logger = logger;
    }

    public Task SendEmailAsync(string email, string subject, string message)
    {
        _logger.LogInformation($"Sending email to {email}");
        // Add your email sending logic here
        return Task.CompletedTask;
    }
}