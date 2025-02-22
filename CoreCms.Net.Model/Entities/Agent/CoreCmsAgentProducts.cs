/***********************************************************************
 *            Project: CoreCms
 *        ProjectName: 核心内容管理系统                                
 *                Web: https://www.corecms.net                      
 *             Author: 大灰灰                                          
 *              Email: jianweie@163.com                                
 *         CreateTime: 2021/1/31 21:45:10
 *        Description: 暂无
 ***********************************************************************/

using SqlSugar;
using System.ComponentModel.DataAnnotations;

namespace CoreCms.Net.Model.Entities
{
    /// <summary>
    /// 代理货品池
    /// </summary>
    public partial class CoreCmsAgentProducts
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public CoreCmsAgentProducts()
        {
        }

        /// <summary>
        /// 序列
        /// </summary>
        [Display(Name = "序列")]
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        [Required(ErrorMessage = "请输入{0}")]

        public System.Int32 id { get; set; }

        /// <summary>
        /// 关联代理商品池
        /// </summary>
        [Display(Name = "关联代理商品池")]
        [Required(ErrorMessage = "请输入{0}")]

        public System.Int32 agentGoodsId { get; set; }

        /// <summary>
        /// 商品序列
        /// </summary>
        [Display(Name = "商品序列")]
        [Required(ErrorMessage = "请输入{0}")]

        public System.Int32 goodId { get; set; }

        /// <summary>
        /// 货品序列
        /// </summary>
        [Display(Name = "货品序列")]
        [Required(ErrorMessage = "请输入{0}")]

        public System.Int32 productId { get; set; }

        /// <summary>
        /// 货品成本价格
        /// </summary>
        [Display(Name = "货品成本价格")]
        [Required(ErrorMessage = "请输入{0}")]

        public System.Decimal productCostPrice { get; set; }

        /// <summary>
        /// 货品销售价格
        /// </summary>
        [Display(Name = "货品销售价格")]
        [Required(ErrorMessage = "请输入{0}")]

        public System.Decimal productPrice { get; set; }

        /// <summary>
        /// 代理商等级
        /// </summary>
        [Display(Name = "代理商等级")]
        [Required(ErrorMessage = "请输入{0}")]

        public System.Int32 agentGradeId { get; set; }

        /// <summary>
        /// 代理价格
        /// </summary>
        [Display(Name = "代理价格")]
        [Required(ErrorMessage = "请输入{0}")]

        public System.Decimal agentGradePrice { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Display(Name = "创建时间")]
        [Required(ErrorMessage = "请输入{0}")]

        public System.DateTime createTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [Display(Name = "更新时间")]

        public System.DateTime? updateTime { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        [Display(Name = "是否删除")]
        [Required(ErrorMessage = "请输入{0}")]

        public System.Boolean isDel { get; set; }
    }
}