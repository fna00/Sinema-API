using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myfirstapi.Migrations
{
    /// <inheritdoc />
    public partial class düzeltme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bilets_Kullanicis_KullaniciId",
                table: "bilets");

            migrationBuilder.DropForeignKey(
                name: "FK_bilets_Seanss_SeansId",
                table: "bilets");

            migrationBuilder.DropForeignKey(
                name: "FK_Films_yonetmens_YonetmenId",
                table: "Films");

            migrationBuilder.DropPrimaryKey(
                name: "PK_yonetmens",
                table: "yonetmens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_bilets",
                table: "bilets");

            migrationBuilder.RenameTable(
                name: "yonetmens",
                newName: "Yonetmens");

            migrationBuilder.RenameTable(
                name: "bilets",
                newName: "Bilets");

            migrationBuilder.RenameIndex(
                name: "IX_bilets_SeansId",
                table: "Bilets",
                newName: "IX_Bilets_SeansId");

            migrationBuilder.RenameIndex(
                name: "IX_bilets_KullaniciId",
                table: "Bilets",
                newName: "IX_Bilets_KullaniciId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Yonetmens",
                table: "Yonetmens",
                column: "YonetmenId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bilets",
                table: "Bilets",
                column: "BiletId");

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
                name: "FK_Films_Yonetmens_YonetmenId",
                table: "Films",
                column: "YonetmenId",
                principalTable: "Yonetmens",
                principalColumn: "YonetmenId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bilets_Kullanicis_KullaniciId",
                table: "Bilets");

            migrationBuilder.DropForeignKey(
                name: "FK_Bilets_Seanss_SeansId",
                table: "Bilets");

            migrationBuilder.DropForeignKey(
                name: "FK_Films_Yonetmens_YonetmenId",
                table: "Films");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Yonetmens",
                table: "Yonetmens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bilets",
                table: "Bilets");

            migrationBuilder.RenameTable(
                name: "Yonetmens",
                newName: "yonetmens");

            migrationBuilder.RenameTable(
                name: "Bilets",
                newName: "bilets");

            migrationBuilder.RenameIndex(
                name: "IX_Bilets_SeansId",
                table: "bilets",
                newName: "IX_bilets_SeansId");

            migrationBuilder.RenameIndex(
                name: "IX_Bilets_KullaniciId",
                table: "bilets",
                newName: "IX_bilets_KullaniciId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_yonetmens",
                table: "yonetmens",
                column: "YonetmenId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bilets",
                table: "bilets",
                column: "BiletId");

            migrationBuilder.AddForeignKey(
                name: "FK_bilets_Kullanicis_KullaniciId",
                table: "bilets",
                column: "KullaniciId",
                principalTable: "Kullanicis",
                principalColumn: "KullaniciId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_bilets_Seanss_SeansId",
                table: "bilets",
                column: "SeansId",
                principalTable: "Seanss",
                principalColumn: "SeansId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Films_yonetmens_YonetmenId",
                table: "Films",
                column: "YonetmenId",
                principalTable: "yonetmens",
                principalColumn: "YonetmenId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
