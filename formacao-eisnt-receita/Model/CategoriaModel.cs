namespace formacao_eisnt_receita.Model
{
	/// <summary>
	/// Categoria da receita.(Carne, Peixe, Marisco, Pastelaria, Sobremesas, etc.) 
	/// </summary>
	public class CategoriaModel
	{
		public int Numero { get; set; }
		public string Nome{ get; set;} = string.Empty;

		/// <summary>
		/// Construtor com parâmetros para inicialização.
		/// </summary>
		public CategoriaModel(int numero, string nome)
		{
			Numero = numero;
			Nome = nome;
		}
	}
}