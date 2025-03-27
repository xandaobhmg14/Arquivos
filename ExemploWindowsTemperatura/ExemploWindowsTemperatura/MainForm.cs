/*
 * Created by SharpDevelop.
 * User: alexa
 * Date: 06/02/2025
 * Time: 08:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ExemploWindowsTemperatura
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
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
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			double tc, tk, tf;
			
			tc = double.Parse(textBox1.Text);
			tk=tc+273;
			tf=(1.8*tc)+32;
			textBox2.Text = tk.ToString();
			textBox3.Text = tf.ToString();
		}
	}
}
