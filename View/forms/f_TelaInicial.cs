using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tela_Login_Sis_RH;

namespace SisRH_Desktop
{
    public partial class f_TelaInicial : Form
    {
        public f_TelaInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Redirect(this, new f_ListarColab());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
