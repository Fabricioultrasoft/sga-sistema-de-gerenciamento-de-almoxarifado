﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGA.Facade;

namespace SGA.Entity
{
    public class Requisicao
    {
        private int i_codRequisicao;
        private DateTime i_dtRequisicao;
        private DateTime i_dtBaixa;
        private List<Ferramenta> i_ferramentas = new List<Ferramenta>();
        private List<Funcionario> i_funcionario = new List<Funcionario>();
        private int i_matFuncRequisicao;
        private int i_matFuncBaixa;
        private string i_situacao;
        private string[] i_periodo = { "", "" };
        private string i_tipoPeriodo;

        public string tipoPeriodo
        {
            get { return i_tipoPeriodo; }
            set { i_tipoPeriodo = value; }
        }

        public string[] periodo
        {
            get { return i_periodo; }
            set { i_periodo = value; }
        }

        public string situacao
        {
            get { return i_situacao; }
            set { i_situacao = value; }
        }

        internal List<Funcionario> funcionario
        {
            get { return i_funcionario; }
            set { i_funcionario = value; }
        }

        internal List<Ferramenta> ferramentas
        {
            get { return i_ferramentas; }
            set { i_ferramentas = value; }
        }

        public int matFuncBaixa
        {
            get { return i_matFuncBaixa; }
            set { i_matFuncBaixa = value; }
        }

        public int matFuncRequisicao
        {
            get { return i_matFuncRequisicao; }
            set { i_matFuncRequisicao = value; }
        }

        public DateTime dtBaixa
        {
            get { return i_dtBaixa; }
            set { i_dtBaixa = value; }
        }

        public DateTime dtRequisicao
        {
            get { return i_dtRequisicao; }
            set { i_dtRequisicao = value; }
        }

        public int codRequisicao
        {
            get { return i_codRequisicao; }
            set { i_codRequisicao = value; }
        }
    }
}
