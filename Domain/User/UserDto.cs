using System;
namespace Domain.User
{
    public class UserDto
    {
        public long UserId { get; set; }
        public string LastName { get; set; }
        public string Firstname { get; set; }
        public int Age { get; set; }
    }
}
