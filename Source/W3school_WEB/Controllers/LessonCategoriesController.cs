using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using w3schools_API.Models;
using w3schools_WEB.ApiCaller;

namespace w3schools_WEB.Controllers
{
    public class LessonCategoriesController : Controller
    {
        public LessonCategoriesController(IOptionsSnapshot<ApiUrl> app /*,IOptionsSnapshot<AuthenInfo> authen*/)
        {
            //authenSettings = authen;
            ApplicationSettings.WebApiUrl = app.Value.WebApiBaseUrl;
            //userInfo = new UserInfo();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> GetListLessonCategories()
        {
            var returns = await ApiClientFactory.Instance.getListLessonCate();
            return Json(returns);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateBatchLessonCategories([FromBody] IEnumerable<UpdateBatchData<LessonCategories>> data)
        {
            var result = await ApiClientFactory.Instance.updateBatchLessonCate(data);
            return Json(result);
        }

    }
}
