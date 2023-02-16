using DoubleSlash_Api.DB;
using DoubleSlash_Api.DB.Tables;
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
            using (var db = new DoubleSlashDB())
            {
                var cpuT = db.cpu.ToList();
                return JsonConvert.SerializeObject(cpuT);
            }
        }
        [HttpGet("{id}")]
        public async Task<string> GetAllByChipsetId(int id) {
            using (var db = new DoubleSlashDB()) {
                var chipsetT = db.chipset.ToList();
                var cpuT = db.cpu.ToList().FindAll(x => x.cpu_id == id);
                return JsonConvert.SerializeObject(cpuT);
            }
        }
    }
}
