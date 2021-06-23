using ERMDesktopUI.Models;
using System.Threading.Tasks;

namespace ERMDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string userName, string password);
    }
}