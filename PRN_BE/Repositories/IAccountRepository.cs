using Microsoft.AspNetCore.Identity;
using PRN_BE.Models.Request;
using PRN_BE.Models.Response;

namespace PRN_BE.Repositories
{
    public interface IAccountRepository
    {
        public Task<BaseDataResponse<IdentityResult>> SignUpAsync(SignUpModel model);
        public Task<BaseDataResponse<string>> SignInAsync(SignInModel model);
        public Task<BaseDataResponse<string>> UpdateProfile(UserModel model);
        public Task<BaseDataResponse<string>> UpdatePassword(PasswordModel model);
        public Task<BaseDataResponse<UserModel>> GetUser();
        public Task<BaseDataResponse<string>> CreateHostByEmail(UserModel model);
        public Task<BaseDataResponse<string>> UploadAvatar(UploadModel model);
    }
}
