using MySql.Data.MySqlClient;

namespace License_Key_Generator.Data;

public class DbContext
{
    public static MySqlConnection Get()
    {
        return new MySqlConnection("Server=us-cdbr-east-05.cleardb.net; Port=3306; Database=heroku_08439d662fd2e97; Uid=b308d35a8acafe; Pwd=311e3b45;");
    }
}