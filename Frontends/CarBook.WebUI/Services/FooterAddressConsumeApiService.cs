using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Services
{
    public class FooterAddressConsumeApiService : GenericConsumeApiService<ResultFooterAddressDto, CreateFooterAddressDto, UpdateFooterAddressDto>, IFooterAddressConsumeApiService
    {
        public FooterAddressConsumeApiService(HttpClient client, ISharedAuthorizationApiService shared) : base(client, shared)
        {
        }
    }
}
