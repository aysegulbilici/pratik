using pratik.Models;
using Microsoft.AspNetCore.Mvc;


namespace pratik.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            //kurs nesnesi tanımladık
            var kurs = new Course();

            kurs.Id = 1;
            kurs.Title = "Aspnet core kursu";
            kurs.Description = "Güzel bir kurs";
            kurs.Image = "kedi.jpeg";
            //kurs objesini model olarak viewa gönderdik
            return View(kurs);
        }

        public IActionResult List()
        {
            //listenin tipi Course olan liste oluşturduk.
            var kurslar = new List<Course>()
            {
                //Listeye elemanlar ekledik.
                new Course(){Id=1, Title="aspnet kursu", Description="güzelbir kurs", Image="kedi.jpeg"},
                new Course(){Id=2, Title="php kursu", Description="güzelbir kurs",Image="kopek.jpeg"},
                new Course(){Id=3, Title="django kursu", Description="güzelbir kurs",Image="panda.jpeg"}
            };
            return View("CourseList", kurslar);
        }
    }
}
