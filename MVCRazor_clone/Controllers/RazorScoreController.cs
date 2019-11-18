using MVCRazor_clone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRazor_clone.Controllers
{
    public class RazorScoreController : Controller
    {

        //學生考試成績model資料
        protected List<Student> students = new List<Student>
        {
            new Student { Id =1, Name="Joe", Chinese=88, English=95, Math=71 },
            new Student { Id =12, Name="Mary", Chinese=92, English=82, Math=60 },
            new Student { Id =23, Name="Cathy", Chinese=98, English=91, Math=94 },
            new Student { Id =34, Name="John", Chinese=63, English=85, Math=55 },
            new Student { Id =45, Name="David", Chinese=59, English=77, Math=82 }
        };

        public ActionResult Scores()
        {
            return View(students);
        }

        public ActionResult ScoreRazor()
        {
            int topId = 0;
            int topScore = 0;

            foreach(var student in students)
            {
                student.Total = student.Chinese + student.English + student.Math;
                if (student.Total > topScore)
                    topScore = student.Total;
                topId = student.Id;
            }
            ViewBag.TopId = Convert.ToInt32(topId);
            return View(students);
        }
        // GET: RazorScore
        public ActionResult Index()
        {
            return View();
        }
    }
}