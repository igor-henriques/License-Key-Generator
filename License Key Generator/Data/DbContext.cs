using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace License_Key_Generator.Data
{
    public class DbContext
    {
        public async static Task<MySqlConnection> Get()
        {
            var conn = new MySqlConnection("Server=license.ironside.dev; Port=3306; Database=license; Uid=root; Pwd=95653549Hh*;SslMode=none");

            await conn.OpenAsync();

            return conn;
        }
    }
}
