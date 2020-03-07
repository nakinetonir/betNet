using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace betController.Migrations
{
    public partial class primeraMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bet_bet",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    active = table.Column<int>(nullable: false),
                    bet_money = table.Column<double>(nullable: false),
                    creation_date = table.Column<DateTime>(nullable: false),
                    emision = table.Column<string>(nullable: true),
                    estado = table.Column<int>(nullable: false),
                    evento = table.Column<string>(nullable: true),
                    event_date = table.Column<string>(nullable: true),
                    hour = table.Column<string>(nullable: true),
                    player_one = table.Column<string>(nullable: true),
                    player_two = table.Column<string>(nullable: true),
                    resultado = table.Column<string>(nullable: true),
                    sport = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bet_bet", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bet_bet");
        }
    }
}
