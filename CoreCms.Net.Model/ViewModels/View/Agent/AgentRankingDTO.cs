﻿/***********************************************************************
 *            Project: CoreCms
 *        ProjectName: 核心内容管理系统                                
 *                Web: https://www.corecms.net                      
 *             Author: 大灰灰                                          
 *              Email: jianweie@163.com                                
 *         CreateTime: 2021/1/31 21:45:10
 *        Description: 暂无
 ***********************************************************************/

using System;

namespace CoreCms.Net.Model.ViewModels.View.Agent
{
    public class AgentRankingDTO
    {
        /// <summary>
        ///     代理商序列
        /// </summary>
        public int id { get; set; }


        /// <summary>
        ///     代理商昵称
        /// </summary>
        public string nickname { get; set; }

        /// <summary>
        ///     加入时间
        /// </summary>
        public DateTime createtime { get; set; }

        /// <summary>
        ///     累计收益
        /// </summary>
        public decimal totalInCome { get; set; }

        /// <summary>
        ///     订单数
        /// </summary>
        public decimal orderCount { get; set; }
    }
}