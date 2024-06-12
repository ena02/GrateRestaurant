using AutoMapper;
using Greate.Services.ProdustAPI.Models;
using Greate.Services.ProdustAPI.Models.Dto;

namespace Greate.Services.ProdustAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });

            return mappingConfig;
        }
    
    }
}
