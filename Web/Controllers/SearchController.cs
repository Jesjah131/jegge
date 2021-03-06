﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebData;
using Web.Models;

namespace Web.Controllers
{
    public class SearchController : Controller
    {
        [HttpGet]
        public ActionResult Search()
        {
            return PartialView("_SearchFormPartial");
        }

        [HttpPost]
        public ActionResult Search(string query)
        {
            UserRepository rep = new UserRepository();

            if (query != null)
            {
                try
                {
                    var searchlist = rep.GetSearchedUsername(query);

                    var model = new SearchModel()
                    {
                        Usernames = searchlist
                    };

                    return PartialView("_SearchResultsPartial", model);
                }
                catch (Exception e)
                {
                    // handle exception
                }
            }
            return PartialView("Error");
        }
    }
}