using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using w3schools.Models;
using w3schools_API.Models;
using w3schools_WEB.ApiCaller;
using w3schools_WEB.Models;

namespace w3schools.Controllers
{
    public class LessonContentsController : Controller
    {
        public LessonContentsController(IOptionsSnapshot<ApiUrl> app /*,IOptionsSnapshot<AuthenInfo> authen*/)
        {

            //authenSettings = authen;
            ApplicationSettings.WebApiUrl = app.Value.WebApiBaseUrl;
            //userInfo = new UserInfo();
        }

        public IActionResult Index(string contentType)
        {

            //string json = userInfo.GetUserInfo(HttpContext);

            //if (json != null)
            //{
            //    UserInfoModel curUser = JsonConvert.DeserializeObject<UserInfoModel>(json);

            //    curUser.token = await ApiClientFactory.Instance.RefeshToken(curUser);

            //    userInfo.SetUserInfo(curUser, HttpContext);                
            return View();
            //}            
        }

        public async Task<IActionResult> AddEditLessonContentsView(string method,int id = -1)
        {

            if (ModelState.IsValid)
            {
                var model = new LessonContents();
                if (id != -1)
                {
                    model = await ApiClientFactory.Instance.GetLessonContentById(id);                    
                    //ViewBag.UserRole = curUser.role;
                }                
                ViewBag.Method = method;
                return View(model);
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> GetListLessContent()
        {
            var returns = await ApiClientFactory.Instance.GetListLessonContents();
            return Json(returns);
        }

        [HttpPost]
        public async Task<IActionResult> AddEditLessonContentsMethod([FromQuery]string method, [FromBody] LessonContents obj)
        {
            if (ModelState.IsValid)
            {
                var result = new Message<DataResults<LessonContents>>();
                if (method == "edit")
                    result = await ApiClientFactory.Instance.UpdateLessonContent(obj);
                else if(method =="insert")
                    result = await ApiClientFactory.Instance.InsertLessonContent(obj);
                
                return Json(result);
            }
            return BadRequest("Request error");
        } 
        public async Task<IActionResult> DeleteLessonContent(int id =-1)
        {

            if (ModelState.IsValid)
            {
                var result = new DataResults<int>();
                if (id != -1)
                {
                    result = await ApiClientFactory.Instance.DeleteLessonContent(id);
                    return Json(result);
                }               
            }
            return BadRequest("Request error");
        }
    }    
}
