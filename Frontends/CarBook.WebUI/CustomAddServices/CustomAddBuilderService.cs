using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;
using UdemyCarBook.WebUI.Services;

namespace UdemyCarBook.WebUI.CustomAddServices
{
    public static class CustomAddBuilderService
    {
        public static void AddBuilderService(this IServiceCollection Services, IConfiguration configuration)
        {
            Services.AddHttpContextAccessor();
            Services.AddScoped<ISharedAuthorizationApiService, SharedAuthorizationApiService>();

            Services.AddScoped(typeof(IGenericConsumeApiService<,,>), typeof(GenericConsumeApiService<,,>));

            Services.AddHttpClient<IAboutConsumeApiService, AboutConsumeApiService>(opts =>
            {
                opts.BaseAddress = new Uri(configuration["ApiConsumes:BaseAddress"]);
            });
            Services.AddHttpClient<ITestimonialConsumeApiService, TestimonialConsumeApiService>(opts =>
            {
                opts.BaseAddress = new Uri(configuration["ApiConsumes:BaseAddress"]);
            });
            Services.AddHttpClient<IServiceConsumeApiService, ServiceConsumeApiService>(opts =>
            {
                opts.BaseAddress = new Uri(configuration["ApiConsumes:BaseAddress"]);
            });
            Services.AddHttpClient<ICarConsumeApiService, CarConsumeApiService>(opts =>
            {
                opts.BaseAddress = new Uri(configuration["ApiConsumes:BaseAddress"]);
            });
            Services.AddHttpClient<IFooterAddressConsumeApiService, FooterAddressConsumeApiService>(opts =>
            {
                opts.BaseAddress = new Uri(configuration["ApiConsumes:BaseAddress"]);
            });
            Services.AddHttpClient<IContactConsumeApiService, ContactConsumeApiService>(opts =>
             {
                 opts.BaseAddress = new Uri(configuration["ApiConsumes:BaseAddress"]);
             });
            Services.AddHttpClient<IBannerConsumeApiService, BannerConsumeApiService>(opts =>
            {
                opts.BaseAddress = new Uri(configuration["ApiConsumes:BaseAddress"]);
            });
            Services.AddHttpClient<IBlogConsumeApiService, BlogConsumeApiService>(opts =>
            {
                opts.BaseAddress = new Uri(configuration["ApiConsumes:BaseAddress"]);
            });
            Services.AddHttpClient<ICarPricingConsumeApiServe, CarPricingConsumeApiService>(opts =>
            {
                opts.BaseAddress = new Uri(configuration["ApiConsumes:BaseAddress"]);
            });
            Services.AddHttpClient<ICategoryConsumeApiService, CategoryConsumeApiService>(opts =>
            {
                opts.BaseAddress = new Uri(configuration["ApiConsumes:BaseAddress"]);
            });
            Services.AddHttpClient<ITagCloudConsumeApiService, TagCloudConsumeApiService>(opts =>
            {
                opts.BaseAddress = new Uri(configuration["ApiConsumes:BaseAddress"]);
            });
            Services.AddHttpClient<ICommentConsumeApiService, CommentConsumeApiService>(opts =>
            {
                opts.BaseAddress = new Uri(configuration["ApiConsumes:BaseAddress"]);
            });
            Services.AddHttpClient<IBrandConsumeApiService, BrandConsumeApiService>(opts =>
            {
                opts.BaseAddress = new Uri(configuration["ApiConsumes:BaseAddress"]);
            });
            Services.AddHttpClient<IFeatureConsumeApiService, FeatureConsumeApiService>(opts =>
            {
                opts.BaseAddress = new Uri(configuration["ApiConsumes:BaseAddress"]);
            });
            Services.AddHttpClient<IAuthorConsumeApiService, AuthorConsumeApiService>(opts =>
            {
                opts.BaseAddress = new Uri(configuration["ApiConsumes:BaseAddress"]);
            });
            Services.AddHttpClient<IPricingConsumeApiService, PricingConsumeApiService>(opts =>
            {
                opts.BaseAddress = new Uri(configuration["ApiConsumes:BaseAddress"]);
            });
            Services.AddHttpClient<ILocationConsumeApiService, LocationConsumeApiService>(opts =>
            {
                opts.BaseAddress = new Uri(configuration["ApiConsumes:BaseAddress"]);
            });
            Services.AddHttpClient<ISocialMediaConsumeApiService, SocialMediaConsumeApiService>(opts =>
            {
                opts.BaseAddress = new Uri(configuration["ApiConsumes:BaseAddress"]);
            });
            Services.AddHttpClient<IRentACarConsumeApiService, RentACarConsumeApiService>(opts =>
            {
                opts.BaseAddress = new Uri(configuration["ApiConsumes:BaseAddress"]);
            });
            Services.AddHttpClient<IReservationConsumeApiService, ReservationConsumeApiService>(opts =>
            {
                opts.BaseAddress = new Uri(configuration["ApiConsumes:BaseAddress"]);
            });
            Services.AddHttpClient<IStatisticConsumeApiService, StatisticConsumeApiService>(opts =>
            {
                opts.BaseAddress = new Uri(configuration["ApiConsumes:BaseAddress"]);
            });
            Services.AddHttpClient<ICarFeatureConsumeApiService, CarFeatureConsumeApiService>(opts =>
            {
                opts.BaseAddress = new Uri(configuration["ApiConsumes:BaseAddress"]);
            });
            Services.AddHttpClient<ICarDescriptionConsumeApiService, CarDescriptionConsumeApiService>(opts =>
           {
               opts.BaseAddress = new Uri(configuration["ApiConsumes:BaseAddress"]);
           });
            Services.AddHttpClient<IReviewConsumeApiService, ReviewConsumeApiService>(opts =>
            {
                opts.BaseAddress = new Uri(configuration["ApiConsumes:BaseAddress"]);
            });
            Services.AddHttpClient<IAccountConsumeApiService, AccountConsumeApiService>(opts =>
            {
                opts.BaseAddress = new Uri(configuration["ApiConsumes:BaseAddress"]);
            });

            Services.AddDataProtection();

        }
    }
}
