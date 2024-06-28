using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "FirstName", "LastName", "Email"},
                values: new object[] { "John", "Doe", "foo@example.com" }
            );
            
            migrationBuilder.InsertData(
                table: "Medicaments",
                columns: new[] { "Name", "Description", "Type"},
                values: new object[] { "Some", "Medicament", "some type" }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
