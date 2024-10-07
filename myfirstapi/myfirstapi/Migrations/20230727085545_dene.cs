using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myfirstapi.Migrations
{
    /// <inheritdoc />
    public partial class dene : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seans_Salons_SalomId",
                table: "Seans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seans",
                table: "Seans");

            migrationBuilder.RenameTable(
                name: "Seans",
                newName: "Seanss");

            migrationBuilder.RenameIndex(
                name: "IX_Seans_SalomId",
                table: "Seanss",
                newName: "IX_Seanss_SalomId");

            migrationBuilder.AddColumn<int>(
                name: "SeansId",
                table: "Indirims",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seanss",
                table: "Seanss",
                column: "SeansId");

            migrationBuilder.CreateIndex(
                name: "IX_Indirims_SeansId",
                table: "Indirims",
                column: "SeansId");

            migrationBuilder.AddForeignKey(
                name: "FK_Indirims_Seanss_SeansId",
                table: "Indirims",
                column: "SeansId",
                principalTable: "Seanss",
                principalColumn: "SeansId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seanss_Salons_SalomId",
                table: "Seanss",
                column: "SalomId",
                principalTable: "Salons",
                principalColumn: "SalonId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Indirims_Seanss_SeansId",
                table: "Indirims");

            migrationBuilder.DropForeignKey(
                name: "FK_Seanss_Salons_SalomId",
                table: "Seanss");

            migrationBuilder.DropIndex(
                name: "IX_Indirims_SeansId",
                table: "Indirims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seanss",
                table: "Seanss");

            migrationBuilder.DropColumn(
                name: "SeansId",
                table: "Indirims");

            migrationBuilder.RenameTable(
                name: "Seanss",
                newName: "Seans");

            migrationBuilder.RenameIndex(
                name: "IX_Seanss_SalomId",
                table: "Seans",
                newName: "IX_Seans_SalomId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seans",
                table: "Seans",
                column: "SeansId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seans_Salons_SalomId",
                table: "Seans",
                column: "SalomId",
                principalTable: "Salons",
                principalColumn: "SalonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
