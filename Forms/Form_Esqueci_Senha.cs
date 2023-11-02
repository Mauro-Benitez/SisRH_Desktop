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
using Button = System.Windows.Forms.Button;

namespace Tela_Login_Sis_RH
{
    public partial class Form_Esqueci_Senha : Form
    {
        public Form_Esqueci_Senha()
        {
            InitializeComponent();
            CustomizeTextBoxAppearance();
            CostomizeButtonAppearence(btn_Enviar);
        }
        private Form formAtivo;

        private void FormShow(Form frm)
        {
            FecharFormAtivo();
            formAtivo = frm;
            frm.TopLevel = false;           
            frm.BringToFront();
            frm.Show();
        }
        private void FecharFormAtivo()
        {
            if (formAtivo != null)
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


            Rectangle bounds = new Rectangle(0, 0, button.Width, button.Height);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            path.AddArc(bounds.X, bounds.Y, borderRadius, borderRadius, 180, 90);
            path.AddArc(bounds.Right - borderRadius, bounds.Y, borderRadius, borderRadius, 270, 90);
            path.AddArc(bounds.Right - borderRadius, bounds.Bottom - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - borderRadius, borderRadius, borderRadius, 90, 90);
            button.Region = new Region(path);

            //  button1.BackColor = Color.White;

        }

        private void CustomizeTextBoxAppearance()
        {
            panel_EsqueciSenha.BorderStyle = BorderStyle.None;
            panel_EsqueciSenha.BackColor = Color.White;
            panel_EsqueciSenha.Padding = new Padding(5);
            panel_EsqueciSenha.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel_EsqueciSenha.Width, panel_EsqueciSenha.Height, 15, 15));

            // Ajustar aparência da TextBox
            txtBox_Email.BorderStyle = BorderStyle.None;
            txtBox_Email.BackColor = Color.White;
        }

        //Função auxiliar para criar um retângulo arredondado
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int cx, int cy);


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormShow(new Login());
        }

        private void Form_Esqueci_Senha_Load(object sender, EventArgs e)
        {

        }

       
    }
}
