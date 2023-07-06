using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagementApplication.Migrations
{
    public partial class fourthmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookLends_BookCategories_Id",
                table: "BookLends");

            migrationBuilder.DropForeignKey(
                name: "FK_BookLends_Books_BookId",
                table: "BookLends");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Lecturers_LecturerId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_LecturerId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookLends",
                table: "BookLends");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "BookLends");

            migrationBuilder.RenameColumn(
                name: "LecturerId",
                table: "Books",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "Books",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "BookLendId",
                table: "BookLends",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookLends",
                table: "BookLends",
                column: "BookLendId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookLends_Books_BookId",
                table: "BookLends",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookCategories_Id",
                table: "Books",
                column: "Id",
                principalTable: "BookCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookLends_Books_BookId",
                table: "BookLends");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookCategories_Id",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookLends",
                table: "BookLends");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Books",
                newName: "LecturerId");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "Books",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "BookLendId",
                table: "BookLends",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "BookLends",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookLends",
                table: "BookLends",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Books_LecturerId",
                table: "Books",
                column: "LecturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookLends_BookCategories_Id",
                table: "BookLends",
                column: "Id",
                principalTable: "BookCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookLends_Books_BookId",
                table: "BookLends",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Lecturers_LecturerId",
                table: "Books",
                column: "LecturerId",
                principalTable: "Lecturers",
                principalColumn: "LecturerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
