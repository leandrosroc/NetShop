using NetShop.ProductAPI.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetShop.ProductAPI.Models
{
    [Table("TB_PRODUTO")]
    public class Produto : BaseEntity
    {
        [Column("NM_NOME")]
        [Required]
        [StringLength(150)]
        public string Nome { get; set; }

        [Column("VL_PRECO")]
        [Required]
        [Range(1, 10000)]
        public decimal Preco { get; set; }

        [Column("DS_DESCRICAO")]
        [StringLength(500)]
        public string Descricao { get; set; }

        [Column("NM_CATEGORIA")]
        [Required]
        [StringLength(50)]
        public string CategoriaNome { get; set;}

        [Column("URL_IMAGEM")]
        [StringLength(300)]
        public string ImagemUrl { get; set;}
    }
}
