using AutoMapper;
using UdemyCarBook.Application.Enums;
using UdemyCarBook.Application.Features.Mediator.Commands;
using UdemyCarBook.Application.Features.Mediator.Commands.ReviewCommands;
using UdemyCarBook.Application.Features.Mediator.Results;
using UdemyCarBook.Application.Features.Mediator.Results.ReservationResults;
using UdemyCarBook.Application.ViewModels;
using UdemyCarBook.Domain;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Mappings
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<About, GetAboutQueryResult>().ReverseMap();
            CreateMap<About, GetAboutByIdQueryResult>().ReverseMap();
            CreateMap<About, CreateAboutCommand>().ReverseMap();
            CreateMap<About, UpdateAboutCommand>().ReverseMap();

            CreateMap<Banner, GetBannerQueryResult>().ReverseMap();
            CreateMap<Banner, GetBannerByIdQueryResult>().ReverseMap();
            CreateMap<Banner, CreateBannerCommand>().ReverseMap();
            CreateMap<Banner, UpdateBannerCommand>().ReverseMap();

            CreateMap<Brand, GetBrandQueryResult>().ReverseMap();
            CreateMap<Brand, GetBrandByIdQueryResult>().ReverseMap();
            CreateMap<Brand, CreateBrandCommand>().ReverseMap();
            CreateMap<Brand, UpdateBrandCommand>().ReverseMap();

            CreateMap<Car, GetCarQueryResult>().ReverseMap();
            CreateMap<Car, GetCarByIdQueryResult>().ReverseMap();
            CreateMap<Car, GetCarWithBrandQueryResult>().ForMember(x => x.BrandName, opt => opt.MapFrom(x => x.Brand.Name)).ReverseMap();
            CreateMap<Car, GetLastFiveCarWithBrandQueryResult>().ForMember(x => x.BrandName, opt => opt.MapFrom(x => x.Brand.Name)).ReverseMap();
            CreateMap<Car, CreateCarCommand>().ReverseMap();
            CreateMap<Car, UpdateCarCommand>().ReverseMap();


            CreateMap<Category, GetCategoryQueryResult>().ReverseMap();
            CreateMap<Category, GetCategoryByIdQueryResult>().ReverseMap();
            CreateMap<Category, CreateCategoryCommand>().ReverseMap();
            CreateMap<Category, UpdateCategoryCommand>().ReverseMap();


            CreateMap<Contact, GetContactQueryResult>().ReverseMap();
            CreateMap<Contact, GetContactByIdQueryResult>().ReverseMap();
            CreateMap<Contact, CreateContactCommand>().ReverseMap();
            CreateMap<Contact, UpdateContactCommand>().ReverseMap();

            CreateMap<Feature, GetFeatureQueryResult>().ReverseMap();
            CreateMap<Feature, GetFeatureByIdQueryResult>().ReverseMap();
            CreateMap<Feature, CreateFeatureCommand>().ReverseMap();
            CreateMap<Feature, UpdateFeatureCommand>().ReverseMap();

            CreateMap<FooterAddress, GetFooterAddressQueryResult>().ReverseMap();
            CreateMap<FooterAddress, GetFooterAddressByIdQueryResult>().ReverseMap();
            CreateMap<FooterAddress, CreateFooterAddressCommand>().ReverseMap();
            CreateMap<FooterAddress, UpdateFooterAddressCommand>().ReverseMap();


            CreateMap<Location, GetLocationQueryResult>().ReverseMap();
            CreateMap<Location, GetLocationByIdQueryResult>().ReverseMap();
            CreateMap<Location, CreateLocationCommand>().ReverseMap();
            CreateMap<Location, UpdateLocationCommand>().ReverseMap();

            CreateMap<Pricing, GetPricingQueryResult>().ReverseMap();
            CreateMap<Pricing, GetPricingByIdQueryResult>().ReverseMap();
            CreateMap<Pricing, CreatePricingCommand>().ReverseMap();
            CreateMap<Pricing, UpdatePricingCommand>().ReverseMap();

            CreateMap<Service, GetServiceQueryResult>().ReverseMap();
            CreateMap<Service, GetServiceByIdQueryResult>().ReverseMap();
            CreateMap<Service, CreateServiceCommand>().ReverseMap();
            CreateMap<Service, UpdateServiceCommand>().ReverseMap();


            CreateMap<SocialMedia, GetSocialMediaQueryResult>().ReverseMap();
            CreateMap<SocialMedia, GetSocialMediaByIdQueryResult>().ReverseMap();
            CreateMap<SocialMedia, CreateSocialMediaCommand>().ReverseMap();
            CreateMap<SocialMedia, UpdateSocialMediaCommand>().ReverseMap();

            CreateMap<Testimonial, GetTestimonialQueryResult>().ReverseMap();
            CreateMap<Testimonial, GetTestimonialByIdQueryResult>().ReverseMap();
            CreateMap<Testimonial, CreateTestimonialCommand>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialCommand>().ReverseMap();

            CreateMap<Author, GetAuthorQueryResult>().ReverseMap();
            CreateMap<Author, GetAuthorByIdQueryResult>().ReverseMap();
            CreateMap<Author, CreateAuthorCommand>().ReverseMap();
            CreateMap<Author, UpdateAuthorCommand>().ReverseMap();

            CreateMap<Blog, GetBlogQueryResult>().ReverseMap();
            CreateMap<Blog, GetBlogByIdQueryResult>().ReverseMap();
            CreateMap<Blog, CreateBlogCommand>().ReverseMap();
            CreateMap<Blog, UpdateBlogCommand>().ReverseMap();
            CreateMap<Blog, GetBlogWithAuthorQueryResult>().
                ForMember(x => x.AuthorName, map => map.MapFrom(y => y.Author.Name)).
                ForMember(x => x.AuthorImage, map => map.MapFrom(y => y.Author.ImageUrl)).
                ForMember(x => x.AuthorDescription, map => map.MapFrom(y => y.Author.Description)).ReverseMap();

            CreateMap<Blog, GetBlogWithAuthorAndCategoryQueryResult>().
                ForMember(x => x.AuthorName, map => map.MapFrom(x => x.Author.Name)).
                ForMember(x => x.CategoryName, map => map.MapFrom(x => x.Category.Name)).ReverseMap();

            CreateMap<Blog, GetLastThreeBlogsWithAuthorsAndCategoryQueryResult>().
                ForMember(x => x.AuthorName, map => map.MapFrom(x => x.Author.Name)).
                ForMember(x => x.CategoryName, map => map.MapFrom(x => x.Category.Name)).ReverseMap();


            CreateMap<CarPricing, GetCarPricingWithCarsQueryResult>().
                ForMember(x => x.PricingName, map => map.MapFrom(y => y.Pricing.Name)).
                ForMember(x => x.CarModel, map => map.MapFrom(x => x.Car.Model)).
                ForMember(x => x.CoverImageUrl, map => map.MapFrom(x => x.Car.CoverImageUrl)).
                ForMember(x => x.Km, map => map.MapFrom(x => x.Car.Km)).
                ForMember(x => x.BrandName, map => map.MapFrom(y => y.Car.Brand.Name)).ReverseMap();

            CreateMap<CarPricing, GetCarPricingWithCarsDayQueryResult>().
                ForMember(x => x.PricingName, map => map.MapFrom(y => y.Pricing.Name)).
                ForMember(x => x.CarModel, map => map.MapFrom(x => x.Car.Model)).
                ForMember(x => x.CoverImageUrl, map => map.MapFrom(x => x.Car.CoverImageUrl)).
                ForMember(x => x.Km, map => map.MapFrom(x => x.Car.Km)).
                ForMember(x => x.BrandName, map => map.MapFrom(y => y.Car.Brand.Name)).ReverseMap();

            CreateMap<CarPricing, GetCarPricingByIdQueryResult>().ReverseMap();
            CreateMap<CarPricing, CreateCarPricingCommand>().ReverseMap();
            CreateMap<CarPricing, UpdateCarPricingCommand>().ReverseMap();

            CreateMap<CarPricingViewModel, GetCarPricingWithTimePeriodQueryResult>().
                ForMember(x => x.CoverImageUrl, map => map.MapFrom(x => x.CoverImageUrl)).
                ForMember(x => x.ModelBrand, map => map.MapFrom(x => x.ModelBrand)).
                ForMember(x => x.DailyAmound, map => map.MapFrom(x => x.Amounts[0])).
                ForMember(x => x.WeeklyAmount, map => map.MapFrom(x => x.Amounts[1])).
                ForMember(x => x.MountlyAmoun, map => map.MapFrom(x => x.Amounts[2])).ReverseMap();


            CreateMap<TagCloud, GetTagCloudQueryResult>().ReverseMap();
            CreateMap<TagCloud, GetTagCloudByIdQueryResult>().ReverseMap();
            CreateMap<TagCloud, CreateTagCloudCommand>().ReverseMap();
            CreateMap<TagCloud, UpdateTagCloudCommand>().ReverseMap();
            CreateMap<TagCloud, GetTagCloudByBlogIdQueryResult>().ReverseMap();

            CreateMap<Comment, GetCommentQueryResult>().ReverseMap();
            CreateMap<Comment, GetCommentByIdQueryResult>().ReverseMap();
            CreateMap<Comment, CreateCommentCommand>().ReverseMap();
            CreateMap<Comment, UpdateCommentCommand>().ReverseMap();
            CreateMap<Comment, GetCommentByBlogIdQueryResult>().ReverseMap();

            CreateMap<RentACar, GetRentACarFilterQeuryResult>().
                ForMember(x => x.CarModel, map => map.MapFrom(x => x.Car.Model)).
                ForMember(x => x.BrandName, map => map.MapFrom(x => x.Car.Brand.Name)).
                ForMember(x => x.CoverImageUrl, map => map.MapFrom(x => x.Car.CoverImageUrl)).ReverseMap();


            CreateMap<Reservation, GetReservationQueryResults>().
                ForMember(x => x.CarModel, map => map.MapFrom(x => x.Car.Model)).
                ForMember(x => x.PickUpLocationName, map => map.MapFrom(x => x.PickUpLocation.Name)).
                ForMember(x => x.DropOffLocationName, map => map.MapFrom(x => x.DropOffLocation.Name)).ReverseMap();
            CreateMap<Reservation, GetReservationByIdQueryResult>().ReverseMap();
            CreateMap<Reservation, CreateReservationCommand>().ReverseMap();
            CreateMap<Reservation, UpdateReservationCommand>().ReverseMap();


            CreateMap<CarFeature, GetCarFeatureByCarIdQeuryResult>().
                 ForMember(x => x.CarName, map => map.MapFrom(x => x.Card.Model)).
                 ForMember(x => x.FeatureName, map => map.MapFrom(x => x.Feature.Name)).ReverseMap();

            CreateMap<CarFeature, CreateCarFeatureCommand>().ReverseMap();


            CreateMap<CarDescription, GetCarDescriptionByCarIdQueryResult>().ReverseMap();


            CreateMap<Review, GetReviewListByCarIdQueryResult>().ReverseMap();
            CreateMap<Review, UpdateReviewCommand>().ReverseMap();
            CreateMap<Review, CreateReviewCommand>().ReverseMap();

            CreateMap<AppUser, GetCheckApUserQueryResult>().ForMember(x => x.AppRoleName, map => map.MapFrom(x => x.AppRole.AppRoleName)).ReverseMap();

            CreateMap<AppUser, CreateAppUserCommand>().ReverseMap();
        }
    }
}
