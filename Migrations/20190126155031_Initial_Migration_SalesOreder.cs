using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace netcore.Migrations
{
    public partial class Initial_Migration_SalesOreder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "picCustomer",
                table: "SalesOrder");

            migrationBuilder.DropColumn(
                name: "picInternal",
                table: "SalesOrder");

            migrationBuilder.DropColumn(
                name: "referenceNumberExternal",
                table: "SalesOrder");

            migrationBuilder.RenameColumn(
                name: "referenceNumberInternal",
                table: "SalesOrder",
                newName: "vehicleNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "vehicleNumber",
                table: "SalesOrder",
                newName: "referenceNumberInternal");

            migrationBuilder.AddColumn<string>(
                name: "picCustomer",
                table: "SalesOrder",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "picInternal",
                table: "SalesOrder",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "referenceNumberExternal",
                table: "SalesOrder",
                maxLength: 30,
                nullable: true);
        }
    }
}
