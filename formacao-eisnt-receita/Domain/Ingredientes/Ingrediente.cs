using formacao_eisnt_receita.Utilities;

namespace formacao_eisnt_receita.Domain.Ingredientes
{
	public class Ingrediente
	{
		public string Nome { get; set; } = string.Empty;
		public int Quantidade { get; set; }
		public UnidadeDeMedida UnidadeDeMedida { get; }

		/// <summary>
		/// Construtor com parâmetros para inicialização.
		/// </summary>
		/// <param name="nome">Nome do ingrediente.</param>
		/// <param name="quantidade">Quantidade a ser utilizada.</param>
		/// <param name="unidadeDeMedida">Tipo de unidade de medida do ingrediente.</param>
		public Ingrediente(string nome, int quantidade, UnidadeDeMedida unidadeDeMedida)
		{
			Nome = nome;
			Quantidade = quantidade;
			UnidadeDeMedida = unidadeDeMedida;
		}
	}
}
