using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudAPI.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class alter_books_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                schema: "cmn",
                table: "books",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Description",
                schema: "cmn",
                table: "books",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "cmn",
                table: "books",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Updated",
                schema: "cmn",
                table: "books",
                newName: "updated_date");

            migrationBuilder.RenameColumn(
                name: "Created",
                schema: "cmn",
                table: "books",
                newName: "created_date");

            migrationBuilder.RenameColumn(
                name: "BookGenre",
                schema: "cmn",
                table: "books",
                newName: "book_genre");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "title",
                schema: "cmn",
                table: "books",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "description",
                schema: "cmn",
                table: "books",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                schema: "cmn",
                table: "books",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_date",
                schema: "cmn",
                table: "books",
                newName: "Updated");

            migrationBuilder.RenameColumn(
                name: "created_date",
                schema: "cmn",
                table: "books",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "book_genre",
                schema: "cmn",
                table: "books",
                newName: "BookGenre");
        }
    }
}
