using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaigiamasisAPI.Migrations
{
    /// <inheritdoc />
    public partial class login2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_LoginInfo_UserId",
                table: "LoginInfo",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_LoginInfo_Users_UserId",
                table: "LoginInfo",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoginInfo_Users_UserId",
                table: "LoginInfo");

            migrationBuilder.DropIndex(
                name: "IX_LoginInfo_UserId",
                table: "LoginInfo");
        }
    }
}
