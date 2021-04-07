using Aula2.Bordas.Repositorios;
using Aula2.DTO.RetornarListaProdutos;
using Aula2.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2.UseCase
{
    public class RetornarListaProdutoUseCase : IRetornarListaProdutoUseCase
    {
        private IRepositorioProdutos _repositorioProdutos;

        public RetornarListaProdutoResponse Executar(RetornarListaProdutoRequest request)
        {
            _repositorioProdutos.Add(request);
        }
    }
}
