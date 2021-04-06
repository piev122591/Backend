
//Add to class csproj
//<FrameworkReference Include = "Microsoft.AspNetCore.App"/>
using Microsoft.AspNetCore.Http; 
using Microsoft.AspNetCore.Hosting;
//=============================================================
using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using Maestro.Core.Exceptions;

namespace Maestro.Shared.Kernel.ErrorHandling
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, IWebHostEnvironment env)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex, env);
            }


        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception, IWebHostEnvironment env)
        {
            HttpStatusCode status;
            string message;
            var stackTrace = String.Empty;
            string result = string.Empty;

            var exceptionType = exception.GetType();

            if (exceptionType == typeof(BadRequestException))
            {
                message = exception.Message;
                status = HttpStatusCode.BadRequest;
                result = GetResult(null, message, stackTrace);

            }
            else if (exceptionType == typeof(NotFoundException))
            {
                message = exception.Message;
                status = HttpStatusCode.NotFound;

                result = GetResult(null, message, stackTrace);

            }
            else if (exceptionType == typeof(ValidationException))
            {
                message = exception.Message;

                status = HttpStatusCode.BadRequest;

                var err = exceptionType.GetProperty("Errors").GetValue(exception, null);

                result = GetResult(err, message, stackTrace);

            }
            else
            {
                status = HttpStatusCode.InternalServerError;
                message = exception.Message;

                if (env.EnvironmentName == "Development")
                    stackTrace = exception.StackTrace;

                result = GetResult(null, message, stackTrace);

            }


            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)status;

            return context.Response.WriteAsync(result);
        }

        private static string GetResult(object error, string errorMsg, string stackTrace)
        {

            return JsonSerializer.Serialize(new
            {
                errorMsg = errorMsg,
                error = error,
                stackTrace
            });
        }
    }
}
