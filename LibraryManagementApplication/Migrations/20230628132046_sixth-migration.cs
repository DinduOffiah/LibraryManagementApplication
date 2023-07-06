using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagementApplication.Migrations
{
    public partial class sixthmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BookCategories",
                newName: "BookCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BookCategoryId",
                table: "BookCategories",
                newName: "Id");
        }
    }
}
