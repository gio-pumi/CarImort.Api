namespace CarImport.Domain.DbEntities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshExpirationDate { get; set; }
        public List<Role> Roles { get; set; } 
    }
}
