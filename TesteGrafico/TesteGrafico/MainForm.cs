/*
 * Criado por SharpDevelop.
 * Usuário: Polimig
 * Data: 18/08/2025
 * Hora: 14:15
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;


namespace TesteGrafico
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private string conexao = "server=localhost;port=3306;database=bdvendas;uid=root;pwd=polimigmysql";
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			try
			{
				using (MySqlConnection conn = new MySqlConnection(conexao))
				{
					conn.Open();
					string sql = "SELECT datavenda, valorvenda FROM tbvendas ORDER BY datavenda";
					MySqlCommand cmd = new MySqlCommand(sql, conn);
					MySqlDataReader reader = cmd.ExecuteReader();
					
					// Cria um objeto gráfico (Chart) em memória
					Chart Chart1 = new Chart();
					Chart1.Size = new Size(600, 400);

					// Limpa séries e áreas existentes 
					Chart1.Series.Clear();
					Chart1.ChartAreas.Clear();

					// Cria a área do grafico
					ChartArea area = new ChartArea();
					Chart1.ChartAreas.Add(area);

					// Cria a série de dados (linha, coluna, etc.)
					Series serie = new Series
					{
						Name = "Vendas",
						ChartType = SeriesChartType.Pie, //Tipo de grafico
						XValueType = ChartValueType.Date
					};
					
					
					Chart1.Series.Add(serie);

					//Busca os dados no banco registro por registro e adiciona no grafico
					while (reader.Read())
					{
						DateTime data = reader.GetDateTime("datavenda");
						double valor = reader.GetDouble("valorvenda");
						serie.Points.AddXY(data, valor);
					}

					reader.Close();
					
					//Exibe o grafico no formulário 
					Chart1.Location = new Point(10, 10);
					this.Controls.Add(Chart1);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro: " + ex.Message);
			}
		
		}
	}
}

