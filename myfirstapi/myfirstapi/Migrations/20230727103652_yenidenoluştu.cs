using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myfirstapi.Migrations
{
    /// <inheritdoc />
    public partial class yenidenoluştu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BiletFiyats");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Indirims");

            migrationBuilder.DropTable(
                name: "Turs");

            migrationBuilder.DropTable(
                name: "Seanss");

            migrationBuilder.DropTable(
                name: "Salons");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Salons",
                columns: table => new
                {
                    SalonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalonNo = table.Column<int>(type: "int", nullable: false),
                    Salonkapasite = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salons", x => x.SalonId);
                });

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

            migrationBuilder.CreateTable(
                name: "Seanss",
                columns: table => new
                {
                    SeansId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalomId = table.Column<int>(type: "int", nullable: false),
                    Seanssaat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seanss", x => x.SeansId);
                    table.ForeignKey(
                        name: "FK_Seanss_Salons_SalomId",
                        column: x => x.SalomId,
                        principalTable: "Salons",
                        principalColumn: "SalonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    FilmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    TursTurId = table.Column<int>(type: "int", nullable: false),
                    Fiilmaltyazi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiilmdil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Filmad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Filmpuan = table.Column<double>(type: "float", nullable: false),
                    Filmsüre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Filmvizyondurumu = table.Column<bool>(type: "bit", nullable: false),
                    Filmvizyontarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Indirims",
                columns: table => new
                {
                    IndirimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeansId = table.Column<int>(type: "int", nullable: false),
                    Indirimad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Indirimgun = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Indirimiçecek = table.Column<bool>(type: "bit", nullable: false),
                    Indirimmisir = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indirims", x => x.IndirimId);
                    table.ForeignKey(
                        name: "FK_Indirims_Seanss_SeansId",
                        column: x => x.SeansId,
                        principalTable: "Seanss",
                        principalColumn: "SeansId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BiletFiyats",
                columns: table => new
                {
                    BiletFiyatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndirimId = table.Column<int>(type: "int", nullable: false),
                    Biletfiyat = table.Column<double>(type: "float", nullable: false),
                    Bilettur = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BiletFiyats", x => x.BiletFiyatId);
                    table.ForeignKey(
                        name: "FK_BiletFiyats_Indirims_IndirimId",
                        column: x => x.IndirimId,
                        principalTable: "Indirims",
                        principalColumn: "IndirimId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BiletFiyats_IndirimId",
                table: "BiletFiyats",
                column: "IndirimId");

            migrationBuilder.CreateIndex(
                name: "IX_Films_KullaniciId",
                table: "Films",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Films_TursTurId",
                table: "Films",
                column: "TursTurId");

            migrationBuilder.CreateIndex(
                name: "IX_Indirims_SeansId",
                table: "Indirims",
                column: "SeansId");

            migrationBuilder.CreateIndex(
                name: "IX_Seanss_SalomId",
                table: "Seanss",
                column: "SalomId");
        }
    }
}
