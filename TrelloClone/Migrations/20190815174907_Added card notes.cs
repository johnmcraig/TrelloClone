using Microsoft.EntityFrameworkCore.Migrations;

namespace TrelloClone.Migrations
{
    public partial class Addedcardnotes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Card_Column_ColumnId",
                table: "Card");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Card",
                table: "Card");

            migrationBuilder.RenameTable(
                name: "Card",
                newName: "Cards");

            migrationBuilder.RenameIndex(
                name: "IX_Card_ColumnId",
                table: "Cards",
                newName: "IX_Cards_ColumnId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cards",
                table: "Cards",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Column_ColumnId",
                table: "Cards",
                column: "ColumnId",
                principalTable: "Column",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Column_ColumnId",
                table: "Cards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cards",
                table: "Cards");

            migrationBuilder.RenameTable(
                name: "Cards",
                newName: "Card");

            migrationBuilder.RenameIndex(
                name: "IX_Cards_ColumnId",
                table: "Card",
                newName: "IX_Card_ColumnId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Card",
                table: "Card",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Card_Column_ColumnId",
                table: "Card",
                column: "ColumnId",
                principalTable: "Column",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
