using System.Collections.Generic;

namespace Exemplo_Colecoes.helper
{
    public class OperacoesLista
    {
        public void ImprimirLista(List<string> lista)
        {
            for (var i = 0; i < lista.Count; i++)
            {
                System.Console.WriteLine($"INDICE :{i} estado: {lista[i]}");
            }
        }
    }
}