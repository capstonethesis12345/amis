/*
 * Created by SharpDevelop.
 * User: Anne
 * Date: 04/01/2007
 * Time: 18:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tester
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.eIn = new System.Windows.Forms.TextBox();
			this.eOut = new System.Windows.Forms.TextBox();
			this.dOut = new System.Windows.Forms.TextBox();
			this.dIn = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Window;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(5);
			this.label1.Size = new System.Drawing.Size(433, 39);
			this.label1.TabIndex = 0;
			this.label1.Text = "This program is going to test the RailFenceCypher class, to make sure it is worki" +
			"ng";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Encoding";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 166);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Decoding";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 75);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(141, 51);
			this.label4.TabIndex = 3;
			this.label4.Text = "Input:\r\n\r\nOutput:";
			// 
			// eIn
			// 
			this.eIn.Location = new System.Drawing.Point(68, 72);
			this.eIn.Name = "eIn";
			this.eIn.Size = new System.Drawing.Size(276, 20);
			this.eIn.TabIndex = 4;
			// 
			// eOut
			// 
			this.eOut.Location = new System.Drawing.Point(68, 98);
			this.eOut.Name = "eOut";
			this.eOut.Size = new System.Drawing.Size(276, 20);
			this.eOut.TabIndex = 5;
			// 
			// dOut
			// 
			this.dOut.Location = new System.Drawing.Point(68, 212);
			this.dOut.Name = "dOut";
			this.dOut.Size = new System.Drawing.Size(276, 20);
			this.dOut.TabIndex = 8;
			// 
			// dIn
			// 
			this.dIn.Location = new System.Drawing.Point(68, 186);
			this.dIn.Name = "dIn";
			this.dIn.Size = new System.Drawing.Size(276, 20);
			this.dIn.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 189);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(141, 51);
			this.label5.TabIndex = 6;
			this.label5.Text = "Input:\r\n\r\nOutput:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 124);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "Encode";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(93, 124);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(128, 23);
			this.button2.TabIndex = 10;
			this.button2.Text = "Put output for decoding";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 238);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 11;
			this.button3.Text = "Decode";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(433, 291);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dOut);
			this.Controls.Add(this.dIn);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.eOut);
			this.Controls.Add(this.eIn);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RailFenceCypher Tester";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox dIn;
		private System.Windows.Forms.TextBox dOut;
		private System.Windows.Forms.TextBox eOut;
		private System.Windows.Forms.TextBox eIn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
