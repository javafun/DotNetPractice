using FizzWare.NBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace MvcApplication2
{
    public class NewsService
    {
        public IEnumerable<News> GetNews()
        {
            Thread.Sleep(5000);
            var result = Builder<News>.CreateListOfSize(50).Build();

            return result;

        }
    }


    public class News
    {
        public string Title { get; set; }
        public int ID { get; set; }
        public string ShortDescription { get; set; }
    }

}