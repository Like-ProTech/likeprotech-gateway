using System.Security.Claims;

namespace Likeprotech_gateway.Middlewares
{
    public class ClaimsHeaderMiddleware
    {
        private readonly RequestDelegate _next;
        public async Task Invoke(HttpContext context)
        {
            if(!(context.User.Identity is null))
            {
                Claim? userId = context.User.Claims.FirstOrDefault(c=>c.Type == ClaimsIdentity.DefaultNameClaimType); //NameIdentifier default claim
                if(userId is not null)
                {
                    context.Request.Headers["X-User-Id"] = userId.Value;
                }
                
            }
            await this._next(context);
        }
    }
}
