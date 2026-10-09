using Chat.BussinesLogic.Abstraction;
using Chat.BussinesLogic.DTOs.User;
using Chat.DataAccess.Abstractions.Repository;
using Chat.DataAccess.Abstractions.UnitOfWork;
using Chat.DataAccess.Entity.User;
using Chat.DataAccess.ORM.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.BussinesLogic.Services
{
    public class UserService(IUserRepository userRepository, IUnitOfWork unitOfWork) : IUserService
    {
        public async Task CreateAsync(CreateUserRequest createUserRequest, CancellationToken cancellationToken = default)
        {
            UserEntity user = new UserEntity
            {
                Name = createUserRequest.Name,
                PasswordHash = "ToDo..."
            };

            await userRepository.CreateAsync(user, cancellationToken);

            await unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<UserResponse>> GetAllAsync(CancellationToken cancellationToken = default)
        {
           var users = await userRepository.GetAllAsync(cancellationToken);
           //var response = new List<UserResponse>();
           //foreach(var u in users)
           //{
           //     response.Add(new UserResponse
           //     {
           //         Id = u.Id,
           //         Name = u.Name,
           //         Password = u.PasswordHash,
           //     });
           //}
           // return response;

            return users
                .Select(u => new UserResponse
                    {
                        Id = u.Id,
                        Name = u.Name,
                        Password = u.PasswordHash,
                    }).ToList();
        }

        public Task UpdateAsync(UpdateUserRequest updateUserRequest, CancellationToken cancellationToken = default)
        {
            //ToDo...
            throw new NotImplementedException();
        }
    }
}
