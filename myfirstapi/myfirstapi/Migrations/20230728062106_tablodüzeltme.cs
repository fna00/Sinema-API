using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myfirstapi.Migrations
{
    /// <inheritdoc />
    public partial class tablodüzeltme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Kullanicid_tarihi",
                table: "Kullanicis",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Kullanicid_tarihi",
                table: "Kullanicis",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
