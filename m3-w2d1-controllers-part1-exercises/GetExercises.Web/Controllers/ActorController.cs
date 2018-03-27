using GetExercises.Web.DAL.Interfaces;
using GetExercises.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;

namespace GetExercises.Web.Controllers
{
    public class ActorController : Controller
    {
        private IActorDAL dal;

        /// <summary>
        /// The MVC framework with the assistance of Ninject, automatically passes in a ActorDAL.
        /// </summary>
        /// <param name="dal"></param>
        public ActorController(IActorDAL dal)
        {
            this.dal = dal;
        }
        
        /// <summary>
        /// The request to display an empty search page.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View("Index");
        }

        /// <summary>
        /// The request to display search results.
        /// </summary>
        /// <param name="request">A request model that contains the search parameters.</param>
        /// <returns></returns>
        
        public ActionResult SearchResult()
        {
      List<Actor> model = new List<Actor>();
      var query = HttpContext.Request.QueryString;
      var qs = query.GetValues("LastName");

      var actor = dal.FindActors(qs[0]);
            
            /* Call the DAL and pass the values as a model back to the View */
            return View("SearchResult", actor);
        }

    


  }
}