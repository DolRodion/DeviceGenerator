using DeviceGenerator.Application.Interfaces;
using DeviceGenerator.Application.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MovieCatalog.Application.Interfaces;
using MovieCatalog.Application.Services;


namespace MovieCatalog.Application
{
    /// <summary>
    /// Класс внедрения зависимости слоя бизнес логики
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Добавляет зависимости в общий контейнер зависимостей.
        /// </summary>
        /// <param name="services">Контейнер зависимостей.</param>
        /// <param name="configuration">Конфигурация приложения.</param>
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IDeviceService, DeviceService>();

            services.AddSingleton<IDeviceRepository, DeviceRepository>();


            return services;
        }
    }
}
