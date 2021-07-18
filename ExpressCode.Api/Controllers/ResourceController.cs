using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpressCode.Services;
using ExpressCode.Common;

namespace ExpressCode.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        private IResourceService _resourceService;

        
        public ResourceController(IResourceService resourceService)
        {
            _resourceService = resourceService;
        }

        /// <summary>
        /// 显示资源管理
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetResource")]
        public ResultData GetResource(string name="", string appId = "", int pageIndex=1, int pageSize=2)
        {
            int total;

            List<ResourceOutPut> list = _resourceService.GetResources(name, appId, pageIndex, pageSize, out total);
            ResultData resultData = new ResultData();
            try
            {
                resultData = new ResultData
                {
                    code = 200,
                    msg = "请求成功",
                    data = new { list,total}
                };
            }
            catch (Exception)
            {
                resultData = new ResultData
                {
                    code = 500,
                    msg = "请求失败",
                    data = ""
                };
            }
            return resultData;
        }
        /// <summary>
        ///  //停用
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("UpdateDisable")]
        public ResultData UpdateDisable(string id)
        {
            int i = _resourceService.UpdateDisable(id);
            ResultData resultData = new ResultData();
            if (i > 0)
            {
                resultData = new ResultData
                {
                    code = 200,
                    msg = "请求成功",
                    data = i
                };
            }
            else
            {
                resultData = new ResultData
                {
                    code = 500,
                    msg = "请求失败",
                    data = i
                };
            }
            return resultData;
        }
    }
}
