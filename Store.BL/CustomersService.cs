using Store.BL.Interface;
using Store.Dal.Interface;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.BL
{
    public class CustomersService : ICustomersService
    {
        readonly ICustomersRepository _CustomersRepository;
        public CustomersService(ICustomersRepository CustomersRepository)
        {
            _CustomersRepository = CustomersRepository;
        }
        public List<Customers> GetAll()
        {
            return _CustomersRepository.GetAll();
        }
    }
}
