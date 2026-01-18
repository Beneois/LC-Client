namespace LC.Client.Models
{
    public class UserSession
    {
        public int? UserId { get; set; }
        public string? UserName { get; set; }

        public bool IsLoggedIn => UserId.HasValue;

        public void Logout()
        {
            UserId = null;
            UserName = null;
        }
    }
}
