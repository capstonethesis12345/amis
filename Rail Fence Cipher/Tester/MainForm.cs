/*
 * Created by SharpDevelop.
 * User: Anne
 * Date: 04/01/2007
 * Time: 18:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tester
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Load ld;
		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			ld = new Load();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			ld.Show();
			eOut.Text = RailFenceCypher.RailFenceCypher.Encode(eIn.Text);
			ld.Hide();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			ld.Show();
			dIn.Text = eOut.Text;
			ld.Hide();
		}

		
		void Button3Click(object sender, EventArgs e)
		{
			ld.Show();
			dOut.Text = RailFenceCypher.RailFenceCypher.DeCode(dIn.Text);
			ld.Hide();
		}
	}
}
