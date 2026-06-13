using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class EnrollmentData
    {


        public static bool GetEnrollmentByStudentID(ref int EnrollmentID, string Status,int StudentID, ref int CourseID,ref float Grade,ref DateTime EnrollmentDate,
    ref float TotalFee)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataSettings.Stringconnection);

            string query = "select * from Enrollments where StudentsID=@StudentsID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@StudentsID", StudentID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    EnrollmentID = (int)reader["EnrollmentID"];
                    Status = (string)reader["Statuss"];
                    CourseID = (int)reader["Courses"];
                    Grade = Convert.ToSingle(reader["Grade"]);
                    EnrollmentDate = (DateTime)reader["EnrollmentDate"];
                    TotalFee = Convert.ToSingle(reader["TotalFee"]);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Handle exception if needed
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }



        public static bool GetEnrollmentByCourseID(ref int EnrollmentID, string Status,ref int StudentID,  int CourseID, ref float Grade, ref DateTime EnrollmentDate,
   ref float TotalFee)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataSettings.Stringconnection);

            string query = "select * from Enrollments where CoursesID=@CoursesID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CoursesID", CourseID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    EnrollmentID = (int)reader["EnrollmentID"];
                    Status = (string)reader["Statuss"];
                    StudentID = (int)reader["StudentsID"];
                    Grade = Convert.ToSingle(reader["Grade"]);
                    EnrollmentDate = (DateTime)reader["EnrollmentDate"];
                    TotalFee = Convert.ToSingle(reader["TotalFee"]);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Handle exception if needed
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }




     public static int InsertNewEnrollment(string Status,int StudentID,int courseID,float Grade,DateTime enromentDate,float totalfee)
        {
            int EromentID = -1;
            SqlConnection connection = new SqlConnection(DataSettings.Stringconnection);
            string query = @"insert into Enrollments (Statuss,StudentsID,CoursesID,Grade,EnrollmentDate,TotalFee) 
                                         values(@Statuss,@StudentsID,@CoursesID,@Grade,@EnrollmentDate,@TotalFee);select SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@Statuss", Status);
            cmd.Parameters.AddWithValue("@StudentsID", StudentID);
            cmd.Parameters.AddWithValue("@CoursesID", courseID);
            if (Grade != 0)
            {
                cmd.Parameters.AddWithValue("@Grade", Grade);
            }
            else
                cmd.Parameters.AddWithValue("@Grade", System.DBNull.Value);
            cmd.Parameters.AddWithValue("@EnrollmentDate", enromentDate);
            cmd.Parameters.AddWithValue("@TotalFee", totalfee);

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if(result!=null&&int.TryParse(result.ToString(),out int ID))
                {
                    EromentID = ID;
                }
            }catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return EromentID;
        }





    }


}
