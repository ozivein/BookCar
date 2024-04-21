using Microsoft.Extensions.DependencyInjection;

namespace UdemyCarBook.Application.Services
{

    //Api Program.cs tarafında builder.service ekleme için yazılan static metot;
    
    //Api program.cs tarafında meditR kütüphanesi eklenerek burada kullanılına mediatRService eklemesi yapılmıştır.
    public static class ServiceRegistiration
    {
        public static void AddApplicationRegistiration(this IServiceCollection services)
        {
            services.AddMediatR(conf => conf.RegisterServicesFromAssembly(typeof(ServiceRegistiration).Assembly));
        }
    }
}
