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

namespace ymdb.Panels
{
    public partial class UserPanel : Form
    {
        public static string conString = Properties.Settings.Default.SqlConnection;
        SqlConnection sqlConnect = new SqlConnection(conString);
        int countrows;
        public UserPanel()
        {
            InitializeComponent();
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            loginlbl.Text = Properties.Settings.Default.Login;

            sqlConnect.Open();
            SqlCommand getuserid = new SqlCommand();
            getuserid.CommandType = CommandType.StoredProcedure;
            getuserid.CommandText = "getuserid";
            getuserid.Parameters.AddWithValue("username", loginlbl.Text);
            getuserid.Connection = sqlConnect;
            try
            {
                object results = getuserid.ExecuteScalar();

                if (results != null)
                {
                    useridlbl.Text = results.ToString();
                }
                else
                {
                    useridlbl.Text = "0";
                }
            }
            catch (SqlException ex)
            {
                useridlbl.Text = "Error" + ex.Message;
            }
            finally
            {
                sqlConnect.Close();
            }

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

        private void button_WOC2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(yourgradelbl.Text))
            {
                int title = Convert.ToInt32(titleidlbl.Text);
                int author = Convert.ToInt32(useridlbl.Text);
                int score = Convert.ToInt32(scoreTb.Text);

                sqlConnect.Open();
                SqlCommand addreview = new SqlCommand();
                addreview.CommandType = CommandType.StoredProcedure;
                addreview.CommandText = "addreview";
                addreview.Parameters.AddWithValue("@title", title);
                addreview.Parameters.AddWithValue("@text", textreview.Text);
                addreview.Parameters.AddWithValue("@author", author);
                addreview.Parameters.AddWithValue("@score", score);
                addreview.Connection = sqlConnect;
                addreview.ExecuteNonQuery();
                sqlConnect.Close();

                //scoreTb.Text =null;
                MessageBox.Show("Отзыв успешно опубликован!",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Вы уже публиковали отзыв на это произведение!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoryid = ((gunaComboBox1.SelectedIndex) + 1).ToString();
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

        private void gunaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            //string genreid = ((gunaComboBox2.SelectedIndex) + 1).ToString();
            //genrelbl.Text = genreid;

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



        private void ChooseBtn_Click(object sender, EventArgs e)
        {
            if (TitleDGW.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedrow = TitleDGW.SelectedRows[0];

                string titleid = selectedrow.Cells[0].Value.ToString();
                string titlename = selectedrow.Cells[1].Value.ToString();

                titleidlbl.Text = titleid;
                titlelbl.Text = titlename;

                sqlConnect.Open();
                SqlCommand getReviewlist = new SqlCommand();
                getReviewlist.CommandType = CommandType.StoredProcedure;
                getReviewlist.CommandText = "getreviewList";
                getReviewlist.Parameters.AddWithValue("@title", Convert.ToInt32(titleidlbl.Text));
                getReviewlist.Connection = sqlConnect;
                SqlDataAdapter adapterr = new SqlDataAdapter(getReviewlist);
                DataSet dataSett = new DataSet();
                adapterr.Fill(dataSett);
                sqlConnect.Close();

                ReviewDGW.DataSource = dataSett.Tables[0];
                countrows = dataSett.Tables[0].Rows.Count;
                reviewlbl.Text = countrows.ToString();

                sqlConnect.Open();
                SqlCommand getCommentList = new SqlCommand();
                getCommentList.CommandType = CommandType.StoredProcedure;
                getCommentList.CommandText = "getCommentList";
                getCommentList.Parameters.AddWithValue("@title", Convert.ToInt32(titleidlbl.Text));
                getCommentList.Connection = sqlConnect;
                SqlDataAdapter adapterrr = new SqlDataAdapter(getCommentList);
                DataSet dataSettt = new DataSet();
                adapterrr.Fill(dataSettt);
                sqlConnect.Close();

                commentDGW.DataSource = dataSettt.Tables[0];
                countrows = dataSettt.Tables[0].Rows.Count;
                commentlbl.Text = countrows.ToString();

                sqlConnect.Open();
                SqlCommand gettitlegrade = new SqlCommand();
                gettitlegrade.CommandType = CommandType.StoredProcedure;
                gettitlegrade.CommandText = "gettitlegrade";
                gettitlegrade.Parameters.AddWithValue("@title", Convert.ToInt32(titleidlbl.Text));
                gettitlegrade.Connection = sqlConnect;
                try
                {
                    object result = gettitlegrade.ExecuteScalar();

                    if (result != null)
                    {
                        gradelbl.Text = result.ToString();
                    }
                    else
                    {
                        gradelbl.Text = "0";
                    }
                } catch (SqlException ex)
                {
                    gradelbl.Text = "Error"+ex.Message;
                }
                finally
                {
                    sqlConnect.Close();
                }

                sqlConnect.Open();
                SqlCommand getusergrade = new SqlCommand();
                getusergrade.CommandType = CommandType.StoredProcedure;
                getusergrade.CommandText = "getusergrade";
                getusergrade.Parameters.AddWithValue("@author", Convert.ToInt32(useridlbl.Text));
                getusergrade.Parameters.AddWithValue("@title", Convert.ToInt32(titleidlbl.Text));
                getusergrade.Connection = sqlConnect;
                try
                {
                    object resultt = getusergrade.ExecuteScalar();
                    
                    if (resultt != null)
                    {
                        yourgradelbl.Text = resultt.ToString();
                        scoreTb.Visible = false;
                    }
                    else
                    {
                        yourgradelbl.Visible = false;
                        yourgradelbl.Text = null;
                        scoreTb.Visible = true;
                    }
                }
                catch(SqlException ex)
                {
                    gradelbl.Text = "error"+ex.Message;
                }
                finally 
                { 
                    sqlConnect.Close(); 
                }
                return;



            }
            else
            {
                MessageBox.Show("Выберите произведение из списка!",
                   "Ошибка",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void choosecomment_Click(object sender, EventArgs e)
        {
            if (ReviewDGW.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedroww = ReviewDGW.SelectedRows[0];
                int reviewid = Convert.ToInt32(selectedroww.Cells[0].Value);
                reviewidlbl.Text = Convert.ToString(reviewid);
            }
            else
            {
                MessageBox.Show("Выберите отзыв на который хотите ответить из списка из списка!",
                   "Ошибка",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void addCommentBtn_Click(object sender, EventArgs e)
        {
            if (reviewidlbl.Text != "")
            {
                sqlConnect.Open();
                SqlCommand addcomment = new SqlCommand();
                addcomment.CommandType = CommandType.StoredProcedure;
                addcomment.CommandText = "addcomment";
                addcomment.Parameters.AddWithValue("@review_id",Convert.ToInt32(reviewidlbl.Text));
                addcomment.Parameters.AddWithValue("@text", commentRTB.Text);
                addcomment.Parameters.AddWithValue("@author", Convert.ToInt32(useridlbl.Text));
                addcomment.Connection = sqlConnect; 
                addcomment.ExecuteNonQuery();
                sqlConnect.Close();

                MessageBox.Show("Ваш комментарий успешно опубликован!",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Выберите отзыв на который хотите ответить из списка из списка!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            this.Close();
            LolginForm lf = new LolginForm();
            lf.Show();    
        }
    }
}
