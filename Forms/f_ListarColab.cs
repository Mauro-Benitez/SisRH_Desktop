using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisRH_Desktop
{
    public partial class f_ListarColab : Form
    {

        private Form FormAtivo;


        public f_ListarColab()
        {
            InitializeComponent();
        }

        private void FormShow(Form frm)
        {
            FecharFormAtivo();
            FormAtivo = frm;
            frm.TopLevel = false;
            panelBusca.Controls.Add(FormAtivo);
            frm.BringToFront();
            frm.Show();
        }



        private void FecharFormAtivo()
        {
            if (FormAtivo != null)
            {
                FormAtivo.Close();
            }
        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
           
            FormShow(new f_CadColaborador1());
            //btnNovo.Visible = false;
        }

        private void f_ListarColab_Load(object sender, EventArgs e)
        {

        }

        private void panelBusca_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEmitir_Click(object sender, EventArgs e)
        {
            FormShow(new f_EmitirHolerite());
        }
    }
}
