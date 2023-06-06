using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryDBWPFCore.Domain.Models
{
    [Table("OperatingSystems")]
    public class OperatingSystemDB : DomainObject
    {
        //[Key]
        //[Column(Order = 0)]
        //public int OperatingSystemId { get; set; }

        [Column(Order = 1)]
        public string OperatingSystemManufacturer { get; set; }

        [Column(Order = 2)]
        public string OperatingSystemName { get; set; }

        [Column(Order = 3)]
        public string OperatingSystemVersion { get; set; }

        [Column(Order = 4)]
        public string OperatingSystemType { get; set; }
    }
}
