using Microsoft.AspNetCore.Mvc;
using MVCFirstApp.Models;

namespace MVCFirstApp.Controllers
{
    [Route("[controller]")]
    public class StudentController : Controller
    {
        [Route("Bharath")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("GetStudents")]
        public IActionResult GetStudent()
        {
            List<StudentModel> students = getStudents();
            return View();
        }
        [Route("SaveStudent")]
        public IActionResult Save(StudentModel input)
        {
            List<StudentModel> students = getStudents();
            string name = input.Name;
            int age = input.Age;
            students.Add(input);
            return View();
        }
        [Route("ShowStudents")]
        public IActionResult ShowStudent()
        {
            List<StudentModel> students = getStudents();
            return View(students);
        }
        private List<StudentModel> getStudents()
        {
            List<StudentModel> Students = new List<StudentModel>();
            var emp1 = new StudentModel();
            emp1.Id = 101;
            emp1.Name = "Bharath M";
            emp1.Age = 21;
            Students.Add(emp1);
            var emp2 = new StudentModel();
            emp2.Id = 102;
            emp2.Name = "Manoj";
            emp2.Age = 22;
            Students.Add(emp2);
            return Students;

        }
    }
}
