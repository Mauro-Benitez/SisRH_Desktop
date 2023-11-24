using SisRH_Desktop.Controller;
using SisRH_Desktop.Enum;
using SisRH_Desktop.Model;
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
    public partial class f_Taxas : Form
    {
        public f_Taxas()
        {
            InitializeComponent();
        }

        private void f_Taxas_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeTaxa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                ControllerFuncionario Controllerfuncionario = new ControllerFuncionario();              
                ControllerTaxa controllerTaxa = new ControllerTaxa();


               

                FuncionarioModel funcEntrada = new FuncionarioModel(6);

                FuncionarioModel funcionario = Controllerfuncionario.BuscarPorRegistro(funcEntrada);

                

                EnumTipo tipo = EnumTipo.Acresimo;
            

                TaxaModel taxa = new TaxaModel("taxa teste", 2.0, tipo, funcionario);
                controllerTaxa.adicionarTaxa(taxa, funcionario);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                MessageBox.Show("EXITO");
            }
          
        }
    }
}
