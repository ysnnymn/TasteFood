using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using TasteFoodIt.Context;
using TasteFoodIt.Entities;

namespace TasteFoodIt.Controllers
{
    public class AdminProductController : Controller
    {
        private readonly TasteContext _context;

        public AdminProductController(TasteContext context)
        {
            _context = context;
        }

        [HttpGet]
       
        public ActionResult ProductList(int page = 1)
        {
            int pageSize = 10;
            int totalProducts = _context.Products.Count();
            int totalPages = (int)Math.Ceiling((double)totalProducts / pageSize);

            // Sayfa sayısı geçersizse son sayfaya yönlendir
            if (page < 1) page = 1;
            if (page > totalPages && totalPages > 0)
                return RedirectToAction("ProductList", new { page = totalPages });

            var products = _context.Products
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            ViewBag.TotalPages = totalPages;
            ViewBag.CurrentPage = page;

            return View(products);
        }

        

        [HttpGet]
        public ActionResult CreateProduct()
        {
            List<SelectListItem> values = (from x in _context.Categories.ToList()
                select new SelectListItem
                {
                    Text = x.CategoryName,
                    Value = x.CategoryId.ToString()
                }).ToList();
            ViewBag.v = values;
            return View();
        } 

        [HttpPost]
        public ActionResult CreateProduct(Product p)
        {
            p.IsActive = true;
            _context.Products.Add(p);
            _context.SaveChanges();
            return RedirectToAction("ProductList");
        }

        [HttpGet]
        public ActionResult UpdateProduct(int id)
        {
            var value=_context.Products.Find(id);
            if (value == null)
                return NotFound();
            List<SelectListItem> values = (from x in _context.Categories.ToList()
                select new SelectListItem
                {
                    Text = x.CategoryName,
                    Value = x.CategoryId.ToString()
                }).ToList();
            ViewBag.v = values;
            return View(value);
            
        }

        [HttpPost]
        public ActionResult UpdateProduct(Product product)
        {
            var value = _context.Products.Find(product.ProductId);
            value.Description = product.Description;
            value.Price = product.Price;
            value.ImageUrl = product.ImageUrl;
            value.CategoryId = product.CategoryId;
            value.IsActive=product.IsActive;
            value.ProductName = product.ProductName;
            _context.SaveChanges();
            return RedirectToAction("ProductList");
            
        }

        [HttpPost]
        public ActionResult DeleteProduct(int id)
        {
            var value=_context.Products.Find(id);
            if (value == null)
                return NotFound();
            _context.Products.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("ProductList");
        }

    }
}
