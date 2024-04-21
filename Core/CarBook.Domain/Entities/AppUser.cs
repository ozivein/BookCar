using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Domain
{
    public class AppUser
    {
        public int Id { get; set; }
        public string AppUserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int AppRoleId { get; set; }
        public virtual AppRole AppRole { get; set; }
    }
}
