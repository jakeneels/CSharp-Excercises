using GetExercises.Web.DAL.Interfaces;
using GetExercises.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GetExercises.Web.DAL
{
    public class CustomerDAL : ICustomerDAL
    {
        private string connectionString;

        public CustomerDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<Customer> SearchForCustomers(string search, string sortBy)
        {
            IList<Customer> custs = new List<Customer>();

            string custSearchSql = @"select first_name, last_name, email from customer where first_name = @fName or last_name = @lName order by";
            string orderLastName = " last_name";
            string orderFirstName = " first_name";
            string orderActive = " active";

            if(sortBy == "last_name")
            {
                custSearchSql += orderLastName;
            }
            if (sortBy == "first_name")
            {
                custSearchSql += orderFirstName;
            }
            if (sortBy == "active")
            {
                custSearchSql += orderActive;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(custSearchSql, conn);
                cmd.Parameters.AddWithValue("@fName", search);
                cmd.Parameters.AddWithValue("@lName", search);


                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var cust = new Customer();
                    cust.FirstName = reader["first_name"].ToString();
                    cust.LastName = reader["last_name"].ToString();
                    cust.Email = reader["email"].ToString();

                    custs.Add(cust);
                }
            }

            return custs;
        }


    }
}