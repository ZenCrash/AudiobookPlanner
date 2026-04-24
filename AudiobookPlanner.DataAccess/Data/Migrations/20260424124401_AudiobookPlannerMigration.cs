using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AudiobookPlanner.DataAccess.Data.Migrations
{
    /// <inheritdoc />
    public partial class AudiobookPlannerMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Audiobooks_Publishers_PublisherId",
                table: "Audiobooks");

            migrationBuilder.AlterColumn<int>(
                name: "PublisherId",
                table: "Audiobooks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Audiobooks_Publishers_PublisherId",
                table: "Audiobooks",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Audiobooks_Publishers_PublisherId",
                table: "Audiobooks");

            migrationBuilder.AlterColumn<int>(
                name: "PublisherId",
                table: "Audiobooks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Audiobooks_Publishers_PublisherId",
                table: "Audiobooks",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
