using Aula2.DTO.RetornarProdutoPorId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2.UseCase
{
    public interface IRetornarProdutoPorIdUseCase
    {
        RetornarProdutoPorIdResponse Executar(RetornarProdutoPorIdRequest request);
    }
}
