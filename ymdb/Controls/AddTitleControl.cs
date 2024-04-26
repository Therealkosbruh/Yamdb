using Guna.UI.WinForms;
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
    public partial class AddTitleControl : UserControl
    {
        public static string conString = Properties.Settings.Default.SqlConnection;
        SqlConnection sqlConnect = new SqlConnection(conString);
        public AddTitleControl()
        {
            InitializeComponent();
        }

        private void AddCatBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddTitleBtn_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            SqlCommand addTitle = new SqlCommand();
            addTitle.CommandType = CommandType.StoredProcedure;
            addTitle.CommandText = "addTitle";
            addTitle.Parameters.AddWithValue("@name",nameTb.Text);
            addTitle.Parameters.AddWithValue("@year", YearTb.Text);
            addTitle.Parameters.AddWithValue("@category", CategoryIdLbl.Text);
            addTitle.Connection = sqlConnect;
            addTitle.ExecuteNonQuery();
            sqlConnect.Close();

           /* sqlConnect.Open();
            SqlCommand addGenreTitle = new SqlCommand();
            addGenreTitle.CommandType = CommandType.StoredProcedure;
            addGenreTitle.CommandText = "addGenreTitle";
            addGenreTitle.Parameters.AddWithValue("@TitleId", titleidLbl.Text);
            addGenreTitle.Parameters.AddWithValue("@GenreId", YearTb.Text);
            addGenreTitle.Connection = sqlConnect;
            addGenreTitle.ExecuteNonQuery();
            sqlConnect.Close() ;*/
        }

        private void AddTitleControl_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            SqlCommand loadtitleid = new SqlCommand();
            loadtitleid.CommandType = CommandType.StoredProcedure;
            loadtitleid.CommandText = "loadtitleid";
            loadtitleid.Connection = sqlConnect;
            object maxid = loadtitleid.ExecuteScalar();
            if (maxid != null)
            {
                titleidLbl.Text = maxid.ToString();
            }
            else
            {
                titleidLbl.Text = "Нет данных!";
            }
            sqlConnect.Close();

            sqlConnect.Open();
            SqlCommand getGenreList = new SqlCommand();
            getGenreList.CommandType = CommandType.StoredProcedure;
            getGenreList.CommandText = "getGenreList";
            getGenreList.Connection = sqlConnect;
            SqlDataReader genre = getGenreList.ExecuteReader();
            while (genre.Read())
            {
                genreCB.Items.Add(genre.GetString(0));
            }
            genreCB.SelectedIndex = 0;
            sqlConnect.Close();
        }

        private void CatCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoryid = ((CatCB.SelectedIndex) + 1).ToString();
            CategoryIdLbl.Text = categoryid;
        }

        private void genreCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string genreid = ((genreCB.SelectedIndex) + 1).ToString();
            GenreLbl.Text = genreid;
        }
    }
}
