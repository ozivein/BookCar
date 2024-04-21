namespace UdemyCarBook.Shared.Services
{
    public interface ISharedAuthorizationApiService
    {
        public string AccessToken { get; }

        public void TokenHeaderAuthorization(HttpClient client, string token);
    }
}
