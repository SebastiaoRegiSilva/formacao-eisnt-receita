using formacao_eisnt_ingrediente.Infrastructure.Repositories.Local.Ingredientes;
using formacao_eisnt_receita.Infrastructure.Repositories.Local.Categorias;
using formacao_eisnt_receita.Infrastructure.Repositories.Local.Categorias.Models;
using formacao_eisnt_receita.Infrastructure.Repositories.Local.Ingredientes.Models;
using formacao_eisnt_receita.Infrastructure.Repositories.Local.Receitas;
using formacao_eisnt_receita.Utilities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace formacao_eisnt_receita.Domain.Receitas
{
	public class ReceitaService
	{
		/// <summary>Repositório para armazenamento dos ingredientes.</summary>
		private readonly IngredienteRepository _ingredienteRep;

		/// <summary>Repositório para armazenamento das categorias.</summary>
		private readonly CategoriaRepository _categoriaRep;

		/// <summary>Repositório para armazenamento das receitas.</summary>
		private readonly ReceitaRepository _receitaRep;

		/// <summary>
		/// Construtor com injeção de dependência.
		/// </summary>
		/// <param name="ingredienteRep">Repositório para armazenamento dos ingredientes.</param>
		/// <param name="categoriaRepository">Repositório para armazenamento das categorias.</param>
		public ReceitaService(IngredienteRepository ingredienteRep, CategoriaRepository categoriaRepository, IngredienteRepository ingredienteRepository)
		{
			_ingredienteRep = ingredienteRep;
			_categoriaRep = categoriaRepository;
			_ingredienteRep = ingredienteRepository;
		}

		public void CadastrarReceita(CategoriaModel categoriaNome, List<IngredienteModel> ingredientes, string nome, int quantidadePessoas, TimeSpan tempoPreparacao, TipoDificuldade tipoDificuldade)
		{
			
		}

		/// <summary>Exclui no repositório todas receitas cadastradas.</summary>
		public void ExcluirTodosRegistros()
		{

		}

	}
}
