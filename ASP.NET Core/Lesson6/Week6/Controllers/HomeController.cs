using Microsoft.AspNetCore.Mvc;
using Week6.Models;

namespace Week6.Controllers
{
    public class HomeController : Controller
    {
        List<Product> products = new List<Product>() 
        {
            new Product(){ID=1,Name ="Product1",CategoryName="a"},
            new Product(){ID=2,Name ="Product2",CategoryName="a"},
            new Product(){ID=3,Name ="Product3", CategoryName = "b"},
            new Product(){ID=4,Name ="Product4",CategoryName="b"}
        };

        
        public IActionResult Index()
        {

            return View(products);
        }

        public IActionResult getProductByroute(int id)
        {
            Product product = products.Find(x => x.ID == id);

            if (product == null)
                ViewBag.Error = "Aradoğınız ürün bulunamadı.";
            return View(product);

        }

        public IActionResult getProductByQuery(string id) 
        {
            int requestedId = Convert.ToInt32(id);

            Product product = products.Find(x => x.ID == requestedId);

            Console.WriteLine(product.Name);
            if (product == null)
                ViewBag.Error = "Aradığınız ürün bulunamadı.";

            return View(product);
        }

        public IActionResult useQuery(string catName)
        {
            List<Product> p = products.FindAll(x => x.CategoryName == catName);
            if(p.Count ==0)
                ViewBag.Error = "Aradığınız kategoriye ait ürün bulunamadı.";

            ViewBag.Message = "Geldim knks";
            return View(p);
        }
    }
}
