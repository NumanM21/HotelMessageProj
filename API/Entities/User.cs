namespace API.Entities
{
    public class User
    {
        public int Id { get; set; } // PK
        public int RoomNumber { get; set; }  
        public string? Username { get; set; } 

        public string? FullName { get; set; }    
        public string? Password { get; set; }    


    }
}