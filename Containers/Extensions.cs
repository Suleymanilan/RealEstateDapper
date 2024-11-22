using RealEstateDapper8.Models.DapperContext;
using RealEstateDapper8.Repositories.AgentRepository;
using RealEstateDapper8.Repositories.AppUserRepository;
using RealEstateDapper8.Repositories.BottomRepository;
using RealEstateDapper8.Repositories.CategoryRepository;
using RealEstateDapper8.Repositories.ContactRepository;
using RealEstateDapper8.Repositories.EstateAgentRepository.DashboardRepository.ChartRepository;
using RealEstateDapper8.Repositories.EstateAgentRepository.DashboardRepository.LastProductRepository;
using RealEstateDapper8.Repositories.EstateAgentRepository.DashboardRepository.StatisticesRepository;
using RealEstateDapper8.Repositories.MessageRepository;
using RealEstateDapper8.Repositories.PictureAdvertRepository;
using RealEstateDapper8.Repositories.ProductAmenitiesRepository;
using RealEstateDapper8.Repositories.ProductRepository;
using RealEstateDapper8.Repositories.RotaRepository;
using RealEstateDapper8.Repositories.ServiceRepository;
using RealEstateDapper8.Repositories.StatisticsRepository;
using RealEstateDapper8.Repositories.SubFeatureRepository;
using RealEstateDapper8.Repositories.TestimonialRepository;
using RealEstateDapper8.Repositories.TuDoListRepository;
using RealEstateDapper8.Repositories.WhoWeAreDetail;

namespace RealEstateDapper8.Containers
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddTransient<Context>();

            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IWhoWeAreDetailRepository, WhoWeAreDetailRepository>();
            services.AddTransient<IServiceRepository, ServiceRepository>();
            services.AddTransient<IBottomRepository, BottomRepsitory>();
           services.AddTransient<ITestimonialRepository, TestimonialRepository>();
           services.AddTransient<IStatisticsRepository, StatisticsRepository>();
           services.AddTransient<IAgentRepository, AgentRepository>();
           services.AddTransient<IRotaRepository, RotaRepository>();
           services.AddTransient<IContactRepository, ContactRepository>();
          services.AddTransient<ITuDoListRepository, TuDoListRepository>();
            services.AddTransient<IStatisticesRepository, StatisticesRepository>();
            services.AddTransient<IChartRepository, ChartRepository>();
          services.AddTransient<ILast5ProductRepository, Last5ProductRepository>();
            services.AddTransient<IMessageRepository, MessageRepository>();
           services.AddTransient<IProductAmenitiesRepository, ProductAmenitiesRepository>();
            services.AddTransient<IAppUserRepository, AppUserRepository>();
           services.AddTransient<IPictureAdvertRepository, PictureAdvertRepository>();
           services.AddTransient<ISubFeatureRepository, SubFeatureRepository>();

        }



    }
}
