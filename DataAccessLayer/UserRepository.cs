using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UserRepository
    {
        public List<User> GetUsers()
        {
            List<User> list = new List<User>();


            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Users";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    User user = new User();
                    user.userid = sqlDataReader.GetInt32(0);
                    user.name = sqlDataReader.GetString(1);
                    user.surname = sqlDataReader.GetString(2);
                    user.username = sqlDataReader.GetString(3);
                    user.pass = sqlDataReader.GetString(4);
                    user.birth = sqlDataReader.GetDateTime(5);
                    user.phone = sqlDataReader.GetString(6);
                    user.mail = sqlDataReader.GetString(7);
                    user.address = sqlDataReader.GetString(8);
                    list.Add(user);
                }
            }
            return list;

        }



        public int InsertUser(User user)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Users VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", user.name, user.surname, user.username, user.pass, user.birth, user.phone, user.mail, user.address);

                int result = sqlCommand.ExecuteNonQuery();
                return result;

            }

        }
    }
}