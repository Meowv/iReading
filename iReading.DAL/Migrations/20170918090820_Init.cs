using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace iReading.DAL.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    ArticleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Author = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<int>(type: "int", nullable: false),
                    IssueTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.ArticleId);
                });

            migrationBuilder.CreateTable(
                name: "ArticleViews",
                columns: table => new
                {
                    ArticleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Hits = table.Column<int>(type: "int", nullable: false),
                    ShowHits = table.Column<int>(type: "int", nullable: false),
                    UserAgent = table.Column<int>(type: "int", nullable: false),
                    UserIp = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ViewTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleViews", x => x.ArticleId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "ArticleViews");
        }
    }
}
