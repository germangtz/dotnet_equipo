/*
 * Created by SharpDevelop.
 * User: licge
 * Date: 10/28/2026
 * Time: 7:24 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyectoPrueba
{
	/// <summary>
	/// Description of operaciones.
	/// </summary>
	public partial class operaciones : Form
	{
		public operaciones()
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
			MainForm MF=new MainForm();
			MF.Show();
		}
	}
}
