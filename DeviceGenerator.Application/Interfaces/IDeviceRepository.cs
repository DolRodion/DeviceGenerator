using Bogus;
using MovieCatalog.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceGenerator.Application.Interfaces
{
    public interface IDeviceRepository
    {
        IEnumerable<DeviceModel> GetDevices(string type, string status);

        Task<DeviceModel> GetDeviceByIdAsync(Guid deviceId);

    }
}
