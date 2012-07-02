﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.WindowsAzure.Manager.Models;

namespace MongoDB.WindowsAzure.Manager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index( )
        {         
            return View( ReplicaSetStatus.GetReplicaSetStatus( ) );
        }

        public ActionResult About( )
        {
            ViewBag.Message = "Your app description page.";

            return View( );
        }

        public ActionResult Contact( )
        {
            ViewBag.Message = "Your contact page.";

            return View( );
        }
    }
}
