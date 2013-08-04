using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGA.Facade;
using SGA.Entity;

namespace SGA.Delegate
{
    class RequisicaoDelegate
    {
        RequisicaoFacade requisicaoFacade = new RequisicaoFacade();

        public void gravarRequisicao(Requisicao requisicao)
        {
            requisicaoFacade.gravarRequisicao(requisicao);
        }
        public List<Requisicao> pesquisarRequisicao()
        {
            return requisicaoFacade.pesquisarRequisicao();
        }
    }
}
