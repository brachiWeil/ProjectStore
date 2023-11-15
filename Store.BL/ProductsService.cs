using Store.BL.Interface;
using Store.Dal;
using Store.Dal.Interface;
using Store.model;
using Store.Model;


//
//מקבל מהקונטרולר הפעלת פונקציה ולפעמים גם נתונים  ומעביר לרפוזיטורי , מקבל בחזרה את הנתונים מהריפוזיטורי

namespace Store.BL
{
    public class ProductsService: IProductsService
    {
        readonly IProductsRepository _Repository;
        public ProductsService(IProductsRepository Repository)
        {
            _Repository = Repository;
        }

        public List<Products> GetAll()
        {
            return _Repository.GetAll();
        }
    }
}