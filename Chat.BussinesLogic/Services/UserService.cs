using Chat.BussinesLogic.Abstraction;
using Chat.BussinesLogic.DTOs.Request.User;
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

        public Task<List<UserEntity>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return userRepository.GetAllAsync(cancellationToken);
        }

        public Task UpdateAsync(UpdateUserRequest updateUserRequest, CancellationToken cancellationToken = default)
        {
            //ToDo...
            throw new NotImplementedException();
        }
    }
}
