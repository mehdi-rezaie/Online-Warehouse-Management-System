using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace netcore.Migrations
{
    public partial class Intitial_Migration_AllSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "city",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "country",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "province",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "street1",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "street2",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "vendorInvoice",
                table: "Receiving");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "Warehouse",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "country",
                table: "Warehouse",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "province",
                table: "Warehouse",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "street1",
                table: "Warehouse",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "street2",
                table: "Warehouse",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "vendorInvoice",
                table: "Receiving",
                maxLength: 50,
                nullable: true);
        }
    }
}
