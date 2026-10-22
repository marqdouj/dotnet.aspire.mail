using MimeKit;

namespace AspireMail.ApiService.Services
{
    internal record EmailServiceSettings(
        MailboxAddress Sender,
        List<MailboxAddress> ErrorRecipients,
        string? ConnectionString);
}
