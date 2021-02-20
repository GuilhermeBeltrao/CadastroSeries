using System;
using System.Collections.Generic;
using CadastroSeries.Interface;
namespace CadastroSeries
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> serieList = new List<Serie>();
        public void Add(Serie entity)   // DONE
        {
            serieList.Add(entity);
        }

        public List<Serie> List()   // DONE       
        {
            return serieList;
        }

        public int NextId()    // DONE
        {
            return serieList.Count;
        }

        public void Remove(int id)    // DONE 
        {
            serieList[id].Remove();
        }

        public Serie ReturnById(int id)    // DONE
        {
            return serieList[id];
        }

        public void Update(int id, Serie entity)    // DONE
        {
            serieList[id] = entity;
        }
    }
}