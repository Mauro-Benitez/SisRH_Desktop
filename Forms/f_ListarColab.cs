using SisRH_Desktop.Controller;
using SisRH_Desktop.Enum;
using SisRH_Desktop.Forms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SisRH_Desktop
{
    public partial class f_ListarColab : Form
    {

        private Form FormAtivo;
        int registroColaborador = 1;

        public f_ListarColab()
        {
            InitializeComponent();
            formatacaoListView();
            CarregarTodosFuncionarios();
            
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

        private void formatacaoListView()
        {

            lvFuncionario.Columns.Add(" # ", 50);
            lvFuncionario.Columns.Add("Nome", 110);
            lvFuncionario.Columns.Add("Email", 100);
            lvFuncionario.Columns.Add("Cargo", 100);
            lvFuncionario.Columns.Add("Nivel", 80);
            lvFuncionario.Columns.Add("Ativo", 50);

            //lvFuncionario.View = System.Windows.Forms.View.Details;
            //lvFuncionario.GridLines = true;

        }

        private void CarregarTodosFuncionarios()
        {
            FuncionarioModel funcEntrada = new FuncionarioModel();

            try
            {

                ControllerFuncionario contFuncionario = new ControllerFuncionario();
                var listaFuncionario = contFuncionario.ListarTodos(funcEntrada);
                lvFuncionario.Items.Clear();
                foreach (FuncionarioModel resultado in listaFuncionario)
                {

                    lvFuncionario.Items.Add(new ListViewItem(new string[]
                    {   resultado.registro.ToString(),
                        resultado.nome,
                        resultado.email,
                        resultado.cargo,
                        resultado.nivel_acesso.ToString(),
                        resultado.ativo.ToString()

                    }));
                   
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }

        }


        public void FuncionarioCheckEditar()
        {

            FuncionarioModel funsaida;
            int registro;

            
            foreach (ListViewItem item in lvFuncionario.Items)
            {
                string[] partes = item.Text.Split(',');
                if (item.Checked)
                {
                    if(partes.Length > 0 )
                    {

                        if (int.TryParse(partes[0].Trim(), out registro))
                        {
                            FormShow(new f_AtualizarColaborador(registro));
                        }

                        else
                        {
                            MessageBox.Show("Não foi possível converter o número de registro");

                        }

                    }
                    
                   
                }

                
                
                    //MessageBox.Show("Selecione um funcionário para atulizar", "Aviso", MessageBoxButtons.OK,
                    //               MessageBoxIcon.Warning);

                

            }
           
               
            




        }

        public void FuncionarioCheckEmitirHolerite()
        {

            FuncionarioModel funsaida;
            int registro;


            foreach (ListViewItem item in lvFuncionario.Items)
            {
                string[] partes = item.Text.Split(',');
                if (item.Checked)
                {
                    if (partes.Length > 0)
                    {

                        if (int.TryParse(partes[0].Trim(), out registro))
                        {
                            FormShow(new f_EmitirHolerite(registro));
                        }

                        else
                        {
                            MessageBox.Show("Não foi possível converter o número de registro");

                        }

                    }


                }

                //else
                //{

                //    MessageBox.Show("Selecione um funcionário para atulizar", "Aviso", MessageBoxButtons.OK,
                //                        MessageBoxIcon.Warning);

                //}

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
            FuncionarioCheckEmitirHolerite();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void lvFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {                             
    
        }
        private void buscarFuncionario()
        {

            if (txtNome.Text != string.Empty)
            {

                if (int.TryParse(txtNome.Text, out int registro))
                {
                    FuncionarioModel funcEntrada = new FuncionarioModel(registro);
                    
                    try
                    {

                        ControllerFuncionario contFuncionario = new ControllerFuncionario();
                        FuncionarioModel Funsaida = contFuncionario.BuscarPorRegistro(funcEntrada);
                        lvFuncionario.Items.Clear();
                        
                            lvFuncionario.Items.Add(new ListViewItem(new string[]
                            {   Funsaida.registro.ToString(),
                                Funsaida.nome,
                                Funsaida.email,
                                Funsaida.cargo,
                                Funsaida.nivel_acesso.ToString(),
                                Funsaida.ativo.ToString()

                            }));

                        

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);


                    }
                }
                else
                {
                    FuncionarioModel funcEntrada = new FuncionarioModel(txtNome.Text);

                    try
                    {

                        ControllerFuncionario contFuncionario = new ControllerFuncionario();
                        var listaFuncionario = contFuncionario.ListarPorNome(funcEntrada);
                        lvFuncionario.Items.Clear();
                        foreach (FuncionarioModel resultado in listaFuncionario)
                        {

                            lvFuncionario.Items.Add(new ListViewItem(new string[]
                            {   resultado.registro.ToString(),
                                resultado.nome,
                                resultado.email,
                                resultado.cargo,
                                resultado.nivel_acesso.ToString(),
                                resultado.ativo.ToString()

                            }));

                        };

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);


                    }
                }



            }

            else
            {
                MessageBox.Show("Nenhum dado inserido","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                CarregarTodosFuncionarios();

            }

           




        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            buscarFuncionario();

        }

        private void btnAtualizarDados_Click(object sender, EventArgs e)
        {

            FuncionarioCheckEditar();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarTodosFuncionarios();
        }

        private void lvFuncionario_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                foreach (ListViewItem item in lvFuncionario.Items)
                {
                    if (item != e.Item)
                    {
                        item.Checked = false;
                    }
                }
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                buscarFuncionario();

                e.Handled = true;
            }


        }
    }
}
