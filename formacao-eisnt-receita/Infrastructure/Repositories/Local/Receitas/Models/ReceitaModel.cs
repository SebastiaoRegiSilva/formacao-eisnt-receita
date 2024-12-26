using formacao_eisnt_receita.Infrastructure.Repositories.Local.Categorias.Models;
using formacao_eisnt_receita.Infrastructure.Repositories.Local.Ingredientes.Models;
using formacao_eisnt_receita.Utilities;
using System;
using System.Collections.Generic;

namespace formacao_eisnt_receita.Infrastructure.Repositories.Local.Receitas.Models
{
    /// <summary>
    /// Modelo de receita.
    /// </summary>
    public class ReceitaModel
    {
        CategoriaModel CategoriaNome { get; set; }
        List<IngredienteModel> Ingredientes { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int QuantidadePessoas { get; set; }
        public TimeSpan TempoPreparacao { get; set; }
        public TipoDificuldade TipoDificuldade { get; }

        /// <summary>
        /// Construtor com parâmetros para inicialização.
        /// </summary>
        public ReceitaModel(CategoriaModel categoriaNome, List<IngredienteModel> ingredientes, string nome, int quantidadePessoas, TimeSpan tempoPreparacao, TipoDificuldade tipoDificuldade)
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
