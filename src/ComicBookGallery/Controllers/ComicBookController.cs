using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBookController : Controller
    {
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spiderman",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final moments of Dr. Octopus' life and his last, greatest and most evil attempt at revenge. Even if spiderman survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[] 
                {
                    new Artist(){Name = "Dan Slott", Role = "Script" },
                    new Artist(){Name = "Humberto Ramos", Role = "Pencils" },
                    new Artist(){Name = "Victor Olazaba", Role = "Ink" },
                    new Artist(){Name = "Edgar Delgado", Role = "Colors" },
                    new Artist(){Name = "Chris Eliopoulos", Role = "Letters" },
                }
            };
            return View(comicBook);
        }
    }
}