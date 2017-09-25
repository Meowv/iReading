﻿using iReading.DAL;
using iReading.Entity;
using iReading.Utility;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace iReading.Job
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "https://interface.meiriyiwen.com/article/random";
            string json = HttpHelper.SendPost(url, new Dictionary<string, string>(), "get");
            JObject obj = JObject.Parse(json);

            using (ArticleDbContext db = new ArticleDbContext("Server=.;Database=Reading;User ID=sa;Password=123456"))
            {
                db.Articles.Add(new Articles()
                {
                    Title = (string)obj["data"]["title"],
                    Author = (string)obj["data"]["author"],
                    Details = (string)obj["data"]["content"],
                    Summary = (string)obj["data"]["digest"],
                    Category = "阅读",
                    IssueTime = DateTime.Now,
                    UpdateTime = DateTime.Now
                });
                db.SaveChanges();
            }
        }
    }
}