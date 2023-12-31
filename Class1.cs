using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace db_lab_movies
{
    internal class DbConnection
    {
        public SqlConnection cnn { get; set; }
        public DbConnection()
        {
            try
            {
                cnn = new SqlConnection("Data Source = .\\SQLEXPRESS; Initial Catalog = movies; Integrated Security = True");
                cnn.Open();
            } catch ( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Disconnect()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }
    }
}
