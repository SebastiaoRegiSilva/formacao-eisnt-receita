using formacao_eisnt_receita.Infrastructure.Repositories.Local.Categorias.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace formacao_eisnt_receita.Repository
{
    public class CategoriaRepository : ICategoriaRepository
	{
		private const string FilePath = "categorias.json";

		public void Cadastrar(CategoriaModel categoriaModel)
		{
			var categorias = CarregarCategorias();
			categorias.Add(categoriaModel);
			SalvarCategorias(categorias);
		}

		public List<CategoriaModel> ListarCategorias()
		{
			return CarregarCategorias();
		}

		#region Operação com Json.
		// Método para carregar as categorias do arquivo JSON
		private List<CategoriaModel> CarregarCategorias()
		{
			if (!File.Exists(FilePath))
				return new List<CategoriaModel>();

			var json = File.ReadAllText(FilePath);
			return JsonConvert.DeserializeObject<List<CategoriaModel>>(json) ?? new List<CategoriaModel>();
		}

		// Método para salvar as categorias no arquivo JSON
		private void SalvarCategorias(List<CategoriaModel> categorias)
		{
			var json = JsonConvert.SerializeObject(categorias, Formatting.Indented);
			File.WriteAllText(FilePath, json);
		}
		#endregion
	}
}
