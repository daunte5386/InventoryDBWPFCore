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
        public string ComputerProcessorMake { get; set; }

        [Column(Order = 7)]
        public string ComputerProcessorModel { get; set; }

        [Column(Order = 8)]
        public string ComputerProcessorSpeed { get; set; }

        [Column(Order = 9)]
        public string ComputerRAMSlots { get; set; }

        [Column(Order = 10)]
        public string ComputerRAMSize { get; set; }

        [Column(Order = 11)]
        public string ComputerRAMMaxCapacity { get; set; }

        [Column(Order = 12)]
        public string ComputerHardDriveCapacity{ get; set; }

        [Column(Order = 13)]
        public string ComputerHardDriveType { get; set; }

        [Column(Order = 14)]
        public string ComputerHardDriveManufacturer { get; set; }

        [Column(Order = 15)]
        public string ComputerHardDriveLocation { get; set; }

        [Column(Order = 16)]
        public string ComputerOperatingSystemManufacturer { get; set; }

        [Column(Order = 17)]
        public string ComputerOperatingSystemName { get; set; }

        [Column(Order = 18)]
        public string ComputerOperatingSystemVersion { get; set; }

        [Column(Order = 19)]
        public string ComputerOperatingSystemType { get; set; }

        [Column(Order = 20)]
        public string ComputerEmployeeName { get; set; }

        [Column(Order = 21)]
        public string ComputerEmployeePhoneNumber { get; set; }

        [Column(Order = 22)]
        public string ComputerEmployeeLocation { get; set; }

        [Column(Order = 23)]
        public string ComputerVirtual { get; set; }

        [Column(Order = 24)]
        public string ComputerVirtualHomeServer { get; set; }
    }
}

