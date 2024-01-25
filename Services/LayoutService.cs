using FinalExamLumia.DAL;
using Microsoft.EntityFrameworkCore;

namespace FinalExamLumia.Services
{
    public class Layoutservice
    {
        private readonly AppDbContext _context;

        public Layoutservice(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Dictionary<string,string>> GetSettingsAsync()
        {
            var settings=await _context.Settings.ToDictionaryAsync(s=>s.Key, s=>s.Value);
            return settings;
        }
    }
}
