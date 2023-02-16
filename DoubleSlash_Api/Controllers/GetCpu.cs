using DoubleSlash_Api.DB;
using DoubleSlash_Api.DB.Tables;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace DoubleSlash_Api.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class GetCpu : ControllerBase {
        
        [HttpGet()]
        public async Task<string> GetAll() {
            using (DoubleSlashDB dB = new DoubleSlashDB()) {
                var abc = dB.chipset.ToList();
                var users = dB.cpu.ToList();
                return JsonConvert.SerializeObject(users);
            }
        }
    }
}
