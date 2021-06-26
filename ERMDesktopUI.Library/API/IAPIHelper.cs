using ERMDesktopUI.Library.Models;
using System.Threading.Tasks;

namespace ERMDesktopUI.Library.API
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string userName, string password);
        Task GetLoggedInUserByInfo(string token);
    }
}