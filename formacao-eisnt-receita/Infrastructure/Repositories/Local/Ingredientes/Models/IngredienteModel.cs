using formacao_eisnt_receita.Utilities;

namespace formacao_eisnt_receita.Infrastructure.Repositories.Local.Ingredientes.Models
{
    /// <summary>
    /// Modelo de ingrediente.
    /// </summary>
    public class IngredienteModel
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
        public IngredienteModel(string nome, int quantidade, UnidadeDeMedida unidadeDeMedida)
        {
            Nome = nome;
            Quantidade = quantidade;
            UnidadeDeMedida = unidadeDeMedida;
        }
    }
}