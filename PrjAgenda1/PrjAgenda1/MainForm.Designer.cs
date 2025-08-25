﻿
namespace PrjAgenda1
{
	partial class FrmPrincipal
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem contatosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem outrosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem relógioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.contatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.outrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.relógioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.DarkKhaki;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.contatosToolStripMenuItem,
			this.outrosToolStripMenuItem,
			this.sobreToolStripMenuItem,
			this.sairToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(404, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1ItemClicked);
			// 
			// contatosToolStripMenuItem
			// 
			this.contatosToolStripMenuItem.Name = "contatosToolStripMenuItem";
			this.contatosToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
			this.contatosToolStripMenuItem.Text = "Contatos";
			this.contatosToolStripMenuItem.Click += new System.EventHandler(this.ContatosToolStripMenuItemClick);
			// 
			// outrosToolStripMenuItem
			// 
			this.outrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.relógioToolStripMenuItem,
			this.calculadoraToolStripMenuItem});
			this.outrosToolStripMenuItem.Name = "outrosToolStripMenuItem";
			this.outrosToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
			this.outrosToolStripMenuItem.Text = "Outros";
			// 
			// relógioToolStripMenuItem
			// 
			this.relógioToolStripMenuItem.Name = "relógioToolStripMenuItem";
			this.relógioToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
			this.relógioToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
			this.relógioToolStripMenuItem.Text = "Relógio";
			// 
			// calculadoraToolStripMenuItem
			// 
			this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
			this.calculadoraToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
			this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
			this.calculadoraToolStripMenuItem.Text = "Calculadora";
			// 
			// sobreToolStripMenuItem
			// 
			this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
			this.sobreToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
			this.sobreToolStripMenuItem.Text = "Sobre";
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
			this.sairToolStripMenuItem.Text = "Sair";
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.OliveDrab;
			this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripButton1,
			this.toolStripButton2,
			this.toolStripButton3});
			this.toolStrip1.Location = new System.Drawing.Point(0, 28);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(404, 27);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
			this.toolStripButton1.Text = "toolStripButton1";
			this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
			this.toolStripButton2.Text = "toolStripButton2";
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
			this.toolStripButton3.Text = "toolStripButton3";
			// 
			// FrmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.ClientSize = new System.Drawing.Size(404, 253);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FrmPrincipal";
			this.Text = "Agenda Pessoal";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
