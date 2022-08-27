using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCatalog.Application.Models
{
    /// <summary>
    /// Полное описание фильма
    /// </summary>
    public class DeviceModel
    {
        /// <summary>
        /// Id устройства
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Тип устройства
        /// </summary>
        public string DeviceType { get; set; }

        /// <summary>
        /// Серийный номер устройства
        /// </summary>
        public int SerialNumber { get; set; }

        /// <summary>
        /// Статус работоспособности устройства
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Место установки устройства
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Время последней активности устройства
        /// </summary>
        public DateTime LastActivity { get; set; }

        /// <summary>
        /// Объем буфера на устройстве
        /// </summary>
        public int BufferSize { get; set; }

        /// <summary>
        /// Температура на устройстве
        /// </summary>
        public double Temperature { get; set; }
    }
}
