using formacao_eisnt_receita.Infrastructure.Repositories.Local.Categorias.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace formacao_eisnt_receita.Infrastructure.Repositories.Local.Categorias
{
	public class CategoriaRepository
	{
		private readonly string _caminhoArquivo = @"..\..\..\..\Data\CategoriaData\categoriaDados.xml";

		public CategoriaRepository()
		{
			if (!File.Exists(_caminhoArquivo))
				Salvar(new List<CategoriaModel>()); // Cria o arquivo inicial vazio.
		}

		public List<CategoriaModel> ObterTodos()
		{
			if (!File.Exists(_caminhoArquivo))
				return new List<CategoriaModel>();

			var serializer = new XmlSerializer(typeof(List<CategoriaModel>));
			try
			{
				using (var stream = new FileStream(_caminhoArquivo, FileMode.Open))
					return (List<CategoriaModel>)serializer.Deserialize(stream);

			}
			catch
			{
				// Retorna uma lista vazia em caso de erro na desserialização.1
				return new List<CategoriaModel>();
			}
		}

		public void Adicionar(CategoriaModel categoria)
		{
			var categorias = ObterTodos();
			categorias.Add(categoria);
			Salvar(categorias);
		}

		public void Atualizar(CategoriaModel categoriaAtualizada)
		{
			var categorias = ObterTodos();
			var categoria = categorias.FirstOrDefault(p => p.Nome == categoriaAtualizada.Nome);
			if (categoria != null)
			{
				categoria.Nome = categoriaAtualizada.Nome;
				Salvar(categorias);
			}
		}

		public void Deletar(string nome)
		{
			var categorias = ObterTodos();
			var categoria = categorias.FirstOrDefault(p => p.Nome == nome);
			if (categoria != null)
			{
				categorias.Remove(categoria);
				Salvar(categorias);
			}
		}

		private void Salvar(List<CategoriaModel> categorias)
		{
			var serializer = new XmlSerializer(typeof(List<CategoriaModel>));
			using (var stream = new FileStream(_caminhoArquivo, FileMode.Create))
			{
				serializer.Serialize(stream, categorias);
			}
		}
	}
}
