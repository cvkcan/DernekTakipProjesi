using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace Dernek_Takip_Projesi.Data_Access_Layer.DbArea.DbModels
{
    static public class Database
    {
        //Static sınıf yaparak new'lemeyi önlemiş oldum.
        static private OleDbConnection Connection
        {
            //Set'leme olmayacağı için sadece get özelliğini kullandım.
            get
            {
                OleDbConnection connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["AccessConnection"].ToString());
                //Presentation Layer içerisinde bulunan app.config içerisindeki conncetionstringi belirttim.
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                return connection;
                //Bağlantı açık değilse açmasını sağlayıp kodu geri döndürdüm.
            }
        }

        static public OleDbCommand command(string query)
        {
            OleDbCommand _command = new OleDbCommand(query, Connection);
            return _command;
            //Command'a gelen sorguya bağlantıyı ekledim.
        }

        static public DataTable datatable(OleDbCommand command)
        {
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            return dt;
            //Gelen command'a göre Datatable türünde veri döndürmeyi sağladım.
        }
    }
}
