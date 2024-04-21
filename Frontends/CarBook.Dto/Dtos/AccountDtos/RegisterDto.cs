namespace UdemyCarBook.Dto.Dtos
{
    public class RegisterDto
    {
        public string AppUserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int AppRoleId { get; set; }
    }
}
