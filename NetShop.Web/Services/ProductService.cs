using NetShop.Web.Models;
using NetShop.Web.Services.IServices;
using NetShop.Web.Utils;

namespace NetShop.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;

        public const string BasePath = "api/v1/product";

        public ProductService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<ProductModel>> FindAllProducts()
        {
            var response = await _client.GetAsync(BasePath);

            return await response.ReadContentAs<List<ProductModel>>();
        }

        public async Task<ProductModel> FindProductById(long id)
        {
            var response = await _client.GetAsync($"{BasePath}/{id}");

            return await response.ReadContentAs<ProductModel>();
        }

        public async Task<ProductModel> CreateProduct(ProductModel model)
        {
            var response = await _client.PostAsJson(BasePath, model);

            if (!response.IsSuccessStatusCode) throw new Exception("Algo aconteceu de errado ao chamar API");

            return await response.ReadContentAs<ProductModel>();
        }

        public async Task<ProductModel> UpdateProduct(ProductModel model)
        {
            var response = await _client.PutAsJson(BasePath, model);

            if (!response.IsSuccessStatusCode) throw new Exception("Algo aconteceu de errado ao chamar API");

            return await response.ReadContentAs<ProductModel>();
        }

        public async Task<bool> DeleteProduct(long id)
        {
            var response = await _client.DeleteAsync($"{BasePath}/{id}");

            if (!response.IsSuccessStatusCode) throw new Exception("Algo aconteceu de errado ao chamar API");

            return await response.ReadContentAs<bool>();
        }
    }
}
