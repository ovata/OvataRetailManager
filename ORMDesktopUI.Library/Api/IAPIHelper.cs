using ORMDesktopUI.Library.Models;
using System.Threading.Tasks;

namespace ORMDesktopUI.Library.Api
{
    public interface IAPIHelper
    {
        Task<AuthUser> Authenticate(string username, string password);
        Task GetLoggedInUserInfo(string token);
    }
}