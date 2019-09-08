using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MercuryHealthCore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    VideoUrl = table.Column<string>(nullable: true),
                    MusclesInvolved = table.Column<string>(nullable: true),
                    Equipment = table.Column<string>(nullable: true),
                    ExerciseId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exercises_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MemberProfile",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Bio = table.Column<string>(nullable: true),
                    WeightInKilograms = table.Column<int>(nullable: false),
                    HeightInCentimeters = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberProfile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodLogEntries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MemberProfileId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Quantity = table.Column<float>(nullable: false),
                    MealTime = table.Column<DateTime>(nullable: false),
                    Tags = table.Column<string>(nullable: true),
                    Calories = table.Column<int>(nullable: false),
                    ProteinInGrams = table.Column<decimal>(nullable: false),
                    FatInGrams = table.Column<decimal>(nullable: false),
                    CarbohydratesInGrams = table.Column<decimal>(nullable: false),
                    SodiumInGrams = table.Column<decimal>(nullable: false),
                    Color = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodLogEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodLogEntries_MemberProfile_MemberProfileId",
                        column: x => x.MemberProfileId,
                        principalTable: "MemberProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_ExerciseId",
                table: "Exercises",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodLogEntries_MemberProfileId",
                table: "FoodLogEntries",
                column: "MemberProfileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "FoodLogEntries");

            migrationBuilder.DropTable(
                name: "MemberProfile");
        }
    }
}
