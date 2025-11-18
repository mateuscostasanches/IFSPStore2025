using AutoMapper;
using IFSPStore.App.Register;
using IFSPStore.App.ViewModel;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Context;
using IFSPStore.Repository.Repository;
using IFSPStore.Service.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;

namespace IFSPStore.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? services;
        public static IServiceProvider? serviceProvider;

        public static void ConfigureServices()
        {
            var dbConfigFile = "Config/DBConfig.txt";
            var strCon = File.ReadAllText(dbConfigFile);
            services = new ServiceCollection();
            services.AddDbContext<IFSPStoreContext>(options =>
                {
                    options.LogTo(Console.WriteLine);
                    options.UseMySQL(strCon);
                }
            );
            services.AddScoped<IBaseRepository<Category>, BaseRepository<Category>>();
            services.AddScoped<IBaseService<Category>, BaseService<Category>>();
            services.AddScoped<CategoryForm, CategoryForm>();

            services.AddSingleton(
                new MapperConfiguration(config => { config.CreateMap<Category, CategoryViewModel>(); },
                    NullLoggerFactory.Instance).CreateMapper()
            );
            serviceProvider = services.BuildServiceProvider();
        }
    }
}
