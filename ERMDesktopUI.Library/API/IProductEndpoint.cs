using ERMDesktopUI.Library.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERMDesktopUI.Library.API
{
    public interface IProductEndpoint
    {
        Task<List<ProductModel>> GetAll();
    }
}