using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace Vendor.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
       
        public IActionResult log()
        {
            var connectionstring = "Server=192.168.0.19;Database=edeskSama;Trusted_Connection=false;User Id=sa;Password=13490303";
            DataTable dt = new DataTable();
            SqlConnection myConnection = new SqlConnection(connectionstring);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand("select * from Users", myConnection);
            myConnection.Open();
            adapter.Fill(dt);
            myConnection.Close();
            return View();
        }
    }
}
