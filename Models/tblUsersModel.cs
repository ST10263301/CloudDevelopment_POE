using System.Data.SqlClient;

namespace CloudDevelopment.Models
{
    public class tblUsersModel
    {
        public static string con_string = "Server=tcp:keenia-server.database.windows.net,1433;Initial Catalog=st10263301-db;Persist Security Info=False;User ID=keenia;Password=Geemooi2005!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public static SqlConnection con = new SqlConnection(con_string);

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int insert_User(tblUsersModel m)
        {

            try
            {
                string sql = "INSERT INTO tblUsers (name, surname, email, password) VALUES (@Name, @Surname, @Email, @Password)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Name", m.Name);
                cmd.Parameters.AddWithValue("@Surname", m.Surname);
                cmd.Parameters.AddWithValue("@Email", m.Email);
                cmd.Parameters.AddWithValue("@Password", m.Password);
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
                return rowsAffected;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }


        }
    }
}
