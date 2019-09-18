using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingManagement.Database.Migrations
{
    public partial class TraineeTypeId_add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TraineeTypeId",
                table: "Trainees",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TraineeTypeId",
                table: "Trainees");
        }
    }
}
