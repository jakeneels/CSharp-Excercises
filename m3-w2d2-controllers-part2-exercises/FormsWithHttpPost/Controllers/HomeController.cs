using FormsWithHttpPost.DAL;
using FormsWithHttpPost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormsWithHttpPost.Controllers
{
  public class HomeController : Controller
  {
    // GET: Home
    public ActionResult Index()
    {
      ReviewSqlDAL _dal = new ReviewSqlDAL();
      var model = _dal.GetAllReviews();

      return View("Index", model);
    }

    public ActionResult NewReview()
    {
      return View("NewReview");
    }

    [HttpPost]
    public ActionResult NewReview(Review model)
    {
      ReviewSqlDAL _dal = new ReviewSqlDAL();
      _dal.SaveReview(model);

      return RedirectToAction("Index");
    }
  }
}
