using System;
using System.Collections.Generic;
using Cadatro.Net;

namespace Cadatro.Net.Classes
{
    public class SeriesRepositorio : IRepositorio<Series>
    {
        private List<Series> listaSeries = new List<Series>();
        public void Atualizar(int id, Series objeto)
        {
            listaSeries[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaSeries[id].Excluir();
        }

        public void Insere(Series objeto)
        {
            listaSeries.Add(objeto);
        }

        public List<Series> Lista()
        {
            return listaSeries;
        }

        public int proximoId()
        {
            return listaSeries.Count;
        }

        public Series RetornarPorId(int id)
        {
            return listaSeries[id];
        }
    }
}