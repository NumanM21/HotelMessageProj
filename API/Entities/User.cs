using Microsoft.AspNetCore.Identity;

namespace API.Entities
{
    public class User : IdentityUser
    //TODO: Chnage this class to what we need
    {
        public int Id { get; set; } // PK
        public int RoomNumber { get; set; }  
        public string? Username { get; set; } 

        public string? FullName { get; set; }    
        public string? Password { get; set; }    


    }
}