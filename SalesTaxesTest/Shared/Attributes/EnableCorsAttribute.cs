using System.Web.Http.Filters;

namespace SalesTaxesTest.Shared.Attributes
{
    public class EnableCustomCorsAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            actionExecutedContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            actionExecutedContext.Response.Headers.Add("Access-Control-Allow-Methods", "POST");
        }
    }
}