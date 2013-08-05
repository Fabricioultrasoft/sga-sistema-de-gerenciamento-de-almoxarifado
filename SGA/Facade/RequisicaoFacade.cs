using System;
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

        public List<Requisicao> pesquisarRequisicao(Requisicao objRequisicao)
        {
            return requisicaoAs.pesquisarRequisicao(objRequisicao);
        }

        public string setDateTimerPicker()
        {
            return requisicaoAs.setDateTimerPicker();
        }

        public void finalizarRequisicao(Requisicao requisicao)
        {
            requisicaoAs.finalizarRequisicao(requisicao);
        }
    }
}
