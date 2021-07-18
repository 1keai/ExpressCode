using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Services
{
   public interface IResourceService
    {
        /// <summary>
        /// 显示资源管理
        /// </summary>
        /// <param name="name"></param>
        /// <param name="appName"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<ResourceOutPut> GetResources(string name, string appId, int pageIndex, int pageSize, out int totalCount);
        /// <summary>
        /// 停用
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int UpdateDisable(string Id);
    }
}
