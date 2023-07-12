using GameAPI.EF;
using Microsoft.EntityFrameworkCore;
using Models.Entities_POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAPI_Repos
{
    public class GameRepo
    {
        private DataContext _context;

        public GameRepo(DataContext context)
        {
            _context = context;
        }

        public void AddGame(Jeu jeu)
        {
            _context.Add(jeu);
            _context.SaveChanges();
        }

        public IEnumerable<Jeu> GetAll()
        {
            return _context.Jeux.Include(j => j.Genre);
        }

        public IEnumerable<Jeu> GetByKeywork(string keyword)
        {
            return _context.Jeux.Where(j => j.Titre.Contains(keyword));
        }

        public IEnumerable<Jeu> GetByGenre(int idGenre)
        {
            return _context.Jeux.Where(j => j.GenreId == idGenre);
        }
    }
}
