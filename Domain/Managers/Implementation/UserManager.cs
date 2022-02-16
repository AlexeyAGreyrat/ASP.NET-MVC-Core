using Lesson9.Data.Interfaces;
using Lesson9.Domain.Managers.Interfaces;
using Lesson9.Models;
using Lesson9.Models.Dto;
using Lesson9.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lesson9.Domain.Managers.Implementation
{
    
    public class UserManager : IUserManager
    {
        private readonly IUserRepo _userRepo;

        public UserManager(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public async Task CreateUser(UserCreateRequest request)
        {
            var user = new User
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                EmailConfirmDate = System.DateTime.Now,
                EmailConfirmed = true,
                AcceptEmailConversation = true,
                RegisterDate = System.DateTime.Now
            };
            
            await _userRepo.CreateUser(user);

        }
        
        public async Task<UserResponse> GetUser(UserRequest request)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<UserResponse>> GetUsers()
        {
            var users = await _userRepo.GetUsers();

            var result = new List<UserResponse>();
          
            foreach (var user in users)
            {
                result.Add(new UserResponse
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    EmailConfirmDate = user.EmailConfirmDate,
                    AcceptEmailConversation = user.AcceptEmailConversation,
                    EmailConfirmed = user.EmailConfirmed,
                    RegisterDate = user.RegisterDate
                }); 
            }

            return result;
        }

        public async Task UpdateCard(UserRequest request)
        {
            throw new System.NotImplementedException();
        }

        public async Task DeleteCard(UserRequest request)
        {
            throw new System.NotImplementedException();
        }

    }
}
