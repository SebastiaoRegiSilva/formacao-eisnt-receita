using System;
using System.Windows.Forms;

namespace formacao_eisnt_receita
{
	partial class Form3 : Form
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

		#endregion

		private Label labelNomeIng;
		private Label labelQuantIng;
		private Label labelUniMIng;
		private NumericUpDown numericUpDownQuantIng;
		private TextBox textBoxNomeIng;
		private Button buttonInserirIng;
		private Button buttonVoltarForm2;
		private DataGridView dataGridViewAdmIngr;
		private ComboBox comboBoxUniMIng;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewComboBoxColumn Column4;
	}
}