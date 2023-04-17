using Smartproduct.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Smartproduct.Interface
{
    public interface IExternalUser
    {
        Task<ExternalUser> FindByNameAsync(string username);
        Task<bool> CreateAsync(ExternalUser user);
        Task<long> Post(ExternalUser user);
        Task<bool> PutUpdateAsync(ExternalUser user);
        Task<ExternalUser> FindByIdAsync(int userId);
        Task<List<ExternalUser>> GetAllUsersInclLockedOut();
        Task<List<ExternalUserModel>> GetUserWithRoles();
        Task<bool> CheckIfEmailExist(string email);
        Task<ExternalUserModel> FindByExternalUserID(int externalUserID);
    }
}
