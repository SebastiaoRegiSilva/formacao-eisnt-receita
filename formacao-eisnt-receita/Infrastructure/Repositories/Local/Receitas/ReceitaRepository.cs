using formacao_eisnt_receita.Infrastructure.Repositories.Local.Receitas.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace formacao_eisnt_receita.Infrastructure.Repositories.Local.Receitas
{
	public class ReceitaRepository
	{
		private readonly string _caminhoArquivo = @"..\..\..\..\Data\ReceitaData\receitaDados.xml";

		public ReceitaRepository()
		{
			if (!File.Exists(_caminhoArquivo))
				Salvar(new List<ReceitaModel>()); // Cria o arquivo inicial vazio.
		}

		public List<ReceitaModel> ObterTodos()
		{
			if (!File.Exists(_caminhoArquivo))
				return new List<ReceitaModel>();

			var serializer = new XmlSerializer(typeof(List<ReceitaModel>));
			try
			{
				using (var stream = new FileStream(_caminhoArquivo, FileMode.Open))
					return (List<ReceitaModel>)serializer.Deserialize(stream);

			}
			catch
			{
				// Retorna uma lista vazia em caso de erro na desserialização.1
				return new List<ReceitaModel>();
			}
		}

		public void Adicionar(ReceitaModel receita)
		{
			var receitas = ObterTodos();
			receitas.Add(receita);
			Salvar(receitas);
		}

		public void Atualizar(ReceitaModel receitaAtualizada)
		{
			var receitas = ObterTodos();
			var receita = receitas.FirstOrDefault(p => p.Nome == receitaAtualizada.Nome);
			if (receita != null)
			{
				receita.Nome = receitaAtualizada.Nome;
				Salvar(receitas);
			}
		}

		public void Deletar(string nome)
		{
			var receitas = ObterTodos();
			var receita = receitas.FirstOrDefault(p => p.Nome == nome);
			if (receita != null)
			{
				receitas.Remove(receita);
				Salvar(receitas);
			}
		}

		private void Salvar(List<ReceitaModel> receitas)
		{
			var serializer = new XmlSerializer(typeof(List<ReceitaModel>));
			using (var stream = new FileStream(_caminhoArquivo, FileMode.Create))
			{
				serializer.Serialize(stream, receitas);
			}
		}
	}
}
