using Microsoft.AspNetCore.Mvc;
using StudentInfoApp.Models;


namespace StudentInfoApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Details()
        {
            var student = new Student
            {
                Name = "John Doe",
                Age = 20,
                Course = "Computer Science"
            };
            return View(student);
        }
    }
}
