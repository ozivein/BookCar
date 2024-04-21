namespace UdemyCarBook.WebUI.Abstracts
{
    public interface IGenericConsumeApiService<resultDto, createDto, updateDto>
        where createDto : class
        where updateDto : class
        where resultDto : class
    {
        Task<HttpResponseMessage> CreateAsync(string controllerName, createDto entity, string token);
        Task<HttpResponseMessage> UpdateAsync(string controllerName, updateDto entity, string token);
        Task<HttpResponseMessage> RemoveAsync(string controllerName, int id, string token);
        Task<resultDto> GetByIdAsync(string controllerName, int id, string token);

        Task<updateDto> GetByIdUpdateAsync(string controllerName, int id, string token);
        Task<List<resultDto>> GetListAsync(string controllerName, string token);
        Task<List<resultDto>> GetListAsync(string controllerName, string actionName, string token);
    }
}
