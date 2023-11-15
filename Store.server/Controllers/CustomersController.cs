using Microsoft.AspNetCore.Mvc;
using Store.BL;
using Store.BL.Interface;
using Store.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Store.server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        readonly ICustomersService _CustomersService;

        public CustomersController(ICustomersService CustomersService)
        {
            _CustomersService = CustomersService;
        }

        [HttpGet]
        public List<Customers> Get()
        {
            return _CustomersService.GetAll();
        }

    }
}
