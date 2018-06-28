using System;
using System.Collections.Generic;
using System.Linq;
using FilmeLibraryService.Models;

namespace FilmeLibraryService.Repository
{
    public class FilmsRepository
    {
        public string[] descriptions = new string[] 
        { @"A film, also called a movie, motion picture, moving pícture, theatrical film, or photoplay, is a series of still images that, 
                when shown on a screen, create the illusion of moving images. (See the glossary of motion picture terms.)
        This optical illusion causes the audience to perceive continuous motion between separate objects viewed in rapid succession. 
        The process of filmmaking is both an art and an industry. A film is created by photographing actual scenes with a motion-picture camera,
         by photographing drawings or miniature models using traditional animation techniques, by means of CGI and computer animation, 
        or by a combination of some or all of these techniques, and other visual effects.",
                    @"Films were originally recorded onto plastic film through a photochemical process and then shown through a movie projector
                     onto a large screen. Contemporary films are now often fully digital through the entire process of production, distribution, 
        and exhibition, while films recorded in a photochemical form traditionally included an analogous optical soundtrack (a graphic recording 
        of the spoken words, music and other sounds that accompany the images which runs along a portion of the film exclusively reserved for it,
         and is not projected).", 
                    @"Films are cultural artifacts created by specific cultures. They reflect those cultures, and, in turn, affect them. 
                    Film is considered to be an important art form, a source of popular entertainment, and a powerful medium for educating—or 
        indoctrinating—citizens. The visual basis of film gives it a universal power of communication. Some films have become popular worldwide 
        attractions through the use of dubbing or subtitles to translate the dialog into other languages. Some have criticized the film industry's
         glorification of violence,[2] and have perceived in it the prevalence of a negative attitude toward women.[3][4]

        The individual images that make up a film are called frames. In the projection of traditional celluloid films,
         a rotating shutter causes intervals of darkness as each frame, in turn, is moved into position to be projected, 
        but the viewer does not notice the interruptions because of an effect known as persistence of vision, whereby the 
        eye retains a visual image for a fraction of a second after its source disappears. The perception of motion is due 
        to a psychological effect called the phi phenomenon."
        };



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



        ///orck with content of list 
        public void AddFilm(Film film)
        {
            Filme.Add(film);
        }

        public void DeleteFilm(Film film)
        {
            Filme.RemoveAt(film.Id);
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


        /// <summary>
        /// IiniTializeRepo.
        /// </summary>

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
