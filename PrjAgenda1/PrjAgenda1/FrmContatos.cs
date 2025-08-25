using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PrjAgenda1
{
	public partial class FrmContatos : Form
	{
		private string Estado;
		public FrmContatos()
		{
			InitializeComponent();
			Estado="Ler";
		}
		private void limparCampos()
		{
			txtCodigo.Clear();
			txtNome.Clear();
			txtEmail.Clear();
			mskTelefone.Clear();
		}
		
		void AbreBanco()
		{
			AcessoDados db = new AcessoDados();
			string parametro = "";
			dvgDados.DataSource = db.Consultar(parametro);
			db = null;
		}
		void FrmContatosLoad(object sender, EventArgs e)
		{
			AbreBanco();
			Estado = "Alterar";
		}
		void BtnNovoClick(object sender, EventArgs e)
		{
			Estado = "Inserir";
			limparCampos();
			txtNome.Focus();
		}
		void BtnCancelarClick(object sender, EventArgs e)
		{
			limparCampos();
		}
		void BtnSalvarClick(object sender, EventArgs e)
		{
			try
			{
				Pessoa p = new Pessoa();
				p.Pnome = txtNome.Text;
				p.Pemail = txtEmail.Text;
				p.Ptelefone = mskTelefone.Text;
				if (Estado == "Inserir")
					p.InserirPessoa();
				else if (Estado == "Alterar")
				{
					p.Pcodigo = Convert.ToInt32(txtCodigo.Text);
					p.AlterarPessoa();
				}
				Estado = "Ler";
				limparCampos();
				AbreBanco();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao cadastrar contato"+ex.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}
		void BtnPesquisarClick(object sender, EventArgs e)
		{
			AcessoDados db = new AcessoDados();

			string campo = cmbCampo.Text;
			string operador = cmbOperador.Text;
			string valor = txtValor.Text;

			string parametro = "where " + campo + " " + operador + " '" + valor + "'";
			dvgDados.DataSource = db.Consultar(parametro);

			db = null;
			Estado = "Alterar";
		}

		void DvgDadosClick(object sender, EventArgs e)
		{
			if (dvgDados.CurrentRow != null)
			{
				Pessoa p = new Pessoa();
				p.CarregarPessoa(Convert.ToInt32(dvgDados.CurrentRow.Cells[0].Value.ToString()));

				txtCodigo.Text = p.Pcodigo.ToString();
				txtNome.Text = p.Pnome;
				txtEmail.Text = p.Pemail;
				mskTelefone.Text = p.Ptelefone;
				Estado = "Alterar";
			}
		}
		void BtnExcluirClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Deseja excluir este contato?", "Confirmação",
			                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Pessoa p = new Pessoa();
				p.Pcodigo = Convert.ToInt32(txtCodigo.Text);
				p.ExcluirPessoa();

				limparCampos();
				AbreBanco();
			}
		}
	}
}
