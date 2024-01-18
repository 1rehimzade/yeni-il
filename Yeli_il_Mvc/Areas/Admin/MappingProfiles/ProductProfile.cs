using AutoMapper;
using Yeli_il_Mvc.Areas.Admin.ViewModels;
using Yeli_il_Mvc.Models;

namespace Yeli_il_Mvc.Areas.Admin.MappingProfiles
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductVM, Product>().ReverseMap();
        }
    }
}
