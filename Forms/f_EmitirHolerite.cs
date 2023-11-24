using SisRH_Desktop.Controller;
using SisRH_Desktop.Model;
using SisRH_Desktop.Models.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Globalization;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Security.Policy;

namespace SisRH_Desktop
{
    public partial class f_EmitirHolerite : Form
    {
        int registroFuncionario;
        private SqlConnection con;
        private SqlCommand cmd;

        private readonly string url = @"Data Source=DESKTOP-DNIRGUH\SQLEXPRESS;Initial Catalog=BD_Funcionario;"
        + "Integrated Security=true;";



        public f_EmitirHolerite(int registro)
        {
            InitializeComponent();
            formatacaoListView();
            CarregarDados(registro);
            registroFuncionario = registro;
        }

        void CarregarDados(int registro)
        {
           

            try
            {

                ControllerFuncionario contFuncionario = new ControllerFuncionario();
                FuncionarioModel FuncionarioRetorno = contFuncionario.CarregarTodosOsDados(registro);
                lvFuncionario.Items.Clear();
                //foreach (FuncionarioModel resultado in listaFuncionario)
                //{

                lvFuncionario.Items.Add(new ListViewItem(new string[]
                    {   FuncionarioRetorno.registro.ToString(),
                        FuncionarioRetorno.nome,
                        FuncionarioRetorno.email,
                        FuncionarioRetorno.cargo,
                        FuncionarioRetorno.nivel_acesso.ToString(),
                        FuncionarioRetorno.ativo.ToString()

                    }));

               // };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


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

            lvFuncionario.View = System.Windows.Forms.View.Details;
            lvFuncionario.GridLines = true;

        }


        private void f_EmitirHolerite_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lvFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEmitir_Click(object sender, EventArgs e)
        {
            try
            {
               
                ControllerFuncionario contFuncionario = new ControllerFuncionario();
                FuncionarioModel funSaida = contFuncionario.CarregarTodosOsDados(registroFuncionario);

                ControllerHolerite contHolerite = new ControllerHolerite();
                ControllerRelatorio controllerRelatorio = new ControllerRelatorio();
               
                //   TaxaModel taxaSaida = new TaxaModel();

                //TaxaModel taxaModel = controllerRelatorio.GerarHoleiteComTaxa(funSaida);
                HoleriteModel HoleriteGerado = contHolerite.GerarHolerite(funSaida);
                //TaxaModel taxaModel = null;

                //taxaModel = controllerRelatorio.GerarHoleiteComTaxa(funSaida);
               


                //criando um  pdf do holerite
                try
                {
                   
                    //caminho do arquivo
                    string caminho = @"C:\PDF_Holerites\" + @"holeriteNovembro_ID" + HoleriteGerado.Id_Holerite + ".pdf";
                    string imagem = @"C:\Users\Mauro\OneDrive - ciesglobal.org\Sis RH\Desktop - Git\Telas\SisRH_Desktop\Imagem\LogoComFundo.png";


                    //criando o arquivo
                    FileStream arquivoPDF = new FileStream(caminho, FileMode.Create);
                    Document doc = new Document(PageSize.A4);
                    PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);
                    doc.Open();

                    //titulo
                    Paragraph Titulo  = new Paragraph("Demonstrativo de Pagamento\n",new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL,20,(int)System.Drawing.FontStyle.Regular));
                    Titulo.Alignment = Element.ALIGN_CENTER;


                    //inserindo a logo 
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(imagem);
                    logo.ScaleToFit(110f, 90f);
                    logo.SetAbsolutePosition(90, 726f);
                    doc.Add(logo);



                   //criando e inserindo os dados na tabela

                    PdfPTable tabela = new PdfPTable(5);
                    tabela.DefaultCell.FixedHeight = 200;

                    PdfPCell celulaCabecalho = new PdfPCell(new Phrase($"                                   {HoleriteGerado.NomeEmpresa} \n                                  Av. Paulista \n                                  Bela Vista        Sao Paulo \n                                  CNPJ:99.058.522/0001-01       Mes referencia: {(int)HoleriteGerado.Mes_referencia}/2023"));
                    celulaCabecalho.Colspan = 5;


                    PdfPCell celulaDados1 = new PdfPCell(new Phrase($"Registro      Data de admissão \n 000{HoleriteGerado.Funcionario.registro}            {HoleriteGerado.Funcionario.data_contratacao.ToString("dd/MM/yyyy")}"));
                    celulaDados1.Colspan = 5;

                    PdfPCell celulaDados2 = new PdfPCell(new Phrase($"Trabalhador                   Cargo           Pis:        \n{HoleriteGerado.Funcionario.nome}         {HoleriteGerado.Funcionario.cargo}      "));
                    celulaDados2.Colspan = 5;

                    tabela.AddCell(celulaCabecalho);
                    tabela.AddCell(celulaDados1);
                    tabela.AddCell(celulaDados2);



                    tabela.AddCell($"Código \n {HoleriteGerado.Id_Holerite.ToString()}");
                    tabela.AddCell($"Descrição \n Salario \n INSS \n ");
                    tabela.AddCell($"Referência\n {HoleriteGerado.Dias_trabalhados.ToString()} d \n {HoleriteGerado.Desconto_INSS} % \n  %"); //{taxa.taxa.Porcentagem}
                    tabela.AddCell($"Proventos\n {HoleriteGerado.Salario_bruto.ToString("f2", CultureInfo.InvariantCulture)} \n "); //{taxa.taxa.Valor.ToString("f2")}
                    tabela.AddCell($"Descontos \n \n {HoleriteGerado.ValorDescontoFGTS().ToString("f2", CultureInfo.InvariantCulture)}");




                    doc.Add(Titulo);
                    doc.Add(tabela);
                    doc.Close();





                    DialogResult resultado = MessageBox.Show("PDF gerado, deseja abrir?", "Sucesso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(caminho);
                    }

                }

                catch (PdfException ex)
                {
                    MessageBox.Show(ex.Message);
                }








            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
