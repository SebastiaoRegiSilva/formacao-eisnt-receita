using System;
using System.Windows.Forms;

namespace formacao_eisnt_receita
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void CadastrarReceita_Click(object sender, EventArgs e)
		{
			// Criar uma instância do Form2.
			Form2 form2 = new();
			form2.Show();

			// Opção fechar o formulário 1.
			//this.Close();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
