using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using w3schools_WEB.ApiCaller;

namespace w3schools_WEB.Controllers
{
    public class ContentTypeController : Controller
    {
        public ContentTypeController(IOptionsSnapshot<ApiUrl> app /*,IOptionsSnapshot<AuthenInfo> authen*/)
        {

            //authenSettings = authen;
            ApplicationSettings.WebApiUrl = app.Value.WebApiBaseUrl;
            //userInfo = new UserInfo();
        }
        [HttpGet]
        public async Task<IActionResult> GetListContentType()
        {
            var returns = await ApiClientFactory.Instance.getListContentType();
            return Json(returns);
        }
    }
}
