﻿using Aula2.DTO.AtualizarProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2.UseCase
{
    public interface IAtualizarProdutoUseCase
    {
        AtualizarProdutoResponse Executar(AtualizarProdutoRequest request);
    }
}
