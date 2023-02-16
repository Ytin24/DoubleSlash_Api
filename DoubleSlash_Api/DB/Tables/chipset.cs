using System.ComponentModel.DataAnnotations;

namespace DoubleSlash_Api.DB.Tables {
    public class Chipset {
        [Key]
        public int chipset_id { get; set; }
        public string name_chipset { get; set; }
    }
}
