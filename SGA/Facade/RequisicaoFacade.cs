﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGA.Entity;
using SGA.AplicationService;

namespace SGA.Facade
{
    class RequisicaoFacade
    {
        RequisicaoAS requisicaoAs = new RequisicaoAS();

        public void gravarRequisicao(Requisicao requisicao)
        {
            requisicaoAs.gravarRequisicao(requisicao);
        }
    }
}