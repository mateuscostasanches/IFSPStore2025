
using AutoMapper;
using IFSPStore.App.Login;
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

        #region Variables
        public static ServiceCollection? services;
        public static IServiceProvider? serviceProvider;
        #endregion 

        public static void ConfigureServices()
        {
            #region Database Configuration
            var dbConfigFile = "Config/DBConfig.txt";
            var strCon = File.ReadAllText(dbConfigFile);
            services = new ServiceCollection();
            services.AddDbContext<IFSPStoreContext>(options =>
                {
                    options.LogTo(Console.WriteLine);
                    options.UseMySQL(strCon);
                }
            );
            #endregion

            #region Repository Configuration
            services.AddScoped<IBaseRepository<Category>, BaseRepository<Category>>();
            services.AddScoped<IBaseRepository<City>, BaseRepository<City>>();
            services.AddScoped<IBaseRepository<Customer>, BaseRepository<Customer>>();
            services.AddScoped<IBaseRepository<Product>, BaseRepository<Product>>();
            services.AddScoped<IBaseRepository<Sale>, BaseRepository<Sale>>();
            services.AddScoped<IBaseRepository<SaleItem>, BaseRepository<SaleItem>>();
            services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
            #endregion

            #region Service Configuration
            services.AddScoped<IBaseService<Category>, BaseService<Category>>();
            services.AddScoped<IBaseService<City>, BaseService<City>>();
            services.AddScoped<IBaseService<Customer>, BaseService<Customer>>();
            services.AddScoped<IBaseService<Product>, BaseService<Product>>();
            services.AddScoped<IBaseService<Sale>, BaseService<Sale>>();
            services.AddScoped<IBaseService<SaleItem>, BaseService<SaleItem>>();
            services.AddScoped<IBaseService<User>, BaseService<User>>();
            #endregion

            #region Form Configuration
            services.AddScoped<LoginForm, LoginForm>();
            services.AddScoped<CategoryForm, CategoryForm>();
            services.AddScoped<CityForm, CityForm>();
            services.AddScoped<CustomerForm, CustomerForm>();
            services.AddScoped<UserForm, UserForm>();
            services.AddScoped<ProductForm, ProductForm>();
            services.AddScoped<SaleForm, SaleForm>();
            #endregion

            #region AutoMapper Configuration
            services.AddSingleton(
                new MapperConfiguration(config =>
                { 
                    config.CreateMap<Category, CategoryViewModel>();

                    config.CreateMap<City, CityViewModel>()
                        .ForMember(d => d.CityState, opt => opt.MapFrom(src => $"{src.Name} - {src.State}"));

                    config.CreateMap<Customer, CustomerViewModel>()
                        .ForMember(d => d.CityState, d => d.MapFrom(src => $"{src.City.Name} - {src.City.State}"))
                        .ForMember(d => d.CityId, d => d.MapFrom(src => src.City!.Id));

                    config.CreateMap<Product, ProductViewModel>()
                        .ForMember(d => d.Category, d => d.MapFrom(src => $"{src.Category!.Name}"))
                        .ForMember(d => d.CategoryId, d => d.MapFrom(src => src.Category!.Id))
                        .ForMember(d => d.PurchaseDate, d => d.MapFrom(src => $"{src.PurchaseDate}"));

                    config.CreateMap<Sale, SaleViewModel>()
                        .ForMember(d => d.CustomerId, d => d.MapFrom(x => x.Customer!.Id))
                        .ForMember(d => d.Customer, d => d.MapFrom(x => x.Customer!.Name))
                        .ForMember(d => d.UserId, d => d.MapFrom(x => x.Salesman!.Id))
                        .ForMember(d => d.User, d => d.MapFrom(x => x.Salesman!.Name));

                    config.CreateMap<SaleItem, SaleItemViewModel>()
                        .ForMember(d => d.ProductId, d => d.MapFrom(x => x.Product!.Id))
                        .ForMember(d => d.Product, d => d.MapFrom(x => x.Product!.Name));

                    config.CreateMap<User, UserViewModel>();
                },
                NullLoggerFactory.Instance).CreateMapper()
            );
            serviceProvider = services.BuildServiceProvider();
            #endregion
        }
    }
}
