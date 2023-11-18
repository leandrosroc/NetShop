using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NetShop.ProductAPI.Data.ValueObjects
{
    public class ProductVO
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public string CategoriaNome { get; set; }
        public string ImagemUrl { get; set; }
    }
}
