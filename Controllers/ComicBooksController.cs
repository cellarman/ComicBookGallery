﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;   //MVC Library inserted

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller   //Inherits from Controller base
    {
        public ContentResult Detail()
        {

                if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)    //Monday is a enumeration value)
                 {

                         return  new RedirectResult("/");
                 }
                
              //  Content = "Hello from the comic books controller!"


            
     
        }
    }
}