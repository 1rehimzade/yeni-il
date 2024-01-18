using AutoMapper;
using Yeli_il_Mvc.Areas.Admin.ViewModels;
using Yeli_il_Mvc.Models;

namespace Yeli_il_Mvc.Areas.Admin.MappingProfiles
{
    public class SlideProfile : Profile
    {
        public SlideProfile()
        {
            CreateMap<CreateSlideVM, Slide>();
            CreateMap<UpdateSlideVM, Slide>().ReverseMap();
        }
    }
}
