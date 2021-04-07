using Aula2.Adapter;
using Aula2.Bordas.Repositorios;
using Aula2.DTO.AdicionarProduto;
using Aula2.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2.UseCase
{
    public class AdicionarProdutoUseCase : IAdicionarProdutoUseCase
    {
        private readonly IRepositorioProdutos _repositorioProdutos;
        private readonly IAdicionarProdutoAdapter _adapter;

        public AdicionarProdutoUseCase(IRepositorioProdutos repositorioProdutos, IAdicionarProdutoAdapter adapter)
        {
            _repositorioProdutos = repositorioProdutos;
            _adapter = adapter;
        }
        public AdicionarProdutoResponse Executar(AdicionarProdutoRequest request)
        {
            var response = new AdicionarProdutoResponse();
            try
            {
                var produtoAdicionar = _adapter.converterRequestParaProduto(request);
                _repositorioProdutos.Add(produtoAdicionar);
                response.msg = "Adicionado com sucesso";
                return response;
            }
            catch
            {
                response.msg = "Erro ao adicionar o produto";
            }
        }
    }
}
