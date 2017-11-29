using Dapper;
using Reading.Factory;
using Reading.Model;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Reading.Dal
{
    public class ArticleDal
    {
        private IDbConnection _conn;
        public IDbConnection Conn
        {
            get
            {
                return _conn = ConnectionFactory.CreateConnection();
            }
        }

        /// <summary>
        /// Add the article
        /// </summary>
        /// <param name="articles"></param>
        /// <returns></returns>
        public int InsertArticle(Articles articles)
        {
            using (Conn)
            {
                var sql = @"INSERT  INTO Articles
                            ( Id ,
                              Author ,
                              Title ,
                              Digest ,
                              Content ,
                              Words ,
                              CreateTime
                            )
                    VALUES  ( @Id ,
                              @Author ,
                              @Title ,
                              @Digest ,
                              @Content ,
                              @Words ,
                              @CreateTime
                            )";
                return Conn.Execute(sql, articles);
            }
        }

        /// <summary>
        /// Whether the article exists or not
        /// </summary>
        /// <param name="author"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        public int IsExistArticle(string author, string title)
        {
            using (Conn)
            {
                var sql = @"SELECT
	                            COUNT(*)
                            FROM
	                            Articles
                            WHERE
	                            Title = @Title
                            AND Author = @Author";
                return int.Parse(Conn.ExecuteScalar(sql, new { Author = author, Title = title }).ToString());
            }
        }

        /// <summary>
        /// Articles List very slow
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Articles> Get_Articles_List()
        {
            using (Conn)
            {
                var sql = @"SELECT * FROM `articles`";
                return Conn.Query<Articles>(sql);
            }
        }

        /// <summary>
        /// New Article
        /// </summary>
        /// <returns></returns>
        public Articles Get_New_Article()
        {
            using (Conn)
            {
                var sql = "SELECT * FROM `articles` order by CreateTime DESC LIMIT 1";
                return Conn.Query<Articles>(sql).FirstOrDefault();
            }
        }

        /// <summary>
        /// Random Article
        /// </summary>
        /// <returns></returns>
        public Articles Get_Random_Article()
        {
            using (Conn)
            {
                var sql = "SELECT * FROM `articles` order by rand() LIMIT 1";
                return Conn.Query<Articles>(sql).FirstOrDefault();
            }
        }
    }
}