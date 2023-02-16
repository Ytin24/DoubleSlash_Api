using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoubleSlash_Api.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class GetCpu : ControllerBase {
        [HttpGet()]
        public string GetAll(string a) {
            return a;
        }
    }
}
