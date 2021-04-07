using Aula2.Bordas.Repositorios;
using Aula2.DTO.AtualizarProduto;
using Aula2.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2.UseCase
{
    public class AtualizarProdutoUseCase : IAtualizarProdutoUseCase
    {
        private IRepositorioProdutos _repositorioProdutos;
        public AtualizarProdutoResponse Executar(AtualizarProdutoRequest request)
        {
            _repositorioProdutos.Add(request);
        }
    }
}
