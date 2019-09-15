namespace dateapp.API.Models
{
    public class User
    {
        public int Id { set; get; }
        public int Username { set; get; }
        public byte[] PasswordHash { set; get; }
        public byte[] PasswordSalt { set; get; }
    }
}