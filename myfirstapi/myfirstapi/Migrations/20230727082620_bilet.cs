using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myfirstapi.Migrations
{
    /// <inheritdoc />
    public partial class bilet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Indirims",
                columns: table => new
                {
                    IndirimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Indirimad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Indirimgun = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Indirimiçecek = table.Column<bool>(type: "bit", nullable: false),
                    Indirimmisir = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indirims", x => x.IndirimId);
                });

            migrationBuilder.CreateTable(
                name: "BiletFiyats",
                columns: table => new
                {
                    BiletFiyatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bilettur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Biletfiyat = table.Column<double>(type: "float", nullable: false),
                    IndirimId = table.Column<int>(type: "int", nullable: false)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BiletFiyats");

            migrationBuilder.DropTable(
                name: "Indirims");
        }
    }
}
