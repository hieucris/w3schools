using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using w3schools_API.Models;
using w3schools_WEB.ApiCaller;

namespace w3schools_WEB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {            
            return View();                   
        }
        public async Task<IActionResult> CSS(int id = -1)
        {
            string filters=null;
            if (id != -1) {
                //( ContentType = N'Video' ) 
                filters = "(LessonId =" + id +")";
            }
            if (ModelState.IsValid)
            {
                var model = new List<LessonContents>();
                if (id != -1)
                {
                    model = await ApiClientFactory.Instance.GetListLessonContents(filters);                    
                }
                
                return Json(model);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
