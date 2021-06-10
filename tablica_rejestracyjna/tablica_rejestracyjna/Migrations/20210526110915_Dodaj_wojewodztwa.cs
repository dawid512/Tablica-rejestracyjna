using Microsoft.EntityFrameworkCore.Migrations;

namespace tablica_rejestracyjna.Migrations
{
    public partial class Dodaj_wojewodztwa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "Wojewodztwa",
            columns: new[] { "wojewodztwaID", "Name", "tab_letter" },
            values: new object[] { "13", "śląskie", "S" });

            migrationBuilder.InsertData(
           table: "Wojewodztwa",
           columns: new[] { "wojewodztwaID", "Name", "tab_letter" },
           values: new object[] { "1", "podlaskie", "B" });

            migrationBuilder.InsertData(
           table: "Wojewodztwa",
           columns: new[] { "wojewodztwaID", "Name", "tab_letter" },
           values: new object[] { "2", "kujawsko-pomorskie", "C" });
            migrationBuilder.InsertData(
          table: "Wojewodztwa",
          columns: new[] { "wojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "3", "dolnośląskie", "D" });
            migrationBuilder.InsertData(
          table: "Wojewodztwa",
          columns: new[] { "wojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "4", "łódzkie", "E" });
            migrationBuilder.InsertData(
          table: "Wojewodztwa",
          columns: new[] { "wojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "5", "lubuskie", "F" });
            migrationBuilder.InsertData(
          table: "Wojewodztwa",
          columns: new[] { "wojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "6", "pomorskie", "G" });
            migrationBuilder.InsertData(
          table: "Wojewodztwa",
          columns: new[] { "wojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "7", "małopolskie", "K" });
            migrationBuilder.InsertData(
          table: "Wojewodztwa",
          columns: new[] { "wojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "8", "lubelskie", "L" });
            migrationBuilder.InsertData(
          table: "Wojewodztwa",
          columns: new[] { "wojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "9", "warmińko-mazurskie", "N" });
            migrationBuilder.InsertData(
        table: "Wojewodztwa",
        columns: new[] { "wojewodztwaID", "Name", "tab_letter" },
        values: new object[] { "10", "opolskie", "O" });
            migrationBuilder.InsertData(
        table: "Wojewodztwa",
        columns: new[] { "wojewodztwaID", "Name", "tab_letter" },
        values: new object[] { "11", "wielkopolskie", "P" });
            migrationBuilder.InsertData(
        table: "Wojewodztwa",
        columns: new[] { "wojewodztwaID", "Name", "tab_letter" },
        values: new object[] { "12", "podkarpackie", "R" });
            migrationBuilder.InsertData(
        table: "Wojewodztwa",
        columns: new[] { "wojewodztwaID", "Name", "tab_letter" },
        values: new object[] { "14", "świetokrzyskie", "T" });
            migrationBuilder.InsertData(
        table: "Wojewodztwa",
        columns: new[] { "wojewodztwaID", "Name", "tab_letter" },
        values: new object[] { "15", "mazowieckie", "W" });

            migrationBuilder.InsertData(
        table: "Wojewodztwa",
        columns: new[] { "wojewodztwaID", "Name", "tab_letter" },
        values: new object[] { "16", "zachodniopomorskie", "Z" });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
