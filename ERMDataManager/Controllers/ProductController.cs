using ERMDataManager.Library.DataAccess;
using ERMDataManager.Library.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace ERMDataManager.Controllers
{
    [Authorize]
    public class ProductController : ApiController
    {
        public List<Product> Get()
        {
            ProductData data = new ProductData();

            return data.GetProducts();
        }
    }
}
