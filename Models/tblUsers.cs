namespace CloudDevelopment.Models
{
    public class tblUsers
    {
        public static string con_string = "Server=tcp:keenia-server.database.windows.net,1433;Initial Catalog=keenia-db;Persist Security Info=False;User ID=keenia;Password= Geemooi2005!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30; ";

        public static SqlConnection con = new SqlConnection(con_string);



        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }
    }
}
