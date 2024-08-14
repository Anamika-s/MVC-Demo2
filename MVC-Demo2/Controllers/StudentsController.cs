using Microsoft.AspNetCore.Mvc;
using MVC_Demo2.Models;

namespace MVC_Demo2.Controllers
{
    public class StudentsController : Controller
    {
        static List<Student> students = null;
        public StudentsController()
        {
            if (students == null)
            {
                students = new List<Student>()
                {
                    new Student() { Id = 1, Name = "Ajay", Batch = "B001" },

                    new Student() { Id = 2, Name = "Ajay", Batch = "B001" },

                    new Student() { Id = 3, Name = "Ajay", Batch = "B001" },

                    new Student() { Id = 4, Name = "Ajay", Batch = "B001" }
                };
            }
        }


        [HttpGet]
        public IActionResult Index()

        {
            return View(students);

        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Student temp = new Student();
            foreach(var student in students)
            {
                if(student.Id == id)
                {
                    temp = student;
                    break;

                }
            }
          
            return View(temp);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            students.Add(student);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Student temp = new Student();
            foreach (var student in students)
            {
                if (student.Id == id)
                {
                    temp = student;
                    break;

                }
            }

            return View(temp);
        }
        [HttpPost]
        public IActionResult Delete(int id, Student student)
        {
            
            foreach (var student1 in students)
            {
                if (student1.Id == id)
                {
                 students.Remove(student1);
                    break;

                }
            }

            return RedirectToAction("Index");
        }


        public IActionResult Edit(int id)
        {
            Student temp = new Student();
            foreach (var student in students)
            {
                if (student.Id == id)
                {
                    temp = student;
                    break;

                }
            }

            return View(temp);
        }
        [HttpPost]
        public IActionResult Edit(int id, Student student)
        {

            foreach (var student1 in students)
            {
                if (student1.Id == id)
                {
                   student1.Batch= student.Batch;
                    break;

                }
            }

            return RedirectToAction("Index");
        }
    }
}
