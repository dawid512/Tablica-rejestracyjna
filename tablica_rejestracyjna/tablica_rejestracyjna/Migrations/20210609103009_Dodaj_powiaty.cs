using Microsoft.EntityFrameworkCore.Migrations;

namespace tablica_rejestracyjna.Migrations
{
    public partial class Dodaj_powiaty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.InsertData(
            table: "Powiaty",
            columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
            values: new object[] { "6", "1", "Augustów", "BAU" });
            migrationBuilder.InsertData(
            table: "Powiaty",
            columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
            values: new object[] { "7", "1", "Bielsk Podlaski", "BBI" });
            migrationBuilder.InsertData(
            table: "Powiaty",
            columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
            values: new object[] { "8", "1", "Grajewo", "BGR" });
            migrationBuilder.InsertData(
            table: "Powiaty",
            columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
            values: new object[] { "9", "1", "Hajnówka", "BHA" });
            migrationBuilder.InsertData(
            table: "Powiaty",
            columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
            values: new object[] { "10", "1", "Białystok (miasto)", "BI" });
            migrationBuilder.InsertData(
            table: "Powiaty",
            columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
            values: new object[] { "11", "1", "Białystok (powiat)", "BIA" });
            migrationBuilder.InsertData(
            table: "Powiaty",
            columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
            values: new object[] { "12", "1", "Kolno", "BKL" });
            migrationBuilder.InsertData(
            table: "Powiaty",
            columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
            values: new object[] { "13", "1", "Łomża (miasto)", "BL" });
            migrationBuilder.InsertData(
            table: "Powiaty",
            columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
            values: new object[] { "14", "1", "Łomża (powiat)", "BLM" });
            migrationBuilder.InsertData(
            table: "Powiaty",
            columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
            values: new object[] { "15", "1", "Mońki", "BMN" });
            migrationBuilder.InsertData(
            table: "Powiaty",
            columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
            values: new object[] { "16", "1", "Suwałki", "BS" });
            migrationBuilder.InsertData(
           table: "Powiaty",
           columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
           values: new object[] { "19", "1", "Sejny", "BSE" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "20", "1", "Siemiatyczne", "BSI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "21", "1", "Sokółka", "BSK" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "22", "1", "Suwałki", "BSU" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "23", "1", "Wysokie Mazowieckie", "BWM" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "24", "1", "Zambrów", "BZA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "25", "2", "Aleksandrów Kujawski", "CAL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "26", "2", "Bydgoszcz (miasto)", "CB" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "27", "2", "Brodnica", "CBR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "28", "2", "Bydgoszcz (powiat)", "CBY" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "29", "2", "Chełmno", "CCH" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "30", "2", "Grudziądz (miasto)", "CG" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "31", "2", "Golub Dobrzyń", "CGD" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "32", "2", "Grudziądz (powiat)", "CGR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "33", "2", "Inowrocław", "CLI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "34", "2", "Lipno", "CLI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "35", "2", "Mogilno", "CMG" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "36", "2", "Nakło nad Notecią", "CNA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "37", "2", "Radziejów", "CRA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "38", "2", "Rypin", "CRY" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "39", "2", "Sępólno Krajeńskie", "CSE" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "40", "2", "Świecie", "CSW" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "41", "2", "Toruń (miasto)", "CT" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "42", "2", "Toruń (powiat)", "CTR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "43", "2", "Tuchola", "CTU" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "44", "2", "Włocławek (miasto)", "CW" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "45", "2", "Wąbrzeźno", "CWA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "46", "2", "Włocławek (powiat)", "CWL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "47", "2", "Żnin", "CZN" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "48", "3", "Wałbrzych (miasto)", "DB" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "49", "3", "Wałbrzych (powiat)", "DBA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "50", "3", "Bolesławiec", "DBL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "51", "3", "Dzierżoniów", "DDZ" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "52", "3", "Głogów", "DGL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "53", "3", "Góra", "DGR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "54", "3", "Jelenia Góra (miasto)", "DJ" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "55", "3", "Jawor", "DJA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "56", "3", "Jelenia Góra (powiat)", "DJE" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "57", "3", "Kamienna Góra", "DKA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "58", "3", "Kłodzko", "DKL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "59", "3", "Legnica (miasto)", "DL" });
            migrationBuilder.InsertData(
           table: "Powiaty",
           columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
           values: new object[] { "60", "3", "Lubań", "DLB" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "61", "3", "Legnica (powiat)", "DLE" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "62", "3", "Lubin", "DLU" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "63", "3", "Lwówek Śląski", "DLW" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "64", "3", "Milicz", "DMI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "65", "3", "Oława", "DOA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "66", "3", "Oleśnica", "DOL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "67", "3", "Polkowice", "DPL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "68", "3", "Środa Śląska", "DSR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "69", "3", "Strzelin", "DST" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "70", "3", "Świdnica", "DSW" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "71", "3", "Trzebnica", "DTR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "72", "3", "Wrocław (miasto)", "DW" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "73", "3", "Wołów", "DWL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "74", "3", "Wrocław (powiat)", "DWR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "75", "3", "Ząbkowice Śląskie", "DZA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "76", "3", "Zgorzelec", "DZG" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "77", "3", "Złotoryja", "DZL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "78", "4", "Bełchatów", "EBE" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "79", "4", "Brzeziny", "EBR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "80", "4", "Łódź (miasto)", "ED" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "81", "4", "Kutno", "EKU" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "82", "4", "Łódź (miasto)", "EL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "83", "4", "Łask", "ELA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "84", "4", "Łowicz", "ELC" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "85", "4", "Łęczyca", "ELE" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "86", "4", "Łódź Wschód", "ELW" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "87", "4", "Opoczno", "EOP" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "88", "4", "Piotrków Trybunalski (miasto)", "EP" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "89", "4", "Pabianice", "EPA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "90", "4", "Poddębice", "EPD" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "91", "4", "Piotrków Trybunalski (powiat)", "EPI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "92", "4", "Pajęczno", "EPJ" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "93", "4", "Radomsko", "ERA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "94", "4", "Rawa Mazowiecka", "ERW" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "95", "4", "Skierniewice", "ES" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "96", "4", "Sieradz", "ESI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "97", "4", "Skierniewice", "ESK" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "98", "4", "Tomaszów Mazowiecki", "ETM" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "99", "4", "Wieruszów", "EWE" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "100", "4", "Wieluń", "EWI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "101", "4", "Zduńska Wola", "EZD" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "102", "4", "Zgierz", "EZG" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "103", "5", "Gorzów Wielkopolski (miasto)", "FG" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "104", "5", "Gorzów Wielkopolski (powiat)", "FGW" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "105", "5", "Krosno Odrzańskie", "FKR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "106", "5", "Międzyrzecz", "FMI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "107", "5", "Nowa Sól", "FNW" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "108", "5", "Strzelce Krajeńskie", "FSD" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "109", "5", "Słubice", "FSL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "110", "5", "Sulęcin", "FSU" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "111", "5", "Świebodzin", "FSW" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "112", "5", "Wschowa", "FWS" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "113", "5", "Zielona Góra (miasto)", "FZ" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "114", "5", "Żary", "FZA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "115", "5", "Żagań", "FZG" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "116", "5", "Zielona Góra (powiat)", "FZI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "117", "6", "Gdynia", "GA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "118", "6", "Bytów", "GBY" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "119", "6", "Chojnice", "GCH" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "120", "6", "Człuchów", "GCZ" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "121", "6", "Gdańsk (miasto)", "GD" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "122", "6", "Gdańsk (powiat - Pruszcz Gdański)", "GDA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "123", "6", "Kartuzy", "GKA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "124", "6", "Kościerzyna", "GKS" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "125", "6", "Kwidzyn", "GKW" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "126", "6", "Lębork", "GLE" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "127", "6", "Malbork", "GMB" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "128", "6", "Nowy Dwór Gdański", "GND" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "129", "6", "Puck", "GPU" });
            migrationBuilder.InsertData(
           table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
           values: new object[] { "130", "6", "Słupsk (miasto)", "GS" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "131", "6", "Słupsk (powiat)", "GSL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "132", "6", "Sopot", "GSP" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "133", "6", "Starogard Gdański", "GST" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "134", "6", "Sztum", "GSZ" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "135", "6", "Tczew", "GTC" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "136", "6", "Wejherowo", "GWE" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "137", "6", "Wejherowo", "GWO" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "138", "7", "Bochnia", "KBA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "139", "7", "Bochnia", "KBC" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "140", "7", "Brzesko", "KBR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "141", "7", "Chrzanów", "KCH" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "142", "7", "Dąbrowa Tarnowska", "KDA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "143", "7", "Gorlice", "KGR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "144", "7", "Kraków (miasto)", "KK" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "145", "7", "Limanowa", "KLI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "146", "7", "Miechów", "KMI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "147", "7", "Myślenice", "KMY" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "148", "7", "Nowy Sącz (miasto)", "KN" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "149", "7", "Nowy Sącz (powiat)", "KNS" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "150", "7", "Nowy Targ", "KNT" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "151", "7", "Olkusz", "KOL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "152", "7", "Oświęcim", "KOS" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "153", "7", "Proszowice", "KPR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "154", "7", "Kraków (miasto)", "KR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "155", "7", "Kraków (powiat)", "KRA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "156", "7", "Sucha Beskidzka", "KSU" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "157", "7", "Tarnów (miasto)", "KT" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "158", "7", "Tarnów (powiat)", "KTA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "159", "7", "Zakopane", "KTT" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "160", "7", "Wadowice", "KWA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "161", "7", "Wieliczka", "KWI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "162", "8", "Biała Podlaska (miasto)", "LB" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "163", "8", "Biała Podlaska (powiat)", "LBI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "164", "8", "Biłgoraj", "LBL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "165", "8", "Chełm (miasto)", "LC" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "166", "8", "Chełm (powiat)", "LCH" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "167", "8", "Hrubieszów", "LHR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "168", "8", "Janów Lubelski", "LJA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "169", "8", "Kraśnik", "LKR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "170", "8", "Krasnystaw", "LKS" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "171", "8", "Lubartów", "LLB" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "172", "8", "Łęczna", "LLE" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "173", "8", "Łuków", "LLU" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "174", "8", "Opole Lubelskie", "LOP" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "175", "8", "Parczew", "LPA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "176", "8", "Puławy", "LPU" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "177", "8", "Radzyń Podlaski", "LRA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "178", "8", "Ryki", "LRY" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "179", "8", "Świdnik", "LSW" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "180", "8", "Tomaszów Lubelski", "LTM" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "181", "8", "Lublin (miasto)", "LU" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "182", "8", "Lublin (powiat)", "LUB" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "183", "8", "Włodawa", "LWL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "184", "8", "Zamość (miasto)", "LZ" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "185", "8", "Zamość (powiat)", "LZA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "186", "9", "Bartoszyce", "NBA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "187", "9", "Braniewo", "NBR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "188", "9", "Działdowo", "NDZ" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "189", "9", "Elbląg (miasto)", "NE" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "190", "9", "Elbląg (powiat)", "NEB" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "191", "9", "Ełk", "NEL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "192", "9", "Giżycko", "NGI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "193", "9", "Gołdap", "NGO" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "194", "9", "Iława", "NIL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "195", "9", "Kętrzyn", "NKE" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "196", "9", "Lidzbark Warmiński", "NLI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "197", "9", "Mrągowo", "NMR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "198", "9", "Nidzica", "NNI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "199", "9", "Nowe Miasto Lubawskie", "NNM" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "200", "9", "Olsztyn (miasto)", "NO" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "201", "9", "Olecko (od 2002r.)", "NOE" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "202", "9", "Olecko (do 2002r.)", "NOG" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "203", "9", "Olsztyn (powiat)", "NOL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "204", "9", "Ostróda", "NOS" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "205", "9", "Pisz", "NPI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "206", "9", "Szczytno", "NSZ" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "207", "9", "Węgorzewo", "NWE" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "208", "10", "Brzeg", "OB" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "209", "10", "Głubczyce", "OGL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "210", "10", "Kędzierzyn - Koźle", "OK" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "211", "10", "Kluczbork", "OKL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "212", "10", "Krapkowice", "OKR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "213", "10", "Namysłów", "ONA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "214", "10", "Nysa", "ONY" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "215", "10", "Olesno", "OOL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "216", "10", "Opole (miasto)", "OP" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "217", "10", "Opole (powiat)", "OPO" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "218", "10", "Prudnik", "OPR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "219", "10", "Strzelce Opolskie", "OST" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "220", "11", "Kalisz", "PA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "221", "11", "Chodzież", "PCH" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "222", "11", "Czarnków", "PCT" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "223", "11", "Gniezno", "PGN" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "224", "11", "Grodzisk Wielkopolski", "PGO" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "225", "11", "Gostyń", "PGS" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "226", "11", "Jarocin", "PJA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "227", "11", "Kalisz (miasto)", "PK" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "228", "11", "Kalisz (powiat)", "PKA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "229", "11", "Kępno", "PKE" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "230", "11", "Koło", "PKL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "231", "11", "Konin (powiat)", "PKN" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "232", "11", "Konin (miasto do 2002r.)", "PKO" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "233", "11", "Krotoszyn", "PKR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "234", "11", "Kościan", "PKS" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "235", "11", "Leszno (miasto)", "PL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "236", "11", "Leszno (powiat)", "PLE" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "237", "11", "Międzychód", "PMI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "238", "11", "Konin (miasto od 2002r.)", "PN" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "239", "11", "Nowy Tomyśl", "PNT" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "240", "11", "Poznań (miasto)", "PO" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "241", "11", "Oborniki", "POB" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "242", "11", "Ostrów Wielkopolski", "POS" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "243", "11", "Ostrzeszów", "POT" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "244", "11", "Poznań (powiat do 2002r.)", "POZ" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "245", "11", "Piła", "PP" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "246", "11", "Pleszew", "PPL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "247", "11", "Rawicz", "PRA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "248", "11", "Śrem", "PSE" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "249", "11", "Słupca", "PSL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "250", "11", "Środa Wielkopolska", "PSR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "251", "11", "Szamotuły", "PSZ" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "252", "11", "Turek", "PTU" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "253", "11", "Wągrowiec", "PWA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "254", "11", "Wolsztyn", "PWL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "255", "11", "Września", "PWR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "256", "11", "Poznań (miasto)", "PY" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "257", "11", "Poznań (powiat od 2002r.)", "PZ" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "258", "11", "Złotów", "PZL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "259", "12", "Ustrzyki Dolne", "RBI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "260", "12", "Brzozów", "RBR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "261", "12", "Dębica", "RDE" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "262", "12", "Jarosław", "RJA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "263", "12", "Jasło", "RJS" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "264", "12", "Krosno (miasto)", "RK" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "265", "12", "Kolbuszowa", "RKL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "266", "12", "Krosno (powiat)", "RKR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "267", "12", "Łańcut", "RLA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "268", "12", "Leżajsk", "RLE" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "269", "12", "Lesko", "RLS" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "270", "12", "Lubaczów", "RLU" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "271", "12", "Mielec", "RMI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "272", "12", "Nisko", "RNI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "273", "12", "Przemyśl (miasto)", "RP" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "274", "12", "Przemyśl (powiat)", "RBR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "275", "12", "Przeworsk", "RPZ" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "276", "12", "Ropczycko-Sędziszowski", "RRS" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "277", "12", "Sanok", "RSA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "278", "12", "Strzyżów", "RSR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "279", "12", "Stalowa Wola", "RST" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "280", "12", "Tarnobrzeg (miasto)", "RT" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "281", "12", "Tarnobrzeg (powiat)", "RTA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "282", "12", "Rzeszów (miasto)", "RZ" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "283", "12", "Rzeszów (powiat)", "RZE" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "284", "13", "Bielsko - Biała (miasto)", "SB" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "285", "13", "Będzin", "SBE" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "286", "13", "Bielsko - Biała (powiat)", "SBI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "287", "13", "Bieruń", "SBL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "288", "13", "Częstochowa (miasto)", "SC" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "289", "13", "Cieszyn", "SCI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "290", "13", "Częstochowa (powiat)", "SCZ" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "291", "13", "Dąbrowa Górnicza", "SD" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "292", "13", "Gliwice (miasto)", "SG" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "293", "13", "Gliwice (powiat)", "SGL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "294", "13", "Chorzów", "SH" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "295", "13", "Siemianowice Śląskie", "SI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "296", "13", "Jaworzno", "SJ" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "297", "13", "Jastrzębie Zdrój", "SJZ" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "298", "13", "Katowice", "SK" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "299", "13", "Kłobuck", "SKL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "300", "13", "Ruda Śląska (od 2002r.)", "SL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "301", "13", "Lubliniec", "SLU" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "302", "13", "Mysłowice", "SM" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "303", "13", "Mikołów", "SMI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "304", "13", "Myszków", "SMY" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "305", "13", "Sosnowiec", "SO" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "306", "13", "Piekary Śląskie", "SPI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "307", "13", "Pszczyna", "SPS" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "308", "13", "Rybnik (miasto)", "SR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "309", "13", "Rybnik (powiat)", "SRB" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "310", "13", "Racibórz", "SRC" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "311", "13", "Ruda Śląska (do 2002r.)", "SRS" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "312", "13", "Tychy", "ST" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "313", "13", "Tarnowskie Góry", "STA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "314", "13", "Tychy (powiat do 2002r.)", "STY" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "315", "13", "Świętochłowice", "SW" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "316", "13", "Wodzisław Śląski", "SWD" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "317", "13", "Wodzisław Śląski", "SWZ" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "318", "13", "Bytom", "SY" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "319", "13", "Zabrze", "SZ" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "320", "13", "Zawiercie", "SZA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "321", "13", "Żory", "SZO" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "322", "13", "Żywiec", "SZY" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "323", "14", "Busko - Zdrój", "TBU" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "324", "14", "Jędrzejów", "TJE" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "325", "14", "Kielce (miasto)", "TK" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "326", "14", "Kazimierza Wielka", "TKA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "327", "14", "Kielce (powiat)", "TKI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "328", "14", "Końskie", "TKN" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "329", "14", "Włoszczowa", "TLW" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "330", "14", "Opatów", "TOP" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "331", "14", "Ostrowiec Świętokrzyski", "TOS" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "332", "14", "Pińczów", "TPI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "333", "14", "Sandomierz", "TSA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "334", "14", "Skarżysko - Kamienna", "TSK" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "335", "14", "Starachowice", "TST" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "336", "14", "Staszów", "TSZ" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "337", "15", "Warszawa", "WA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "338", "15", "Warszawa", "WB" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "339", "15", "Białobrzegi", "WBR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "340", "15", "Ciechanów", "WCI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "341", "15", "Warszawa", "WD" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "342", "15", "Warszawa", "WE" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "343", "15", "Warszawa", "WF" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "344", "15", "Garwolin", "WG" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "345", "15", "Grodzisk Mazowiecki", "WGM" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "346", "15", "Grójec", "WGR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "347", "15", "Gostynin", "WGS" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "348", "15", "Warszawa", "WH" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "349", "15", "Warszawa", "WI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "350", "15", "Warszawa", "WJ" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "351", "15", "Warszawa", "WK" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "352", "15", "Kozienice", "WKZ" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "353", "15", "Legionowo", "WL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "354", "15", "Lipsko", "WLI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "355", "15", "Łosice", "WLS" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "356", "15", "Mińsk Mazowiecki", "WM" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "357", "15", "Maków Mazowiecki", "WMA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "358", "15", "Mława", "WML" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "359", "15", "Warszawa", "WN" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "360", "15", "Nowy Dwór Mazowiecki", "WND" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "361", "15", "Ostrołęka (miasto)", "WND" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "362", "15", "Ostrów Mazowiecka", "WOR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "363", "15", "Ostrołęka (powiat)", "WOS" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "364", "15", "Otwock", "WOT" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "365", "15", "Płock (miasto)", "WP" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "366", "15", "Piaseczno", "WPI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "367", "15", "Płock (powiat)", "WPL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "368", "15", "Płońsk", "WPN" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "369", "15", "Pruszków", "WPP" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "370", "15", "Pruszków", "WPR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "371", "15", "Pruszków", "WPS" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "372", "15", "Pułtusk", "WPU" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "373", "15", "Przysucha", "WPY" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "374", "15", "Przasnysz", "WPZ" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "375", "15", "Radom (miasto)", "WR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "376", "15", "Radom (powiat)", "WRA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "377", "15", "Siedlce (miasto)", "WS" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "378", "15", "Sochaczew", "WSC" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "379", "15", "Sierpc", "WSE" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "380", "15", "Siedlce (powiat)", "WSI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "381", "15", "Sokołów Podlaski", "WSK" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "382", "15", "Szydłowiec", "WSZ" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "383", "15", "Warszawa", "WT" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "384", "15", "Warszawa", "WU" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "385", "15", "Wołomin (od 2003r.)", "WV" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "386", "15", "Warszawa", "WW" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "387", "15", "Węgrów", "WWE" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "388", "15", "Wołomin (do 2003r.)", "WWL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "389", "15", "Wyszków", "WWY" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "390", "15", "Warszawa", "WX" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "391", "15", "Warszawa", "WY" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "392", "15", "Warszawa Zachód", "WZ" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "393", "15", "Żuromin", "WZU" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "394", "15", "Zwoleń", "WZW" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "395", "15", "Żyrardów", "WZY" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "396", "16", "Białogard", "ZBI" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "397", "16", "Choszczno", "ZCH" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "398", "16", "Drawsko Pomorskie", "ZDR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "399", "16", "Goleniów", "ZGL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "400", "16", "Gryfino", "ZGR" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "401", "16", "Gryfice", "ZGY" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "402", "16", "Koszalin (miasto)", "ZK" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "403", "16", "Kamień Pomorski", "ZKA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "404", "16", "Kołobrzeg", "ZKL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "405", "16", "Koszalin (powiat)", "ZKO" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "406", "16", "Łobez", "ZLO" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "407", "16", "Myslibórz", "ZMY" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "408", "16", "Police", "ZPL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "409", "16", "Pyrzyce", "ZPY" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "410", "16", "Szczecin", "ZS" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "411", "16", "Świdwin", "ZSD" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "412", "16", "Sławno", "ZSL" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "413", "16", "Stargard Szczeciński", "ZST" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "414", "16", "Świnoujście", "ZSW" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "415", "16", "Szczecinek", "ZSZ" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "416", "16", "Wałacz", "ZWA" });
            migrationBuilder.InsertData(
          table: "Powiaty",
          columns: new[] { "powiatId", "wojewodztwoidwojewodztwaID", "Name", "tab_letter" },
          values: new object[] { "417", "16", "Szczecin", "ZZ" });


        }
    }
}

