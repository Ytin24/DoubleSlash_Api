using DoubleSlash_Api.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

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
                var motherboardT = db.motherboard.ToList();
                return JsonConvert.SerializeObject(motherboardT);
            }
        }

        // Попытка стоящая
        [Route("ByChipsetId")]
        [HttpGet]
        public async Task<string> GetAllByChipsetId(int id)
        {
            using (var db = new DoubleSlashDB())
            {
                var motherboardT = db.motherboard.FromSqlRaw($"SELECT * FROM motherboard WHERE motherboard_id = {id}");
                return JsonConvert.SerializeObject(motherboardT);
            }
        }
    }
}
