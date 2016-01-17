﻿using SocialNetwork.Models;
using SocialNetwork.Models.EntityModels;
using SocialNetwork.Services.RepositoryService;

namespace SocialNetwork.Services.UserService
{
    public interface IUserService
    {
        User GetUserByEmail(string email);
        User AddUser(User model);
        User EditUser(User model, int userId);
        void DeleteUser(int? userId);
        User GetById(int id);
    }
}