using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Dal.Interface
{
    public interface IProductsRepository
    {
        List<Products> GetAll();
    }
}
