using Store.Dal.Interface;
using Store.model;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//, מקבל מהסרביס הפעלת פונקציה ולפעמים גם נתונים  ניגש למופע של הקונטקסט שהוא מכיל
//עושה את הפעולה על הנתונים ומחזיר (לסרויס) את הנתונים שבקשו ממנו

namespace Store.Dal
{
    public class ProductsRepository: IProductsRepository
    {
        readonly StoreContext _productContext;
        public ProductsRepository(StoreContext productContext)
        {
            _productContext = productContext;   
        }

        public List<Products> GetAll()
        {
            return _productContext.Products.ToList();
        }
    }
}
