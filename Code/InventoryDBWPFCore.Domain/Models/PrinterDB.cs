using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryDBWPFCore.Domain.Models
{
    [Table("Printers")]
    public class PrinterDB : DomainObject
    {
        //[Key]
        //[Column(Order = 0)]
        //public int PrinterId { get; set; }

        [Column(Order = 1)]
        public string PrinterTagNumber { get; set; }

        [Column(Order = 2)]
        public string PrinterName { get; set; }

        [Column(Order = 3)]
        public string PrinterMake { get; set; }

        [Column(Order = 4)]
        public string PrinterModel { get; set; }

        [Column(Order = 5)]
        public string PrinterSerialNumber { get; set; }

        [Column(Order = 6)]
        public string PrinterColorBlackWhite { get; set; }

        [Column(Order = 7)]
        public string PrinterCartridgeNumber { get; set; }
    }
}
