using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities_POCO
{
    public class Jeu
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public int AnneeSortie { get; set; }
        public string Description { get; set; }
        public int Note { get; set; }
        public int GenreId { get; set; }

        public Genre Genre { get; set; }
    }
}
