using Smartproduct.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Smartproduct.Model;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Routing;
using Smartproduct.Web.Utils;

namespace Smartproduct.Service
{
    public class ExternalUserService : IExternalUser
    {

        /// <summary>
        /// Gets the user by their username
        /// </summary>
        /// <param name="username"></param>
        /// <returns>Returns a single user</returns>
        public async Task<ExternalUser> FindByNameAsync(string username)
        {
            return await Connection.GetAsync<ExternalUser>(new Uri(UriHelper.Api.FruitSaApi, $"{UriHelper.Controller.User}GetByUsername/{username}"));
        }

        /// <summary>
        /// Creates a new user and returns the user object
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Returns a user object</returns>
        public async Task<bool> CreateAsync(ExternalUser user)
        {
            return await Connection.InsertAsync(new Uri(UriHelper.Api.FruitSaApi, $"{UriHelper.Controller.User}CreateAsync/Insert"), user);
        }

        /// <summary>
        /// Creates a new user and returns a UserID
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Returns a UserID</returns>
        public async Task<long> Post(ExternalUser user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates an existing user
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Returns a boolean</returns>
        public async Task<bool> PutUpdateAsync(ExternalUser user)
        {
            return await Connection.PutAsync(new Uri(UriHelper.Api.FruitSaApi, $"{UriHelper.Controller.User}Put/Update"), user);
        }

        /// <summary>
        /// Gets the user by their UserID
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>Returns a single user</returns>
        public async Task<ExternalUser> FindByIdAsync(int userId)
        {
            return await Connection.GetAsync<ExternalUser>(new Uri(UriHelper.Api.FruitSaApi, $"{UriHelper.Controller.User}GetByUserId/{userId}"));
        }

        /// <summary>
        /// Gets all the users including locked out users
        /// </summary>
        /// <returns>Returns a list of users</returns>
        public async Task<List<ExternalUser>> GetAllUsersInclLockedOut()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the User/UserRoles and Roles for creating views
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="roleIds"></param>
        /// <returns>Returns a UserWithRoles model</returns>
        public async Task<List<ExternalUserModel>> GetUserWithRoles()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> CheckIfEmailExist(string email)
        {
            return await Connection.GetAsync<bool>(new Uri(UriHelper.Api.FruitSaApi, $"{UriHelper.Controller.User}CheckIfEmailExist/{email}"));
        }

        public async Task<ExternalUserModel> FindByExternalUserID(int externalUserID)
        {
            throw new NotImplementedException();
        }
    }
}
