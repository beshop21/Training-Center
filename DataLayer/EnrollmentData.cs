using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class EnrollmentData
    {
        public static bool IsStudentHaveErollmentOnthisCourse(int studentID,int courseID)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataSettings.Stringconnection);

            string query = "select StudentsID from Enrollments where CoursesID=@CoursesID";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@StudentsID", studentID);
            command.Parameters.AddWithValue("@CoursesID", courseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isFound = reader.HasRows;

                reader.Close();
            }catch(Exception ex)

           
            {

            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

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



        public static bool GetEnrollmentByEnrollmentID( int EnrollmentID,ref string Status,ref int StudentID, ref int CourseID, ref float Grade, ref DateTime EnrollmentDate,
  ref float TotalFee)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataSettings.Stringconnection);

            string query = "select * from Enrollments where EnrollmentID=@EnrollmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@EnrollmentID", EnrollmentID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    StudentID = (int)reader["StudentsID"];
                    Status = (string)reader["Statuss"];
                    CourseID = (int)reader["CoursesID"];
                    if (reader["Grade"] != DBNull.Value)
                    {
                        Grade = Convert.ToSingle(reader["Grade"]);
                    }
                    else
                        Grade = 0;
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



        public static bool UpdateNewEnrollment(int id,string Status, int StudentID, int courseID, float Grade, DateTime enromentDate, float totalfee)
        {
            int RowEffect= -1;
            SqlConnection connection = new SqlConnection(DataSettings.Stringconnection);
            string query = @"update Enrollments set Statuss=Statuss,
                       StudentsID=StudentsID,
					    CoursesID=CoursesID,
						Grade=Grade,EnrollmentDate=EnrollmentDate,
						TotalFee=TotalFee where EnrollmentID=@EnrollmentID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@EnrollmentID", id);
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
                RowEffect = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return (RowEffect > 0);
        }



        public static bool DeleteEnrollment(int ID)
        {

            int RowEffect = -1;
            SqlConnection connection = new SqlConnection(DataSettings.Stringconnection);

            string query = "Delete from  Enrollments where EnrollmentID=@EnrollmentID ";
            SqlCommand command = new SqlCommand(query, connection);

            try {

                connection.Open();
                RowEffect = command.ExecuteNonQuery();



                 }catch(Exception ex)
            {

            }
            return (RowEffect > 0);
        }


        public static DataTable GetAllRecode()
        {
            DataTable tb = new DataTable();

            SqlConnection connection = new SqlConnection(DataSettings.Stringconnection);

            string query = "select * from Enrollments";
            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    tb.Load(reader);
                }
                reader.Close();
            }catch(Exception ex)
            {
                
            }

            finally { connection.Close();
            }
            return tb;
        }
    }


}
