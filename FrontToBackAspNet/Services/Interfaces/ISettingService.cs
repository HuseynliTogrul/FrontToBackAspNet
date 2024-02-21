using ChocoLux.Entities;

namespace FrontToBackAspNet.Services.Interfaces
{
    public interface ISettingService
    {
        public Task<Setting> GetAsync();
    }
}
