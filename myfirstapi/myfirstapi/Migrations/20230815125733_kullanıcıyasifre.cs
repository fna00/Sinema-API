using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myfirstapi.Migrations
{
    /// <inheritdoc />
    public partial class kullanıcıyasifre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bilets_Kullanicis_KullaniciId",
                table: "Bilets");

            migrationBuilder.DropForeignKey(
                name: "FK_Bilets_Seanss_SeansId",
                table: "Bilets");

            migrationBuilder.DropForeignKey(
                name: "FK_Films_Turs_TurId",
                table: "Films");

            migrationBuilder.DropForeignKey(
                name: "FK_Films_Yonetmens_YonetmenId",
                table: "Films");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanicis_Rols_RolId",
                table: "Kullanicis");

            migrationBuilder.DropForeignKey(
                name: "FK_Seanss_Films_FilmId",
                table: "Seanss");

            migrationBuilder.DropIndex(
                name: "IX_Seanss_FilmId",
                table: "Seanss");

            migrationBuilder.DropIndex(
                name: "IX_Kullanicis_RolId",
                table: "Kullanicis");

            migrationBuilder.DropIndex(
                name: "IX_Films_TurId",
                table: "Films");

            migrationBuilder.DropIndex(
                name: "IX_Films_YonetmenId",
                table: "Films");

            migrationBuilder.DropIndex(
                name: "IX_Bilets_KullaniciId",
                table: "Bilets");

            migrationBuilder.DropIndex(
                name: "IX_Bilets_SeansId",
                table: "Bilets");

            migrationBuilder.AddColumn<string>(
                name: "Kullanicisifre",
                table: "Kullanicis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kullanicisifre",
                table: "Kullanicis");

            migrationBuilder.CreateIndex(
                name: "IX_Seanss_FilmId",
                table: "Seanss",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicis_RolId",
                table: "Kullanicis",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_Films_TurId",
                table: "Films",
                column: "TurId");

            migrationBuilder.CreateIndex(
                name: "IX_Films_YonetmenId",
                table: "Films",
                column: "YonetmenId");

            migrationBuilder.CreateIndex(
                name: "IX_Bilets_KullaniciId",
                table: "Bilets",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Bilets_SeansId",
                table: "Bilets",
                column: "SeansId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bilets_Kullanicis_KullaniciId",
                table: "Bilets",
                column: "KullaniciId",
                principalTable: "Kullanicis",
                principalColumn: "KullaniciId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bilets_Seanss_SeansId",
                table: "Bilets",
                column: "SeansId",
                principalTable: "Seanss",
                principalColumn: "SeansId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Films_Turs_TurId",
                table: "Films",
                column: "TurId",
                principalTable: "Turs",
                principalColumn: "TurId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Films_Yonetmens_YonetmenId",
                table: "Films",
                column: "YonetmenId",
                principalTable: "Yonetmens",
                principalColumn: "YonetmenId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanicis_Rols_RolId",
                table: "Kullanicis",
                column: "RolId",
                principalTable: "Rols",
                principalColumn: "RolId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seanss_Films_FilmId",
                table: "Seanss",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "FilmId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
