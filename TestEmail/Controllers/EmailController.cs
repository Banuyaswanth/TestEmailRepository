using MailKit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestEmail.Models;
using TestEmail.Services;

namespace TestEmail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly Services.IMailService _mailService;

        public EmailController(Services.IMailService mailService)
        {
            _mailService = mailService;
        }

        [HttpPost]
        public async Task<IActionResult> Send([FromBody] MailRequest mailRequest)
        {
            try
            {
                var result = await _mailService.SendEmailAsync(mailRequest);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
