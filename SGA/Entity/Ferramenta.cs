using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SGA.Entity
{
    public class Ferramenta
    {
        private string i_codFerramenta;
        private string i_nomeFerramenta;
        private DateTime i_dtAquisicao;
        private DateTime i_dtDesativacao;
        private string i_codFabricante;
        private string i_codGrupo;
        private string i_codSituacao;
        private Image i_imagem;
        private int i_quantidade;
        private string i_nu_serie;
        private string[] i_periodo = { "", "", ""};
        private string i_excluivel;
        private string i_chaveUsuario;

        public string chaveUsuario
        {
            get { return i_chaveUsuario; }
            set { i_chaveUsuario = value; }
        }

        public string excluivel
        {
            get { return i_excluivel; }
            set { i_excluivel = value; }
        }

        public string[] periodo
        {
            get { return i_periodo; }
            set { i_periodo = value; }
        }

        public string nu_serie
        {
            get { return i_nu_serie; }
            set { i_nu_serie = value; }
        }

        public int quantidade
        {
            get { return i_quantidade; }
            set { i_quantidade = value; }
        }

        public Image imagem
        {
            get { return i_imagem; }
            set { i_imagem = value; }
        }

        public string codSituacao
        {
            get { return i_codSituacao; }
            set { i_codSituacao = value; }
        }

        public string codGrupo
        {
            get { return i_codGrupo; }
            set { i_codGrupo = value; }
        }

        public string codFabricante
        {
            get { return i_codFabricante; }
            set { i_codFabricante = value; }
        }

        public DateTime dtDesativacao
        {
            get { return i_dtDesativacao; }
            set { i_dtDesativacao = value; }
        }

        public DateTime dtAquisicao
        {
            get { return i_dtAquisicao; }
            set { i_dtAquisicao = value; }
        }

        public string nomeFerramenta
        {
            get { return i_nomeFerramenta; }
            set { i_nomeFerramenta = value; }
        }

        public string codFerramenta
        {
            get { return i_codFerramenta; }
            set { i_codFerramenta = value; }
        }
    }
}
