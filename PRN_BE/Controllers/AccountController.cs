using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PRN_BE.Models.Request;
using PRN_BE.Models.Response;
using PRN_BE.Repositories;

namespace PRN_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _accountRepo;

        public AccountController(IAccountRepository repo)
        {
            _accountRepo = repo;
        }

        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp(SignUpModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(
                    new BaseDataResponse<object>(
                        statusCode: 400,
                        message: "Invalid model data",
                        data: ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage)
                    )
                );
            }

            if (model.password != model.confirm_password)
            {
                return BadRequest(
                    new BaseDataResponse<object>(
                        statusCode: 400,
                        message: "Password and Confirm Password do not match."
                    )
                );
            }

            var result = await _accountRepo.SignUpAsync(model);
            if (result.StatusCode == 200)
            {
                return Ok(result);
            }

            return BadRequest(
                new BaseDataResponse<object>(
                    statusCode: result.StatusCode,
                    message: result.Message ?? "Unknown error",
                    data: result.Data
                )
            );
        }


        [HttpPost("SignIn")]
        public async Task<IActionResult> SignIn(SignInModel model)
        {
            var response = await _accountRepo.SignInAsync(model);
            if (response.StatusCode == 400)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [Authorize]
        [HttpPost("UpdateProf")]
        public async Task<IActionResult> UpdateProfile(UserModel model)
        {
            var response = await _accountRepo.UpdateProfile(model);
            return response.StatusCode == 200 ? Ok(response) : BadRequest(response);
        }

        [Authorize]
        [HttpPost("ChgPwd")]
        public async Task<IActionResult> UpdatePassword(PasswordModel model)
        {
            var response = await _accountRepo.UpdatePassword(model);
            return response.StatusCode == 200 ? Ok(response) : BadRequest(response);
        }

        [Authorize]
        [HttpGet("Profile")]
        public async Task<IActionResult> GetProfile()
        {
            var response = await _accountRepo.GetUser();
            return response.StatusCode == 200 ? Ok(response) : BadRequest(response);
        }

        [Authorize]
        [HttpPost("CreateHost")]
        public async Task<IActionResult> CreateHost(UserModel model)
        {
            var response = await _accountRepo.CreateHostByEmail(model);
            return response.StatusCode == 200 ? Ok(response) : BadRequest(response);
        }

        [Authorize]
        [HttpPost("Upload")]
        public async Task<IActionResult> Upload([FromForm] UploadModel model)
        {
            var response = await _accountRepo.UploadAvatar(model);
            return response.StatusCode == 200 ? Ok(response) : BadRequest(response);
        }
    }
}
