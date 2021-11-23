using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using w3schools_API.Models;

namespace w3schools_WEB.ApiCaller
{
    public partial class ApiClient
    {
        public async Task<DataResults<UserInfo>> checkLogin(string email, string password)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Auth/CheckLogin?email="+email+"&password="+password));

            var x = await GetAsync<DataResults<UserInfo>>(requestUrl);

            return x;
        }
        public async Task<DataResults<UserInfo>> signup(Users data)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Auth/Signup"));

            var x = await PostAsyncForToken<DataResults<UserInfo>,Users>(requestUrl,data);

            return x;
        }
    }
}

