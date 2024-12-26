using System.ComponentModel;

namespace formacao_eisnt_receita.Utilities
{
	/// <summary>
	/// Dificuldade de preparo da receita.
	/// </summary>
	public enum TipoDificuldade
	{
		[Description("Super Fácil")]
		SuperFacil = 1,
		[Description("Fácil")]
		Facil = 2,
		[Description("Médio")]
		Medio = 3,
		[Description("Difícil")]
		Dificil = 4,
		[Description("Super Difícil")]
		SuperDificil = 5,
	}
}
