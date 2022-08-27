using Bogus;
using DeviceGenerator.Application.Interfaces;
using MovieCatalog.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceGenerator.Application.Repositories
{
    public class DeviceRepository : IDeviceRepository
    {
        private IEnumerable<DeviceModel> deviceModels;

        public async Task<DeviceModel> GetDeviceByIdAsync(Guid deviceId)
        {
            return deviceModels.FirstOrDefault(x => x.Id == deviceId); 
        }

        public DeviceRepository()
        {
            Faker<DeviceModel> generatorDevice = GetGeneratorDevice();

            deviceModels = generatorDevice.Generate(100);
        }
        public IEnumerable<DeviceModel> GetDevices(string type, string status)
        {
            var result = deviceModels;

            if (status != null)
            {
                result = result.Where(w => w.Status == status);
            }

            if (type != null)
            {
                result = result.Where(w => w.DeviceType == type);
            }

            return result;
        }

        private Faker<DeviceModel> GetGeneratorDevice()
        {
            return new Faker<DeviceModel>("ru")
                .RuleFor(x => x.Id, f => f.Random.Guid())
                .RuleFor(x => x.DeviceType, f => f.Random.ListItem(new List<string> {
                            "TYPE1",
                            "TYPE2",
                            "TYPE3",
                        }))
                .RuleFor(x => x.Address, f => f.Address.StreetAddress())
                .RuleFor(x => x.SerialNumber, f => f.Random.Int(1000, 5000))
                .RuleFor(x => x.Status, f => f.Random.ListItem(new List<string> {
                            "Работает",
                            "На ремонте",
                            "Не работает",
                        }))
                .RuleFor(x => x.LastActivity, f => DateTime.Now.AddMinutes(f.Random.Int(-1000, -1)))
                .RuleFor(x => x.BufferSize, f => f.Random.Int(10, 1000))
                .RuleFor(x => x.Temperature, f => f.Random.Int(40, 60))
                ;
        }
    }
}
