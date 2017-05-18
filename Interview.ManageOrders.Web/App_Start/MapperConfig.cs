using Interview.ManageOrders.BusinessEntities.Models;
using Interview.ManageOrders.DTO.Mappers;

namespace Interview.ManageOrders.Web.App_Start
{
    public static class MapperConfig
    {
        public static void initialize()
        {
            AutoMapper.Configuration.MapperConfigurationExpression config = new AutoMapper.Configuration.MapperConfigurationExpression();
            config.CreateMap<Order, OrderEntity>();
            config.CreateMap<ServiceOrder, ServiceOrderEntity>();
            config.CreateMap<ServiceType, ServiceTypeEntities>();
            AutoMapper.Mapper.Initialize(config);
        }
    }
}