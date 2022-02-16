using Lesson9.Data.Interfaces;
using Lesson9.Models;
using Lesson9.Data.Ef;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lesson9.Models.Entities;
using Lesson9.Models.Dto;
using Lesson9.Data;

namespace Lesson9.Data.Implementation
{

    public class UserRepo : IUserRepo
    {
        private readonly UserContext _dbContext;

        public UserRepo(UserContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateUser(User user)
        {
             _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
        }

        public Task<User> GetUser(UserRequest request)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task DeleteUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateUser(User user)
        {
            throw new System.NotImplementedException();
        }
    }
    
}
