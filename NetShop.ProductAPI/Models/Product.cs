using NetShop.ProductAPI.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetShop.ProductAPI.Models
{
    [Table("TB_PRODUTO")]
    public class Product : BaseEntity
    {
        [Column("NM_NOME")]
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Column("VL_PRECO")]
        [Required]
        [Range(1, 10000)]
        public decimal Price { get; set; }

        [Column("DS_DESCRICAO")]
        [StringLength(500)]
        public string Description { get; set; }

        [Column("NM_CATEGORIA")]
        [Required]
        [StringLength(50)]
        public string CategoryName { get; set;}

        [Column("URL_IMAGEM")]
        [StringLength(300)]
        public string ImageURL { get; set;}
    }
}
