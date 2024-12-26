namespace formacao_eisnt_receita.Infrastructure.Repositories.Local.Categorias.Models
{
    /// <summary>
    /// Categoria da receita.(Carne, Peixe, Marisco, Pastelaria, Sobremesas, etc.) 
    /// </summary>
    public class CategoriaModel
    {
        public string Nome { get; set; } = string.Empty;

        /// <summary>
        /// Construtor com parâmetros para inicialização.
        /// </summary>
        public CategoriaModel(string nome)
        {
            Nome = nome;
        }
    }
}