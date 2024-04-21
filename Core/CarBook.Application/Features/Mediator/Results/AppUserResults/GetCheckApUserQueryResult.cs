namespace UdemyCarBook.Application.Features.Mediator.Results
{
    public class GetCheckApUserQueryResult
    {
        public int Id { get; set; }
        public string AppUserName { get; set; }
        public int AppRoleId { get; set; }
        public string AppRoleName { get; set; }
        public bool IsExist { get; set; }
    }
}
