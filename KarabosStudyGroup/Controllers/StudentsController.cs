using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KarabosStudyGroup.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult StudyView()
        {
            List<Models.Study> people = new List<Models.Study>();

            people.Add(new Models.Study { FirstName = "Ndalo", LastName = "Kaphwiyo", Email = "u24651797@tuks.co.za", StudentNumber= "u24651797" });
            people.Add(new Models.Study { FirstName = "Karabo",LastName = "Kaula",    Email = "u22715895@tuks.co.za", StudentNumber = "u22715895" });
            people.Add(new Models.Study { FirstName = "Moeletsi",LastName = "Shabangu", Email = "u24698505@tuks.co.za", StudentNumber = "u24698505" });
            people.Add(new Models.Study { FirstName = "Thato", LastName = "Ngobese", Email = "u23073530@tuks.co.za", StudentNumber = "u23073530" });
            people.Add(new Models.Study { FirstName = "Dumo", LastName = "Manzini", Email = "u24742661@tuks.co.za", StudentNumber = "u24742661" });

            return View(people);


       
        }
    }
}