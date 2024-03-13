using AutoMapper;
using BusinessObject;
using DataAccess.Repository;
using eStore.Models;
using eStore.Models.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Options;
using Microsoft.IdentityModel.Tokens;
using System.Collections;

namespace eStore.Controllers
{
    
    public class ProductController : Controller
    {
		
		IProductRepository productsRepository = new ProductRepository();
        SaleAsm2Context _context = new SaleAsm2Context();
        // GET: ProductController
        public ActionResult Index()
        {
            var listProduct = productsRepository.GetProducts();
            return View(listProduct);
        }
        
        public ActionResult Search(string txtSearch)
        {
            
            IEnumerable<ProductObject> listSearch = productsRepository.GetSearchProductByName(txtSearch);

            
            return View(listSearch);
        }

        public IActionResult Filter(string price)
        {
            IEnumerable<ProductObject> listFilter = productsRepository.GetProducts();
            switch (price)
            {
                case "0": listFilter = productsRepository.GetProducts(); break;
                case "0-50": listFilter = productsRepository.GetSearchProductByUnitPrice(0, 50); break;
                case "50-100": listFilter = productsRepository.GetSearchProductByUnitPrice(50, 100); break;
                case "100-200": listFilter = productsRepository.GetSearchProductByUnitPrice(100, 200); break;
                case "200-": listFilter = productsRepository.GetSearchProductByUnitPrice(200); break;

                default:
                    break;
            }
            return View(listFilter);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            if(id == 0)
            {
                return NotFound();
            }
            var product = productsRepository.GetProductByID(id);
            if(product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
			if (HttpContext.Session.GetString("admin") == null)
			{
				return RedirectToAction("Unauthorized", "Access");
			}
			return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductObject product)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    productsRepository.InsertProduct(product);
                }
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(product);
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int? id)
        {
			if (HttpContext.Session.GetString("admin") == null)
			{
				return RedirectToAction("Unauthorized", "Access");
			}
			if (id == null)
            {
                return NotFound();
            }
            var product = productsRepository.GetProductByID(id.Value);
            if(product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProductObject product)
        {
			if (HttpContext.Session.GetString("admin") == null)
			{
				return RedirectToAction("Unauthorized", "Access");
			}
			try
            {
                if(id != product.ProductId)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    productsRepository.UpdateProduct(product);
                }
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int? id)
        {
			if (HttpContext.Session.GetString("admin") == null)
			{
				return RedirectToAction("Unauthorized", "Access");
			}
			if (id == null)
            {
                return NotFound();
            }
            var product = productsRepository.GetProductByID(id.Value);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
			if (HttpContext.Session.GetString("admin") == null)
			{
				return RedirectToAction("Unauthorized", "Access");
			}
			try
            {
                productsRepository.DeleteProduct(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}
