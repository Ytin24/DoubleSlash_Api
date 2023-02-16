using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoubleSlash_Api.DB.Tables
{
    public class Motherboard
    {
        [Key]
        public int motherboard_id { get; set; }

        [ForeignKey("chipset_id")]
        public Chipset chipset { get; set; }
        public string memory { get; set; }
        public string motherboard_name { get; set; }
    }
}
