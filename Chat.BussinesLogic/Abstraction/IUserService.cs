using Chat.BussinesLogic.DTOs.User;
using Chat.DataAccess.Entity.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.BussinesLogic.Abstraction
{
    public interface IUserService
    {
        Task CreateAsync(CreateUserRequest createUserRequest, CancellationToken cancellationToken = default);
        Task UpdateAsync(UpdateUserRequest updateUserRequest, CancellationToken cancellationToken = default);
        Task<List<UserResponse>> GetAllAsync(CancellationToken cancellationToken = default);
    }
}
