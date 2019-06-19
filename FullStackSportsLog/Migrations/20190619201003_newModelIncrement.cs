using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FullStackSportsLog.Migrations
{
    public partial class newModelIncrement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminUsers",
                columns: table => new
                {
                    user_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(type: "varchar(70)", nullable: true),
                    middle_name = table.Column<string>(type: "varchar(70)", nullable: true),
                    last_name = table.Column<string>(type: "varchar(70)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    is_active = table.Column<bool>(nullable: false),
                    username = table.Column<string>(type: "varchar(50)", nullable: true),
                    user_password = table.Column<string>(type: "varchar(60)", nullable: true),
                    user_email = table.Column<string>(type: "varchar(100)", nullable: true),
                    login_time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    logout_time = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminUsers", x => x.user_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminUsers");
        }
    }
}
