using formacao_eisnt_receita.Infrastructure.Repositories.Local.Ingredientes.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace formacao_eisnt_ingrediente.Infrastructure.Repositories.Local.Ingredientes
{
	public class IngredienteRepository
	{
		private readonly string _caminhoArquivo = @"..\..\..\..\Data\IngredienteData\ingredienteDados.xml";

		public IngredienteRepository()
		{
			if (!File.Exists(_caminhoArquivo))
				Salvar(new List<IngredienteModel>()); // Cria o arquivo inicial vazio.
		}

		public List<IngredienteModel> ObterTodos()
		{
			if (!File.Exists(_caminhoArquivo))
				return new List<IngredienteModel>();

			var serializer = new XmlSerializer(typeof(List<IngredienteModel>));
			try
			{
				using (var stream = new FileStream(_caminhoArquivo, FileMode.Open))
					return (List<IngredienteModel>)serializer.Deserialize(stream);

			}
			catch
			{
				// Retorna uma lista vazia em caso de erro na desserialização.1
				return new List<IngredienteModel>();
			}
		}

		public void Adicionar(IngredienteModel ingrediente)
		{
			var ingredientes = ObterTodos();
			ingredientes.Add(ingrediente);
			Salvar(ingredientes);
		}

		public void Atualizar(IngredienteModel ingredienteAtualizada)
		{
			var ingredientes = ObterTodos();
			var ingrediente = ingredientes.FirstOrDefault(p => p.Nome == ingredienteAtualizada.Nome);
			if (ingrediente != null)
			{
				ingrediente.Nome = ingredienteAtualizada.Nome;
				Salvar(ingredientes);
			}
		}

		public void Deletar(string nome)
		{
			var ingredientes = ObterTodos();
			var ingrediente = ingredientes.FirstOrDefault(p => p.Nome == nome);
			if (ingrediente != null)
			{
				ingredientes.Remove(ingrediente);
				Salvar(ingredientes);
			}
		}

		private void Salvar(List<IngredienteModel> ingredientes)
		{
			var serializer = new XmlSerializer(typeof(List<IngredienteModel>));
			using (var stream = new FileStream(_caminhoArquivo, FileMode.Create))
			{
				serializer.Serialize(stream, ingredientes);
			}
		}
	}
}
