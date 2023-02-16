using System.ComponentModel.DataAnnotations;

namespace DoubleSlash_Api.DB.Tables
{
    public class Gpu
    {
        [Key]
        public int videocard_id { get; set; }
        public string gpu_name { get; set; }
        public int tdp { get; set; }
        public int power { get; set; }
    }
}
