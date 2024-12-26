using formacao_eisnt_receita.Domain.Categorias;
using formacao_eisnt_receita.Domain.Ingredientes;
using formacao_eisnt_receita.Utilities;
using System;
using System.Collections.Generic;

namespace formacao_eisnt_receita.Domain.Receitas
{
	public class Receita
	{
		Categoria CategoriaNome { get; set; }
		List<Ingrediente> Ingredientes { get; set; }
		public string Nome { get; set; } = string.Empty;
		public int QuantidadePessoas { get; set; }
		public TimeSpan TempoPreparacao { get; set; }
		public TipoDificuldade TipoDificuldade { get; }

		/// <summary>
		/// Construtor com parâmetros para inicialização.
		/// </summary>
		public Receita(Categoria categoriaNome, List<Ingrediente> ingredientes, string nome, int quantidadePessoas, TimeSpan tempoPreparacao, TipoDificuldade tipoDificuldade)
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
