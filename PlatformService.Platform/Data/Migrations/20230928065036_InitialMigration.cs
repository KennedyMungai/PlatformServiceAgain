using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlatformService.Platform.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Publisher = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cost = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Cost", "Name", "Publisher" },
                values: new object[,]
                {
                    { 1, 85m, "Tasty Steel Gloves", "Daniel Inc" },
                    { 2, 11m, "Awesome Granite Car", "Langworth - Goodwin" },
                    { 3, 30m, "Licensed Rubber Table", "Herman Inc" },
                    { 4, 56m, "Handcrafted Soft Keyboard", "Hahn - Gerlach" },
                    { 5, 98m, "Sleek Granite Chicken", "Hegmann - Dickinson" },
                    { 6, 45m, "Intelligent Granite Table", "Powlowski and Sons" },
                    { 7, 43m, "Unbranded Steel Table", "Murray LLC" },
                    { 8, 5m, "Handcrafted Metal Chicken", "Koelpin, Bogan and Wiegand" },
                    { 9, 59m, "Small Granite Sausages", "Haley, Kerluke and Rosenbaum" },
                    { 10, 8m, "Generic Steel Car", "Conn, Pagac and Heidenreich" },
                    { 11, 53m, "Tasty Frozen Chair", "Bruen, Johnson and Murazik" },
                    { 12, 59m, "Sleek Wooden Pizza", "Lubowitz LLC" },
                    { 13, 60m, "Incredible Fresh Chips", "Lueilwitz - Beatty" },
                    { 14, 6m, "Sleek Cotton Salad", "Gleason, Mayert and Hahn" },
                    { 15, 68m, "Handmade Steel Gloves", "Frami - Johnston" },
                    { 16, 60m, "Intelligent Steel Chair", "Reinger Group" },
                    { 17, 77m, "Handcrafted Plastic Soap", "Krajcik - Blick" },
                    { 18, 17m, "Tasty Wooden Car", "Willms, Rosenbaum and Bruen" },
                    { 19, 62m, "Tasty Plastic Fish", "Howell Group" },
                    { 20, 90m, "Practical Granite Pants", "Boyle, Lebsack and Block" },
                    { 21, 31m, "Handmade Fresh Table", "Kub, Leannon and Turcotte" },
                    { 22, 40m, "Handcrafted Cotton Shirt", "Ratke - Schuppe" },
                    { 23, 6m, "Fantastic Frozen Bacon", "Hirthe - Kiehn" },
                    { 24, 70m, "Intelligent Cotton Mouse", "Hettinger, Ledner and Wilderman" },
                    { 25, 20m, "Handcrafted Soft Computer", "Oberbrunner and Sons" },
                    { 26, 39m, "Licensed Rubber Soap", "Zboncak Inc" },
                    { 27, 34m, "Handmade Frozen Towels", "Mayert, Wilkinson and Keeling" },
                    { 28, 72m, "Small Soft Computer", "Greenfelder Inc" },
                    { 29, 41m, "Gorgeous Frozen Towels", "Rutherford - Heaney" },
                    { 30, 72m, "Sleek Soft Cheese", "Gulgowski - O'Kon" },
                    { 31, 70m, "Practical Frozen Shirt", "Davis Group" },
                    { 32, 84m, "Rustic Rubber Mouse", "Brakus LLC" },
                    { 33, 59m, "Small Soft Car", "Kiehn - Bradtke" },
                    { 34, 18m, "Unbranded Rubber Cheese", "Mraz - Wolff" },
                    { 35, 97m, "Unbranded Metal Chicken", "Skiles and Sons" },
                    { 36, 93m, "Ergonomic Cotton Fish", "Friesen - Watsica" },
                    { 37, 100m, "Handcrafted Rubber Keyboard", "Nader Group" },
                    { 38, 94m, "Generic Concrete Hat", "Beatty Inc" },
                    { 39, 37m, "Unbranded Concrete Chair", "Connelly Inc" },
                    { 40, 1m, "Tasty Rubber Salad", "Rempel Group" },
                    { 41, 42m, "Small Soft Keyboard", "Mraz Inc" },
                    { 42, 16m, "Handmade Rubber Ball", "Larkin, Tromp and Deckow" },
                    { 43, 11m, "Gorgeous Concrete Soap", "Ernser - Prosacco" },
                    { 44, 89m, "Intelligent Frozen Computer", "Stark Group" },
                    { 45, 11m, "Refined Cotton Shoes", "Block and Sons" },
                    { 46, 79m, "Unbranded Plastic Soap", "Gaylord - Wehner" },
                    { 47, 62m, "Handmade Metal Bacon", "Glover Group" },
                    { 48, 46m, "Rustic Frozen Ball", "Bradtke - Kuvalis" },
                    { 49, 76m, "Fantastic Plastic Bacon", "Daniel - Purdy" },
                    { 50, 92m, "Sleek Plastic Bacon", "Rogahn and Sons" },
                    { 51, 7m, "Tasty Cotton Mouse", "DuBuque and Sons" },
                    { 52, 23m, "Rustic Cotton Table", "Schiller - Spencer" },
                    { 53, 78m, "Rustic Granite Bike", "Greenholt, Berge and Schuppe" },
                    { 54, 37m, "Gorgeous Cotton Gloves", "Howell, Bednar and Roberts" },
                    { 55, 14m, "Practical Fresh Hat", "Stark, Lubowitz and Flatley" },
                    { 56, 90m, "Refined Fresh Pants", "Murazik LLC" },
                    { 57, 97m, "Fantastic Plastic Fish", "Schneider Group" },
                    { 58, 43m, "Incredible Frozen Towels", "Corkery, Quigley and Parisian" },
                    { 59, 63m, "Refined Metal Salad", "Heidenreich - Feest" },
                    { 60, 78m, "Ergonomic Steel Ball", "Collins Inc" },
                    { 61, 15m, "Handcrafted Wooden Tuna", "Weimann Group" },
                    { 62, 38m, "Handcrafted Concrete Tuna", "Upton - Lynch" },
                    { 63, 15m, "Gorgeous Metal Hat", "Klein Inc" },
                    { 64, 13m, "Rustic Wooden Towels", "Vandervort, Bruen and Koepp" },
                    { 65, 23m, "Tasty Granite Towels", "Pagac Inc" },
                    { 66, 37m, "Tasty Plastic Ball", "Lynch, Bradtke and O'Reilly" },
                    { 67, 22m, "Handmade Wooden Table", "Larkin, Krajcik and Kling" },
                    { 68, 60m, "Handmade Granite Hat", "Johnston Group" },
                    { 69, 90m, "Handcrafted Plastic Ball", "Cormier Group" },
                    { 70, 98m, "Rustic Granite Cheese", "Farrell, Johnson and Dach" },
                    { 71, 67m, "Refined Concrete Pizza", "Grimes and Sons" },
                    { 72, 86m, "Awesome Soft Fish", "Schiller - Harris" },
                    { 73, 95m, "Rustic Soft Bacon", "Raynor, Waters and Kutch" },
                    { 74, 46m, "Tasty Plastic Sausages", "Maggio - Schinner" },
                    { 75, 56m, "Intelligent Metal Gloves", "MacGyver - Moore" },
                    { 76, 9m, "Incredible Plastic Chips", "Wolf Group" },
                    { 77, 93m, "Incredible Soft Salad", "Mraz Group" },
                    { 78, 93m, "Unbranded Steel Bike", "Gulgowski - Bradtke" },
                    { 79, 97m, "Practical Fresh Hat", "McKenzie, Waters and Hegmann" },
                    { 80, 49m, "Small Steel Shirt", "Frami, Carter and Heathcote" },
                    { 81, 54m, "Gorgeous Frozen Bike", "Abbott - Jakubowski" },
                    { 82, 46m, "Practical Soft Tuna", "Dickinson - Kris" },
                    { 83, 71m, "Handmade Steel Keyboard", "Funk - Gerlach" },
                    { 84, 64m, "Fantastic Metal Bacon", "Gutmann - O'Connell" },
                    { 85, 84m, "Fantastic Rubber Bacon", "Walsh LLC" },
                    { 86, 26m, "Awesome Plastic Car", "Purdy Inc" },
                    { 87, 49m, "Small Metal Shoes", "Roob, Ledner and Towne" },
                    { 88, 37m, "Generic Frozen Fish", "Williamson and Sons" },
                    { 89, 89m, "Generic Concrete Towels", "Spencer, Zemlak and Zemlak" },
                    { 90, 5m, "Rustic Cotton Chicken", "Mohr - McGlynn" },
                    { 91, 74m, "Generic Frozen Ball", "Stiedemann, Lang and Towne" },
                    { 92, 6m, "Unbranded Wooden Cheese", "Gibson - O'Hara" },
                    { 93, 81m, "Unbranded Frozen Hat", "Graham, Roberts and Weimann" },
                    { 94, 57m, "Handcrafted Plastic Sausages", "Cummings - Stokes" },
                    { 95, 87m, "Generic Cotton Car", "Rath, Hauck and Schroeder" },
                    { 96, 34m, "Fantastic Rubber Shirt", "Jacobs and Sons" },
                    { 97, 30m, "Handcrafted Rubber Table", "Heller, Marks and Hagenes" },
                    { 98, 62m, "Rustic Concrete Bacon", "Bogan, Jones and Schultz" },
                    { 99, 81m, "Licensed Fresh Pizza", "Bradtke - Barton" },
                    { 100, 34m, "Refined Cotton Towels", "Hills - Adams" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Platforms");
        }
    }
}
