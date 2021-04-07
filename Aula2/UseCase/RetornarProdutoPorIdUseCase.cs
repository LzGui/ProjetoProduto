using Aula2.Bordas.Repositorios;
using Aula2.DTO.RetornarProdutoPorId;
using Aula2.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2.UseCase
{
    public class RetornarProdutoPorIdUseCase : IRetornarProdutoPorIdUseCase
    {
        private IRepositorioProdutos _repositorioProdutos;

        public RetornarProdutoPorIdResponse Executar(RetornarProdutoPorIdRequest request)
        {
            _repositorioProdutos.Add(request);
        }
    }
}

