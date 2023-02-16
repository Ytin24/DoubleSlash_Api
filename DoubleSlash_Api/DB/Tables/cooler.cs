using System.ComponentModel.DataAnnotations;

namespace DoubleSlash_Api.DB.Tables
{
    public class Cooler
    {
        [Key]
        public int cooler_id { get; set; }
        public int tdp { get; set; }
    }
}
