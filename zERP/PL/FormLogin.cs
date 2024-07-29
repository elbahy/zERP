using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zERP.PL
{
    public partial class FormLogin : Form
    {

        FormMain formmain;
        public FormLogin(FormMain main)
        {
            InitializeComponent();
            formmain = main;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BL.BussinessLayer bl = new BL.BussinessLayer();
            DataTable dt = new DataTable();
            dt = bl.Login(userBox.Text, passBox.Text);
            if(dt.Rows.Count >0)
            {

                this.Close();
                this.formmain.SwitchMenu(true);
            }
            else
            {
                MessageBox.Show("Wrong Password");
            }
        }
    }
}
