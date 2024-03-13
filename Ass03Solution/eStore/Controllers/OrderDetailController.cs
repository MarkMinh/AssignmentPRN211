using AutoMapper;
using DataAccess;
using eStore.Models;
using eStore.Models.DataModels;
using eStore.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eStore.Controllers
{
    public class OrderDetailController : Controller
    {
		IMapper mapper;
         
        public OrderDetailController(IMapper mapper)
		{
			this.mapper = mapper;
		}

		public SaleAsm2Context db = new SaleAsm2Context();
        // GET: OrderDetailController
        public ActionResult Index()
        {
            var list = db.OrderDetails.ToList();
            return View(list);
        }

        // GET: OrderDetailController/Details/5
        public ActionResult Details(int id)
        {
            if(id == 0)
            {
                return NotFound();
            }
            var orderDetail = db.OrderDetails.SingleOrDefault(o=>o.OrderId == id);
            if(orderDetail == null)
            {
                return NotFound();
            }
            return View(orderDetail);
        }

        // GET: OrderDetailController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderDetailController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrderDetailViewModel od)
        {
			try
			{
				if (ModelState.IsValid)
				{
					var orderDetail = mapper.Map<OrderDetail>(od);
                    orderDetail.OrderId = db.Orders.Max(p => p.OrderId);
					db.OrderDetails.Add(orderDetail);
					db.SaveChanges();
				}
				return RedirectToAction("Index", "Order");
			}
			catch (Exception ex)
			{
				ViewBag.Message = ex.Message;
				return View(od);
			}
		}

        // GET: OrderDetailController/Edit/5
        public ActionResult Edit(int? id)
        {
			if (id == null)
			{
				return NotFound();
			}
			var orderDetail = db.OrderDetails.SingleOrDefault(p => p.OrderId == id);
			if (orderDetail == null)
			{
				return NotFound();
			}
			return View(orderDetail);
		}

        // POST: OrderDetailController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, OrderDetail orderDetail)
        {
			try
			{
				if (id != orderDetail.OrderId)
				{
					return NotFound();
				}
				
                //if(ModelState.IsValid)
                //{
                    db.OrderDetails.Update(orderDetail);
                    db.SaveChanges();
                //}
                return RedirectToAction("Details","Order",new {id = id});
            }
			catch (Exception ex)
			{
				ViewBag.Message = ex.Message;
                return View(id);
			}
		}

        // GET: OrderDetailController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderDetailController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
