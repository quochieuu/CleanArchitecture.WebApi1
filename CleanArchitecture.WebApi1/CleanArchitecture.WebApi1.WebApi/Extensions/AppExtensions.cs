using CleanArchitecture.WebApi1.WebApi.Middlewares;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.WebApi1.WebApi.Extensions
{
    public static class AppExtensions
    {
        public static void UseSwaggerExtension(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "CleanArchitecture.CleanArchitecture.WebApi1.WebApi");
            });
        }
        public static void UseErrorHandlingMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}
