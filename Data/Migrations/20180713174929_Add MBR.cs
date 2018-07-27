using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CloudAssign4.Data.Migrations
{
    public partial class AddMBR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employers",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrokerId = table.Column<int>(nullable: false),
                    Employeename = table.Column<int>(nullable: false),
                    Employeeposition = table.Column<string>(nullable: true),
                    Employeesalary = table.Column<int>(nullable: false),
                    Employeeyear = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employers", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Insurances",
                columns: table => new
                {
                    Insuranceid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrokerId = table.Column<int>(nullable: false),
                    InsurancePolicyNumber = table.Column<int>(nullable: false),
                    Insurancevalue = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurances", x => x.Insuranceid);
                });

            migrationBuilder.CreateTable(
                name: "MBRs",
                columns: table => new
                {
                    Applicationid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Applicationstatus = table.Column<bool>(nullable: false),
                    Custaddress = table.Column<string>(nullable: true),
                    Custname = table.Column<string>(nullable: true),
                    Custphone = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false),
                    Employeename = table.Column<int>(nullable: false),
                    Employeeposition = table.Column<string>(nullable: true),
                    Employeesalary = table.Column<int>(nullable: false),
                    Employeeyear = table.Column<int>(nullable: false),
                    EmployerName = table.Column<string>(nullable: true),
                    InsurancePolicyNumber = table.Column<int>(nullable: false),
                    Insuranceid = table.Column<int>(nullable: false),
                    Insurancevalue = table.Column<int>(nullable: false),
                    LifeInsuranceName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MBRs", x => x.Applicationid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employers");

            migrationBuilder.DropTable(
                name: "Insurances");

            migrationBuilder.DropTable(
                name: "MBRs");
        }
    }
}
