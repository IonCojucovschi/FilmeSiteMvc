using System;
namespace FilmeLibraryService.Models
{
    public class Film:Entity
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public string Category { get; set; }
    }
}
