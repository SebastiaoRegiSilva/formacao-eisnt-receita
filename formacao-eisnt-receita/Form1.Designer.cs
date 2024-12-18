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
			folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			dataGridView1 = new System.Windows.Forms.DataGridView();
			Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
			dataGridView1.Location = new System.Drawing.Point(295, 45);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new System.Drawing.Size(738, 306);
			dataGridView1.TabIndex = 0;
			// 
			// Column1
			// 
			Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			Column1.HeaderText = "Nome da receita";
			Column1.Name = "Column1";
			Column1.ToolTipText = "teste";
			// 
			// Column2
			// 
			Column2.HeaderText = "Número de pessoas";
			Column2.Name = "Column2";
			// 
			// Column3
			// 
			Column3.HeaderText = "Dificuldade";
			Column3.Name = "Column3";
			// 
			// Column4
			// 
			Column4.HeaderText = "Categoria";
			Column4.Name = "Column4";
			// 
			// Column5
			// 
			Column5.HeaderText = "Tempo de preparo";
			Column5.Name = "Column5";
			// 
			// Column6
			// 
			Column6.HeaderText = "Ingredientes";
			Column6.Name = "Column6";
			// 
			// Form1
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1138, 450);
			Controls.Add(dataGridView1);
			Name = "Form1";
			Text = "Gestão de Receitas e Culinárias.";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
	}
}
