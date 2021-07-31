using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBusTransportation.Data.Migrations
{
    public partial class updatecolumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Buses",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Buses",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Buses");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Buses");
        }
    }
}
