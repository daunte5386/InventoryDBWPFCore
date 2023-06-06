using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryDBWPFCore.Domain.Models
{
    [Table("Monitors")]
    public class MonitorDB : DomainObject
    {
        //[Key]
        //[Column(Order = 0)]
        //public int MonitorId { get; set; }

        [Column(Order = 1)]
        public string MonitorTagNumber { get; set; }

        [Column(Order = 2)]
        public string MonitorMake { get; set; }

        [Column(Order = 3)]
        public string MonitorModel { get; set; }

        [Column(Order = 4)]
        public string MonitorSerialNumber { get; set; }

        [Column(Order = 5)]
        public string MonitorSize { get; set; }
    }
}
