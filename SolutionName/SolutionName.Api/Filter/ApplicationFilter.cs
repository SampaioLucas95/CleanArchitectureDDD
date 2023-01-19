using Microsoft.AspNetCore.Mvc.Filters;

namespace SolutionName.Api.Filter
{   
    public class ApplicationFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {           
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}
