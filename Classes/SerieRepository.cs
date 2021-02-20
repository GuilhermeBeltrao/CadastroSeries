using System;
using System.Collections.Generic;
using CadastroSeries.Interface;
namespace CadastroSeries
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> listSeries = new List<Serie>();
        public void Add(Serie entity)   // DONE
        {
            listSeries.Add(entity);
        }

        public List<Serie> List()   // DONE       
        {
            return listSeries;
        }

        public int NextId()    // DONE
        {
            return listSeries.Count;
        }

        public void Remove(int id)    // DONE 
        {
            listSeries[id].Remove();
        }

        public Serie ReturnById(int id)    // DONE
        {
            return listSeries[id];
        }

        public void Update(int id, Serie entity)    // DONE
        {
            listSeries[id] = entity;
        }
    }
}