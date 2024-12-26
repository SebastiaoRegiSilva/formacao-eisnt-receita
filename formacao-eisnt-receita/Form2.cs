using formacao_eisnt_receita.Helpers;
using formacao_eisnt_receita.Utilities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace formacao_eisnt_receita
{
	public partial class Form2 : Form
	{
		/// <summary>
		/// DataGridView acessível em toda a classe.
		/// </summary>
		private DataGridView dataGridViewForm2;

		/// <summary>
		/// Construtor do formulário.
		/// </summary>
		public Form2()
		{
			InitializeComponent();
			CriarDataGridView();

			// Preencher o ComboBox com os valores da descrição do enum TipoDificuldade.
			ComboDifPrep.DataSource = Enum.GetValues(typeof(TipoDificuldade))
				.Cast<TipoDificuldade>()
				.Select(e => new
				{
					Value = e,
					Display = EnumHelper.GetEnumDescription(e)
				})
				.ToList();

			ComboDifPrep.DisplayMember = "Display";
			ComboDifPrep.ValueMember = "Value";
		}

		/// <summary>
		/// Método para criar o DataGridView.
		/// </summary>
		private void CriarDataGridView()
		{
			// Criar o DataGridView e configurar suas propriedades
			dataGridViewForm2 = new DataGridView
			{
				Location = new System.Drawing.Point(345, 2), // Posição no formulário.
				Size = new System.Drawing.Size(800, 300),   // Tamanho do DataGridView.
				AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill, // Colunas ajustáveis.
				AllowUserToAddRows = false,                 // Impedir o usuário de adicionar linhas manualmente.
				ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
			};

			// Adicionar colunas ao DataGridView.
			dataGridViewForm2.Columns.Add("Coluna1", "Nome da receita");
			dataGridViewForm2.Columns.Add("Coluna2", "Quantidade de Pessoas");
			dataGridViewForm2.Columns.Add("Coluna3", "Dificuldade");
			dataGridViewForm2.Columns.Add("Coluna4", "Categoria");
			dataGridViewForm2.Columns.Add("Coluna5", "Ingrediente");
			dataGridViewForm2.Columns.Add("Coluna6", "Quantidade");
			dataGridViewForm2.Columns.Add("Coluna7", "Unidade");

			// Adicionar o DataGridView ao formulário
			this.Controls.Add(dataGridViewForm2);
		}

		private void CleanControls()
		{
			textBoxNomeReceita.Clear();
			numericUpDownQtdPessoas.Value = 0;
			ComboDifPrep.SelectedIndex = -1;
			comboCategoria.SelectedIndex = -1;
			textBoxNomeReceita.Focus();
		}
		

		/// <summary>
		/// Evento disparado quando o ComboBox de dificuldade é alterado.
		/// </summary>
		private void ComboDifPrep_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Obter o valor selecionado no ComboBox como tipo enum
			if (ComboDifPrep.SelectedItem != null)
			{
				TipoDificuldade dificuldadeSelecionada = (TipoDificuldade)((dynamic)ComboDifPrep.SelectedItem).Value;
			}
		}

		/// <summary>
		/// Preencher colunas ingrediente, quantidade e unidade, com os dados vindos do form3.
		/// </summary>
		public void PreencherLinhasNoGrid(string ingrediente, string quantidade, string unidade)
		{
			// Preencher as primeiras 4 colunas com os valores do formulário.
			dataGridViewForm2.Rows.Add(textBoxNomeReceita.Text, numericUpDownQtdPessoas.Value, ComboDifPrep.Text, comboCategoria.Text);

			// Criar uma nova linha
			DataGridViewRow row = new DataGridViewRow();
			row.CreateCells(dataGridViewForm2);

			// Preencher as células com os valores fornecidos
			row.Cells[4].Value = ingrediente;
			row.Cells[5].Value = quantidade;
			row.Cells[6].Value = unidade;

			// Adicionar a linha ao DataGridView
			dataGridViewForm2.Rows.Add(row);
			// CleanControls();
		}

		/// <summary>
		/// Evento disparado ao clicar no botão para adicionar ingredientes.
		/// </summary>
		private void ButtonAdcIngredientes_Click(object sender, EventArgs e)
		{
			Form3 form3 = new(this, textBoxNomeReceita.Text);
			form3.Show();
			Hide();
		}
	}
}
