namespace UdemyCarBook.Domain.Entities
{
    public class AppRole
    {
        public int AppRoleId { get; set; }
        public string AppRoleName { get; set; }
        public virtual List<AppUser> AppUsers { get; set; }
    }
}
