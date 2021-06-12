using Microsoft.EntityFrameworkCore.Migrations;

namespace Chat.Web.Data.Migrations
{
    public partial class AddModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medecin",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(nullable: false),
                    prenom = table.Column<string>(nullable: false),
                    age = table.Column<int>(nullable: false),
                    Adresse = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Tel = table.Column<int>(nullable: false),
                    CodeCnam = table.Column<string>(nullable: false),
                    Disponibilite = table.Column<bool>(nullable: false),
                    Experience = table.Column<string>(nullable: false),
                    Specialite = table.Column<string>(nullable: false),
                    Universite = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medecin", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(nullable: true),
                    Prenom = table.Column<string>(nullable: true),
                    Age = table.Column<string>(nullable: true),
                    ville = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medecin");

            migrationBuilder.DropTable(
                name: "Patient");
        }
    }
}
