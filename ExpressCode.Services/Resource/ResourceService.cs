using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpressCode.Repository;
namespace ExpressCode.Services
{
    public class ResourceService : BaseService, IResourceService
    {
        private IResourceRepository _resourceRepository;
        public ResourceService(IResourceRepository resourceRepository)
        {
            _resourceRepository = resourceRepository;
        }
        /// <summary>
        /// 显示资源管理
        /// </summary>
        /// <param name="name"></param>
        /// <param name="appName"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public List<ResourceOutPut> GetResources( string name, string appId, int pageIndex , int pageSize, out int totalCount)
        {
            var list = _resourceRepository.GetResources(name, appId, pageIndex, pageSize, out totalCount);
            return Mapper.Map<List<ResourceOutPut>>(list);
        }
        /// <summary>
        /// 停用
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int UpdateDisable(string Id)
        {
            return _resourceRepository.UpdateState(Id);
        }
    }
}
