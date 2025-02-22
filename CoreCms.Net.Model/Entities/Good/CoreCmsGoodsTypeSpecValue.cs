/***********************************************************************
 *            Project: CoreCms
 *        ProjectName: 核心内容管理系统                                
 *                Web: https://www.corecms.net                      
 *             Author: 大灰灰                                          
 *              Email: jianweie@163.com                                
 *         CreateTime: 2021/1/31 21:45:10
 *        Description: 暂无
 ***********************************************************************/

using System.ComponentModel.DataAnnotations;
using SqlSugar;

namespace CoreCms.Net.Model.Entities
{
    /// <summary>
    ///     商品类型属性值表
    /// </summary>
    public class CoreCmsGoodsTypeSpecValue
    {
        /// <summary>
        ///     序列
        /// </summary>
        [Display(Name = "序列")]
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        [Required(ErrorMessage = "请输入{0}")]
        public int id { get; set; }

        /// <summary>
        ///     属性ID 关联goods_type_spec.id
        /// </summary>
        [Display(Name = "属性ID 关联goods_type_spec.id")]
        [Required(ErrorMessage = "请输入{0}")]
        public int specId { get; set; }

        /// <summary>
        ///     属性值
        /// </summary>
        [Display(Name = "属性值")]
        [Required(ErrorMessage = "请输入{0}")]
        [StringLength(255, ErrorMessage = "{0}不能超过{1}字")]
        public string value { get; set; }

        /// <summary>
        ///     排序
        /// </summary>
        [Display(Name = "排序")]
        [Required(ErrorMessage = "请输入{0}")]
        public int sort { get; set; }
    }
}