using System;
using System.Collections.Generic;
using Domain.Repositories;
using Domain.User;
using Infrastructure;

namespace Repository.User
{
    public class UserRepository : IUserRepository
    {
        private readonly List<UserDto> users = new List<UserDto>
        {
            new UserDto { UserId = 1, LastName = "Ceul", Firstname = "Thib", Age = 45 },
            new UserDto { UserId = 2, LastName = "Mer", Firstname = "Adri", Age = 25 }
        };

        public Result<List<UserDto>, string> GetAllUsers() =>
            users switch
            {
                var u when u.Count > 0 => new Result<List<UserDto>, string>(u),
                _ => new Result<List<UserDto>, string>("No user found")
            };
    }
}
