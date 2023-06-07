using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryDBWPFCore.EntityFramework.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeIdNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeDutyTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeLocation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HardDrives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HardDriveSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HardDriveType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HardDriveManufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HardDriveLocation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardDrives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Monitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonitorTagNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonitorMake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonitorModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonitorSerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonitorSize = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperatingSystems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperatingSystemManufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperatingSystemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperatingSystemVersion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperatingSystemType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingSystems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Printers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrinterTagNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrinterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrinterMake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrinterModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrinterSerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrinterColorBlackWhite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrinterCartridgeNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Printers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Processors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcessorMake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessorModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessorSpeed = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RAM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RamSlots = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RamSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RamMaxCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComputerTagNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComputerMake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComputerModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComputerSerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComputerVirtual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessorId = table.Column<int>(type: "int", nullable: false),
                    RAMId = table.Column<int>(type: "int", nullable: false),
                    HardDriveId = table.Column<int>(type: "int", nullable: false),
                    OperatingSystemId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Computers_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Computers_HardDrives_HardDriveId",
                        column: x => x.HardDriveId,
                        principalTable: "HardDrives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Computers_OperatingSystems_OperatingSystemId",
                        column: x => x.OperatingSystemId,
                        principalTable: "OperatingSystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Computers_Processors_ProcessorId",
                        column: x => x.ProcessorId,
                        principalTable: "Processors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Computers_RAM_RAMId",
                        column: x => x.RAMId,
                        principalTable: "RAM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Servers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServerTagNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServerMake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServerModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServerSerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServerVirtual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessorId = table.Column<int>(type: "int", nullable: false),
                    RAMId = table.Column<int>(type: "int", nullable: false),
                    HardDriveId = table.Column<int>(type: "int", nullable: false),
                    OperatingSystemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servers_HardDrives_HardDriveId",
                        column: x => x.HardDriveId,
                        principalTable: "HardDrives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Servers_OperatingSystems_OperatingSystemId",
                        column: x => x.OperatingSystemId,
                        principalTable: "OperatingSystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Servers_Processors_ProcessorId",
                        column: x => x.ProcessorId,
                        principalTable: "Processors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Servers_RAM_RAMId",
                        column: x => x.RAMId,
                        principalTable: "RAM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Computers_EmployeeId",
                table: "Computers",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_HardDriveId",
                table: "Computers",
                column: "HardDriveId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_OperatingSystemId",
                table: "Computers",
                column: "OperatingSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_ProcessorId",
                table: "Computers",
                column: "ProcessorId");

            migrationBuilder.CreateIndex(
                name: "IX_Computers_RAMId",
                table: "Computers",
                column: "RAMId");

            migrationBuilder.CreateIndex(
                name: "IX_Servers_HardDriveId",
                table: "Servers",
                column: "HardDriveId");

            migrationBuilder.CreateIndex(
                name: "IX_Servers_OperatingSystemId",
                table: "Servers",
                column: "OperatingSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_Servers_ProcessorId",
                table: "Servers",
                column: "ProcessorId");

            migrationBuilder.CreateIndex(
                name: "IX_Servers_RAMId",
                table: "Servers",
                column: "RAMId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computers");

            migrationBuilder.DropTable(
                name: "Monitors");

            migrationBuilder.DropTable(
                name: "Printers");

            migrationBuilder.DropTable(
                name: "Servers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "HardDrives");

            migrationBuilder.DropTable(
                name: "OperatingSystems");

            migrationBuilder.DropTable(
                name: "Processors");

            migrationBuilder.DropTable(
                name: "RAM");
        }
    }
}
