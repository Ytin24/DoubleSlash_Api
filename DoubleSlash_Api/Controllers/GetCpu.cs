using DoubleSlash_Api.DB;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DoubleSlash_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetCpu : ControllerBase
    {
        [HttpGet]
        public async Task<string> GetAll()
        {
            using (DoubleSlashDB dB = new DoubleSlashDB())
            {
                var cpus = dB.cpu.ToList();
                return JsonConvert.SerializeObject(cpus);
            }
        }
    }
}
