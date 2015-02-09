using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInterface.Domain.Model
{
    public class DownloadInfo : AggregateRoot
    {
        public Guid ID { get; set; }

        /// <summary>
        /// 手机的Mac地址
        /// </summary>
        public string MacInfo { get; set; }

        /// <summary>
        /// 手机型号
        /// </summary>
        public string PhoneType { get; set; }

        /// <summary>
        /// 手机系统
        /// </summary>
        public string PhoneSystem { get; set; }

        /// <summary>
        /// 系统版本号
        /// </summary>
        public string SystemVersion { get; set; }

        /// <summary>
        /// 手机名称
        /// </summary>
        public string PhoneName { get; set; }

        /// <summary>
        /// 下载时间
        /// </summary>
        public DateTime DownloadTime { get; set; }

        /// <summary>
        /// 下载的APPName
        /// </summary>
        public string DownloadAppName { get; set; }


        /// <summary>
        /// 下载的APP ID
        /// </summary>
        public Guid DownloadAppID { get; set; }
    }
}
