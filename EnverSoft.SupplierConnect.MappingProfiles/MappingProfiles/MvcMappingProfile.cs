using AutoMapper;
using EnverSoft.SupplierConnect.Domain.DTOs;
using EnverSoft.SupplierConnect.Domain.ViewModels;

namespace EnverSoft.SupplierConnect.MappingProfiles.MappingProfiles
{
    public class MvcMappingProfile : Profile
    {
        public MvcMappingProfile()
        {
            CreateMap<SupplierDto, SupplierViewModel>().ReverseMap();
            CreateMap<SupplierCreateEditViewModel, SupplierDto>().ReverseMap();
        }
    }
}
