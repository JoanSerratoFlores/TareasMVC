using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdminRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@" 
                IF NOT EXISTS(Select Id from AspNetRoles where Id = 'ff68a003-2a45-4c09-b4f9-2988de5d459e') 
                BEGIN 
	                INSERT AspNetRoles (Id, [Name], [NormalizedName]) 
	                VALUES ('ff68a003-2a45-4c09-b4f9-2988de5d459e', 'admin', 'ADMIN')
                END ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                 DELETE AspNetRoles Where Id = 'ff68a003-2a45-4c09-b4f9-2988de5d459e'");
        }
    }
}
