namespace WinFormApp
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.tb_one = new System.Windows.Forms.TextBox();
			this.btn_press_one = new System.Windows.Forms.Button();
			this.tmr_form = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// tb_one
			// 
			this.tb_one.Location = new System.Drawing.Point(12, 12);
			this.tb_one.Name = "tb_one";
			this.tb_one.Size = new System.Drawing.Size(776, 20);
			this.tb_one.TabIndex = 0;
			// 
			// btn_press_one
			// 
			this.btn_press_one.Location = new System.Drawing.Point(12, 132);
			this.btn_press_one.Name = "btn_press_one";
			this.btn_press_one.Size = new System.Drawing.Size(95, 23);
			this.btn_press_one.TabIndex = 1;
			this.btn_press_one.Text = "Жми на меня";
			this.btn_press_one.UseVisualStyleBackColor = true;
			this.btn_press_one.Click += new System.EventHandler(this.btn_press_one_Click);
			// 
			// tmr_form
			// 
			this.tmr_form.Enabled = true;
			this.tmr_form.Interval = 1000;
			this.tmr_form.Tick += new System.EventHandler(this.tmr_form_Tick);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_press_one);
			this.Controls.Add(this.tb_one);
			this.Name = "FormMain";
			this.Text = "Основная форма";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tb_one;
		private System.Windows.Forms.Button btn_press_one;
		private System.Windows.Forms.Timer tmr_form;
	}
}

