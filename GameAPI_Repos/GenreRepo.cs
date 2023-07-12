using GameAPI.EF;
using Models.Entities_POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAPI_Repos
{
    public class GenreRepo
    {
        private DataContext _context;
        public GenreRepo(DataContext context)
        {
            _context = context;
        }

        public void CreateGenre(Genre g)
        {
            _context.Genres.Add(g);
            _context.SaveChanges();
        }

        public IEnumerable<Genre> GetAll()
        {
            return _context.Genres;
        }
        public Genre GetById(int id)
        {
            return _context.Genres.FirstOrDefault(g => g.Id == id);
        }
    }
}
