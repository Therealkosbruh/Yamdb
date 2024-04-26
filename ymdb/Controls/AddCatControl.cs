using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ymdb.Controls
{
    public partial class AddCatControl : UserControl
    {
        public static string conString = Properties.Settings.Default.SqlConnection;
        SqlConnection sqlConnect = new SqlConnection(conString);
        public AddCatControl()
        {
            InitializeComponent();
        }

        private void AddCatBtn_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            SqlCommand addCategory = new SqlCommand();
            addCategory.CommandType = CommandType.StoredProcedure;
            addCategory.CommandText = "addCategory";
            addCategory.Parameters.AddWithValue("@name",catnameTb.Text);
            addCategory.Parameters.AddWithValue("@slug", catslugTb.Text);
            addCategory.Connection = sqlConnect;
            addCategory.ExecuteNonQuery();
            sqlConnect.Close();
        }
    }
}
