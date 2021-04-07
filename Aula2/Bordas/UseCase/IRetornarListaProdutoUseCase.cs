using Aula2.DTO.RetornarListaProdutos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2.UseCase
{
    public interface IRetornarListaProdutoUseCase
    {
        RetornarListaProdutoResponse Executar(RetornarListaProdutoRequest request);
    }
}
