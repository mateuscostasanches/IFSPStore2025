using AutoMapper;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Context;
using IFSPStore.Repository.Repository;
using IFSPStore.Service.Service;
using IFSPStore.Service.Validators;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace IFSPStore.Test
{

    [TestClass]
    public class ServiceTest
    {
        private ServiceCollection services;
        public ServiceProvider ConfigureServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<IFSPStoreContext>();
            services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
            services.AddScoped<IBaseService<User>, BaseService<User>>();
            services.AddSingleton(
                new MapperConfiguration(
                    config => { config.CreateMap<User, User>(); }, NullLoggerFactory.Instance).CreateMapper()
                );
            return services.BuildServiceProvider();
        }

        [TestMethod]
        public void TestUserService()
        {
            var serviceProvider = ConfigureServices();
            var _userService = serviceProvider.GetService<IBaseService<User>>();

            var user = new User
            {
                Name = "murilo",
                Login = "murilo",
                Email = "murilo@gmail.com1",
                Password = "123ABC:@MURILO"
            };
            var result = _userService.Add<User, User, UserValidator>(user);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }

    }
}

