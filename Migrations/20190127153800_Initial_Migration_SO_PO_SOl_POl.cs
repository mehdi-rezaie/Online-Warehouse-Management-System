using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace netcore.Migrations
{
    public partial class Initial_Migration_SO_PO_SOl_POl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "batchNumber",
                table: "SalesOrderLine",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "height",
                table: "SalesOrderLine",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "palletBundle",
                table: "SalesOrderLine",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "thickness",
                table: "SalesOrderLine",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<float>(
                name: "weight",
                table: "SalesOrderLine",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<decimal>(
                name: "width",
                table: "SalesOrderLine",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "batchNumber",
                table: "PurchaseOrderLine",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "palletBundle",
                table: "PurchaseOrderLine",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "batchNumber",
                table: "SalesOrderLine");

            migrationBuilder.DropColumn(
                name: "height",
                table: "SalesOrderLine");

            migrationBuilder.DropColumn(
                name: "palletBundle",
                table: "SalesOrderLine");

            migrationBuilder.DropColumn(
                name: "thickness",
                table: "SalesOrderLine");

            migrationBuilder.DropColumn(
                name: "weight",
                table: "SalesOrderLine");

            migrationBuilder.DropColumn(
                name: "width",
                table: "SalesOrderLine");

            migrationBuilder.DropColumn(
                name: "batchNumber",
                table: "PurchaseOrderLine");

            migrationBuilder.DropColumn(
                name: "palletBundle",
                table: "PurchaseOrderLine");
        }
    }
}
