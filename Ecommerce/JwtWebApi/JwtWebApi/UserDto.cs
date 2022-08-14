namespace JwtWebApi
{
    public class UserDto    //User Data Transfer Object with the Username and Password.
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
