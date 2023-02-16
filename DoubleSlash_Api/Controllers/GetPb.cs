using DoubleSlash_Api.DB;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DoubleSlash_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetPb : ControllerBase {
        [HttpGet]
        public async Task<string> GetAll() {
            using (var db = new DoubleSlashDB()) {
                var pbT = db.pb.ToList();
                return JsonConvert.SerializeObject(pbT);
            }
        }
        [HttpGet("{Watt}")]
        public async Task<string> GetAllByTdp(int Watt) {
            using (var db = new DoubleSlashDB()) {
                var pbT = db.pb.ToList().FindAll(x => x.watt >= Watt + 300);
                return JsonConvert.SerializeObject(pbT);
            }
        }
    }
}
