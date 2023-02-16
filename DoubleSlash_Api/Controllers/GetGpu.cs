using DoubleSlash_Api.DB;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DoubleSlash_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetGpu : ControllerBase
    {
        [HttpGet]
        public async Task<string> GetAll()
        {
            using (var db = new DoubleSlashDB())
            {
                var gpuT = db.gpu.ToList();
                return JsonConvert.SerializeObject(gpuT);
            }
        }
        [HttpGet]
        public async Task<string> GetAllByPower(int Power) {
            using (var db = new DoubleSlashDB()) {
                var gpuT = db.gpu.ToList().FindAll(
                    x => x.power >= Power - 20 
                    && x.power <= Power + 20);
                return JsonConvert.SerializeObject(gpuT);
            }
        }
    }
}
