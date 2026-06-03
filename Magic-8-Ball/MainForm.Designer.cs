/*
 * Created by SharpDevelop.
 * User: User
 * Date: 3/6/2026
 * Time: 11:22 am
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Magic_8_Ball
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
			this.btnAsks = new System.Windows.Forms.Button();
			this.tbxUserInput = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(418, 70);
			this.label1.TabIndex = 0;
			this.label1.Text = "MAGIC 8 BALL";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(34, 142);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(377, 59);
			this.label2.TabIndex = 1;
			this.label2.Text = "\"thou asks magic 8 ball, \r\nand ye shall answer your question\"";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnAsks
			// 
			this.btnAsks.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAsks.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btnAsks.Location = new System.Drawing.Point(151, 323);
			this.btnAsks.Name = "btnAsks";
			this.btnAsks.Size = new System.Drawing.Size(143, 42);
			this.btnAsks.TabIndex = 2;
			this.btnAsks.Text = "Ask";
			this.btnAsks.UseVisualStyleBackColor = true;
			this.btnAsks.Click += new System.EventHandler(this.BtnAsksClick);
			// 
			// tbxUserInput
			// 
			this.tbxUserInput.BackColor = System.Drawing.SystemColors.Window;
			this.tbxUserInput.Location = new System.Drawing.Point(25, 247);
			this.tbxUserInput.Name = "tbxUserInput";
			this.tbxUserInput.Size = new System.Drawing.Size(408, 26);
			this.tbxUserInput.TabIndex = 3;
			this.tbxUserInput.TextChanged += new System.EventHandler(this.TbxUserInputTextChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(1, 412);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 28);
			this.label3.TabIndex = 4;
			this.label3.Text = "ItsByro";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(458, 434);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbxUserInput);
			this.Controls.Add(this.btnAsks);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "MainForm";
			this.Text = "Magic-8-Ball";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbxUserInput;
		private System.Windows.Forms.Button btnAsks;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
