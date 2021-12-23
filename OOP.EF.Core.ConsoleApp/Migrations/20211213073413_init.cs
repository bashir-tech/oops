using Microsoft.EntityFrameworkCore.Migrations;

namespace OOP.EF.Core.ConsoleApp.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookDetails",
                columns: table => new
                {
                    BookDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    ISSN = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "0000-0000-0000"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false, defaultValue: 2021)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookDetails", x => x.BookDetailId);
                    table.ForeignKey(
                        name: "FK_BookDetails_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "categoryName", "description" },
                values: new object[] { 1, "lenovo", "laptop" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "categoryName", "description" },
                values: new object[] { 2, "HP", "Monitor" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "categoryName", "description" },
                values: new object[] { 3, "Dell", "desktop" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "CategoryId", "Price", "Title" },
                values: new object[] { 1, 3, 25m, "marriage" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "CategoryId", "Price", "Title" },
                values: new object[] { 2, 3, 100m, "History Of Islam" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "CategoryId", "Price", "Title" },
                values: new object[] { 3, 3, 35m, "Goal" });

            migrationBuilder.CreateIndex(
                name: "IX_BookDetails_BookId",
                table: "BookDetails",
                column: "BookId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookDetails");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
