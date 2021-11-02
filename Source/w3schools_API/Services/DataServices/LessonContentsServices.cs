using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using w3schools_API.Models;
using w3schools_API.Services.Interfaces;

namespace w3schools_API.Services.DataServices
{
    public class LessonContentsServices:ILessonContents
    {
        private BaseServices basesvc;
        private readonly String table = "LessonContents";
        public LessonContentsServices()
        {
            basesvc = new BaseServices();
        }

        public async Task<IEnumerable<LessonContents>> GetList(string constr, string filters)
        {
            var result = await basesvc.GetList<LessonContents>(table, constr,filters);
            return result;
        }
        public async Task<LessonContents> GetById(string constr, int id)
        {
            var result = await basesvc.GetById<LessonContents>(table, "LessonContentId",id, constr);
            return result;
        }
        public async Task<DataResults<object>> Insert(LessonContents data,string constr)
        {
            basesvc.CommonUpdate(data, "admin", "create");
            object obj = new
            {
                data.ContentTitle,
                data.ContentTypeId,
                data.ContentOrder,
                data.Content,
                data.LessonId,
                data.DateCreated,
                data.CreatedBy,
            };
            var result = await basesvc.Insert<object>(table,obj, constr);
            return result;
        }
        public async Task<DataResults<int>> Delete(string constr,int id)
        {
            var result = await basesvc.Delete(table, constr, "LessonContentId",id);
            return result;
        }
        public async Task<DataResults<object>> Update(LessonContents data, string constr)
        {
            basesvc.CommonUpdate(data, "admin", "update");
            object obj = new
            {
                data.ContentTitle,
                data.ContentTypeId,
                data.ContentOrder,
                data.Content,
                data.LessonId,
                data.DateModified,
                data.ModifiedBy,
            };
            var result = await basesvc.Update(table,obj, constr, "LessonContentId",(int)data.LessonContentId);
            return result;
        }
    }
}
