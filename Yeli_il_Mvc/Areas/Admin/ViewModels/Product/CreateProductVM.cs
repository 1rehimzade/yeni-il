﻿using Yeli_il_Mvc.Models;

namespace Yeli_il_Mvc.Areas.Admin.ViewModels
{
    public class CreateProductVM
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? FacebookLink { get; set; }
        public string? TwitterLink { get; set; }
        public string? LinkedinLink { get; set; }
        public string? PinterestLink { get; set; }
        public int CategoryId { get; set; }
        public List<int> SizeIds { get; set; }
        public List<int> ColorIds { get; set; }
        public IFormFile MainPhoto { get; set; }
        public List<IFormFile>? Photos { get; set; }
        public List<Category>? Categories { get; set; }
        public List<Size>? Sizes { get; set; }
        public List<Color>? Colors { get; set; }
    }
}
