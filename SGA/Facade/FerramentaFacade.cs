using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGA.AplicationService;
using SGA.Entity;

namespace SGA.Facade
{
    class FerramentaFacade
    {
        FerramentaAS ferramentaAS = new FerramentaAS();

        public void gravarFerramenta(Ferramenta ferr)
        {
            ferramentaAS.gravarFerramenta(ferr);
        }

        public void manterFabricante(string comando, string valorAntigo, string novoValor)
        {
            ferramentaAS.manterFabricante(comando, valorAntigo, novoValor);
        }

        public Queue preencherCbxFabricante()
        {
            return ferramentaAS.preencherCbxFabricante();
        }

        public void manterGrupo(string comando, string valorAntigo, string novoValor)
        {
            ferramentaAS.manterGrupo(comando, valorAntigo, novoValor);
        }

        public Queue preencherCbxGrupo()
        {
            return ferramentaAS.preencherCbxGrupo();
        }

        public Queue pesquisaFerramenta(Ferramenta ferr)
        {
            return ferramentaAS.pesquisaFerramenta(ferr);
        }

        public Queue preencherCbxSituacao()
        {
            return ferramentaAS.preencherCbxSituacao();
        }

        public void desativaFerramenta(Ferramenta ferramenta)
        {
            ferramentaAS.desativaFerramenta(ferramenta);
        }

        public string setDateTimerPicker()
        {
            return ferramentaAS.setDateTimerPicker();
        }
    }
}
