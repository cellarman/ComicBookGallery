﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;   //MVC Library inserted
using ComicBookGallery.Models;
using ComicBookGallery.Data;


namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller   //Inherits from Controller base
    { 

        private ComicBookRepository _comicBookRepository = null;

    public ComicBooksController()
    {
        _comicBookRepository = new ComicBookRepository();
    }
    
        public ActionResult Index()
        {
            var comicBooks = _comicBookRepository.GetComicBooks();

            return View(comicBooks);
        }



        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();


            }

            var comicBook = _comicBookRepository.GetComicBook((int)id);

            return View(comicBook);

     
        }
    }
}

