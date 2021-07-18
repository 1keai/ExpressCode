using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpressCode.Model;
namespace ExpressCode.Services
{
    public class _MapConfig: Profile
    {
        public _MapConfig()
        {
            //查询
            CreateMap<ResourceModel,ResourceOutPut>();

        }
    }
}
