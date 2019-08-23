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
        public bool IsNational { get; set; }
        public string City { get; set; }
    }
}