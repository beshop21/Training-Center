using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UsersData
    {

        public static int InsertNewUser( string Username, string Password, int Role)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(DataSettings.Stringconnection);

            string query = @"insert into Users (UserName,PasswordHash,Role_ID) values(@UserName,@PasswordHash,@Role_ID);
                     SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);

           
            cmd.Parameters.AddWithValue("@UserName", Username);
            cmd.Parameters.AddWithValue("@PasswordHash", Password);
            cmd.Parameters.AddWithValue("@Role_ID", Role);

            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int NewID))
                    ID = NewID;
            }
            catch (Exception)
            {
            }
            finally
            {
                connection.Close();
            }

            return ID;
        }



        public static bool UpdateUser(int UserID, string Username, string Password, int Role)
        {
            int EffectNumber = -1;

            SqlConnection connection = new SqlConnection(DataSettings.Stringconnection);

            string query = @"update Users set UserName=@UserName,
                                             PasswordHash=@PasswordHash,
                                             Role_ID=@Role_ID where UserID=@UserID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@UserName", Username);
            cmd.Parameters.AddWithValue("@@PasswordHash", Password);
            cmd.Parameters.AddWithValue("@Role_ID", Role);

            try
            {
                connection.Open();
                EffectNumber = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            finally
            {
                connection.Close();
            }

            return EffectNumber > 0;
        }


        public static DataTable GetAllUsers()
        {
            DataTable tb = new DataTable();

            SqlConnection connection = new SqlConnection(DataSettings.Stringconnection);
            string query = "select * from Users";
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
            }catch(Exception ex)
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
