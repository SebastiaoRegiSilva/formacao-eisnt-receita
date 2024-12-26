using System;
using System.ComponentModel;
using System.Linq;

namespace formacao_eisnt_receita.Helpers
{
	/// <summary>
	/// Utilização as descrições de Enums.
	/// </summary>
	public static class EnumHelper
	{
		public static string GetEnumDescription(Enum value)
		{
			var field = value.GetType().GetField(value.ToString());
			var attribute = field.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault() as DescriptionAttribute;

			return attribute?.Description ?? value.ToString();
		}
	}
}
