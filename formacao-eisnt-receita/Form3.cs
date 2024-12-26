using System;
using System.Drawing;
using System.Windows.Forms;

namespace formacao_eisnt_receita
{
	public partial class Form3 : Form
	{
		private readonly string _nomeReceita;

		private Form2 form2Original;

		/// <summary>
		/// Construtor do formulário.
		/// </summary>
		/// <param name="nomeReceita">Nome da receita vindo do formulário 2.</param>
		public Form3(Form2 form2, string nomeReceita)
		{
			InitializeComponent();
			form2Original = form2;

			// Receber o nome da receita do Form2
			_nomeReceita = nomeReceita;

			// Preencha a coluna do DataGridView com o valor recebido
			DataGridViewRow row = new DataGridViewRow();
			row.CreateCells(dataGridViewAdmIngr);
			row.Cells[0].Value = _nomeReceita;
			dataGridViewAdmIngr.Rows.Add(row);
		}

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
			labelNomeIng = new Label();
			labelQuantIng = new Label();
			labelUniMIng = new Label();
			numericUpDownQuantIng = new NumericUpDown();
			textBoxNomeIng = new TextBox();
			buttonInserirIng = new Button();
			buttonVoltarForm2 = new Button();
			dataGridViewAdmIngr = new DataGridView();
			Column1 = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			Column3 = new DataGridViewTextBoxColumn();
			Column4 = new DataGridViewComboBoxColumn();
			comboBoxUniMIng = new ComboBox();
			((System.ComponentModel.ISupportInitialize)numericUpDownQuantIng).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewAdmIngr).BeginInit();
			SuspendLayout();
			// 
			// labelNomeIng
			// 
			labelNomeIng.AutoSize = true;
			labelNomeIng.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
			labelNomeIng.Location = new Point(12, 9);
			labelNomeIng.Name = "labelNomeIng";
			labelNomeIng.Size = new Size(69, 28);
			labelNomeIng.TabIndex = 0;
			labelNomeIng.Text = "Nome";
			// 
			// labelQuantIng
			// 
			labelQuantIng.AutoSize = true;
			labelQuantIng.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
			labelQuantIng.Location = new Point(178, 9);
			labelQuantIng.Name = "labelQuantIng";
			labelQuantIng.Size = new Size(122, 28);
			labelQuantIng.TabIndex = 1;
			labelQuantIng.Text = "Quantidade";
			// 
			// labelUniMIng
			// 
			labelUniMIng.AutoSize = true;
			labelUniMIng.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
			labelUniMIng.Location = new Point(378, 9);
			labelUniMIng.Name = "labelUniMIng";
			labelUniMIng.Size = new Size(196, 28);
			labelUniMIng.TabIndex = 2;
			labelUniMIng.Text = "Unidade de Medida";
			// 
			// numericUpDownQuantIng
			// 
			numericUpDownQuantIng.BackColor = SystemColors.InactiveBorder;
			numericUpDownQuantIng.Location = new Point(178, 81);
			numericUpDownQuantIng.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
			numericUpDownQuantIng.Name = "numericUpDownQuantIng";
			numericUpDownQuantIng.Size = new Size(120, 23);
			numericUpDownQuantIng.TabIndex = 4;
			// 
			// textBoxNomeIng
			// 
			textBoxNomeIng.Location = new Point(12, 81);
			textBoxNomeIng.Name = "textBoxNomeIng";
			textBoxNomeIng.Size = new Size(120, 23);
			textBoxNomeIng.TabIndex = 5;
			// 
			// buttonInserirIng
			// 
			buttonInserirIng.Location = new Point(12, 365);
			buttonInserirIng.Name = "buttonInserirIng";
			buttonInserirIng.Size = new Size(120, 49);
			buttonInserirIng.TabIndex = 6;
			buttonInserirIng.Text = "Inserir ";
			buttonInserirIng.UseVisualStyleBackColor = true;
			buttonInserirIng.Click += buttonInserirIng_Click;
			// 
			// buttonVoltarForm2
			// 
			buttonVoltarForm2.Location = new Point(160, 365);
			buttonVoltarForm2.Name = "buttonVoltarForm2";
			buttonVoltarForm2.Size = new Size(120, 49);
			buttonVoltarForm2.TabIndex = 7;
			buttonVoltarForm2.Text = "Voltar";
			buttonVoltarForm2.UseVisualStyleBackColor = true;
			buttonVoltarForm2.Click += buttonVoltarForm2_Click;
			// 
			// dataGridViewAdmIngr
			// 
			dataGridViewAdmIngr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dataGridViewAdmIngr.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewAdmIngr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewAdmIngr.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
			dataGridViewAdmIngr.Location = new Point(613, 20);
			dataGridViewAdmIngr.Name = "dataGridViewAdmIngr";
			dataGridViewAdmIngr.Size = new Size(513, 418);
			dataGridViewAdmIngr.TabIndex = 8;
			// 
			// Column1
			// 
			Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			Column1.Frozen = true;
			Column1.HeaderText = "Receita";
			Column1.Name = "Column1";
			Column1.Width = 70;
			// 
			// Column2
			// 
			Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			Column2.HeaderText = "Ingrediente";
			Column2.MaxInputLength = 600;
			Column2.Name = "Column2";
			Column2.Width = 92;
			// 
			// Column3
			// 
			Column3.HeaderText = "Quantidade";
			Column3.Name = "Column3";
			Column3.Width = 94;
			// 
			// Column4
			// 
			Column4.HeaderText = "Unidade de Medida";
			Column4.Items.AddRange(new object[] { "Unidade ", "Mililitros", "Litro", "Miligrama", "Grama", "Kilo", "#IMPLEMENTAR O ENUM" });
			Column4.Name = "Column4";
			Column4.Resizable = DataGridViewTriState.True;
			Column4.SortMode = DataGridViewColumnSortMode.Automatic;
			Column4.Width = 88;
			// 
			// comboBoxUniMIng
			// 
			comboBoxUniMIng.FormattingEnabled = true;
			comboBoxUniMIng.Items.AddRange(new object[] { "Unidade ", "Mililitros", "Litro", "Miligrama", "Grama", "Kilo", "#IMPLEMENTAR O ENUM" });
			comboBoxUniMIng.Location = new Point(378, 80);
			comboBoxUniMIng.Name = "comboBoxUniMIng";
			comboBoxUniMIng.Size = new Size(196, 23);
			comboBoxUniMIng.TabIndex = 9;
			// 
			// Form3
			// 
			BackColor = SystemColors.ButtonHighlight;
			BackgroundImage = Properties.Resources.background_receitas;
			BackgroundImageLayout = ImageLayout.Zoom;
			ClientSize = new Size(1138, 450);
			Controls.Add(comboBoxUniMIng);
			Controls.Add(dataGridViewAdmIngr);
			Controls.Add(buttonVoltarForm2);
			Controls.Add(buttonInserirIng);
			Controls.Add(textBoxNomeIng);
			Controls.Add(numericUpDownQuantIng);
			Controls.Add(labelUniMIng);
			Controls.Add(labelQuantIng);
			Controls.Add(labelNomeIng);
			DoubleBuffered = true;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form3";
			Text = "Página de administração de ingredientes.";
			WindowState = FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)numericUpDownQuantIng).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewAdmIngr).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		private void buttonInserirIng_Click(object sender, System.EventArgs e)
		{
			string nomeIngrediente = textBoxNomeIng.Text.Trim();
			int quantidadeIngrediente = (int)numericUpDownQuantIng.Value;
			string unidadeMedida = comboBoxUniMIng.Text;

			if (string.IsNullOrWhiteSpace(nomeIngrediente) || string.IsNullOrWhiteSpace(unidadeMedida))
			{
				MessageBox.Show("Preencha todos os campos antes de inserir o ingrediente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Adicionar a linha ao DataGridView.
			dataGridViewAdmIngr.Rows.Add(_nomeReceita, nomeIngrediente, quantidadeIngrediente, unidadeMedida);

			CleanControls();
		}
		private void CleanControls()
		{
			textBoxNomeIng.Clear();
			numericUpDownQuantIng.Value = 0;
			comboBoxUniMIng.SelectedIndex = -1;
			textBoxNomeIng.Focus();
		}

		/// <summary>
		/// Botão de retorno para o Form2.
		/// </summary>
		private void buttonVoltarForm2_Click(object sender, EventArgs e)
		{
			// Transferir os dados do DataGridView para o Form2.
			foreach (DataGridViewRow row in dataGridViewAdmIngr.Rows)
			{
				if (row.Cells[1].Value != null) // Ignorar linhas sem ingredientes.
				{
					string ingrediente = row.Cells[1].Value?.ToString();
					string quantidade = row.Cells[2].Value?.ToString();
					string unidade = row.Cells[3].Value?.ToString();

					form2Original.PreencherLinhasNoGrid(ingrediente, quantidade, unidade);
				}
			}

			form2Original.Show();
			Hide();
		}
	}
}
