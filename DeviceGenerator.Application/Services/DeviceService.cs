using MovieCatalog.Application.Models;
using System.Threading.Tasks;
using MovieCatalog.Application.Interfaces;
using System;
using System.Linq;
using DeviceGenerator.Application.Interfaces;


namespace MovieCatalog.Application.Services
{
    /// <inheritdoc/>
    public class DeviceService : IDeviceService
    {
        private readonly IDeviceRepository deviceRepository;

        /// <summary>
        /// Инициализация
        /// </summary>
        /// <param name="omdbApiService">Сервис работы с ImdbApi</param>
        public DeviceService(IDeviceRepository deviceRepository)
        {
            this.deviceRepository = deviceRepository ?? throw new ArgumentNullException(nameof(deviceRepository));
        }

        
       /// <summary>
       /// Получение устройств
       /// </summary>
       
        public async Task<DeviceModel[]> GetDeviceAsync(string type, string status)
        {
            var device = deviceRepository.GetDevices(type,status).ToArray();

            return device;
        }

        /// <summary>
        /// Получает устройство по гуиду
        /// </summary
        public async Task<DeviceModel> GetDeviceByIdAsync(string deviceId)
        {
            return await deviceRepository.GetDeviceByIdAsync(Guid.Parse(deviceId));
        }
    }
}