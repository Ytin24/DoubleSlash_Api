﻿using DoubleSlash_Api.DB;
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
            using (DoubleSlashDB db = new DoubleSlashDB())
            {
                var gpus = db.gpu.ToList();
                return JsonConvert.SerializeObject(gpus);
            }
        }
    }
}