using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myfirstapi.Migrations
{
    /// <inheritdoc />
    public partial class kullanicitablo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_kullanicis_rols_RolId",
                table: "kullanicis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_rols",
                table: "rols");

            migrationBuilder.DropPrimaryKey(
                name: "PK_kullanicis",
                table: "kullanicis");

            migrationBuilder.RenameTable(
                name: "rols",
                newName: "Rols");

            migrationBuilder.RenameTable(
                name: "kullanicis",
                newName: "Kullanicis");

            migrationBuilder.RenameColumn(
                name: "Kullaniciid",
                table: "Kullanicis",
                newName: "KullaniciId");

            migrationBuilder.RenameIndex(
                name: "IX_kullanicis_RolId",
                table: "Kullanicis",
                newName: "IX_Kullanicis_RolId");

            migrationBuilder.AddColumn<string>(
                name: "Kullaniciadres",
                table: "Kullanicis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Kullanicicinsiyet",
                table: "Kullanicis",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Kullanicid_tarihi",
                table: "Kullanicis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Kullanicimail",
                table: "Kullanicis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Kullanicitelefon",
                table: "Kullanicis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rols",
                table: "Rols",
                column: "RolId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kullanicis",
                table: "Kullanicis",
                column: "KullaniciId");

            migrationBuilder.CreateTable(
                name: "Turs",
                columns: table => new
                {
                    TurId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Turad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turs", x => x.TurId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanicis_Rols_RolId",
                table: "Kullanicis",
                column: "RolId",
                principalTable: "Rols",
                principalColumn: "RolId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kullanicis_Rols_RolId",
                table: "Kullanicis");

            migrationBuilder.DropTable(
                name: "Turs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rols",
                table: "Rols");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kullanicis",
                table: "Kullanicis");

            migrationBuilder.DropColumn(
                name: "Kullaniciadres",
                table: "Kullanicis");

            migrationBuilder.DropColumn(
                name: "Kullanicicinsiyet",
                table: "Kullanicis");

            migrationBuilder.DropColumn(
                name: "Kullanicid_tarihi",
                table: "Kullanicis");

            migrationBuilder.DropColumn(
                name: "Kullanicimail",
                table: "Kullanicis");

            migrationBuilder.DropColumn(
                name: "Kullanicitelefon",
                table: "Kullanicis");

            migrationBuilder.RenameTable(
                name: "Rols",
                newName: "rols");

            migrationBuilder.RenameTable(
                name: "Kullanicis",
                newName: "kullanicis");

            migrationBuilder.RenameColumn(
                name: "KullaniciId",
                table: "kullanicis",
                newName: "Kullaniciid");

            migrationBuilder.RenameIndex(
                name: "IX_Kullanicis_RolId",
                table: "kullanicis",
                newName: "IX_kullanicis_RolId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_rols",
                table: "rols",
                column: "RolId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_kullanicis",
                table: "kullanicis",
                column: "Kullaniciid");

            migrationBuilder.AddForeignKey(
                name: "FK_kullanicis_rols_RolId",
                table: "kullanicis",
                column: "RolId",
                principalTable: "rols",
                principalColumn: "RolId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
