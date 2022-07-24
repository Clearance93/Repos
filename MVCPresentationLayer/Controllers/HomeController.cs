using ModelLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MVCPresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IEnumerable<Employee> employees = GetEmployee();
            return View(employees);
        }

        public ActionResult Get(int id)
        {
            Employee employee = GetEmmployeeByID(id);
            List<Employee> employees = new List<Employee>();
            employees.Add(employee);
            return View("Index", employee);
        }

        Employee GetEmmployeeByID(int id)
        {
            Employee employee = null;
            using (HttpClient client = new HttpClient())
            {
                string url = "http://localhost:1993/api/employee?id=" + id;
                Task<HttpResponseMessage> result = client.GetAsync(url);
                if (result.Result.IsSuccessStatusCode)
                {
                    Task<string> serializedResult = result.Result.Content.ReadAsStringAsync();
                    employee = Newtonsoft.Json.JsonConvert.DeserializeObject<Employee>(serializedResult.Result);
                }
            }
            return employee;
        }

        IEnumerable<Employee> GetEmployee()
        {
            IEnumerable<Employee> employees = null;
            using (HttpClient client = new HttpClient())
            {
                string url = "http://localhost:1993/api/employee";
                Uri uri = new Uri(url);
                System.Threading.Tasks.Task<HttpResponseMessage> result = client.GetAsync(uri);
                if (result.Result.IsSuccessStatusCode)
                {
                    System.Threading.Tasks.Task<string> response = result.Result.Content.ReadAsStringAsync();
                    employees = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Employee>>(response.Result);
                }
            }
            return employees;
        }
    }
}