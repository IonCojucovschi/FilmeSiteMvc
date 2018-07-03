using System;
namespace FilmeLibraryService.Models
{
    public class Film : Entity
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public string Category { get; set; }
    }


    public class Custommer : Entity
    {
        public string nome { get; set; }
        public string cognome { get; set; }
        public string posizione { get; set; }
        public string societa { get; set; }
        public string solution { get; set; }
        public string indirizzo { get; set; }
        public string citta { get; set; }
        public string cap { get; set; }
        public string dipartimento { get; set; }
        public string stanza { get; set; }
        public string mail { get; set; }
        public string telefono { get; set; }
        public string mobile { get; set; }
        public string mobilepublico { get; set; }
        public string fax { get; set; }
        public string interno { get; set; }
        public string segretaria { get; set; }
        public string atributo1 { get; set; }
    }

}
