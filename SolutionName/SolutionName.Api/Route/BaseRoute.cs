using Microsoft.AspNetCore.Mvc;

namespace SolutionName.Api.Route
{
    public class BaseRoute : RouteAttribute
    {
        public BaseRoute(string template = "") : base($"api/v1/{template}") { }
    }
}
