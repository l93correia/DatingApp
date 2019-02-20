using System.Threading.Tasks;
using DatingApp.Models;

namespace DatingApp.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User username, string password);
        Task<User> Login(string username, string password); 
        Task<bool> UserExists(string username);
    }
}