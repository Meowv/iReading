using System;

namespace Reading.Model
{
    public class Articles
    {
        public string Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Digest { get; set; }
        public string Content { get; set; }
        public string Words { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
