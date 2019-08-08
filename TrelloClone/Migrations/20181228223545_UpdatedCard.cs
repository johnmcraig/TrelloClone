using Microsoft.EntityFrameworkCore.Migrations;

namespace TrelloClone.Migrations
{
    public partial class UpdatedCard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Card_Column_ColumnId",
                table: "Card");

            migrationBuilder.DropForeignKey(
                name: "FK_Column_Boards_BoardId",
                table: "Column");

            migrationBuilder.RenameColumn(
                name: "Contnents",
                table: "Card",
                newName: "Notes");

            migrationBuilder.AlterColumn<int>(
                name: "BoardId",
                table: "Column",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ColumnId",
                table: "Card",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contents",
                table: "Card",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Card_Column_ColumnId",
                table: "Card",
                column: "ColumnId",
                principalTable: "Column",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Column_Boards_BoardId",
                table: "Column",
                column: "BoardId",
                principalTable: "Boards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Card_Column_ColumnId",
                table: "Card");

            migrationBuilder.DropForeignKey(
                name: "FK_Column_Boards_BoardId",
                table: "Column");

            migrationBuilder.DropColumn(
                name: "Contents",
                table: "Card");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "Card",
                newName: "Contnents");

            migrationBuilder.AlterColumn<int>(
                name: "BoardId",
                table: "Column",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ColumnId",
                table: "Card",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Card_Column_ColumnId",
                table: "Card",
                column: "ColumnId",
                principalTable: "Column",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Column_Boards_BoardId",
                table: "Column",
                column: "BoardId",
                principalTable: "Boards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
