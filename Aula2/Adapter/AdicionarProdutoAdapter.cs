using Aula2.DTO.AdicionarProduto;
using Aula2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2.Adapter
{
    public class AdicionarProdutoAdapter : IAdicionarProdutoAdapter
    {
        public Produto converterRequestParaProduto(AdicionarProdutoRequest request)
        {
            var novoProduto = new Produto();
            novoProduto.nome = request.nome;
            novoProduto.descricao = request.descricao;
            novoProduto.valor = request.valor;

            return novoProduto;
        }
    }
}
