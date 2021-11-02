﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using w3schools_API.Models;

namespace w3schools_WEB.ApiCaller
{
    public partial class ApiClient
    {
        public async Task<List<Lessons>> getListLesson()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Lessons/GetList"));

            var x = await GetAsync<List<Lessons>>(requestUrl);

            return x;
        }
        
        public async Task<DataResults<IEnumerable<UpdateBatchData<Lessons>>>> updateBatchLesson( IEnumerable<UpdateBatchData<Lessons>> data, string user="")
        {
            
            
            Uri toApi = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Lessons/Update?username=" + user));
            var results = await NewPostAsync<IEnumerable<UpdateBatchData<Lessons>>>(toApi, data);
            return results;
        }
    }
}
