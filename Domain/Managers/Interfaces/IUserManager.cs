using Lesson9.Models.Entities;
using Lesson9.Models.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lesson9.Domain.Managers.Interfaces
{
    public interface IUserManager
    {
        Task CreateUser(UserCreateRequest request);

        Task<IEnumerable<UserResponse>> GetUsers();
        
        Task<UserResponse> GetUser (UserRequest request);

        Task UpdateCard (UserRequest request);

        Task DeleteCard(UserRequest request);

    }
}
