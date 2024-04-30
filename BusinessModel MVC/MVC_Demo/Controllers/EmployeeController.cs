using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBusinessLayer = new BusinessLayer.EmployeeBusinessLayer();
            List<Employee> employees = employeeBusinessLayer.GetAllEmployees();
            return View(employees);
        }
    }
}