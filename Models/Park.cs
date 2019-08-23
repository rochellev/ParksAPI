using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ParksAPI.Models
{
    [Table("parks")]
    public class Park
    {
        [Key]
        public int ParkId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Area { get; set; }
        public string URL {get; set;}
    }
}