using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInterface.Domain.Model
{
    public class AppInfo : AggregateRoot
    {
        public AppInfo()
        {
            this.ID = Guid.NewGuid();
        }
        public Guid ID { get; set; }

        /// <summary>
        /// 所属类型
        /// </summary>
        public string AppCategoryType { get; set; }

        /// <summary>
        /// APP名称
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        public string Introduction { get; set; }

        /// <summary>
        /// 详情介绍
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// 更新日志
        /// </summary>
        public string UpdateLog { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 下载地址
        /// </summary>
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 排序权重
        /// </summary>
        public string OrderWeight { get; set; }

        /// <summary>
        /// 置顶
        /// </summary>
        public string IsTop { get; set; }

        /// <summary>
        /// 下载次数
        /// </summary>
        public string DownloadCount { get; set; }

        /// <summary>
        /// 版本名称
        /// </summary>
        public string VersionName { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        public string VersionNo { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime LastModifyTime { get; set; }

        public Guid CreaterID { get; set; }

        public Guid LastModifierID { get; set; }

        /// <summary>
        /// 状态（保存，上架，停用，删除）
        /// </summary>
        public string Status { get; set; }
    }
}
