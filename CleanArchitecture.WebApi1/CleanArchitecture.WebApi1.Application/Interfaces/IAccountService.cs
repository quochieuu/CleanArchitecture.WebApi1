using CleanArchitecture.WebApi1.Application.DTOs.Account;
using CleanArchitecture.WebApi1.Application.Wrappers;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.WebApi1.Application.Interfaces
{
    public interface IAccountService
    {
        Task<Response<AuthenticationResponse>> AuthenticateAsync(AuthenticationRequest request, string ipAddress);
        Task<Response<string>> RegisterAsync(RegisterRequest request, string origin);
        Task<Response<string>> ConfirmEmailAsync(string userId, string code);
        Task ForgotPassword(ForgotPasswordRequest model, string origin);
        Task<Response<string>> ResetPassword(ResetPasswordRequest model);
    }
}
