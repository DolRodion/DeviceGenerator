using Microsoft.AspNetCore.Mvc;
using MovieCatalog.Application.Interfaces;
using MovieCatalog.Application.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace MovieСatalog.Controllers
{
    /// <summary>
    /// Контроллер фильмов
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class DeviceController : ControllerBase
    {
        private readonly IDeviceService deviceService;

        /// <summary>
        /// Инициализация
        /// </summary>
        /// <param name="movieService">Сервис устройств</param>
        public DeviceController(IDeviceService deviceService)
        {
            this.deviceService = deviceService ?? throw new System.ArgumentNullException(nameof(deviceService));
        }

        /// <summary>
        /// Получает устройства
        /// </summary>

        [HttpGet]
        [Route("GetDevices")]
        public async Task<ActionResult<DeviceModel[]>> GetDevicesAsync(string selectedType, string selectedStatus)
        {
            var result = await deviceService.GetDeviceAsync(selectedType, selectedStatus);

            return Ok(result);
        }

        /// <summary>
        /// Получает устройство по гуиду
        /// </summary
        [HttpGet]
        [Route("GetDeviceById")]
        public async Task<ActionResult<DeviceModel>> GetDeviceByIdAsync(string deviceId)
        {
            var result = await deviceService.GetDeviceByIdAsync(deviceId);

            return Ok(result);
        }


    }
}
