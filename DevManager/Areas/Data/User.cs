using Microsoft.AspNetCore.Identity;

namespace DevManager.Areas.Data
{
    public class User : IdentityUser
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Position { get; set; } //senior - junior - intern ..

        public int? UserId { get; set; }
    }
}
