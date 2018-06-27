using System;
using System.Collections.Generic;
using System.Linq;
using FilmeLibraryService.Models;

namespace FilmeLibraryService.Repository
{
    public class FilmsRepository
    {
        public string[] descriptions = new string[] { "description 12234 dsfgsdf fgsdfgsd sdfg hrty ety", "sfgsdfg 09788767655443 55 3456 34 56 563 45", "Dghdghdfghdfgdfgh dgh dgf d fghd fghdeyrtetr,ety" };
        public string[] images = new string[] {"https://upload.wikimedia.org/wikipedia/pt/thumb/9/90/Pantera_Negra_%28poster%29.jpg/250px-Pantera_Negra_%28poster%29.jpg",
            "https://i.ytimg.com/vi/fKKbCdz6K8Q/hqdefault.jpg",
            "https://www.radiofly.ws/filmepoze2017/Poster%20Kickboxer%20-%20Retaliation%20(2018).jpg",
            "http://static.cinemagia.ro/img/db/movie/56/71/19/de-ce-eu-958587l.jpg",
            "http://www.x-filme.de/files/filme/cloud-atlas/cloud_atlas.jpg"


        };
        private string[] categories = new string[] { "Trayler", "Fantastic", "Musicle", "Horror", "History", "Moldavian" };

        private string[] countries = new string[] { "MD", "UE", "USA", "RUSSIA", "CHINA" };

        public List<Film> Filme = new List<Film>();

        public FilmsRepository()
        {
            IiniTializeRepo();
        }


        public Film GetByID(int Id)
        {
            var film = from f in Filme
                       where f.Id == Id
                       select f;
            return film.SingleOrDefault<Film>();
        }

        public List<Film> GetAll()
        {
            return Filme;
        }

        public List<Film> GetByCategory(string cate)
        {
            var list = from itm in Filme
                       where itm.Category == cate
                       select itm;
            return list.ToList<Film>();
        }

        public List<Film> GetByName(string name)
        {
            var list = from itar in Filme
                       where itar.Name.Contains(name)
                       select itar;

            return list.ToList();
        }

        public List<string> GetAllCategory()
        {
            var categ = Filme.Select(prop => prop.Category).Distinct().ToList<string>();
            return categ;
        } 

        public void UpdateFilm(Film fil)
        {
            foreach(var itm in Filme)
            {
                if(itm.Id==fil.Id)
                {
                    itm.Name = fil.Name;
                    itm.Image = fil.Image;
                    itm.Country = fil.Country;
                    itm.Description = fil.Description;
                    itm.Category = fil.Category;
                }
            }


        }








        private void IiniTializeRepo()
        {
            Random r = new Random();
            for (int i = 0; i < 100;i++)
            {
                Filme.Add(new Film()
                {
                    Id = i,
                    Name="Name Film"+i,
                    Description=descriptions[r.Next(descriptions.Length)],
                    Category=categories[r.Next(categories.Length)],
                    Image=images[r.Next(images.Length)],
                    Country=countries[r.Next(countries.Length)]

                });
            }

        }
    }
   
}
