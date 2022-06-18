using CleanArchitecture.WebApi1.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CleanArchitecture.WebApi1.Infrastructure.Shared.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}
