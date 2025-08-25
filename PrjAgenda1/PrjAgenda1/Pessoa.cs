using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace PrjAgenda1
{

	public class Pessoa
	{
		private int codigo;
		private string nome, email, telefone;
		
		public int Pcodigo { get; set; }
		public string Pnome { get; set; }
		public string Pemail { get; set; }
		public string Ptelefone { get; set; }
		
		AcessoDados db = new AcessoDados();

		public void InserirPessoa()
		{
			try
			{
				db.Inserir(Pnome, Pemail, Ptelefone);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao inserir pessoa:\n" + ex.ToString(), "Aviso",
				                MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		public void AlterarPessoa()
		{
			try
			{
				db.Alterar(Pcodigo, Pnome, Pemail, Ptelefone);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao alterar pessoa:\n" + ex.ToString(), "Aviso",
				                MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		public void ExcluirPessoa()
		{
			try
			{
				db.Excluir(Pcodigo);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao excluir pessoa:\n" + ex.ToString(), "Aviso",
				                MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		public void CarregarPessoa(int id)
		{
			try
			{
				DataTable dados = db.Consultar("where id=" + id);
				if (dados != null && dados.Rows.Count > 0)
				{
					DataRow linha = dados.Rows[0];
					Pcodigo = Convert.ToInt32(linha["id"]);
					Pnome = linha["nome"].ToString();
					Pemail = linha["email"].ToString();
					Ptelefone = linha["telefone"].ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao carregar pessoa:\n" + ex.ToString(), "Aviso",
				                MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}
