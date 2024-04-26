using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ymdb.Panels
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            sidepan.Height = TitleBtn.Height;
            sidepan.Top = TitleBtn.Top;
            addTitleControl1.BringToFront();
        }

        private void TitleBtn_Click(object sender, EventArgs e)
        {
            sidepan.Height = TitleBtn.Height;
            sidepan.Top = TitleBtn.Top;
            addTitleControl1.BringToFront();

        }

        private void CatBtn_Click(object sender, EventArgs e)
        {
            sidepan.Height = CatBtn.Height;
            sidepan.Top = CatBtn.Top;
            addCatControl1.BringToFront();
        }

        private void GenreBtn_Click(object sender, EventArgs e)
        {
            sidepan.Height = GenreBtn.Height;
            sidepan.Top = GenreBtn.Top;
            addGenreControl1.BringToFront();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            this.Close();
            LolginForm lf = new LolginForm();
            lf.Show();
        }
    }
}
