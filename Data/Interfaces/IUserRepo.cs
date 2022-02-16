using Lesson9.Models.Entities;
using Lesson9.Models.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lesson9.Data.Interfaces
{

    public interface IUserRepo
    {
        public Task CreateUser(User user);

        public Task<User> GetUser(UserRequest request);

        public Task<IEnumerable<User>> GetUsers();

        public Task UpdateUser(User user);

        public Task DeleteUser(User user);

    }
}