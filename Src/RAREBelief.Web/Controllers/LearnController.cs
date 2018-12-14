using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RAREBelief.Web.Controllers
{
    public class LearnController : Controller
    {
        // GET: Learn
        public ActionResult Index()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            // Use method syntax to apply a lambda expression to each element
            // of the words array. 
            int shortestWordLength = words.Min(w => w.Length);
            ViewBag.Message = shortestWordLength;

            // Compare the following code that uses query syntax.
            // Get the lengths of each word in the words array.
            var query = from w in words
                        select w.Length;
            // Apply the Min method to execute the query and get the shortest length.
            int shortestWordLength2 = query.Min();
            Console.WriteLine(shortestWordLength2);


            return View();
        }
    }
}