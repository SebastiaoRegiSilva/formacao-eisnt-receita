namespace formacao_eisnt_receita.Domain.Categorias
{
	public class Categoria
	{
		public string Nome { get; set; } = string.Empty;

		/// <summary>
		/// Construtor com parâmetros para inicialização.
		/// </summary>
		public Categoria(string nome)
		{
			Nome = nome;
		}
	}
}
