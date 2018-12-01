using System.Web.Http.Filters;

namespace SalesTaxesTest.Shared.Attributes
{
    public class EnableCorsAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            actionExecutedContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
        }
    }
}