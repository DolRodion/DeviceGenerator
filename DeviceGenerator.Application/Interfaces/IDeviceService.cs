using MovieCatalog.Application.Models;
using System;
using System.Threading.Tasks;

namespace MovieCatalog.Application.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса работы с устройствами
    /// </summary>
    public interface IDeviceService
    {
        Task<DeviceModel[]> GetDeviceAsync(string type, string status);

        Task<DeviceModel> GetDeviceByIdAsync(string deviceid);
    }
}
