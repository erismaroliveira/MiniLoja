using MiniLoja.Business.Interfaces;
using MiniLoja.Business.Models;
using MiniLoja.Business.Models.Validations;
using System;
using System.Threading.Tasks;

namespace MiniLoja.Business.Services
{

    public class ProdutoService : BaseService, IProdutoService
    {
        public async Task Adicionar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;
        }

        public async Task Atualizar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
