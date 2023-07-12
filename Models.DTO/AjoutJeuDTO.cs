using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class AjoutJeuDTO
    {
        public string Titre { get; set; }
        public int Note { get; set; }
        public int AnneeSortie { get; set; }
        public string Description { get; set; }
        public int GenreId { get; set; }
    }
}
