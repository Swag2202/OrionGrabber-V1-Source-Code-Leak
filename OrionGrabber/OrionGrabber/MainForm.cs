/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 11/05/2022
 * Time: 09:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OrionGrabber
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
			MessageBox.Show("Welcome to Orion Grabber V0.1!");
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PictureBox3Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void PictureBox4Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			MessageBox.Show("Compiled !");
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
	}
}
