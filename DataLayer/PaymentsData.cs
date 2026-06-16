using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PaymentsData
    {

        public static int InsertNewPayment(string StudentName, string CourseName, DateTime PaymanetData, float AmountOFpaid, string PaymentMethod)
        {
            int PaymentID = -1;

            SqlConnection connection = new SqlConnection(DataSettings.Stringconnection);

            string query = @"(insert into Payments(StudentName,CourseName,PayMentDate,AmountPaid,PaymentMethod)
                                               values(@StudentName,@CourseName,@PayMentDate,@AmountPaid,@PaymentMethod));
                     SELECT SCOPE_IDENTITY();";

            SqlCommand comnd = new SqlCommand(query, connection);

            comnd.Parameters.AddWithValue("@StudentName", StudentName);
            comnd.Parameters.AddWithValue("@CourseName", CourseName);
            comnd.Parameters.AddWithValue("@@PayMentDate", PaymanetData);
            comnd.Parameters.AddWithValue("@AmountPaid", AmountOFpaid);
            comnd.Parameters.AddWithValue("@@PaymentMethod", PaymentMethod);

            try
            {
                connection.Open();

                object result = comnd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    PaymentID = ID;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return PaymentID;
        }

        public static bool UpdatePayments(int PaymentID, string studentID, string CourseName, DateTime PaymentDate, float AmountPaid,string PaymentMethod)
        {
            int Effectnumber = -1;

            SqlConnection connection = new SqlConnection(DataSettings.Stringconnection);

            string qeury = @"update Courses set 
                         StudentName=@StudentName,
                         CourseName=@CourseName,
                          PayMentDate=@PayMentDate,
                          AmountPaid=@AmountPaid,
                       PaymentMethod=@PaymentMethod where paymentID=@paymentID";
                                               

            SqlCommand comnd = new SqlCommand(qeury, connection);

            comnd.Parameters.AddWithValue("@paymentID", PaymentID);
            comnd.Parameters.AddWithValue("@StudentName", studentID);
            comnd.Parameters.AddWithValue("@CourseName", CourseName);
            comnd.Parameters.AddWithValue("@PayMentDate", PaymentDate);
            comnd.Parameters.AddWithValue("@AmountPaid", AmountPaid);

            comnd.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);

            try
            {
                connection.Open();

                Effectnumber = comnd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return (Effectnumber > 0);
        }


        public static bool DeleteCourse(int id)
        {
            int effectnumber = -1;
            SqlConnection connection = new SqlConnection(DataSettings.Stringconnection);

            string query = "delete from Courses where CourseID=@CourseID";
            SqlCommand commd = new SqlCommand(query, connection);
            commd.Parameters.AddWithValue("@CourseID", id);
            try
            {
                connection.Open();
                effectnumber = commd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return (effectnumber > 0);
        }


        public static bool GetCourseByID(int id, ref string Title, ref int Hourse,
    ref float Price, ref DateTime StartDate, ref bool IsActive)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(DataSettings.Stringconnection);

            string qeury = "select * from Courses where CourseID=@CourseID";

            SqlCommand commd = new SqlCommand(qeury, connection);

            commd.Parameters.AddWithValue("@CourseID", id);

            try
            {
                connection.Open();

                SqlDataReader reader = commd.ExecuteReader();

                if (reader.Read())
                {
                    isfound = true;
                    Title = (string)reader["Title"];
                    Hourse = (int)reader["Hourse"];
                    Price = Convert.ToSingle(reader["Price"]);
                    StartDate = (DateTime)reader["StartDate"];
                    IsActive = (bool)reader["IsActive"];
                }

                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return isfound;
        }

        public static bool GetCourseByName(ref int id, string Title, ref int Hourse,
  ref float Price, ref DateTime StartDate, ref bool IsActive)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(DataSettings.Stringconnection);

            string qeury = "select * from Courses where Title=@Title";

            SqlCommand commd = new SqlCommand(qeury, connection);

            commd.Parameters.AddWithValue("@Title", Title);

            try
            {
                connection.Open();

                SqlDataReader reader = commd.ExecuteReader();

                if (reader.Read())
                {
                    isfound = true;
                    id = (int)reader["CourseID"];
                    Hourse = (int)reader["Hourse"];
                    Price = Convert.ToSingle(reader["Price"]);
                    StartDate = (DateTime)reader["StartDate"];
                    IsActive = (bool)reader["IsActive"];
                }

                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return isfound;
        }

        public static DataTable GetAllRecode()
        {
            DataTable tb = new DataTable();
            SqlConnection connection = new SqlConnection(DataSettings.Stringconnection);
            string query = "select * from Courses";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    tb.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {

            }

            finally
            {
                connection.Close();
            }
            return tb;
        }


    }
}
