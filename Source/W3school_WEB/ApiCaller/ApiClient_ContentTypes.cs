using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using w3schools_API.Models;

namespace w3schools_WEB.ApiCaller
{
    public partial class ApiClient
    {
        public async Task<List<ContentTypes>> getListContentType()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "ContentTypes/GetList"));

            var x = await GetAsync<List<ContentTypes>>(requestUrl);

            return x;
        }
    }
}
