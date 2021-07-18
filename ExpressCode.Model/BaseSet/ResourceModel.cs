using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCode.Model
{
    [Table("Resource")]
    public class ResourceModel
    {
        [Key]
        public string Id { get; set; }               //--主键(雪花ID)	
        public string CascadeId { get; set; }        //--层级ID	
        public string Name { get; set; }             //--名称	
        public int SortNo { get; set; }              //--排序号	
        public string Description { get; set; }      //-- 描述	
        public string ParentName { get; set; }       //--父节点名称	
        public string ParentId { get; set; }         //--父节点ID	
        public string AppId { get; set; }            //--资源所属应用ID
        public string AppName { get; set; }          //--所属应用名称	
        public string TypeName { get; set; }         //--分类名称	
        public string TypeId { get; set; }           //--分类ID	
        public int Disable { get; set; }             //--是否可用	
        public  DateTime CreateTime { get; set; }    //--创建时间	
        public string CreateUserId { get; set; }     //--创建人ID	
        public string CreateUserName { get; set; }   //--创建人	
        public DateTime UpdateTime { get; set; }     //--最后更新时间	
        public string UpdateUserId { get; set; }     //--最后更新人ID	
        public string UpdateUserName { get; set; }   //--最后更新人ID
    }
}
