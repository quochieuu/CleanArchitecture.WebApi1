using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.WebApi1.Application.Interfaces
{
    public interface IAuthenticatedUserService
    {
        string UserId { get; }
    }
}
