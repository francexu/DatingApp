using API.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Repository.Interface
{
    public interface IUserRepository
    {
        Task<IEnumerable<AppUser>> GetUsers();
        Task<AppUser> GetUser(int id);
    }
}
