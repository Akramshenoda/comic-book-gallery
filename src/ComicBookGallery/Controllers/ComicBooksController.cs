﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace ComicBookGallery.Controllers
{
   public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {

            if (DateTime.Today.DayOfWeek==DayOfWeek.Tuesday)
            {
                return Redirect("/");
                
            }
            return new ContentResult()
            {

                Content ="Hello from comic books controller"
            }
                ;


        }


    }



    }
