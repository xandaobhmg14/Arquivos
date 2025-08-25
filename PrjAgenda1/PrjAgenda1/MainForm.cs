using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PrjAgenda1
{
	public partial class FrmPrincipal : Form
	{
		public FrmPrincipal()
		{
			InitializeComponent();
			
		}
		void ContatosToolStripMenuItemClick(object sender, EventArgs e)
		{
			FrmContatos f1 = new FrmContatos();
			f1.Show();
		}
		void ToolStripButton1Click(object sender, EventArgs e)
		{
			FrmContatos f1 = new FrmContatos();
			f1.Show();
		}
		void MenuStrip1ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
	
		}
	}
}
