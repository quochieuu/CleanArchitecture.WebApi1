using CleanArchitecture.WebApi1.Application.DTOs.Email;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.WebApi1.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendAsync(EmailRequest request);
    }
}
