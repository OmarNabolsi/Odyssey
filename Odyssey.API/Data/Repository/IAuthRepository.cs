using System.Threading.Tasks;
using Odyssey.API.Models;

namespace Odyssey.API.Data.Repository
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);
    }
}