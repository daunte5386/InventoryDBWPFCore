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
        public string ServerProcessorMake { get; set; }

        [Column(Order = 7)]
        public string ServerProcessorModel { get; set; }

        [Column(Order = 8)]
        public string ServerProcessorSpeed { get; set; }

        [Column(Order = 9)]
        public string ServerProcessorNumberOf { get; set; }

        [Column(Order = 10)]
        public string ServerRAMSlots { get; set; }

        [Column(Order = 11)]
        public string ServerRAMSize { get; set; }

        [Column(Order = 12)]
        public string ServerRAMMaxCapacity { get; set; }

        [Column(Order = 13)]
        public string ServerHardDriveType { get; set; }

        [Column(Order = 14)]
        public string ServerHardDriveCapacity { get; set; }

        [Column(Order = 15)]
        public string ServerHardDriveRAIDType { get; set; }

        [Column(Order = 16)]
        public string ServerHardDriveManufacturer { get; set; }

        [Column(Order = 17)]
        public string ServerOperatingSystemManufacturer { get; set; }

        [Column(Order = 18)]
        public string ServerOperatingSystemName { get; set; }

        [Column(Order = 19)]
        public string ServerOperatingSystemVersion { get; set; }

        [Column(Order = 20)]
        public string ServerOperatingSystemType { get; set; }

        [Column(Order = 21)]
        public string ServerLocation { get; set; }

        [Column(Order = 22)]
        public string ServerVirtual { get; set; }

        [Column(Order = 23)]
        public string ServerVirtualHomeServer { get; set; }
    }
}
