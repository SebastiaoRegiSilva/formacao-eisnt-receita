namespace formacao_eisnt_receita
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			dataGridView1 = new System.Windows.Forms.DataGridView();
			Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			CadastrarReceita = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			resources.ApplyResources(dataGridView1, "dataGridView1");
			dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
			dataGridView1.Name = "dataGridView1";
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// Column1
			// 
			Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			resources.ApplyResources(Column1, "Column1");
			Column1.Name = "Column1";
			// 
			// Column2
			// 
			resources.ApplyResources(Column2, "Column2");
			Column2.Name = "Column2";
			// 
			// Column3
			// 
			resources.ApplyResources(Column3, "Column3");
			Column3.Name = "Column3";
			// 
			// Column4
			// 
			resources.ApplyResources(Column4, "Column4");
			Column4.Name = "Column4";
			// 
			// Column5
			// 
			resources.ApplyResources(Column5, "Column5");
			Column5.Name = "Column5";
			// 
			// Column6
			// 
			resources.ApplyResources(Column6, "Column6");
			Column6.Name = "Column6";
			// 
			// CadastrarReceita
			// 
			resources.ApplyResources(CadastrarReceita, "CadastrarReceita");
			CadastrarReceita.BackColor = System.Drawing.Color.Moccasin;
			CadastrarReceita.FlatAppearance.BorderSize = 3;
			CadastrarReceita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(255, 128, 128);
			CadastrarReceita.Name = "CadastrarReceita";
			CadastrarReceita.UseVisualStyleBackColor = false;
			CadastrarReceita.Click += CadastrarReceita_Click;
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			BackColor = System.Drawing.SystemColors.ButtonHighlight;
			BackgroundImage = Properties.Resources.mestre_cuca1;
			Controls.Add(CadastrarReceita);
			Controls.Add(dataGridView1);
			Name = "Form1";
			WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.Button CadastrarReceita;
	}
}
