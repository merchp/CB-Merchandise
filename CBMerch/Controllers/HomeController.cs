using Microsoft.AspNetCore.Mvc;
using CBMerch.Models;
using System.Linq;
using CBMerch.Models.ViewModels;

namespace CBMerch.Controllers
{
    public class HomeController : Controller
    {
        private ICBMerchRepository repository;
        public int PageSize = 4;

        public HomeController(ICBMerchRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index(int productPage = 1)
       => View(repository.Products
           .OrderBy(p => p.ProductID)
           .Skip((productPage - 1) * PageSize)
           .Take(PageSize),
           PagingInfo = new PagingInfo
           {
               CurrentPage = productPage,
               ItemsPerPage = PageSize,
               TotalItems = repository.Products.Count()
           }
           });
    }

   
}
