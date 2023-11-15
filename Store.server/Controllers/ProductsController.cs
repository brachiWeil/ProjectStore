using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.BL.Interface;
using Store.Model;



// זה הממשק משתמש הוא מקבל נתונים משהמשתמש ושולח אותם לservice


namespace Store.server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {


       
            readonly IProductsService _ProductsService;

            public ProductsController(IProductsService ProductsService)
            {
            _ProductsService = ProductsService;
            }
            [HttpGet]
            public List<Products> Get()
            {
                return _ProductsService.GetAll();
            }

        }
    }

