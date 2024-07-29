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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public void SwitchMenu(bool active)
        {
            this.إستعادةنسخةإحتياطيةToolStripMenuItem.Enabled = active;
            this.نسخةاحتياطيةToolStripMenuItem.Enabled = active;
            this.تسجيلخروجToolStripMenuItem.Enabled = active;
            this.الأصنافToolStripMenuItem.Enabled = active;
            this.المبيعاتوالعملاءToolStripMenuItem.Enabled = active;
            this.المستخدمينToolStripMenuItem.Enabled = active;
        }

        private void نسخةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void عنالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin(this);
            formLogin.ShowDialog();
        }

        private void تسجيلخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("تاكيد تسجيل الخروج", "تسجيل خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.Yes) this.SwitchMenu(false);
                }
    }
}
