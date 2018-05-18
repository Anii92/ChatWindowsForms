using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Logic.Models;

namespace DataAccess
{
    public class Database : IDatabase
    {
        private string Conexion;

        public Database()
        {
            this.Conexion = ConfigurationManager.ConnectionStrings["DabaseConnection"].ConnectionString;
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            using (SqlConnection connection = new SqlConnection(this.Conexion))
            {
                connection.Open();
                using (SqlCommand myCommand = new SqlCommand("select * from dbo.tbluser", connection))
                {
                    SqlDataReader myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        User user = new User();
                        user.Userid = Convert.ToInt32(myReader["userid"]);
                        user.Email = myReader["email"].ToString();
                        user.Mobile = myReader["mobile"].ToString();
                        user.Password = myReader["password"].ToString();
                        user.Dob = myReader["dob"].ToString();
                        users.Add(user);
                    }
                }
            }
            return users;
        }

        public List<string> GetAllUsersWithConversation()
        {
            List<string> users = new List<string>();
            using (SqlConnection connection = new SqlConnection(this.Conexion))
            {
                connection.Open();
                using (SqlCommand myCommand = new SqlCommand("select email from dbo.tbluser", connection))
                {
                    SqlDataReader myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        string email = myReader["email"].ToString();
                        users.Add(email);
                    }
                }
            }
            return users;
        }

        public User CheckUserAndPasswordForLogin(string userName, string password)
        {
            User user = new User();
            using (SqlConnection connection = new SqlConnection(this.Conexion))
            {
                connection.Open();
                using (SqlCommand myCommand = new SqlCommand("select * from tbluser where email = '" + userName + "' and password = '" + password + "'", connection))
                {
                    SqlDataReader myReader = myCommand.ExecuteReader();
                    if (myReader.Read())
                    {
                        user.Userid = Convert.ToInt32(myReader["userid"]);
                        user.Email = myReader["email"].ToString();
                        user.Mobile = myReader["mobile"].ToString();
                        user.Password = myReader["password"].ToString();
                        user.Dob = myReader["dob"].ToString();
                    }
                }
            }
            return user;
        }
    }
}
