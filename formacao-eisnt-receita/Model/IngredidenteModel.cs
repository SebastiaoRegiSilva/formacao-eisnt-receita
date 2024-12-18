using formacao_eisnt_receita.Utilities;

namespace formacao_eisnt_receita.Model
{
	/// <summary>
	/// Modelo de ingrediente.
	/// </summary>
	public class IngredidenteModel
	{
		public string Nome { get; set; } = string.Empty;
        public int Quantidade { get; set; }
		public UnidadeDeMedidade UnidadeDeMedidade { get;}

		/// <summary>
		/// Construtor com parâmetros para inicialização.
		/// </summary>
		/// <param name="nome">Nome do ingrediente.</param>
		/// <param name="quantidade">Quantidade a ser utilizada.</param>
		/// <param name="unidadeDeMedidade">Tipo de unidade de medida do ingrediente.</param>
		public IngredidenteModel(string nome, int quantidade, UnidadeDeMedidade unidadeDeMedidade)
		{
			Nome = nome;
			Quantidade = quantidade;
			UnidadeDeMedidade = unidadeDeMedidade;
		}
	}
}