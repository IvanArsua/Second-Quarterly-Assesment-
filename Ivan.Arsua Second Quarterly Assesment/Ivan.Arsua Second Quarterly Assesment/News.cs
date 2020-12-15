using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Ivan.Arsua_Second_Quarterly_Assesment
{
    public class News
    {
        public string Status { get; set; }
        public int TotalResults { get; set; }
        public List<Article> Articles { get; set; }
    }
    public class Article
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string SourceName { get; set; }
        public string PublishedAt { get; set; }
    }
}   
