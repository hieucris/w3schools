using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using w3schools_API.Models;

namespace w3schools_WEB.ApiCaller
{
    public partial class ApiClient
    {
        public async Task<List<LessonContents>> GetLstBankdfdf(string token)
        {
            Uri toApi = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "LstBank/GetList"));
            var results = await GetAsync<List<LessonContents>>(toApi, token);
            return results;
        }

        public async Task<DataResults<IEnumerable<UpdateBatchData<LessonContents>>>> Updateafd(string token, IEnumerable<UpdateBatchData<LessonContents>> data, string user)
        {
            Uri toApi = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "LstBank/Update?username=" + user));
            var results = await NewPostAsync<IEnumerable<UpdateBatchData<LessonContents>>>(toApi, data, token);
            return results;
        }
    }
}
