using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGA.Dao;
using SGA.Entity;

namespace SGA.AplicationService
{
    class RequisicaoAS
    {
        RequisicaoDao requisicaoDao = new RequisicaoDao();

        public void gravarRequisicao(Requisicao requisicao)
        {
            requisicaoDao.gravarRequisicao(requisicao);
        }
    }
}
