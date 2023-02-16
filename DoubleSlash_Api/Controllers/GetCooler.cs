using DoubleSlash_Api.DB;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DoubleSlash_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetCooler : ControllerBase {
        [HttpGet]
        public async Task<string> GetAll() {
            using (var db = new DoubleSlashDB()) {
                var coolerT = db.cooler.ToList();
                return JsonConvert.SerializeObject(coolerT);
            }
        }
        [HttpGet("{Tpd}")]
        public async Task<string> GetAllByTdp(int Tdp) {
            using (var db = new DoubleSlashDB()) {
                var coolerT = db.cooler.ToList().FindAll(x => x.tdp >= Tdp);
                return JsonConvert.SerializeObject(coolerT);
            }
        }
    }
}
