using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGA.Dao;
using SGA.Entity;

namespace SGA.AplicationService
{
    class FerramentaAS
    {
        FerramentaDao ferramentaDao = new FerramentaDao();

        public void gravarFerramenta(Ferramenta ferr)
        {
            if (ferramentaDao.testFerramentaNSerie(ferr) || ferr.nu_serie == "")
            {
                ferramentaDao.gravarFerramenta(ferr);
            }
            else
            {
                throw new System.ArgumentException("Número de série já cadastrado!\nCorrija o campo.");
            }
        }

        public void manterFabricante(string comando, string valorAntigo, string novoValor)
        {
            ferramentaDao.manterFabricante(comando, valorAntigo,novoValor);
        }

        public void manterGrupo(string comando, string valorAntigo, string novoValor)
        {
            ferramentaDao.manterGrupo(comando, valorAntigo, novoValor);
        }

        public Queue preencherCbxGrupo()
        {
            return ferramentaDao.preencherCbxGrupo();
        }

        public Queue preencherCbxFabricante()
        {
            return ferramentaDao.preencherCbxFabricante();
        }

        public Queue pesquisaFerramenta(Ferramenta ferr)
        {
            return ferramentaDao.pesquisaFerramenta(ferr);
        }

        public Queue preencherCbxSituacao()
        {
            return ferramentaDao.preencherCbxSituacao();
        }

        public void desativaFerramenta(Ferramenta ferramenta)
        {
            if (ferramentaDao.testFerramentaPendencia(ferramenta))
            {
                ferramentaDao.desativaFerramenta(ferramenta);
            }
            else
            {
                throw new System.ArgumentException("Ferramenta com pendência impossível excluir!");
            }
        }

        public string setDateTimerPicker()
        {
            return ferramentaDao.setDateTimerPicker();
        }
    }
}
