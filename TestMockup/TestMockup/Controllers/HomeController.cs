using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TestMockup.DAL;
using TestMockup.DTO.Request;

namespace TestMockup.Controllers
{
    public class HomeController : Controller
    {
        TestMockupDbContext _context = new TestMockupDbContext();
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult UploadVideo()
        {
            return View();
        }

        public ActionResult Upload()
        {
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> LoginUser(LoginReqDTO obj)
        {
            var response = await _context.Users.AnyAsync(x => x.Email == obj.Email && x.Password == obj.Password);
            if (response)
            {
              return RedirectToAction("UploadVideo");
            }
            else
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound);
            }
        }

    }
}