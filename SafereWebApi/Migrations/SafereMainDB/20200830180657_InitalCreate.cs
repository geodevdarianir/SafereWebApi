using Microsoft.EntityFrameworkCore.Migrations;

namespace SafereWebApi.Migrations.SafereMainDB
{
    public partial class InitalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Admins_PartnerId",
                table: "Admins",
                column: "PartnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Partners_PartnerId",
                table: "Admins",
                column: "PartnerId",
                principalTable: "Partners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Partners_PartnerId",
                table: "Admins");

            migrationBuilder.DropIndex(
                name: "IX_Admins_PartnerId",
                table: "Admins");
        }
    }
}
