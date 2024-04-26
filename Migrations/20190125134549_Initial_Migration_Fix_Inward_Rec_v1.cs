using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace netcore.Migrations
{
    public partial class Initial_Migration_Fix_Inward_Rec_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "height",
                table: "PurchaseOrder");

            migrationBuilder.DropColumn(
                name: "thickness",
                table: "PurchaseOrder");

            migrationBuilder.DropColumn(
                name: "width",
                table: "PurchaseOrder");

            migrationBuilder.AddColumn<decimal>(
                name: "height",
                table: "ReceivingLine",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "thickness",
                table: "ReceivingLine",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<float>(
                name: "weight",
                table: "ReceivingLine",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<decimal>(
                name: "width",
                table: "ReceivingLine",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "height",
                table: "PurchaseOrderLine",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "thickness",
                table: "PurchaseOrderLine",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<float>(
                name: "weight",
                table: "PurchaseOrderLine",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<decimal>(
                name: "width",
                table: "PurchaseOrderLine",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "height",
                table: "ReceivingLine");

            migrationBuilder.DropColumn(
                name: "thickness",
                table: "ReceivingLine");

            migrationBuilder.DropColumn(
                name: "weight",
                table: "ReceivingLine");

            migrationBuilder.DropColumn(
                name: "width",
                table: "ReceivingLine");

            migrationBuilder.DropColumn(
                name: "height",
                table: "PurchaseOrderLine");

            migrationBuilder.DropColumn(
                name: "thickness",
                table: "PurchaseOrderLine");

            migrationBuilder.DropColumn(
                name: "weight",
                table: "PurchaseOrderLine");

            migrationBuilder.DropColumn(
                name: "width",
                table: "PurchaseOrderLine");

            migrationBuilder.AddColumn<decimal>(
                name: "height",
                table: "PurchaseOrder",
                maxLength: 30,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "thickness",
                table: "PurchaseOrder",
                maxLength: 30,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "width",
                table: "PurchaseOrder",
                maxLength: 30,
                nullable: false,
                defaultValue: 0m);
        }
    }
}
