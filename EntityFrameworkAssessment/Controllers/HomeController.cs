using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityFrameworkAssessment.Models;

namespace EntityFrameworkAssessment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            NorthwindEntities NorthwindDB = new NorthwindEntities();

            List<Order_Detail> OrderIdentities = NorthwindDB.Order_Details.ToList();
            List<Customer> CustomerIdentities = NorthwindDB.Customers.ToList();
            List<Employee> EmployeeIdentities = NorthwindDB.Employees.ToList();

            ViewBag.OrdersID = OrderIdentities;
            ViewBag.CustomersTable = CustomerIdentities;
            ViewBag.EmployeesTable = EmployeeIdentities;

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult OrdersTable(int OrderID, string CustomerID, int EmployeeID)
        {
            NorthwindEntities NorthwindDB = new NorthwindEntities();

            return View("About");
        }
    }
}