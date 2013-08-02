using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGA.Facade;
using SGA.Entity;
using System.Collections;

namespace SGA.Delegate
{
    class FerramentaDelegate
    {
        FerramentaFacade ferramentaFacade = new FerramentaFacade();

        public void gravarFerramenta(Ferramenta ferr)
        {
            ferramentaFacade.gravarFerramenta(ferr);
        }

        public void manterFabricante(string comando, string valorAntigo, string novoValor)
        {
            ferramentaFacade.manterFabricante(comando, valorAntigo, novoValor);
        }

        public Queue preencherCbxFabricante()
        {
            return ferramentaFacade.preencherCbxFabricante();
        }

        public void manterGrupo(string comando, string valorAntigo, string novoValor)
        {
            ferramentaFacade.manterGrupo(comando, valorAntigo, novoValor);
        }

        public Queue preencherCbxGrupo()
        {
            return ferramentaFacade.preencherCbxGrupo();
        }

        public Queue preencherCbxSituacao()
        {
            return ferramentaFacade.preencherCbxSituacao();
        }

        public Queue pesquisaFerramenta(Ferramenta ferr)
        {
            return ferramentaFacade.pesquisaFerramenta(ferr);
        }

        public void desativaFerramenta(Ferramenta ferramenta)
        {
            ferramentaFacade.desativaFerramenta(ferramenta);
        }

        public string setDateTimerPicker()
        {
            return ferramentaFacade.setDateTimerPicker();
        }
    }
}
