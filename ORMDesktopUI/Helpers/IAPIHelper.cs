using ORMDesktopUI.Models;
using System.Threading.Tasks;

namespace ORMDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthUser> Authenticate(string username, string password);
    }
}