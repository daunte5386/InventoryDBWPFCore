using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryDBWPFCore.Domain.Models
{
    [Table("RAM")]
    public class RamDB : DomainObject
    {
        //[Key]
        //[Column(Order = 0)]
        //public int RamId { get; set; }

        [Column(Order = 1)]
        public string RamSlots { get; set; }

        [Column(Order = 2)]
        public string RamSize { get; set; }

        [Column(Order = 3)]
        public string RamMaxCapacity { get; set; }
    }
}
