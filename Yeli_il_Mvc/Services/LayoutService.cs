using Microsoft.EntityFrameworkCore;
using Yeli_il_Mvc.DAL;
using Yeli_il_Mvc.Models.ViewModels;

namespace Yeli_il_Mvc.Services
{
    public class LayoutService
    {
        private readonly AppDbContext _context;

        public LayoutService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<LayoutVM> GetSettings()
        {
            var settings = await _context.Settings.ToDictionaryAsync(s => s.Key, s => s.Value);
            var categories = await _context.Categories.ToListAsync();
            LayoutVM vm = new()
            {
                Settings = settings,
                Categories = categories
            };
            return vm;
        }
    }
}
