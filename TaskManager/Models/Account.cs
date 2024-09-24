namespace TaskManager.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Role { get; set; }
        public string? PhoneNumber { get; set; }
        //if LoggedIn == 1 -- this member is logged in, if 0 -- NOT logged in
        public int LoggedIn { get; set;}
    }
}
