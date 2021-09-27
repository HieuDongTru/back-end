using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRMSolution.Data.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "noiCap",
                table: "NhanVien",
                newName: "noiCapHoChieu");

            migrationBuilder.RenameColumn(
                name: "ngayCap",
                table: "NhanVien",
                newName: "ngayHetHanHoChieu");

            migrationBuilder.AddColumn<string>(
                name: "hoChieu",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "maSoThue",
                table: "NhanVien",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ngayCapCCCD",
                table: "NhanVien",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ngayCapHoChieu",
                table: "NhanVien",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "noiCapCCCD",
                table: "NhanVien",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "hoChieu",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "maSoThue",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "ngayCapCCCD",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "ngayCapHoChieu",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "noiCapCCCD",
                table: "NhanVien");

            migrationBuilder.RenameColumn(
                name: "noiCapHoChieu",
                table: "NhanVien",
                newName: "noiCap");

            migrationBuilder.RenameColumn(
                name: "ngayHetHanHoChieu",
                table: "NhanVien",
                newName: "ngayCap");
        }
    }
}
