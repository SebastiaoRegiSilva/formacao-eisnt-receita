using System.ComponentModel;

namespace formacao_eisnt_receita.Utilities
{
	/// <summary>
	/// Dificuldade de preparo da receita.
	/// </summary>
	public enum UnidadeDeMedida
	{
		[Description("Unidade")]
		Unidade = 1,
		[Description("Grama")]
		Grama = 2,
		[Description("Litro")]
		Litro = 3,
		[Description("Mililitros")]
		Mililitros = 4,
		[Description("Quilo")]
		Kilo = 5,
	}
}
