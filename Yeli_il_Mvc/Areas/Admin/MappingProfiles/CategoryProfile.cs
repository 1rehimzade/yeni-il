using AutoMapper;
using Yeli_il_Mvc.Areas.Admin.ViewModels;
using Yeli_il_Mvc.Models;

namespace Yeli_il_Mvc.Areas.Admin.MappingProfiles
{
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            CreateMap<CreateCategoryVM, Category>();
            CreateMap<UpdateCategoryVM, Category>().ReverseMap();
        }
    }
}
