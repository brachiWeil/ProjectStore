using Store.Dal.Interface;
using Store.model;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Dal
{
    public class CustomersRepository: ICustomersRepository
    {
        readonly StoreContext _customerContext;
        public CustomersRepository(StoreContext customerContext)
        {
            _customerContext = customerContext;
        }

        public List<Customers> GetAll()
        {
            return _customerContext.Customers.ToList();
        }
    }
}
