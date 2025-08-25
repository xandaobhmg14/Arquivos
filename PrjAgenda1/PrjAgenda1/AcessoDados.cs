using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
namespace PrjAgenda1
{
	public class AcessoDados
	{
		public MySqlConnection AbrirConexao()
		{
			string strconexao = "server=localhost; uid=root; password=polimigmysql; database=bdcontatos";
			MySqlConnection conexao;

			try
			{
				conexao = new MySqlConnection(strconexao);
				conexao.Open();
				return conexao;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro na conexão com o banco!\n" + ex.Message,
				                "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}

		public void Inserir(string nome, string email, string telefone)
		{
			MySqlConnection conexao = AbrirConexao();
			string sql;
			MySqlCommand cmd;

			try
			{
				if (conexao != null)
				{
					sql = "INSERT INTO pessoas VALUES (null,'" + nome + "','" + email + "','" + telefone + "')";
					cmd = new MySqlCommand(sql, conexao);
					cmd.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro na gravação:\n" + ex.ToString(), "Aviso",
				                MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{
				if (conexao != null)
					conexao.Close();
			}
		}


		
		public void Alterar(int id, string nome, string email, string telefone)
		{
			MySqlConnection conexao = AbrirConexao();
			string sql;
			MySqlCommand cmd;

			try
			{
				if (conexao != null)
				{
					sql = "UPDATE pessoas SET nome='" + nome + "', email='" + email + "', telefone='" + telefone + "' WHERE id=" + id;
					cmd = new MySqlCommand(sql, conexao);
					cmd.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro na alteração:\n" + ex.ToString(), "Aviso",
				                MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{
				if (conexao != null)
					conexao.Close();
			}
		}

		
		
		public void Excluir(int id)
		{
			MySqlConnection conexao = AbrirConexao();
			string sql;
			MySqlCommand cmd;

			try
			{
				if (conexao != null)
				{
					sql = "DELETE FROM pessoas WHERE id=" + id;
					cmd = new MySqlCommand(sql, conexao);
					cmd.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro na exclusão:\n" + ex.ToString(), "Aviso",
				                MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{
				if (conexao != null)
					conexao.Close();
			}
		}
		
		
		public DataTable Consultar(string filtro)
		{
			MySqlConnection conexao = AbrirConexao();
			string sql;
			MySqlCommand cmd;

			try
			{
				if (conexao != null)
				{
					sql = "SELECT * FROM pessoas " + filtro;
					MessageBox.Show(sql);
					cmd = new MySqlCommand(sql, conexao);
					cmd.CommandType = CommandType.Text;

					MySqlDataAdapter da = new MySqlDataAdapter(cmd);
					DataTable tabela = new DataTable();
					da.Fill(tabela);

					return tabela;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro na consulta:\n" + ex.ToString(), "Aviso",
				                MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{
				if (conexao != null)
					conexao.Close();
			}

			return null;
		}
	}
}

