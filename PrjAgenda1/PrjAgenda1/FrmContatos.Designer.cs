
namespace PrjAgenda1
{
	partial class FrmContatos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.MaskedTextBox mskTelefone;
		private System.Windows.Forms.ComboBox cmbCampo;
		private System.Windows.Forms.ComboBox cmbOperador;
		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.DataGridView dvgDados;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnNovo = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
			this.cmbCampo = new System.Windows.Forms.ComboBox();
			this.cmbOperador = new System.Windows.Forms.ComboBox();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.dvgDados = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dvgDados)).BeginInit();
			this.SuspendLayout();
			// 
			// btnNovo
			// 
			this.btnNovo.BackColor = System.Drawing.Color.OliveDrab;
			this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNovo.ForeColor = System.Drawing.Color.White;
			this.btnNovo.Location = new System.Drawing.Point(12, 12);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(99, 74);
			this.btnNovo.TabIndex = 0;
			this.btnNovo.Text = "Inserir";
			this.btnNovo.UseVisualStyleBackColor = false;
			this.btnNovo.Click += new System.EventHandler(this.BtnNovoClick);
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackColor = System.Drawing.Color.OliveDrab;
			this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.ForeColor = System.Drawing.Color.White;
			this.btnSalvar.Location = new System.Drawing.Point(117, 12);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(99, 74);
			this.btnSalvar.TabIndex = 1;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.BtnSalvarClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.OliveDrab;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ForeColor = System.Drawing.Color.White;
			this.btnCancelar.Location = new System.Drawing.Point(222, 12);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(99, 74);
			this.btnCancelar.TabIndex = 2;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.Color.OliveDrab;
			this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.ForeColor = System.Drawing.Color.White;
			this.btnExcluir.Location = new System.Drawing.Point(327, 12);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(99, 74);
			this.btnExcluir.TabIndex = 3;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = false;
			this.btnExcluir.Click += new System.EventHandler(this.BtnExcluirClick);
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.BackColor = System.Drawing.Color.OliveDrab;
			this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPesquisar.ForeColor = System.Drawing.Color.White;
			this.btnPesquisar.Location = new System.Drawing.Point(516, 247);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(139, 24);
			this.btnPesquisar.TabIndex = 4;
			this.btnPesquisar.Text = "Pesquisar";
			this.btnPesquisar.UseVisualStyleBackColor = false;
			this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisarClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(13, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "ID";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(120, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "Nome";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(13, 150);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Email";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(515, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Fone";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Enabled = false;
			this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigo.Location = new System.Drawing.Point(13, 119);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(100, 22);
			this.txtCodigo.TabIndex = 9;
			// 
			// txtNome
			// 
			this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.Location = new System.Drawing.Point(120, 119);
			this.txtNome.MaxLength = 50;
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(535, 22);
			this.txtNome.TabIndex = 10;
			// 
			// txtEmail
			// 
			this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(12, 176);
			this.txtEmail.MaxLength = 150;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(497, 22);
			this.txtEmail.TabIndex = 11;
			// 
			// mskTelefone
			// 
			this.mskTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mskTelefone.Location = new System.Drawing.Point(516, 177);
			this.mskTelefone.Mask = "(00)0000-0000";
			this.mskTelefone.Name = "mskTelefone";
			this.mskTelefone.Size = new System.Drawing.Size(139, 22);
			this.mskTelefone.TabIndex = 12;
			// 
			// cmbCampo
			// 
			this.cmbCampo.FormattingEnabled = true;
			this.cmbCampo.Items.AddRange(new object[] {
			"id",
			"nome",
			"email",
			"telefone"});
			this.cmbCampo.Location = new System.Drawing.Point(13, 247);
			this.cmbCampo.Name = "cmbCampo";
			this.cmbCampo.Size = new System.Drawing.Size(85, 24);
			this.cmbCampo.TabIndex = 13;
			// 
			// cmbOperador
			// 
			this.cmbOperador.FormattingEnabled = true;
			this.cmbOperador.Items.AddRange(new object[] {
			"=",
			">",
			"<",
			">=",
			"<=",
			"<>"});
			this.cmbOperador.Location = new System.Drawing.Point(105, 247);
			this.cmbOperador.Name = "cmbOperador";
			this.cmbOperador.Size = new System.Drawing.Size(75, 24);
			this.cmbOperador.TabIndex = 14;
			// 
			// txtValor
			// 
			this.txtValor.Location = new System.Drawing.Point(186, 249);
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(323, 22);
			this.txtValor.TabIndex = 15;
			// 
			// dvgDados
			// 
			this.dvgDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dvgDados.BackgroundColor = System.Drawing.Color.OliveDrab;
			this.dvgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dvgDados.Location = new System.Drawing.Point(12, 297);
			this.dvgDados.Name = "dvgDados";
			this.dvgDados.RowTemplate.Height = 24;
			this.dvgDados.Size = new System.Drawing.Size(642, 150);
			this.dvgDados.TabIndex = 16;
			this.dvgDados.Click += new System.EventHandler(this.DvgDadosClick);
			// 
			// FrmContatos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.ClientSize = new System.Drawing.Size(677, 459);
			this.Controls.Add(this.dvgDados);
			this.Controls.Add(this.txtValor);
			this.Controls.Add(this.cmbOperador);
			this.Controls.Add(this.cmbCampo);
			this.Controls.Add(this.mskTelefone);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.btnNovo);
			this.Name = "FrmContatos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Contatos";
			this.Load += new System.EventHandler(this.FrmContatosLoad);
			((System.ComponentModel.ISupportInitialize)(this.dvgDados)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		}
	}

