using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoubleSlash_Api.DB.Tables {
    public class Cpu {
        [Key]
        public int cpu_id { get; set; }
        public string cpu{ get; set;}
        public int tdp { get; set; }
        public int chipset_id { get; set; }
        [ForeignKey("chipset_id")]
        public Chipset chipset { get; set; }
        public int power { get; set; }

    }
}
