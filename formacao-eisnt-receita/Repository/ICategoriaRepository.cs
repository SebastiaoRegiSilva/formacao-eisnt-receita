using formacao_eisnt_receita.Infrastructure.Repositories.Local.Categorias.Models;
using System.Collections.Generic;

namespace formacao_eisnt_receita.Repository
{
    /// <summary>
    /// Interface que padroniza repositório.
    /// </summary>
    public interface ICategoriaRepository
	{
		void Cadastrar(CategoriaModel categoriaModel);
		// void AtualizarCategoria(string antigoNome, string novoNome);
		List<CategoriaModel> ListarCategorias();
	}
}
