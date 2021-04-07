using Aula2.Bordas.Repositorios;
using Aula2.DTO.RemoverProduto;
using Aula2.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2.UseCase
{
    public class RemoverProdutoUseCase : IRemoverProdutoUseCase
    {
        private IRepositorioProdutos _repositorioProdutos;
        public RemoverProdutoResponse Executar(RemoverProdutoRequest request)
        {
            _repositorioProdutos.Add(request);
        }
    }
}
