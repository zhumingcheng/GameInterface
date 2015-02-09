using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInterface.Domain.Model
{
    public class AppCategory : AggregateRoot
    {
        public AppCategory()
        {
            this.ID = Guid.NewGuid();
        }

        public Guid ID { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// 排序权重
        /// </summary>
        public string OrderWeight { get; set; }

        /// <summary>
        /// 状态。参见AppCategoryType枚举
        /// </summary>
        public string Type { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime LastModifyTime { get; set; }

        public Guid CreaterID { get; set; }

        public Guid LastModifierID { get; set; }
    }
}
