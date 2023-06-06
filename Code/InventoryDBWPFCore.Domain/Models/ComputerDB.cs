using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryDBWPFCore.Domain.Models
{
    [Table("Computers")]
    public class ComputerDB : DomainObject
    {
        //[Key]
        //[Column(Order = 0)]
        //public int ComputerId { get; set; }

        [Column(Order = 1)]
        public string ComputerTagNumber { get; set; }

        [Column(Order = 2)]
        public string ComputerName { get; set; }

        [Column(Order = 3)]
        public string ComputerMake { get; set; }

        [Column(Order = 4)]
        public string ComputerModel { get; set; }

        [Column(Order = 5)]
        public string ComputerSerialNumber { get; set; }

        [Column(Order = 6)]
        public string ComputerVirtual { get; set; }

        [ForeignKey("Processors")]
        [Column(Order = 7)]
        public int ProcessorId { get; set; }
        public ProcessorDB Processor { get; set; }

        [ForeignKey("RAM")]
        [Column(Order = 8)]
        public int RAMId { get; set; }
        public RamDB Ram { get; set; }

        [ForeignKey("HardDrives")]
        [Column(Order = 9)]
        public int HardDriveId { get; set; }
        public HardDriveDB HardDrive { get; set; }

        [ForeignKey("OperatingSystems")]
        [Column(Order = 10)]
        public int OperatingSystemId { get; set; }
        public OperatingSystemDB OperatingSystem { get; set; }

        [ForeignKey("Employee")]
        [Column(Order = 11)]
        public int EmployeeId { get; set; }
        public EmployeeDB Employee { get; set; }
    }
}
