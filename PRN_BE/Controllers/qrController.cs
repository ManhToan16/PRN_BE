using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PRN_BE.Models.Request;
using PRN_BE.Repositories;

namespace PRN_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class qrController : ControllerBase
    {
        private readonly IQrGenerateRepository _qrGenerateRepository;

        public qrController(IQrGenerateRepository qrGenerateRepository)
        {
            _qrGenerateRepository = qrGenerateRepository;
        }

        [HttpPost("generate")]
        public async Task<IActionResult> GenerateQRCode(BankInfoDTO bankInfo)
        {
            var response = await _qrGenerateRepository.QrGenerate(bankInfo);
            return response.StatusCode == 200 ? Ok(response) : BadRequest(response);
        }
    }
}
