using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetShop.ProductAPI.Migrations
{
    public partial class SeedProductsDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TB_PRODUTO",
                columns: new[] { "ID", "NM_CATEGORIA", "DS_DESCRICAO", "URL_IMAGEM", "NM_NOME", "VL_PRECO" },
                values: new object[] { 1L, "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://no_image/image1.jpg", "First shirt", 59.9m });

            migrationBuilder.InsertData(
                table: "TB_PRODUTO",
                columns: new[] { "ID", "NM_CATEGORIA", "DS_DESCRICAO", "URL_IMAGEM", "NM_NOME", "VL_PRECO" },
                values: new object[] { 2L, "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://no_image/image2.jpg", "Second shirt", 89.9m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TB_PRODUTO",
                keyColumn: "ID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "TB_PRODUTO",
                keyColumn: "ID",
                keyValue: 2L);
        }
    }
}
