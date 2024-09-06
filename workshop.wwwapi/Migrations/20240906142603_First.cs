using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace workshop.wwwapi.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bottles",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    brand = table.Column<string>(type: "text", nullable: false),
                    size = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bottles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "fridge",
                columns: table => new
                {
                    studentid = table.Column<int>(type: "integer", nullable: false),
                    bottleid = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fridge", x => new { x.studentid, x.bottleid });
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    firstname = table.Column<string>(type: "text", nullable: false),
                    lastname = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "bottles",
                columns: new[] { "id", "brand", "size" },
                values: new object[,]
                {
                    { 1, "Heineken", 330 },
                    { 2, "Bud", 330 },
                    { 3, "Fosters", 330 },
                    { 4, "Doom Bar", 330 }
                });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "email", "firstname", "lastname" },
                values: new object[,]
                {
                    { 1, "jimi.jagger@google.com", "Jimi", "Jagger" },
                    { 2, "barack.jagger@google.com", "Barack", "Jagger" },
                    { 3, "kate.presley@something.com", "Kate", "Presley" },
                    { 4, "mick.hepburn@theworld.ca", "Mick", "Hepburn" },
                    { 5, "kate.jagger@gov.us", "Kate", "Jagger" },
                    { 6, "kate.obama@gov.ru", "Kate", "Obama" },
                    { 7, "oprah.winslet@gov.gr", "Oprah", "Winslet" },
                    { 8, "charles.hepburn@tesla.com", "Charles", "Hepburn" },
                    { 9, "kate.hepburn@bbc.co.uk", "Kate", "Hepburn" },
                    { 10, "audrey.middleton@nasa.org.us", "Audrey", "Middleton" },
                    { 11, "kate.jagger@gov.us", "Kate", "Jagger" },
                    { 12, "audrey.windsor@theworld.ca", "Audrey", "Windsor" },
                    { 13, "kate.presley@nasa.org.us", "Kate", "Presley" },
                    { 14, "jimi.presley@bbc.co.uk", "Jimi", "Presley" },
                    { 15, "mick.hendrix@tesla.com", "Mick", "Hendrix" },
                    { 16, "audrey.trump@gov.us", "Audrey", "Trump" },
                    { 17, "audrey.presley@something.com", "Audrey", "Presley" },
                    { 18, "charles.trump@theworld.ca", "Charles", "Trump" },
                    { 19, "oprah.hepburn@gov.ru", "Oprah", "Hepburn" },
                    { 20, "jimi.winfrey@something.com", "Jimi", "Winfrey" },
                    { 21, "kate.winslet@something.com", "Kate", "Winslet" },
                    { 22, "charles.winslet@nasa.org.us", "Charles", "Winslet" },
                    { 23, "jimi.presley@theworld.ca", "Jimi", "Presley" },
                    { 24, "kate.obama@gov.ru", "Kate", "Obama" },
                    { 25, "kate.middleton@google.com", "Kate", "Middleton" },
                    { 26, "kate.presley@something.com", "Kate", "Presley" },
                    { 27, "audrey.obama@google.com", "Audrey", "Obama" },
                    { 28, "audrey.obama@gov.gr", "Audrey", "Obama" },
                    { 29, "jimi.presley@nasa.org.us", "Jimi", "Presley" },
                    { 30, "elvis.jagger@nasa.org.us", "Elvis", "Jagger" },
                    { 31, "audrey.jagger@tesla.com", "Audrey", "Jagger" },
                    { 32, "elvis.winslet@gov.ru", "Elvis", "Winslet" },
                    { 33, "barack.presley@gov.us", "Barack", "Presley" },
                    { 34, "mick.winslet@gov.nl", "Mick", "Winslet" },
                    { 35, "audrey.trump@gov.gr", "Audrey", "Trump" },
                    { 36, "donald.jagger@nasa.org.us", "Donald", "Jagger" },
                    { 37, "audrey.trump@something.com", "Audrey", "Trump" },
                    { 38, "donald.hepburn@gov.us", "Donald", "Hepburn" },
                    { 39, "mick.presley@google.com", "Mick", "Presley" },
                    { 40, "donald.windsor@gov.ru", "Donald", "Windsor" },
                    { 41, "charles.middleton@gov.ru", "Charles", "Middleton" },
                    { 42, "elvis.trump@google.com", "Elvis", "Trump" },
                    { 43, "audrey.jagger@gov.nl", "Audrey", "Jagger" },
                    { 44, "audrey.jagger@gov.ru", "Audrey", "Jagger" },
                    { 45, "donald.winslet@gov.us", "Donald", "Winslet" },
                    { 46, "elvis.trump@something.com", "Elvis", "Trump" },
                    { 47, "oprah.windsor@gov.gr", "Oprah", "Windsor" },
                    { 48, "barack.middleton@gov.us", "Barack", "Middleton" },
                    { 49, "elvis.hendrix@gov.gr", "Elvis", "Hendrix" },
                    { 50, "jimi.hendrix@gov.nl", "Jimi", "Hendrix" },
                    { 51, "audrey.jagger@google.com", "Audrey", "Jagger" },
                    { 52, "kate.middleton@gov.gr", "Kate", "Middleton" },
                    { 53, "elvis.middleton@tesla.com", "Elvis", "Middleton" },
                    { 54, "kate.middleton@gov.nl", "Kate", "Middleton" },
                    { 55, "donald.winslet@gov.us", "Donald", "Winslet" },
                    { 56, "elvis.winslet@nasa.org.us", "Elvis", "Winslet" },
                    { 57, "donald.windsor@gov.nl", "Donald", "Windsor" },
                    { 58, "charles.windsor@bbc.co.uk", "Charles", "Windsor" },
                    { 59, "mick.windsor@gov.us", "Mick", "Windsor" },
                    { 60, "mick.presley@something.com", "Mick", "Presley" },
                    { 61, "oprah.winfrey@tesla.com", "Oprah", "Winfrey" },
                    { 62, "elvis.winslet@google.com", "Elvis", "Winslet" },
                    { 63, "oprah.hepburn@gov.us", "Oprah", "Hepburn" },
                    { 64, "elvis.presley@google.com", "Elvis", "Presley" },
                    { 65, "jimi.presley@theworld.ca", "Jimi", "Presley" },
                    { 66, "oprah.hepburn@gov.gr", "Oprah", "Hepburn" },
                    { 67, "donald.presley@tesla.com", "Donald", "Presley" },
                    { 68, "donald.hepburn@google.com", "Donald", "Hepburn" },
                    { 69, "charles.trump@gov.gr", "Charles", "Trump" },
                    { 70, "oprah.trump@google.com", "Oprah", "Trump" },
                    { 71, "kate.trump@gov.gr", "Kate", "Trump" },
                    { 72, "donald.winfrey@theworld.ca", "Donald", "Winfrey" },
                    { 73, "charles.winfrey@something.com", "Charles", "Winfrey" },
                    { 74, "elvis.hepburn@gov.gr", "Elvis", "Hepburn" },
                    { 75, "donald.hepburn@gov.nl", "Donald", "Hepburn" },
                    { 76, "kate.presley@theworld.ca", "Kate", "Presley" },
                    { 77, "jimi.jagger@tesla.com", "Jimi", "Jagger" },
                    { 78, "jimi.hendrix@tesla.com", "Jimi", "Hendrix" },
                    { 79, "charles.trump@tesla.com", "Charles", "Trump" },
                    { 80, "jimi.hepburn@theworld.ca", "Jimi", "Hepburn" },
                    { 81, "kate.hepburn@gov.us", "Kate", "Hepburn" },
                    { 82, "barack.obama@theworld.ca", "Barack", "Obama" },
                    { 83, "jimi.hendrix@gov.nl", "Jimi", "Hendrix" },
                    { 84, "jimi.windsor@bbc.co.uk", "Jimi", "Windsor" },
                    { 85, "barack.jagger@gov.nl", "Barack", "Jagger" },
                    { 86, "mick.obama@gov.nl", "Mick", "Obama" },
                    { 87, "elvis.middleton@gov.gr", "Elvis", "Middleton" },
                    { 88, "donald.obama@nasa.org.us", "Donald", "Obama" },
                    { 89, "oprah.windsor@bbc.co.uk", "Oprah", "Windsor" },
                    { 90, "audrey.hendrix@something.com", "Audrey", "Hendrix" },
                    { 91, "jimi.hendrix@bbc.co.uk", "Jimi", "Hendrix" },
                    { 92, "mick.windsor@something.com", "Mick", "Windsor" },
                    { 93, "jimi.winslet@something.com", "Jimi", "Winslet" },
                    { 94, "charles.winslet@gov.gr", "Charles", "Winslet" },
                    { 95, "audrey.winfrey@tesla.com", "Audrey", "Winfrey" },
                    { 96, "mick.obama@theworld.ca", "Mick", "Obama" },
                    { 97, "elvis.windsor@tesla.com", "Elvis", "Windsor" },
                    { 98, "elvis.windsor@something.com", "Elvis", "Windsor" },
                    { 99, "jimi.hepburn@gov.nl", "Jimi", "Hepburn" },
                    { 100, "kate.winslet@gov.gr", "Kate", "Winslet" },
                    { 101, "jimi.winslet@gov.nl", "Jimi", "Winslet" },
                    { 102, "charles.windsor@google.com", "Charles", "Windsor" },
                    { 103, "barack.hepburn@gov.gr", "Barack", "Hepburn" },
                    { 104, "donald.hepburn@bbc.co.uk", "Donald", "Hepburn" },
                    { 105, "elvis.trump@google.com", "Elvis", "Trump" },
                    { 106, "barack.jagger@gov.ru", "Barack", "Jagger" },
                    { 107, "kate.presley@nasa.org.us", "Kate", "Presley" },
                    { 108, "jimi.windsor@gov.us", "Jimi", "Windsor" },
                    { 109, "barack.winslet@something.com", "Barack", "Winslet" },
                    { 110, "audrey.winfrey@bbc.co.uk", "Audrey", "Winfrey" },
                    { 111, "donald.hendrix@google.com", "Donald", "Hendrix" },
                    { 112, "audrey.presley@nasa.org.us", "Audrey", "Presley" },
                    { 113, "oprah.presley@bbc.co.uk", "Oprah", "Presley" },
                    { 114, "kate.trump@google.com", "Kate", "Trump" },
                    { 115, "mick.winslet@something.com", "Mick", "Winslet" },
                    { 116, "audrey.winfrey@gov.us", "Audrey", "Winfrey" },
                    { 117, "jimi.winfrey@gov.ru", "Jimi", "Winfrey" },
                    { 118, "kate.obama@bbc.co.uk", "Kate", "Obama" },
                    { 119, "kate.winslet@tesla.com", "Kate", "Winslet" },
                    { 120, "oprah.middleton@bbc.co.uk", "Oprah", "Middleton" },
                    { 121, "kate.jagger@gov.us", "Kate", "Jagger" },
                    { 122, "audrey.winslet@nasa.org.us", "Audrey", "Winslet" },
                    { 123, "charles.hendrix@gov.us", "Charles", "Hendrix" },
                    { 124, "oprah.trump@gov.nl", "Oprah", "Trump" },
                    { 125, "kate.trump@something.com", "Kate", "Trump" },
                    { 126, "kate.jagger@gov.nl", "Kate", "Jagger" },
                    { 127, "oprah.presley@gov.ru", "Oprah", "Presley" },
                    { 128, "donald.presley@gov.nl", "Donald", "Presley" },
                    { 129, "audrey.presley@bbc.co.uk", "Audrey", "Presley" },
                    { 130, "kate.windsor@google.com", "Kate", "Windsor" },
                    { 131, "kate.jagger@gov.gr", "Kate", "Jagger" },
                    { 132, "mick.jagger@gov.gr", "Mick", "Jagger" },
                    { 133, "kate.hepburn@bbc.co.uk", "Kate", "Hepburn" },
                    { 134, "oprah.jagger@tesla.com", "Oprah", "Jagger" },
                    { 135, "oprah.windsor@gov.nl", "Oprah", "Windsor" },
                    { 136, "elvis.hendrix@theworld.ca", "Elvis", "Hendrix" },
                    { 137, "barack.hendrix@gov.ru", "Barack", "Hendrix" },
                    { 138, "charles.winslet@gov.ru", "Charles", "Winslet" },
                    { 139, "jimi.presley@something.com", "Jimi", "Presley" },
                    { 140, "kate.jagger@google.com", "Kate", "Jagger" },
                    { 141, "barack.presley@gov.nl", "Barack", "Presley" },
                    { 142, "oprah.winslet@nasa.org.us", "Oprah", "Winslet" },
                    { 143, "audrey.hepburn@gov.ru", "Audrey", "Hepburn" },
                    { 144, "oprah.jagger@gov.gr", "Oprah", "Jagger" },
                    { 145, "barack.hepburn@tesla.com", "Barack", "Hepburn" },
                    { 146, "mick.hepburn@theworld.ca", "Mick", "Hepburn" },
                    { 147, "elvis.jagger@google.com", "Elvis", "Jagger" },
                    { 148, "elvis.winfrey@nasa.org.us", "Elvis", "Winfrey" },
                    { 149, "oprah.winslet@gov.nl", "Oprah", "Winslet" },
                    { 150, "audrey.windsor@google.com", "Audrey", "Windsor" },
                    { 151, "barack.windsor@theworld.ca", "Barack", "Windsor" },
                    { 152, "barack.presley@nasa.org.us", "Barack", "Presley" },
                    { 153, "barack.winfrey@bbc.co.uk", "Barack", "Winfrey" },
                    { 154, "mick.presley@gov.nl", "Mick", "Presley" },
                    { 155, "barack.obama@gov.gr", "Barack", "Obama" },
                    { 156, "jimi.winslet@gov.us", "Jimi", "Winslet" },
                    { 157, "barack.winfrey@gov.ru", "Barack", "Winfrey" },
                    { 158, "oprah.jagger@bbc.co.uk", "Oprah", "Jagger" },
                    { 159, "mick.winslet@something.com", "Mick", "Winslet" },
                    { 160, "charles.presley@gov.ru", "Charles", "Presley" },
                    { 161, "jimi.hepburn@bbc.co.uk", "Jimi", "Hepburn" },
                    { 162, "elvis.trump@google.com", "Elvis", "Trump" },
                    { 163, "barack.middleton@nasa.org.us", "Barack", "Middleton" },
                    { 164, "mick.hendrix@gov.us", "Mick", "Hendrix" },
                    { 165, "elvis.winfrey@nasa.org.us", "Elvis", "Winfrey" },
                    { 166, "barack.winslet@bbc.co.uk", "Barack", "Winslet" },
                    { 167, "kate.windsor@nasa.org.us", "Kate", "Windsor" },
                    { 168, "kate.middleton@gov.us", "Kate", "Middleton" },
                    { 169, "mick.obama@tesla.com", "Mick", "Obama" },
                    { 170, "oprah.hendrix@theworld.ca", "Oprah", "Hendrix" },
                    { 171, "donald.hepburn@nasa.org.us", "Donald", "Hepburn" },
                    { 172, "kate.trump@nasa.org.us", "Kate", "Trump" },
                    { 173, "charles.presley@gov.gr", "Charles", "Presley" },
                    { 174, "jimi.winslet@tesla.com", "Jimi", "Winslet" },
                    { 175, "mick.windsor@gov.gr", "Mick", "Windsor" },
                    { 176, "kate.windsor@gov.nl", "Kate", "Windsor" },
                    { 177, "jimi.hendrix@something.com", "Jimi", "Hendrix" },
                    { 178, "elvis.presley@google.com", "Elvis", "Presley" },
                    { 179, "kate.hendrix@bbc.co.uk", "Kate", "Hendrix" },
                    { 180, "barack.hepburn@gov.gr", "Barack", "Hepburn" },
                    { 181, "kate.jagger@tesla.com", "Kate", "Jagger" },
                    { 182, "donald.middleton@tesla.com", "Donald", "Middleton" },
                    { 183, "barack.jagger@something.com", "Barack", "Jagger" },
                    { 184, "charles.hendrix@gov.ru", "Charles", "Hendrix" },
                    { 185, "elvis.presley@bbc.co.uk", "Elvis", "Presley" },
                    { 186, "jimi.windsor@gov.gr", "Jimi", "Windsor" },
                    { 187, "kate.presley@nasa.org.us", "Kate", "Presley" },
                    { 188, "barack.winfrey@theworld.ca", "Barack", "Winfrey" },
                    { 189, "charles.obama@gov.nl", "Charles", "Obama" },
                    { 190, "audrey.jagger@gov.us", "Audrey", "Jagger" },
                    { 191, "mick.presley@google.com", "Mick", "Presley" },
                    { 192, "audrey.hendrix@bbc.co.uk", "Audrey", "Hendrix" },
                    { 193, "audrey.obama@gov.gr", "Audrey", "Obama" },
                    { 194, "charles.middleton@theworld.ca", "Charles", "Middleton" },
                    { 195, "kate.obama@bbc.co.uk", "Kate", "Obama" },
                    { 196, "kate.middleton@theworld.ca", "Kate", "Middleton" },
                    { 197, "charles.middleton@gov.us", "Charles", "Middleton" },
                    { 198, "oprah.jagger@google.com", "Oprah", "Jagger" },
                    { 199, "charles.middleton@gov.ru", "Charles", "Middleton" },
                    { 200, "audrey.jagger@gov.gr", "Audrey", "Jagger" },
                    { 201, "kate.hepburn@bbc.co.uk", "Kate", "Hepburn" },
                    { 202, "kate.winslet@gov.us", "Kate", "Winslet" },
                    { 203, "mick.trump@gov.gr", "Mick", "Trump" },
                    { 204, "oprah.middleton@gov.us", "Oprah", "Middleton" },
                    { 205, "donald.hepburn@gov.gr", "Donald", "Hepburn" },
                    { 206, "barack.obama@google.com", "Barack", "Obama" },
                    { 207, "kate.winfrey@google.com", "Kate", "Winfrey" },
                    { 208, "kate.middleton@gov.us", "Kate", "Middleton" },
                    { 209, "kate.jagger@something.com", "Kate", "Jagger" },
                    { 210, "kate.obama@google.com", "Kate", "Obama" },
                    { 211, "mick.jagger@google.com", "Mick", "Jagger" },
                    { 212, "mick.windsor@bbc.co.uk", "Mick", "Windsor" },
                    { 213, "audrey.middleton@gov.ru", "Audrey", "Middleton" },
                    { 214, "oprah.winslet@gov.ru", "Oprah", "Winslet" },
                    { 215, "kate.presley@gov.gr", "Kate", "Presley" },
                    { 216, "elvis.winslet@bbc.co.uk", "Elvis", "Winslet" },
                    { 217, "audrey.presley@tesla.com", "Audrey", "Presley" },
                    { 218, "kate.trump@gov.us", "Kate", "Trump" },
                    { 219, "charles.hendrix@gov.nl", "Charles", "Hendrix" },
                    { 220, "oprah.trump@gov.gr", "Oprah", "Trump" },
                    { 221, "kate.presley@gov.nl", "Kate", "Presley" },
                    { 222, "donald.winfrey@nasa.org.us", "Donald", "Winfrey" },
                    { 223, "kate.winslet@gov.nl", "Kate", "Winslet" },
                    { 224, "mick.hendrix@bbc.co.uk", "Mick", "Hendrix" },
                    { 225, "kate.presley@bbc.co.uk", "Kate", "Presley" },
                    { 226, "elvis.winslet@something.com", "Elvis", "Winslet" },
                    { 227, "mick.trump@google.com", "Mick", "Trump" },
                    { 228, "kate.jagger@google.com", "Kate", "Jagger" },
                    { 229, "elvis.hendrix@gov.nl", "Elvis", "Hendrix" },
                    { 230, "elvis.presley@gov.ru", "Elvis", "Presley" },
                    { 231, "donald.winslet@something.com", "Donald", "Winslet" },
                    { 232, "elvis.presley@nasa.org.us", "Elvis", "Presley" },
                    { 233, "mick.trump@nasa.org.us", "Mick", "Trump" },
                    { 234, "jimi.hepburn@theworld.ca", "Jimi", "Hepburn" },
                    { 235, "audrey.winslet@nasa.org.us", "Audrey", "Winslet" },
                    { 236, "mick.trump@tesla.com", "Mick", "Trump" },
                    { 237, "mick.winslet@gov.us", "Mick", "Winslet" },
                    { 238, "elvis.middleton@gov.gr", "Elvis", "Middleton" },
                    { 239, "jimi.jagger@gov.ru", "Jimi", "Jagger" },
                    { 240, "mick.hepburn@gov.gr", "Mick", "Hepburn" },
                    { 241, "barack.middleton@something.com", "Barack", "Middleton" },
                    { 242, "barack.middleton@gov.nl", "Barack", "Middleton" },
                    { 243, "oprah.middleton@tesla.com", "Oprah", "Middleton" },
                    { 244, "kate.hendrix@gov.us", "Kate", "Hendrix" },
                    { 245, "elvis.obama@nasa.org.us", "Elvis", "Obama" },
                    { 246, "jimi.hendrix@theworld.ca", "Jimi", "Hendrix" },
                    { 247, "audrey.middleton@bbc.co.uk", "Audrey", "Middleton" },
                    { 248, "oprah.winfrey@tesla.com", "Oprah", "Winfrey" },
                    { 249, "jimi.presley@theworld.ca", "Jimi", "Presley" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bottles");

            migrationBuilder.DropTable(
                name: "fridge");

            migrationBuilder.DropTable(
                name: "students");
        }
    }
}
