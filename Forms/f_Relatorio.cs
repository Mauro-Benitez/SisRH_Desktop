using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SisRH_Desktop
{
    public partial class f_Relatorio : Form
    {

        private SqlConnection con;
        private SqlCommand cmd;

        private readonly string url = @"Data Source=DESKTOP-DNIRGUH\SQLEXPRESS;Initial Catalog=BD_Funcionario;"
        + "Integrated Security=true;";

        public f_Relatorio()
        {
            InitializeComponent();
         
        }


        private void btnGerar_Click(object sender, EventArgs e)
        {
            relatorioOficial();


        }



        private void GerarRelatorio()
        {
            string query = @"SELECT 
                                SUM(TB_funcionario.salario_bruto) AS TotalSalarioBruto, 
                                SUM(TB_Holerite.SalarioLiquido) AS TotalSalarioLiquido, 
                                SUM(TB_Holerite.desconto_inss) AS TotalINSS, 
                                SUM(TB_Holerite.desconto_vt) AS TotalVT                                 
                            FROM TB_funcionario 
                            JOIN TB_Holerite ON TB_funcionario.registro = TB_Holerite.id_funcionario;";

            using (SqlConnection connection = new SqlConnection(url))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                    using (ExcelPackage package = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Relatório");

                        // Escrevendo os totais na planilha
                        worksheet.Cells["A1"].Value = "Total Salário Bruto";
                        worksheet.Cells["B1"].Value = dataTable.Rows[0]["TotalSalarioBruto"];

                        worksheet.Cells["A2"].Value = "Total Salário Líquido";
                        worksheet.Cells["B2"].Value = dataTable.Rows[0]["TotalSalarioLiquido"];

                        worksheet.Cells["A3"].Value = "Total INSS";
                        worksheet.Cells["B3"].Value = dataTable.Rows[0]["TotalINSS"];

                        worksheet.Cells["A4"].Value = "Total VT";
                        worksheet.Cells["B4"].Value = dataTable.Rows[0]["TotalVT"];

                       
                        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                        {
                            saveFileDialog.Filter = "Arquivos Excel (*.xlsx)|*.xlsx";
                            saveFileDialog.FileName = "RelatorioFuncionarios.xlsx";

                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                                package.SaveAs(excelFile);
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
            }
        }
        private void relatorioOficial()
        {
            string query = @"SELECT TB_funcionario.registro AS IDFuncionario,
                            TB_funcionario.nome AS NomeFuncionario,
                            TB_Holerite.SalarioBruto,
                            TB_Holerite.SalarioLiquido";

            bool hasINSS = checkBoxGastoINSS.Checked;
            bool hasVT = checkBoxGastoVT.Checked;
            bool hasVR = checkBoxGastoVR.Checked;

            if (hasINSS)
                query += ", TB_Holerite.desconto_inss";

            if (hasVT)
                query += ", TB_funcionario.valor_vt";

            if (hasVR)
                query += ", TB_funcionario.valor_vr";

            query += @"
                FROM TB_funcionario
                JOIN TB_Holerite ON TB_funcionario.registro = TB_Holerite.id_funcionario";

            // Configuração da conexão com o banco de dados
            //string connectionString = "SUA_STRING_DE_CONEXAO_AQUI";

            using (SqlConnection connection = new SqlConnection(url))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                    using (ExcelPackage package = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Relatório");

                        // Escrever os dados na planilha
                        int rowCount = 1;
                        int colCount = 1;

                        // Escrever cabeçalhos das colunas
                        foreach (DataColumn column in dataTable.Columns)
                        {
                            worksheet.Cells[rowCount, colCount].Value = column.ColumnName;
                            colCount++;
                        }

                        rowCount++;

                        // Escrever dados dos funcionários
                        foreach (DataRow row in dataTable.Rows)
                        {
                            colCount = 1;
                            foreach (DataColumn column in dataTable.Columns)
                            {
                                worksheet.Cells[rowCount, colCount].Value = row[column.ColumnName];
                                colCount++;
                            }
                            rowCount++;
                        }

                        // Calcular e escrever as somas no final das colunas de INSS, VT e VR
                        int lastRow = rowCount - 1;

                        if (hasINSS)
                        {
                            worksheet.Cells[lastRow + 1, colCount - 1].Value = "Soma Total INSS:";
                            worksheet.Cells[lastRow + 1, colCount].Formula = $"SUM({GetExcelColumnName(colCount)}2:{GetExcelColumnName(colCount)}{lastRow})";
                        }

                        if (hasVT)
                        {
                            colCount++;
                            worksheet.Cells[lastRow + 1, colCount - 1].Value = "Soma Total VT:";
                            worksheet.Cells[lastRow + 1, colCount].Formula = $"SUM({GetExcelColumnName(colCount)}2:{GetExcelColumnName(colCount)}{lastRow})";
                        }

                        if (hasVR)
                        {
                            colCount++;
                            worksheet.Cells[lastRow + 1, colCount - 1].Value = "Soma Total VR:";
                            worksheet.Cells[lastRow + 1, colCount].Formula = $"SUM({GetExcelColumnName(colCount)}2:{GetExcelColumnName(colCount)}{lastRow})";
                        }

                        // Salvar a planilha Excel
                        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                        {
                            saveFileDialog.Filter = "Arquivos Excel (*.xlsx)|*.xlsx";
                            saveFileDialog.FileName = "RelatorioFuncionarios.xlsx";

                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                                package.SaveAs(excelFile);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
            }
        }

        // Função auxiliar para obter o nome da coluna do Excel
        private string GetExcelColumnName(int columnIndex)
        {
            int dividend = columnIndex;
            string columnName = string.Empty;

            while (dividend > 0)
            {
                int modulo = (dividend - 1) % 26;
                columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
                dividend = (dividend - modulo) / 26;
            }

            return columnName;
        }
    
        private void GerarRelatorioChekbox()
        {
            string query = @"SELECT TB_funcionario.registro AS IDFuncionario,
                                    TB_funcionario.nome AS NomeFuncionario,
                                    TB_Holerite.SalarioBruto,
                                    TB_Holerite.SalarioLiquido
                            FROM TB_funcionario
                            JOIN TB_Holerite ON TB_funcionario.registro = TB_Holerite.id_funcionario";

            // Configuração da conexão com o banco de dados
            //string connectionString = "SUA_STRING_DE_CONEXAO_AQUI";

            using (SqlConnection connection = new SqlConnection(url))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                    using (ExcelPackage package = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Relatório");

                        // Escrever os dados na planilha
                        int rowCount = 1;
                        int colCount = 1;

                        // Escrever cabeçalhos das colunas
                        foreach (DataColumn column in dataTable.Columns)
                        {
                            worksheet.Cells[rowCount, colCount].Value = column.ColumnName;
                            colCount++;
                        }

                        rowCount++;

                        // Escrever dados dos funcionários
                        foreach (DataRow row in dataTable.Rows)
                        {
                            colCount = 1;
                            foreach (DataColumn column in dataTable.Columns)
                            {
                                worksheet.Cells[rowCount, colCount].Value = row[column.ColumnName];
                                colCount++;
                            }
                            rowCount++;
                        }

                        // Calcular e escrever as somas no final das colunas SalarioBruto e SalarioLiquido
                        worksheet.Cells[rowCount, 1].Value = "Soma Total Salário Bruto:";
                        worksheet.Cells[rowCount, 3].Formula = $"SUM(C2:C{rowCount - 1})";

                        worksheet.Cells[rowCount, 4].Value = "Soma Total Salário Líquido:";
                        worksheet.Cells[rowCount, 5].Formula = $"SUM(D2:D{rowCount - 1})";

                        // Salvar a planilha Excel
                        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                        {
                            saveFileDialog.Filter = "Arquivos Excel (*.xlsx)|*.xlsx";
                            saveFileDialog.FileName = "RelatorioFuncionarios.xlsx";

                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                                package.SaveAs(excelFile);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
            }
        }
        private void f_Relatorio_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxGastoINSS_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
