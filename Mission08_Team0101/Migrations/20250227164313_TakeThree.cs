using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission08_Team0101.Migrations
{
    /// <inheritdoc />
    public partial class TakeThree : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "Habits");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Habits",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Habits_CategoryId",
                table: "Habits",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Habits_Categories_CategoryId",
                table: "Habits",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Habits_Categories_CategoryId",
                table: "Habits");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Habits_CategoryId",
                table: "Habits");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Habits");

            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "Habits",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
