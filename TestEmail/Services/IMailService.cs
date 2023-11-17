using TestEmail.Models;

namespace TestEmail.Services
{
    public interface IMailService
    {
        Task<Object> SendEmailAsync(MailRequest mailRequest);
    }
}
