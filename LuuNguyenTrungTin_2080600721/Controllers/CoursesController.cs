using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LuuNguyenTrungTin_2080600721.Models;
using LuuNguyenTrungTin_2080600721.ViewModels;
namespace LuuNguyenTrungTin_2080600721.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        // GET: Courses
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                
                Categories = _dbContext.Categiries.ToList()
            };
            return View(viewModel);
        }


    }
}