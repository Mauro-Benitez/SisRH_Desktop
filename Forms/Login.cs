using SisRH_Desktop;
using SisRH_Desktop.Controller;
using SisRH_Desktop.Model;
using SisRH_Desktop.Models.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela_Login_Sis_RH
{
    public partial class Login : Form
    {
        private Point dragStartPoint;
        private bool isDragging = false;

        private Form formAtivo;

        public Login()
        {
            InitializeComponent();
            CustomizeTextBoxAppearance();
            CostomizeButtonAppearence(btnAcessar);
           
        }
       

        private void FormShow(Form frm)
        {
            FecharFormAtivo();
            formAtivo = frm;
            frm.TopLevel = false;
            Card_login.Controls.Add(formAtivo);
            frm.BringToFront();
            frm.Show(); 
        }


        private void FecharFormAtivo()
        {
            if(formAtivo != null)
            {
                formAtivo.Close();
            }
           
        }







        private void CostomizeButtonAppearence(Button button)
        {
            int borderRadius = 8;

            button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button.Width + 1, button.Height + 1, borderRadius, borderRadius));
            button.FlatStyle = FlatStyle.Flat;
            //button.BackColor= Color.White;
            button.FlatAppearance.MouseDownBackColor = button.BackColor;

            button.FlatAppearance.BorderSize = 0;


            Rectangle bounds = new Rectangle(0, 0, btnAcessar.Width, btnAcessar.Height);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            path.AddArc(bounds.X, bounds.Y, borderRadius, borderRadius, 180, 90);
            path.AddArc(bounds.Right - borderRadius, bounds.Y, borderRadius, borderRadius, 270, 90);
            path.AddArc(bounds.Right - borderRadius, bounds.Bottom - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - borderRadius, borderRadius, borderRadius, 90, 90);
            button.Region = new Region(path);

            //  button1.BackColor = Color.White;

        }

      




        //ajuste da aparencia 
        private void CustomizeTextBoxAppearance()
        {
            Card_login.BorderStyle = BorderStyle.None;           
            Card_login.Padding = new Padding(5);
            Card_login.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Card_login.Width, Card_login.Height, 15, 15));


            panel1.BorderStyle = BorderStyle.None;
            panel1.BackColor= Color.White;
            panel1.Padding = new Padding(5);
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 15, 15));

            // Ajustar aparência da TextBox
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.BackColor = Color.White;


            panel2.BorderStyle = BorderStyle.None;
            panel2.BackColor = Color.White;
            panel2.Padding = new Padding(5);
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 15, 15));

            // Ajustar aparência da TextBox
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.BackColor = Color.White;

            


        }

        //Função auxiliar para criar um retângulo arredondado
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int cx, int cy);

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel3_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                dragStartPoint = new Point(e.X, e.Y);
            }
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point endPoint = PointToScreen(new Point(e.X, e.Y));
                Location = new Point(endPoint.X - dragStartPoint.X, endPoint.Y - dragStartPoint.Y);
            }
        }
        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }


        //private void panel3_Paint_1(object sender, PaintEventArgs e)
        //{
        //    panel3.MouseDown += panel3_MouseDown_1;
        //    panel3.MouseMove += panel3_MouseMove;
        //    panel3.MouseUp += panel3_MouseUp;

        //}

        //verificação de login
  

        //link esqueci_senha
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormShow(new Form_Esqueci_Senha());
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;


            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {

                MessageBox.Show("Por favor, preencha todos os campos de login",
                                        "Aviso",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);


            }


            else
            {
                FuncionarioModel funEntrada = new FuncionarioModel(email, senha);
                ControllerFuncionario conFuncionario = new ControllerFuncionario();

                bool Acessar = conFuncionario.login(funEntrada);

                if (Acessar)
                {
                    f_TelaInicial telaInicial = new f_TelaInicial(email, senha);
                    telaInicial.Show();
                    this.Hide();

                }

                else
                {
                    MessageBox.Show("Login ou senha incorretas",
                                        "Erro",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                }

            }





            


        }
    }
}
