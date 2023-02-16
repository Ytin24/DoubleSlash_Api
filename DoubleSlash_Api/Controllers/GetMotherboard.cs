using DoubleSlash_Api.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NpgsqlTypes;

namespace DoubleSlash_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetMotherboard : ControllerBase
    {
        [HttpGet]
        public async Task<string> GetAll()
        {
            using (var db = new DoubleSlashDB())
            {
                var chipsetT = db.chipset.ToList();
                var motherboardT = db.motherboard.ToList();
                return JsonConvert.SerializeObject(motherboardT);
            }
        }
        [HttpGet("{id}")]
        public async Task<string> GetAllByChipsetId(int id)
        {
            using (var db = new DoubleSlashDB())
            {
                var chipsetT = db.chipset.ToList();
                var motherboardT = db.motherboard.ToList().FindAll(x=>x.motherboard_id == id);
                return JsonConvert.SerializeObject(motherboardT);
            }
        }
    }
}
