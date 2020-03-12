using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;   //MVC Library inserted

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller   //Inherits from Controller base
    {
        public string Detail()
        {

            return "Hello from the comic books controller!";

        }
    }
}