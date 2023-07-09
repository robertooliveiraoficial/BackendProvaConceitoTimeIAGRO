using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BooksManager.Attributes
{
    /// <summary>
    /// 
    /// </summary>
    [AttributeUsage(validOn: AttributeTargets.Class | AttributeTargets.Method)]
    public class ApiKeyAttribute : Attribute, IAsyncActionFilter
    {        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="next"></param>
        /// <returns></returns>
        public async Task OnActionExecutionAsync(
            ActionExecutingContext context,
            ActionExecutionDelegate next)
        {
            var _config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var apiKeyName = _config.GetValue<string>("ApiConfiguration:ApiKeyName");
            var apiKey = _config.GetValue<string>("ApiConfiguration:ApiKey");


            if (!context.HttpContext.Request.Query.TryGetValue(apiKeyName, out var extractedApiKey))
            {
                context.Result = new ContentResult()
                {
                    StatusCode = 401,
                    Content = "ApiKey não encontrada"
                };
                return;
            }


            if (!apiKey.Equals(extractedApiKey))
            {
                context.Result = new ContentResult()
                {
                    StatusCode = 403,
                    Content = "Acesso não autorizado"
                };
                return;
            }

            await next();
        }
    }
}
