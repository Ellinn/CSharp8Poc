using System;
using Domain.Repositories;
using Repository.User;

namespace CSharp8Poc
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserRepository userRepository = new UserRepository();

            var usersResult = userRepository.GetAllUsers();
            if (usersResult.IsOk)
                Console.WriteLine(usersResult.ResultValue.Count + " users found.");
            else
                Console.WriteLine(usersResult.ErrorValue);

            Console.WriteLine("Press any key to leave...");
            Console.ReadKey();
        }
    }
}
