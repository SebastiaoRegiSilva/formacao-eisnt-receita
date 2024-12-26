using System;
using System.Drawing;
using System.Windows.Forms;

namespace formacao_eisnt_receita
{
	partial class Form2
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
			if (disposing && (components != null))
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			labelNomeReceita = new Label();
			labelQuantidadePessoas = new Label();
			labelDificuldade = new Label();
			labelCategoria = new Label();
			labelIngrediente = new Label();
			textBoxNomeReceita = new TextBox();
			numericUpDownQtdPessoas = new NumericUpDown();
			ButtonAdcIngredientes = new Button();
			comboCategoria = new ComboBox();
			ComboDifPrep = new ComboBox();
			((System.ComponentModel.ISupportInitialize)numericUpDownQtdPessoas).BeginInit();
			SuspendLayout();
			// 
			// labelNomeReceita
			// 
			labelNomeReceita.AutoSize = true;
			labelNomeReceita.Location = new Point(22, 39);
			labelNomeReceita.Name = "labelNomeReceita";
			labelNomeReceita.Size = new Size(43, 15);
			labelNomeReceita.TabIndex = 0;
			labelNomeReceita.Text = "Nome:";
			// 
			// labelQuantidadePessoas
			// 
			labelQuantidadePessoas.AutoSize = true;
			labelQuantidadePessoas.Location = new Point(22, 103);
			labelQuantidadePessoas.Name = "labelQuantidadePessoas";
			labelQuantidadePessoas.Size = new Size(132, 15);
			labelQuantidadePessoas.TabIndex = 1;
			labelQuantidadePessoas.Text = "Quantidade de Pessoas:";
			// 
			// labelDificuldade
			// 
			labelDificuldade.AutoSize = true;
			labelDificuldade.Location = new Point(23, 163);
			labelDificuldade.Name = "labelDificuldade";
			labelDificuldade.Size = new Size(130, 15);
			labelDificuldade.TabIndex = 2;
			labelDificuldade.Text = "Dificuldade de Preparo:";
			// 
			// labelCategoria
			// 
			labelCategoria.AutoSize = true;
			labelCategoria.Location = new Point(22, 227);
			labelCategoria.Name = "labelCategoria";
			labelCategoria.Size = new Size(61, 15);
			labelCategoria.TabIndex = 3;
			labelCategoria.Text = "Categoria:";
			// 
			// labelIngrediente
			// 
			labelIngrediente.AutoSize = true;
			labelIngrediente.Location = new Point(22, 279);
			labelIngrediente.Name = "labelIngrediente";
			labelIngrediente.Size = new Size(129, 15);
			labelIngrediente.TabIndex = 4;
			labelIngrediente.Text = "Adicionar Ingredientes:";
			// 
			// textBoxNomeReceita
			// 
			textBoxNomeReceita.Location = new Point(174, 36);
			textBoxNomeReceita.Name = "textBoxNomeReceita";
			textBoxNomeReceita.Size = new Size(124, 23);
			textBoxNomeReceita.TabIndex = 5;
			// 
			// numericUpDownQtdPessoas
			// 
			numericUpDownQtdPessoas.Location = new Point(174, 101);
			numericUpDownQtdPessoas.Name = "numericUpDownQtdPessoas";
			numericUpDownQtdPessoas.Size = new Size(124, 23);
			numericUpDownQtdPessoas.TabIndex = 6;
			// 
			// ButtonAdcIngredientes
			// 
			ButtonAdcIngredientes.BackColor = SystemColors.ControlLightLight;
			ButtonAdcIngredientes.Location = new Point(174, 275);
			ButtonAdcIngredientes.Name = "ButtonAdcIngredientes";
			ButtonAdcIngredientes.Size = new Size(124, 23);
			ButtonAdcIngredientes.TabIndex = 7;
			ButtonAdcIngredientes.Text = "Adicionar";
			ButtonAdcIngredientes.UseVisualStyleBackColor = false;
			ButtonAdcIngredientes.Click += ButtonAdcIngredientes_Click;
			// 
			// comboCategoria
			// 
			comboCategoria.FormattingEnabled = true;
			comboCategoria.Items.AddRange(new object[] { "Carne", "Peixe", "Marisco", "Pastelaria", "Sobremesas" });
			comboCategoria.Location = new Point(174, 219);
			comboCategoria.Name = "comboCategoria";
			comboCategoria.Size = new Size(121, 23);
			comboCategoria.TabIndex = 8;
			// 
			// ComboDifPrep
			// 
			ComboDifPrep.FormattingEnabled = true;
			ComboDifPrep.Location = new Point(177, 163);
			ComboDifPrep.Name = "ComboDifPrep";
			ComboDifPrep.Size = new Size(121, 23);
			ComboDifPrep.TabIndex = 9;
			ComboDifPrep.SelectedIndexChanged += ComboDifPrep_SelectedIndexChanged;
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			BackColor = SystemColors.ButtonHighlight;
			BackgroundImage = Properties.Resources.background_receitas;
			BackgroundImageLayout = ImageLayout.Zoom;
			ClientSize = new Size(1138, 450);
			Controls.Add(ComboDifPrep);
			Controls.Add(comboCategoria);
			Controls.Add(ButtonAdcIngredientes);
			Controls.Add(numericUpDownQtdPessoas);
			Controls.Add(textBoxNomeReceita);
			Controls.Add(labelIngrediente);
			Controls.Add(labelCategoria);
			Controls.Add(labelDificuldade);
			Controls.Add(labelQuantidadePessoas);
			Controls.Add(labelNomeReceita);
			DoubleBuffered = true;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form2";
			Text = "Página Cadastro de Receitas.";
			WindowState = FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)numericUpDownQtdPessoas).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label labelNomeReceita;
		private System.Windows.Forms.Label labelQuantidadePessoas;
		private System.Windows.Forms.Label labelDificuldade;
		private System.Windows.Forms.Label labelCategoria;
		private System.Windows.Forms.Label labelIngrediente;
		private System.Windows.Forms.TextBox textBoxNomeReceita;
		private System.Windows.Forms.NumericUpDown numericUpDownQtdPessoas;
		public System.Windows.Forms.Button ButtonAdcIngredientes;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
		private System.Windows.Forms.ComboBox comboCategoria;
		private System.Windows.Forms.ComboBox ComboDifPrep;

		public DataGridViewColumn Column5 { get; private set; }
		public DataGridViewColumn Column6 { get; private set; }
		public DataGridViewColumn Column7 { get; private set; }
	}
}