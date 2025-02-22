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

namespace CoreCms.Net.Model.Entities
{
    /// <summary>
    ///     商品参数类型关系表
    /// </summary>
    public class CoreCmsGoodsTypeParams
    {
        /// <summary>
        ///     商品参数id
        /// </summary>
        [Display(Name = "商品参数id")]
        [Required(ErrorMessage = "请输入{0}")]
        public int paramsId { get; set; }

        /// <summary>
        ///     商品类型id
        /// </summary>
        [Display(Name = "商品类型id")]
        [Required(ErrorMessage = "请输入{0}")]
        public int typeId { get; set; }
    }
}