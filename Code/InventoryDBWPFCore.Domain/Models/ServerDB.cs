using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryDBWPFCore.Domain.Models
{
    [Table("Servers")]
    public class ServerDB : DomainObject
    {
        //[Key]
        //[Column(Order = 0)]
        //public int ServerId { get; set; }

        [Column(Order = 1)]
        public string ServerTagNumber { get; set; }

        [Column(Order = 2)]
        public string ServerName { get; set; }

        [Column(Order = 3)]
        public string ServerMake { get; set; }

        [Column(Order = 4)]
        public string ServerModel { get; set; }

        [Column(Order = 5)]
        public string ServerSerialNumber { get; set; }

        [Column(Order = 6)]
        public string ServerVirtual { get; set; }

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
    }
}
