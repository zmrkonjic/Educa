using System;


namespace Bookmark.Manager
{
    public class Bookmark
    {
        public Bookmark(string name, string url, DateTime timestamp)
        {
            this.Name = name;
            this.Url = url;
            this.Timestimp = timestamp;
        }


        public string Name { get; private set; }
        public string Url { get; private set; }
        public DateTime Timestimp { get; private set; }

    }
}
