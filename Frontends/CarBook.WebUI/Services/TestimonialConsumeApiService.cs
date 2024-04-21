using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Services
{
    public class TestimonialConsumeApiService : GenericConsumeApiService<ResultTestimonialDto, CreateTestimonialDto, UpdateTestimonialDto>, ITestimonialConsumeApiService
    {
        public TestimonialConsumeApiService(HttpClient client, ISharedAuthorizationApiService shared) : base(client, shared)
        {
        }
    }
}
