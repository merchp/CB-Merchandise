using Microsoft.AspNetCore.Mvc;
using System.Linq;
using CBMerch.Models;

namespace CBMerch.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private ICBMerchRepository repository;
        public NavigationMenuViewComponent(ICBMerchRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke() { 
            ViewBag.SelectedCategory = RouteData?.Values["category"];
        {
            return View(repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
        }
    }

}