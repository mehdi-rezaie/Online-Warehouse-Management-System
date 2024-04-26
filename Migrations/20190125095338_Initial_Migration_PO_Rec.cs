using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace netcore.Migrations
{
    public partial class Initial_Migration_PO_Rec : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrder_Vendor_vendorId",
                table: "PurchaseOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_Receiving_Vendor_vendorId",
                table: "Receiving");

            migrationBuilder.DropIndex(
                name: "IX_Receiving_vendorId",
                table: "Receiving");

            migrationBuilder.DropColumn(
                name: "vendorId",
                table: "Receiving");

            migrationBuilder.DropColumn(
                name: "picInternal",
                table: "PurchaseOrder");

            migrationBuilder.DropColumn(
                name: "referenceNumberExternal",
                table: "PurchaseOrder");

            migrationBuilder.DropColumn(
                name: "referenceNumberInternal",
                table: "PurchaseOrder");

            migrationBuilder.RenameColumn(
                name: "vendorDO",
                table: "Receiving",
                newName: "vehicleNumber");

            migrationBuilder.RenameColumn(
                name: "vendorId",
                table: "PurchaseOrder",
                newName: "customerId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseOrder_vendorId",
                table: "PurchaseOrder",
                newName: "IX_PurchaseOrder_customerId");

            migrationBuilder.AddColumn<string>(
                name: "customerId",
                table: "Receiving",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "picVendor",
                table: "PurchaseOrder",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

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

            migrationBuilder.CreateIndex(
                name: "IX_Receiving_customerId",
                table: "Receiving",
                column: "customerId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrder_Customer_customerId",
                table: "PurchaseOrder",
                column: "customerId",
                principalTable: "Customer",
                principalColumn: "customerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receiving_Customer_customerId",
                table: "Receiving",
                column: "customerId",
                principalTable: "Customer",
                principalColumn: "customerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrder_Customer_customerId",
                table: "PurchaseOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_Receiving_Customer_customerId",
                table: "Receiving");

            migrationBuilder.DropIndex(
                name: "IX_Receiving_customerId",
                table: "Receiving");

            migrationBuilder.DropColumn(
                name: "customerId",
                table: "Receiving");

            migrationBuilder.DropColumn(
                name: "height",
                table: "PurchaseOrder");

            migrationBuilder.DropColumn(
                name: "thickness",
                table: "PurchaseOrder");

            migrationBuilder.DropColumn(
                name: "width",
                table: "PurchaseOrder");

            migrationBuilder.RenameColumn(
                name: "vehicleNumber",
                table: "Receiving",
                newName: "vendorDO");

            migrationBuilder.RenameColumn(
                name: "customerId",
                table: "PurchaseOrder",
                newName: "vendorId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseOrder_customerId",
                table: "PurchaseOrder",
                newName: "IX_PurchaseOrder_vendorId");

            migrationBuilder.AddColumn<string>(
                name: "vendorId",
                table: "Receiving",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "picVendor",
                table: "PurchaseOrder",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "picInternal",
                table: "PurchaseOrder",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "referenceNumberExternal",
                table: "PurchaseOrder",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "referenceNumberInternal",
                table: "PurchaseOrder",
                maxLength: 30,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Receiving_vendorId",
                table: "Receiving",
                column: "vendorId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrder_Vendor_vendorId",
                table: "PurchaseOrder",
                column: "vendorId",
                principalTable: "Vendor",
                principalColumn: "vendorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receiving_Vendor_vendorId",
                table: "Receiving",
                column: "vendorId",
                principalTable: "Vendor",
                principalColumn: "vendorId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
