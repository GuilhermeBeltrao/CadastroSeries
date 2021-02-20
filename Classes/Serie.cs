using System;

namespace CadastroSeries
{
    public class Serie : BaseEntity
    {
        // attributes
        private Genre Genre { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }

        private bool IsDeleted { get; set; }

        // methods
        public Serie(int id, string title, string description,  int year, Genre genre)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Year = year;
            this.Genre = genre;
            this.IsDeleted = false;
        }
        public override string ToString()
        {
            string ret = "";
            ret += "Genre: " + this.Genre + Environment.NewLine;
            ret += "Title: " + this.Title + Environment.NewLine;
            ret += "Description: " + this.Description + Environment.NewLine;
            ret += "Year: " + this.Year + Environment.NewLine;
            return ret;
        }

        public void Remove()
        {
            this.IsDeleted = true;
        }
    }
}