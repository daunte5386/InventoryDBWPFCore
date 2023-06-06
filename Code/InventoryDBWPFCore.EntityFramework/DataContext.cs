using InventoryDBWPFCore.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryDBWPFCore.EntityFramework
{
    public class DataContext : DbContext
    {     
        public DbSet<ComputerDB> Computers { get; set; }
        public DbSet<EmployeeDB> Employees { get; set; }
        public DbSet<HardDriveDB> HardDrives { get; set; }
        public DbSet<MonitorDB> Monitors { get; set; }
        public DbSet<OperatingSystemDB> OperatingSystems { get; set; }
        public DbSet<PrinterDB> Printers { get; set; }
        public DbSet<ProcessorDB> Processors { get; set; }
        public DbSet<RamDB> Rams { get; set; }
        public DbSet<ServerDB> Servers { get; set; }
        public DbSet<UserDB> Users { get; set; }    
        public DataContext(DbContextOptions options) : base(options) { }           
    }
}
