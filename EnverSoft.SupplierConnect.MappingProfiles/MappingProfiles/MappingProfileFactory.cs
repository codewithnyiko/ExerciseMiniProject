using AutoMapper;

namespace EnverSoft.SupplierConnect.MappingProfiles.MappingProfiles
{
    public static class MappingProfileFactory
    {
        public static void ConfigureProfiles(IMapperConfigurationExpression config)
        {
            config.AddProfile<MvcMappingProfile>();
            config.AddProfile<SupplierServiceMappingProfile>();
        }
    }
}
