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
using ymdb.Includs;
using ymdb.Panels;

namespace ymdb
{
    public partial class LolginForm : Form
    {
        public static string conString = Properties.Settings.Default.SqlConnection;
        SqlConnection sqlConnect = new SqlConnection(conString);
        int counter;
        public LolginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            counter++;
            sqlConnect.Open();
            SqlCommand login = new SqlCommand();
            login.CommandType  = CommandType.StoredProcedure;
            login.CommandText = "Login";
            login.Parameters.AddWithValue("@username", LoginTb.Text);
            login.Parameters.AddWithValue("@Password", PasswordTb.Text);
            login.Connection = sqlConnect;

            using(SqlDataReader reader = login.ExecuteReader())
            {
                if (reader.Read()) 
                {
                    string loginusr = login.Parameters["@username"].Value.ToString();
                    reader.Close();
                    SqlCommand uservalid = new SqlCommand();
                    uservalid.CommandType = CommandType.StoredProcedure;
                    uservalid.CommandText = "UserValidation";
                    uservalid.Parameters.AddWithValue("@username",loginusr);
                    uservalid.Connection = sqlConnect;

                    using (SqlDataReader rolereader = uservalid.ExecuteReader())
                    {
                        if (rolereader.Read())
                        {
                            int roleid = Convert.ToInt32(rolereader["Role"]);
                            switch(roleid)
                            {
                                case 1:
                                    this.Hide();
                                    UserPanel up = new UserPanel();
                                    up.Show();
                                    break;
                                case 2:
                                    this.Hide();
                                    AdminPanel ap = new AdminPanel();
                                    ap.Show();
                                    break;
                                case 3:
                                    this.Hide();
                                    ManagerPanel mp = new ManagerPanel();
                                    mp.Show();
                                    break;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Пароль или логин не верны, повторите попытку",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                if (counter == 3) 
                {
                    Captcha captcha = new Captcha();
                    captcha.Show();
                }
            }
            sqlConnect.Close();
            
            Properties.Settings.Default.Login = LoginTb.Text;
            Properties.Settings.Default.Save();
        }

        private void GuestLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            NonAuthUserPanel nonAuthUserPanel = new NonAuthUserPanel();
            nonAuthUserPanel.Show();
        }
    }
}

