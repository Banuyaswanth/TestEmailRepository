namespace TestEmail.Models
{
    public class MailRequest
    {
        public string To { get; set; } = null!;
        public string? Subject { get; set; }
        public string? Body { get; set; }
    }
}
