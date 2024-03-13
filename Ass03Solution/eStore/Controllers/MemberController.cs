
using BusinessObject;
using DataAccess.Repository;
using eStore.Models;
using eStore.Models.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eStore.Controllers
{
    public class MemberController : Controller
    {
        SaleAsm2Context _context = new SaleAsm2Context();
        IMemberRepository memberRepository = new MemberRepository();
        // GET: MemberController
        public ActionResult Index()
        {
			if (HttpContext.Session.GetString("admin") == null)
			{
				return RedirectToAction("Details", "Member");
			}
			var listMember = memberRepository.GetMembers();
            //var list = _context.Members;
            return View(listMember);
        }

        // GET: MemberController/Details/5
        public ActionResult Details(int id)
        {
            if (HttpContext.Session.GetString("admin") != null)
            {
                var member = _context.Members.SingleOrDefault(m => m.MemberId == id);
                //var member = memberRepository.GetMemberByID(id);
                if (member == null)
                {
                    return NotFound();
                }
                return View(member);
            }
            else
            {
                var session = HttpContext.Session.GetString("email");
                var member2 = _context.Members.SingleOrDefault(m => m.Email.Equals(session));
                return View(member2);
            }
            
        }

        // GET: MemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: MemberController/Edit/5
        public ActionResult Edit(int id)
        {
            if(HttpContext.Session.GetString("admin") != null)
            {
                if (id == null)
                {
                    return NotFound();
                }
                var member = _context.Members.SingleOrDefault(m => m.MemberId == id);
                if (member == null)
                {
                    return NotFound();
                }
                return View(member);
            }
            var session = HttpContext.Session.GetString("email");
            var member2 = _context.Members.SingleOrDefault(m=>m.Email.Equals(session));
            return View(member2);

        }

        // POST: MemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Member member)
        {
            try
            {
                if (id != member.MemberId)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    _context.Update(member);
                    _context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        // GET: MemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MemberController/Delete/5
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
