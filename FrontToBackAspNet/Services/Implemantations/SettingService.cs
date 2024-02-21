using ChocoLux.Entities;
using FrontToBackAspNet.Contexts;
using FrontToBackAspNet.Services.Interfaces;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace FrontToBackAspNet.Services.Implemantations
{
    public class SettingService : ISettingService
    {
        readonly ChocoDbContext _chocoDbContext;
        public SettingService(ChocoDbContext chocoDbContext)
        {
            _chocoDbContext = chocoDbContext;
        }

        public async Task<Setting> GetAsync()
        {
            return await _chocoDbContext.Service().FirstOrDefault()
        }
    }
}
