using Microsoft.AspNetCore.Mvc;
using MVC_Demo2.Models;

namespace MVC_Demo2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>()
            {
                 new Student(){ Id=1, Name="Ajay", Batch="B001"},

                 new Student(){ Id=2, Name="Ajay", Batch="B001"},

                 new Student(){ Id=3, Name="Ajay", Batch="B001"},

                 new Student(){ Id=4, Name="Ajay", Batch="B001"}
            };
            //ViewBag.Students = students;
            return View(students);
        }


        public IActionResult Details()
        {
            Student student = new Student()
            {
                Id = 2,
                Name = "Ajay Sood",
                Batch = "DotNet"
            };
            ViewBag.Student = student;
            return View();
        }

        public IActionResult Details1()
        {
            Student student = new Student()
            {
                Id = 2,
                Name = "Ajay Sood",
                Batch = "DotNet"
            };
            //ViewBag.Student = student;
            return View(student);
        }





    }
}
