using System.ComponentModel.DataAnnotations;

namespace DoubleSlash_Api.DB.Tables
{
    public class Pb
    {
        [Key]
        public int pb_id { get; set; }
        public int watt { get; set; }
        public string name { get; set; }
    }
}
