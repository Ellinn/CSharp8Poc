using System;
using System.Collections.Generic;
using Domain.User;
using Infrastructure;

namespace Domain.Repositories
{
    public interface IUserRepository
    {
        Result<List<UserDto>, string> GetAllUsers();
    }
}
