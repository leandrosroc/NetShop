using AutoMapper;
using NetShop.ProductAPI.Models;
using NetShop.ProductAPI.Data.ValueObjects;

namespace NetShop.ProductAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config => {
                config.CreateMap<ProductVO, Product>();
                config.CreateMap<Product, ProductVO> ();
            });

            return mappingConfig;
        }
    }
}
