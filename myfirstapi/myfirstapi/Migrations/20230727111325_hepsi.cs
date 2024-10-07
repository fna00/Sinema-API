using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myfirstapi.Migrations
{
    /// <inheritdoc />
    public partial class hepsi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bilets_Seans_SeansId",
                table: "bilets");

            migrationBuilder.DropForeignKey(
                name: "FK_Film_Tur_TurId",
                table: "Film");

            migrationBuilder.DropForeignKey(
                name: "FK_Film_Yonetmen_YonetmenId",
                table: "Film");

            migrationBuilder.DropForeignKey(
                name: "FK_Seans_Film_FilmId",
                table: "Seans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Yonetmen",
                table: "Yonetmen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tur",
                table: "Tur");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seans",
                table: "Seans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Film",
                table: "Film");

            migrationBuilder.RenameTable(
                name: "Yonetmen",
                newName: "yonetmens");

            migrationBuilder.RenameTable(
                name: "Tur",
                newName: "Turs");

            migrationBuilder.RenameTable(
                name: "Seans",
                newName: "Seanss");

            migrationBuilder.RenameTable(
                name: "Film",
                newName: "Films");

            migrationBuilder.RenameIndex(
                name: "IX_Seans_FilmId",
                table: "Seanss",
                newName: "IX_Seanss_FilmId");

            migrationBuilder.RenameIndex(
                name: "IX_Film_YonetmenId",
                table: "Films",
                newName: "IX_Films_YonetmenId");

            migrationBuilder.RenameIndex(
                name: "IX_Film_TurId",
                table: "Films",
                newName: "IX_Films_TurId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_yonetmens",
                table: "yonetmens",
                column: "YonetmenId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Turs",
                table: "Turs",
                column: "TurId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seanss",
                table: "Seanss",
                column: "SeansId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Films",
                table: "Films",
                column: "FilmId");

            migrationBuilder.AddForeignKey(
                name: "FK_bilets_Seanss_SeansId",
                table: "bilets",
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
                name: "FK_Films_yonetmens_YonetmenId",
                table: "Films",
                column: "YonetmenId",
                principalTable: "yonetmens",
                principalColumn: "YonetmenId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seanss_Films_FilmId",
                table: "Seanss",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "FilmId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bilets_Seanss_SeansId",
                table: "bilets");

            migrationBuilder.DropForeignKey(
                name: "FK_Films_Turs_TurId",
                table: "Films");

            migrationBuilder.DropForeignKey(
                name: "FK_Films_yonetmens_YonetmenId",
                table: "Films");

            migrationBuilder.DropForeignKey(
                name: "FK_Seanss_Films_FilmId",
                table: "Seanss");

            migrationBuilder.DropPrimaryKey(
                name: "PK_yonetmens",
                table: "yonetmens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Turs",
                table: "Turs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seanss",
                table: "Seanss");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Films",
                table: "Films");

            migrationBuilder.RenameTable(
                name: "yonetmens",
                newName: "Yonetmen");

            migrationBuilder.RenameTable(
                name: "Turs",
                newName: "Tur");

            migrationBuilder.RenameTable(
                name: "Seanss",
                newName: "Seans");

            migrationBuilder.RenameTable(
                name: "Films",
                newName: "Film");

            migrationBuilder.RenameIndex(
                name: "IX_Seanss_FilmId",
                table: "Seans",
                newName: "IX_Seans_FilmId");

            migrationBuilder.RenameIndex(
                name: "IX_Films_YonetmenId",
                table: "Film",
                newName: "IX_Film_YonetmenId");

            migrationBuilder.RenameIndex(
                name: "IX_Films_TurId",
                table: "Film",
                newName: "IX_Film_TurId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Yonetmen",
                table: "Yonetmen",
                column: "YonetmenId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tur",
                table: "Tur",
                column: "TurId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seans",
                table: "Seans",
                column: "SeansId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Film",
                table: "Film",
                column: "FilmId");

            migrationBuilder.AddForeignKey(
                name: "FK_bilets_Seans_SeansId",
                table: "bilets",
                column: "SeansId",
                principalTable: "Seans",
                principalColumn: "SeansId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Film_Tur_TurId",
                table: "Film",
                column: "TurId",
                principalTable: "Tur",
                principalColumn: "TurId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Film_Yonetmen_YonetmenId",
                table: "Film",
                column: "YonetmenId",
                principalTable: "Yonetmen",
                principalColumn: "YonetmenId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seans_Film_FilmId",
                table: "Seans",
                column: "FilmId",
                principalTable: "Film",
                principalColumn: "FilmId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
