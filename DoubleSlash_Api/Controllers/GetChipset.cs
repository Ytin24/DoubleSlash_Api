using DoubleSlash_Api.DB;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DoubleSlash_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetChipset : ControllerBase
    {
        [HttpGet]
        public async Task<string> GetAll()
        {
            using (var db = new DoubleSlashDB())
            {
                var DdrT = db.ddr_type.ToList();
                var chipsetT = db.chipset.ToList();
                return JsonConvert.SerializeObject(chipsetT);
            }
        }
        [HttpGet("{Id}")]
        public async Task<string> GetAllByDdrId(int Id) {
            using (var db = new DoubleSlashDB()) {
                var DdrT = db.ddr_type.ToList();
                var chipsetT = db.chipset.ToList().FindAll(x=> x.ddr_id == Id);
                return JsonConvert.SerializeObject(chipsetT);
            }
        }
    }
}
