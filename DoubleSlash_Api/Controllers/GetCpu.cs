﻿using DoubleSlash_Api.DB;
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
    }
}
