using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ymdb.Forms
{
    public partial class ReviewsForm : Form
    {
        public ReviewsForm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Оставлять комментарии могут только авторизованные пользователи!",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
        }

        private void ReviewsForm_Load(object sender, EventArgs e)
        {
            TitleIdLbl.Text = Properties.Settings.Default.TitleId;
        }
    }
}
