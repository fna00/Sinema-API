using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myfirstapi.Migrations
{
    /// <inheritdoc />
    public partial class dsadövdla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    FilmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Filmad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Filmsüre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Filmvizyontarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Filmvizyondurumu = table.Column<bool>(type: "bit", nullable: false),
                    Filmpuan = table.Column<double>(type: "float", nullable: false),
                    Fiilmdil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiilmaltyazi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TursTurId = table.Column<int>(type: "int", nullable: false),
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.FilmId);
                    table.ForeignKey(
                        name: "FK_Films_Kullanicis_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicis",
                        principalColumn: "KullaniciId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Films_Turs_TursTurId",
                        column: x => x.TursTurId,
                        principalTable: "Turs",
                        principalColumn: "TurId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Films_KullaniciId",
                table: "Films",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Films_TursTurId",
                table: "Films",
                column: "TursTurId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");
        }
    }
}
