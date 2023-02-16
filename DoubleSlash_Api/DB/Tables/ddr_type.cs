using System.ComponentModel.DataAnnotations;

namespace DoubleSlash_Api.DB.Tables
{
    public class DdrType
    {
        [Key]
        public int ddr_id { get; set; }
        public int ddr_model { get; set; }
        public int freq { get; set; }
    }
}
