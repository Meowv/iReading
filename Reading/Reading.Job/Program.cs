using Newtonsoft.Json.Linq;
using Reading.Bll;
using Reading.Model;
using Reading.Utility;
using System;

namespace Reading.Job
{
    class Program
    {
        static void Main()
        {
            const string api = "https://interface.meiriyiwen.com/article/random";
            for (var i = 0; i < 10; i++)
            {
                var json = HttpHelper.HttpGet(api);
                var obj = JObject.Parse(json);
                try
                {
                    var author = obj["data"]["author"].ToString();
                    var title = obj["data"]["title"].ToString();
                    var digest = obj["data"]["digest"].ToString();
                    var content = obj["data"]["content"].ToString();
                    var words = obj["data"]["wc"].ToString();

                    var articles = new Articles
                    {
                        Id = Guid.NewGuid().ToString(),
                        Author = author,
                        Title = title,
                        Digest = digest,
                        Content = content,
                        Words = words,
                        CreateTime = DateTime.Now
                    };
                    var bll = new ArticleBll();
                    if (bll.IsExistArticle(author, title))
                    {
                        Console.WriteLine("exist");
                    }
                    else
                    {
                        var v = bll.InsertArticle(articles);
                        Console.WriteLine(v >= 1 ? "ojbk" : "error");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}