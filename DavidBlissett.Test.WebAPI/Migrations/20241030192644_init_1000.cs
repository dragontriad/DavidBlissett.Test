using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DavidBlissett.Test.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class init_1000 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address1 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Address2 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address1", "Address2", "FirstName", "LastName", "PostCode", "TelephoneNumber" },
                values: new object[,]
                {
                    { 1, "10 Downing Street", "Westminster", "John", "Doe", "SW1A 2AA", "020-7123-4567" },
                    { 2, "1 King Street", "St. James's", "Jane", "Smith", "SW1Y 6QW", "020-7890-1234" },
                    { 3, "15 Queen Square", "", "Mike", "Brown", "BS1 4NT", "0117-9876-5432" },
                    { 4, "3 Great George Street", "", "Lucy", "Williams", "BS1 5RH", "0117-6543-2109" },
                    { 5, "2 Broad Street", "", "Chris", "Johnson", "OX1 3AZ", "01865-987-654" },
                    { 6, "5 Magdalen Street", "", "Anna", "Davis", "OX1 3AD", "01865-876-543" },
                    { 7, "1 Albert Square", "", "Tom", "Clark", "M2 5DB", "0161-234-5000" },
                    { 8, "3 Saint Peter's Square", "", "Sara", "Miller", "M2 3AE", "0161-234-6000" },
                    { 9, "30 Dean Street", "", "Ben", "Garcia", "W1D 3RF", "020-7323-4400" },
                    { 10, "1 Oxford Street", "", "Emily", "Martinez", "W1D 2DJ", "020-7450-1234" },
                    { 11, "12 Abbey Road", "", "Oliver", "Hughes", "NW8 9AY", "020-7231-7654" },
                    { 12, "25 College Green", "", "Charlotte", "Wilson", "BS1 5TB", "0117-123-4567" },
                    { 13, "7 Oxford Road", "", "George", "Robinson", "OX1 3PF", "01865-456-789" },
                    { 14, "18 Portland Street", "", "Sophie", "Walker", "M1 3LA", "0161-456-7890" },
                    { 15, "9 Baker Street", "", "James", "Hall", "W1U 3AA", "020-3456-7890" },
                    { 16, "21 Park Row", "", "Amelia", "Green", "BS1 5LJ", "0117-234-5678" },
                    { 17, "17 Cornmarket Street", "", "Henry", "Allen", "OX1 3HL", "01865-321-987" },
                    { 18, "45 King Street", "", "Isabella", "Young", "M2 7AY", "0161-567-4321" },
                    { 19, "62 Charing Cross Road", "", "Jack", "Harris", "WC2H 0BB", "020-9876-5432" },
                    { 20, "14 George Street", "", "Lily", "Martin", "BS1 5TP", "0117-345-6789" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
