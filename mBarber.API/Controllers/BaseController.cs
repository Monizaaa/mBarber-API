using System.Linq;
using System.Net.Http;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace mBarber.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Base")]
    public class BaseController : Controller
    {
        protected object ModelError()
        {
            var message = string.Join(" | ", ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => {
                    if (string.IsNullOrEmpty(e.ErrorMessage))
                    {
                        return e.Exception.Message;
                    }
                    else
                    {
                        return e.ErrorMessage;
                    }
                }));

            return JsonConvert.SerializeObject(new { status = 400, message });
        }
    }
}