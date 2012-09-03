using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class AsnyDemoController : AsyncController
    {
        //
        // GET: /AsnyDemo/

        public void IndexAsync()
        {
            AsyncManager.OutstandingOperations.Increment();
            NewsService service = new NewsService();
            var result = service.GetNews();
            AsyncManager.Parameters["values"] = result;
            AsyncManager.OutstandingOperations.Decrement();         
        }

        public ActionResult IndexCompleted(IEnumerable<News> values)
        {            
            return View(values);
        }

    }
}
