using System;
using System.ComponentModel.DataAnnotations;

namespace iReading.Entity
{
    public class ArticleViews
    {
        /// <summary>
        /// 文章主键
        /// </summary>
        [Key]
        public int ArticleId { get; set; }

        /// <summary>
        /// 真实点击量
        /// </summary>
        public int Hits { get; set; }

        /// <summary>
        /// 用于展示的点击量
        /// </summary>
        public int ShowHits { get; set; }

        /// <summary>
        /// 用户IP
        /// </summary>
        public string UserIp { get; set; }

        /// <summary>
        /// 来源城市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 用户代理
        /// </summary>
        public int UserAgent { get; set; }

        /// <summary>
        /// 浏览时间
        /// </summary>
        public DateTime ViewTime { get; set; }
    }
}