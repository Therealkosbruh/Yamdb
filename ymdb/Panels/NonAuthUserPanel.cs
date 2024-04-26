using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ymdb.Forms;

namespace ymdb.Panels
{
    public partial class NonAuthUserPanel : Form
    {
        public static string conString = Properties.Settings.Default.SqlConnection;
        SqlConnection sqlConnect = new SqlConnection(conString);
        int countrows;
        public NonAuthUserPanel()
        {
            InitializeComponent();
        }

        private void NonAuthUserPanel_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            SqlCommand gettitleList = new SqlCommand();
            gettitleList.CommandType = CommandType.StoredProcedure;
            gettitleList.CommandText = "GetTitleList";
            gettitleList.Connection = sqlConnect;
            SqlDataAdapter adapter = new SqlDataAdapter(gettitleList);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            sqlConnect.Close();

            TitleDGW.DataSource = dataSet.Tables[0];
            countrows = dataSet.Tables[0].Rows.Count;
            TitleListLbl.Text = countrows.ToString();

            sqlConnect.Open();
            SqlCommand getGenreList = new SqlCommand();
            getGenreList.CommandType = CommandType.StoredProcedure;
            getGenreList.CommandText = "getGenreList";
            getGenreList.Connection = sqlConnect;
            SqlDataReader genre = getGenreList.ExecuteReader();
            while (genre.Read())
            {
                gunaComboBox2.Items.Add(genre.GetString(0));
            }
            gunaComboBox2.SelectedIndex = 0;
            sqlConnect.Close();
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoryid =  ((gunaComboBox1.SelectedIndex)+1).ToString();  
            CategoryIdLbl.Text = categoryid;

            sqlConnect.Open();
            SqlCommand categoryfilter = new SqlCommand();
            categoryfilter.CommandType = CommandType.StoredProcedure;
            categoryfilter.CommandText = "categoryfilter";
            categoryfilter.Parameters.AddWithValue("category", categoryid);
            categoryfilter.Connection = sqlConnect;
            SqlDataAdapter adapter = new SqlDataAdapter(categoryfilter);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            sqlConnect.Close();

            TitleDGW.DataSource = dataSet.Tables[0];
            countrows = dataSet.Tables[0].Rows.Count;
            TitleListLbl.Text = countrows.ToString();
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TitleId = titleidlbl.Text;
            Properties.Settings.Default.Save();
            ReviewsForm rf = new ReviewsForm();
            rf.Show();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Оставлять отзывы могут только авторизованные пользователи!",
                       "Ошибка",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
        }

        private void ChooseBtn_Click(object sender, EventArgs e)
        {
            if(TitleDGW.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedrow = TitleDGW.SelectedRows[0];

                string titleid = selectedrow.Cells[0].Value.ToString();
                string titlename = selectedrow.Cells[1].Value.ToString();

                titleidlbl.Text = titleid;
                titlelbl.Text = titlename;
            }
            else
            {
                MessageBox.Show("Выберите произведение из списка!",
                   "Ошибка",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }

        }

        private void gunaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string genreid = ((gunaComboBox2.SelectedIndex) + 1).ToString();
            genrelbl.Text = genreid;

            /*sqlConnect.Open();
            SqlCommand sortbygenre = new SqlCommand();
            sortbygenre.CommandType = CommandType.StoredProcedure;
            sortbygenre.CommandText = "sortbygenre";
            sortbygenre.Parameters.AddWithValue("@genre_id",genrelbl.Text);
            sortbygenre.Connection = sqlConnect;
            SqlDataAdapter adapterr = new SqlDataAdapter(sortbygenre);
            DataSet dataSett = new DataSet();
            adapterr.Fill(dataSett);
            sqlConnect.Close();

            TitleDGW.DataSource = dataSett.Tables[0];
            countrows = dataSett.Tables[0].Rows.Count;
            TitleListLbl.Text = countrows.ToString();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC1_Click_1(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Оставлять комментарии могут только авторизованные пользователи!",
                       "Ошибка",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
        }

        private void button_WOC2_Click_1(object sender, EventArgs e)
        {
                MessageBox.Show("Отзывы могут оставлять только авторизованные пользователи!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

        }
    }

