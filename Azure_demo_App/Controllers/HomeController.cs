using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Azure_demo_App.Models;

namespace Azure_demo_App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<User> users = new List<User>();
            return View(users);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
                SqlCommand command = new SqlCommand();

                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = user.Name;

                command.Parameters.Add("@mobile", SqlDbType.NVarChar).Value = user.Mobile;

                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = user.Email;

                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = user.Address;

                command.CommandText = "INSERT INTO UserInfo (Name, Mobile, Email, Address) VALUES(@name, @mobile, @email, @address)";

                connection.Open();

                command.Connection = connection;                

                bool isInserted = command.ExecuteNonQuery() > 0;

                connection.Close();
            }
            return View();
        }
    }
}