using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Common.Result
{
    public class ResultData
    {
        /// <summary>
        /// 状态码
        /// </summary>
        public int code { get; set; }
        /// <summary>
        ///  //返回信息
        /// </summary>
        public string Msg { get; set; }
        /// <summary>
        ///  //返回数据
        /// </summary>
        public object data { get; set; }
    }
}
