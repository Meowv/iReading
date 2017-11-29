using System;
using System.ComponentModel.DataAnnotations;

namespace iReading.Entity
{
    public class Articles
    {
        /// <summary>
        /// 文章主键
        /// </summary>
        [Key]
        public int ArticleId { get; set; }

        /// <summary>
        /// 文章标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 文章作者
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// 文章概要
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// 文章详情
        /// </summary>
        public string Details { get; set; }

        /// <summary>
        /// 文章类型
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// 文章Logo
        /// </summary>
        public string Logo { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime IssueTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 文章状态
        /// 0 ---- 发布
        /// 1 ---- 草稿
        /// 2 ---- 定时
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 是否删除
        /// 0 ---- 未删除
        /// 1 ---- 已删除
        /// </summary>
        public int IsDelete { get; set; }
    }
}
