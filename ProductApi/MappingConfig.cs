using AutoMapper;
using ProductApi.Models;
using ProductApi.Models.Dto;

namespace ProductApi
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingconfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();

            });
            return mappingconfig;
        }
    }
}
