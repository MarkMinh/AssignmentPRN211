using AutoMapper;
using eStore.Models;
using eStore.Models.DataModels;
using eStore.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eStore.Controllers
{
    public class OrderController : Controller
    {
        IMapper mapper;
        SaleAsm2Context db = new SaleAsm2Context();
		public OrderController(IMapper mapper)
		{
			this.mapper = mapper;
		}
		// GET: OrderController
		public ActionResult Index()
        {
			if (HttpContext.Session.GetString("admin") == null)
			{
				var email = HttpContext.Session.GetString("email");
				var mem = db.Members.SingleOrDefault(m=> m.Email == email);
				var orders = db.Orders.Where(m => m.MemberId == mem.MemberId);
				return View(orders);
			}
			var orderList = db.Orders.ToList();
            return View(orderList);
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var order = db.Orders.SingleOrDefault(o=>o.OrderId == id);
            if(order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // GET: OrderController/Create
        public ActionResult Create()
        {
			if(HttpContext.Session.GetString("admin") == null)
			{
                return RedirectToAction("Unauthorized","Access");
            }
            return View();
        }
		public ActionResult Statistics()
		{

			var sta = db.Orders.ToList();
			return View(sta);
		}
		[HttpPost]
		public ActionResult Statistics(DateTime startDate, DateTime endDate)
		{
			var sta = db.Orders.Where(o=>o.OrderDate>=startDate && o.OrderDate <= endDate).ToList();
			return View(sta);
		}

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrderViewModel o)
        {
            if (HttpContext.Session.GetString("admin") == null)
            {
                return RedirectToAction("Index");
            }
            try
			{
				if (ModelState.IsValid)
				{
                    var order = mapper.Map<Order>(o);
                    db.Orders.Add(order);
                    db.SaveChanges();
					
				}
				return RedirectToAction("Create", "OrderDetail");
			}
			catch (Exception ex)
			{
				ViewBag.Message = ex.Message;
				return View(o);
			}
		}

        // GET: OrderController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (HttpContext.Session.GetString("admin") == null)
            {
                return RedirectToAction("Index");
            }
            if (id == null)
			{
				return NotFound();
			}
			var order = db.Orders.SingleOrDefault(o=>o.OrderId==id);
			if (order == null)
			{
				return NotFound();
			}
			return View(order);
		}

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Order o)
        {
            if (HttpContext.Session.GetString("admin") == null)
            {
                return RedirectToAction("Index");
            }
            try
			{
				if (id != o.OrderId)
				{
					return NotFound();
				}
				if (ModelState.IsValid)
				{
					db.Orders.Update(o);
                    db.SaveChanges();
				}
				return RedirectToAction(nameof(Index));
			}
			catch (Exception ex)
			{
				ViewBag.Message = ex.Message;
				return View();
			}
		}

        // GET: OrderController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (HttpContext.Session.GetString("admin") == null)
            {
                return RedirectToAction("Index");
            }
            if (id == null)
			{
				return NotFound();
			}
			var order = db.Orders.SingleOrDefault(o=>o.OrderId==id);
			if (order == null)
			{
				return NotFound();
			}
			return View(order);
		}

        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            if (HttpContext.Session.GetString("admin") == null)
            {
                return RedirectToAction("Index");
            }
            try
			{
				var od = db.OrderDetails.SingleOrDefault(od=>od.OrderId==id);
				if(od == null)
				{
					return NotFound();
				}
				db.OrderDetails.Remove(od);
				var o = db.Orders.SingleOrDefault(o => o.OrderId == id);
				if (o == null)
				{
					return NotFound();
				}
				db.Orders.Remove(o);
				db.SaveChanges();
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
