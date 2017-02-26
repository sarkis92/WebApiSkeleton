using System.Web.Http;
using WebApplication.Services.Services;
using WebApplication.Utils.Extensions;

namespace WebApplication.Controllers.V1
{
    public class ValuesController : ApiController
    {
        private readonly IValuesService _service;
        public ValuesController(IValuesService service)
        {
            service.ThrowIfNull(nameof(service));

            _service = service;
        }

        public IHttpActionResult Get()
        {
            return Ok($"{_service.GetValue()} V1");
        }
    }
}
