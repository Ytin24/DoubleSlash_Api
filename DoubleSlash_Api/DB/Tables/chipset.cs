using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoubleSlash_Api.DB.Tables {
    public class Chipset {
        [Key]
        public int chipset_id { get; set; }

        [ForeignKey("ddr_id")]
        public DdrType ddr_type { get; set; }
        public string chipset_name { get; set; }
    }
}
