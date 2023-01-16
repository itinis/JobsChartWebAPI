using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserApiDAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "chartJobs",
                columns: table => new
                {
                    chartJobId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    jobsPerDay = table.Column<int>(type: "INTEGER", nullable: false),
                    jobsViews = table.Column<int>(type: "INTEGER", nullable: false),
                    predictedJobsViews = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chartJobs", x => x.chartJobId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "chartJobs");
        }
    }
}
