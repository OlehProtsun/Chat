using Chat.BussinesLogic.Abstraction;
using Chat.BussinesLogic.Services;
using Chat.DataAccess.Abstractions.Repository;
using Chat.DataAccess.Abstractions.UnitOfWork;
using Chat.DataAccess.ORM.EntityFramework;
using Chat.DataAccess.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.BussinesLogic
{
    public static class Extensions
    {
        public static void AddBussinesLogic(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>();
        }

    }
}
