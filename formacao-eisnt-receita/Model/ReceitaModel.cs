using formacao_eisnt_receita.Utilities;
using System;
using System.Collections.Generic;

namespace formacao_eisnt_receita.Model
{
	/// <summary>
	/// Modelo de receita.
	/// </summary>
	public class ReceitaModel
	{
		string CategoriaNome { get; set; } = string.Empty;
		List<IngredidenteModel> Ingredientes { get; set; }
		public string Nome { get; set; } = string.Empty;
		public int QuantidadePessoas { get; set; }
		public TimeSpan TempoPreparacao { get; set; }
		public TipoDificuldade TipoDificuldade { get;}

		/// <summary>
		/// Construtor com parâmetros para inicialização.
		/// </summary>
		public ReceitaModel(string categoriaNome, List<IngredidenteModel> ingredientes, string nome, int quantidadePessoas, TimeSpan tempoPreparacao, TipoDificuldade tipoDificuldade)
		{
			CategoriaNome = categoriaNome;
			Ingredientes = ingredientes;
			Nome = nome;
			QuantidadePessoas = quantidadePessoas;
			TempoPreparacao = tempoPreparacao;
			TipoDificuldade = tipoDificuldade;
		}
	}
}
