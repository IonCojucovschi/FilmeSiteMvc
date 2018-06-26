using System;
using System.Collections.Generic;
using System.Linq;
using FilmeLibraryService.Models;

namespace FilmeLibraryService.Repository
{
    public class FilmsRepository
    {
        public string[] descriptions = new string[] { "description 12234 dsfgsdf fgsdfgsd sdfg hrty ety", "sfgsdfg 09788767655443 55 3456 34 56 563 45", "Dghdghdfghdfgdfgh dgh dgf d fghd fghdeyrtetr,ety" };
        public string[] images = new string[] {"https://www.google.com/url?sa=i&rct=j&q=&esrc=s&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwjB4Yiy_fDbAhUL6aQKHXjFAKEQjRx6BAgBEAU&url=http%3A%2F%2Fwww.neontommy.com%2Fnews%2F2014%2F09%2Fwhy-successful-films-cannes-or-sundance-arent-popular-blockbuster-hits&psig=AOvVaw0LWgaSsLERQCi9VJgGn78i&ust=1530090483243677",
            "https://www.google.com/url?sa=i&rct=j&q=&esrc=s&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwiF0MXT_fDbAhUL6KQKHQxLDpQQjRx6BAgBEAU&url=https%3A%2F%2Fwww.huffingtonpost.com%2F2013%2F06%2F10%2Fhonest-disney-movies_n_3417085.html&psig=AOvVaw0LWgaSsLERQCi9VJgGn78i&ust=1530090483243677",
            "https://www.google.com/url?sa=i&rct=j&q=&esrc=s&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwjN49je_fDbAhUN26QKHScfATwQjRx6BAgBEAU&url=https%3A%2F%2Fmovieweb.com%2Fsuicide-squad-top-ten-movies-list-imdb-2016%2F&psig=AOvVaw0LWgaSsLERQCi9VJgGn78i&ust=1530090483243677",
            "https://www.google.com/url?sa=i&rct=j&q=&esrc=s&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwjJnqfp_fDbAhUSr6QKHb77AGwQjRx6BAgBEAU&url=https%3A%2F%2Fwww.amctheatres.com%2Ftop-ten-movies-of-2018&psig=AOvVaw0LWgaSsLERQCi9VJgGn78i&ust=1530090483243677"
               
        };
        private string[] categories = new string[] {"Trayler","Fantastic","Musicle","Horror","History","Moldavian" };

        private string[] countries = new string[] { "MD", "UE", "USA", "RUSSIA", "CHINA" };
 
        public List<Film> Filme=new List<Film>();

        public FilmsRepository()
        {
            IiniTializeRepo();  
        }


        public Film GetByID(int Id)
        {
            var film = from f in Filme
                    where f.Id==Id
                           select f;
            return film.SingleOrDefault<Film>();
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
