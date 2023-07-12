using GameAPI_Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Entities_POCO;

namespace GameAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private GenreRepo _genreRepo;
        public GenreController(GenreRepo genreRepo)
        {
            _genreRepo = genreRepo;
        }

        [HttpPost]
        public IActionResult Create(string g)
        {
            _genreRepo.CreateGenre(new Genre { Nom = g});
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_genreRepo.GetAll());
        }
    }
}
