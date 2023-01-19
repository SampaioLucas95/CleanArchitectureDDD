using Microsoft.AspNetCore.Mvc.Filters;

namespace SolutionName.Api.Filter
{   
    public class ApplicationExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
           // Capturar exeptions e salver no elastic serach para analises posterior
        }
    }
}
