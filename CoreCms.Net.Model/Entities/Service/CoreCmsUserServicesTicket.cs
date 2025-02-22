/***********************************************************************
 *            Project: CoreCms
 *        ProjectName: 核心内容管理系统                                
 *                Web: https://www.corecms.net                      
 *             Author: 大灰灰                                          
 *              Email: jianweie@163.com                                
 *         CreateTime: 2021/1/31 21:45:10
 *        Description: 暂无
 ***********************************************************************/

using System;
using System.ComponentModel.DataAnnotations;
using SqlSugar;

namespace CoreCms.Net.Model.Entities
{
    /// <summary>
    ///     服务消费券
    /// </summary>
    public partial class CoreCmsUserServicesTicket
    {
        /// <summary>
        ///     序列
        /// </summary>
        [Display(Name = "序列")]
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        [Required(ErrorMessage = "请输入{0}")]
        public int id { get; set; }

        /// <summary>
        ///     关联购买订单
        /// </summary>
        [Display(Name = "关联购买订单")]
        [Required(ErrorMessage = "请输入{0}")]
        [StringLength(50, ErrorMessage = "{0}不能超过{1}字")]
        public string serviceOrderId { get; set; }

        /// <summary>
        ///     安全码
        /// </summary>
        [Display(Name = "安全码")]
        [Required(ErrorMessage = "请输入{0}")]
        public Guid securityCode { get; set; }

        /// <summary>
        ///     兑换码
        /// </summary>
        [Display(Name = "兑换码")]
        [Required(ErrorMessage = "请输入{0}")]
        [StringLength(50, ErrorMessage = "{0}不能超过{1}字")]
        public string redeemCode { get; set; }

        /// <summary>
        ///     关联服务项目id
        /// </summary>
        [Display(Name = "关联服务项目id")]
        [Required(ErrorMessage = "请输入{0}")]
        public int serviceId { get; set; }

        /// <summary>
        ///     关联用户id
        /// </summary>
        [Display(Name = "关联用户id")]
        [Required(ErrorMessage = "请输入{0}")]
        public int userId { get; set; }

        /// <summary>
        ///     状态
        /// </summary>
        [Display(Name = "状态")]
        [Required(ErrorMessage = "请输入{0}")]
        public int status { get; set; }

        /// <summary>
        ///     核销有效期类型
        /// </summary>
        [Display(Name = "核销有效期类型")]
        [Required(ErrorMessage = "请输入{0}")]
        public int validityType { get; set; }

        /// <summary>
        ///     核销开始时间
        /// </summary>
        [Display(Name = "核销开始时间")]
        public DateTime? validityStartTime { get; set; }

        /// <summary>
        ///     核销结束时间
        /// </summary>
        [Display(Name = "核销结束时间")]
        public DateTime? validityEndTime { get; set; }

        /// <summary>
        ///     创建时间
        /// </summary>
        [Display(Name = "创建时间")]
        [Required(ErrorMessage = "请输入{0}")]
        public DateTime createTime { get; set; }

        /// <summary>
        ///     是否核销
        /// </summary>
        [Display(Name = "是否核销")]
        [Required(ErrorMessage = "请输入{0}")]
        public bool isVerification { get; set; }

        /// <summary>
        ///     核销时间
        /// </summary>
        [Display(Name = "核销时间")]
        public DateTime? verificationTime { get; set; }
    }
}