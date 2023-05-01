using Microsoft.AspNetCore.Mvc.Filters;

namespace CleanArchitecture.API.Filters;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AuthFilterAttribute : Attribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        
        //throw new NotImplementedException();
    }
}

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class ActionFilterAttribute : Attribute, IActionFilter
{
    public void OnActionExecuted(ActionExecutedContext context)
    {
        //throw new NotImplementedException();
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        //throw new NotImplementedException();
    }
}

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class ResultFilterAtribute : Attribute, IResultFilter
{
    public void OnResultExecuted(ResultExecutedContext context)
    {
        //throw new NotImplementedException();
    }

    public void OnResultExecuting(ResultExecutingContext context)
    {
        //throw new NotImplementedException();
    }
}

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class ExceptionFilterAttribute : Attribute, IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        //throw new NotImplementedException();
    }
}

