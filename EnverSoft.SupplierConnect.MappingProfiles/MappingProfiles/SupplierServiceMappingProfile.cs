using AutoMapper;
using EnverSoft.SupplierConnect.Domain.DTOs;
using EnverSoft.SupplierConnect.Domain.Entities;

namespace EnverSoft.SupplierConnect.MappingProfiles.MappingProfiles
{
    public class SupplierServiceMappingProfile : Profile
    {
        public SupplierServiceMappingProfile()
        {
            CreateMap<Supplier, SupplierDto>().ReverseMap();
        }
    }
}
