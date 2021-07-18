using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpressCode.Model;
using ExpressCode.Common;
namespace ExpressCode.Repository
{
    public class ResourceRepository : IResourceRepository
    {
        DBFactory dbFactory = new DBFactory();
        /// <summary>
        /// 显示资源管理
        /// </summary>
        /// <param name="name"></param>
        /// <param name="AppName"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public List<ResourceModel> GetResources( string name, string appId, int pageIndex , int pageSize , out int totalCount)
        {
            string sql = "select * from Resource where Disable=0";
            
            List<ResourceModel> list=dbFactory.GetBaseRepository().Query<ResourceModel>(sql);

            if (!string.IsNullOrEmpty(name))
            {
                list = list.Where(p=>p.Name.Contains(name)).ToList();
            }
            if (!string.IsNullOrEmpty(appId))
            {
                list = list.Where(p=>p.AppId.Equals(appId)).ToList();
            }
            totalCount = list.Count;

            return list.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        }
        /// <summary>
        /// 停用
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int UpdateState(string Id)
        {
            string sql = "update Resource set Disable=1 where Id=@Id";

            return dbFactory.GetBaseRepository().Execute(sql,new { @Id =Id});
        }
    }
}
