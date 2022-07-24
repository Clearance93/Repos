using ModelLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web_task.Controllers
{
    public class EmployeeController : ApiController
    {
        List<Employee> employees;

        public EmployeeController()
        {
            employees = new List<Employee>();
            employees.Add(new Employee { ID = 1, Name = "Clearance", ContactNumber = 769606305, Address = "Boksburg 1459" });
            employees.Add(new Employee { ID = 2, Name = "Tebogo", ContactNumber = 618525640, Address = "Tembisa 1632" });
        }


        public IEnumerable<Employee> Get()
        {
            return employees;
        }

        public Employee Get (int id)
        {
            return employees.FirstOrDefault<Employee>(x => x.ID.Equals(id));
        }
    }
}