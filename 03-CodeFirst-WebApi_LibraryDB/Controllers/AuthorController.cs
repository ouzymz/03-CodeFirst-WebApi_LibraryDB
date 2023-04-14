using _03_CodeFirst_WebApi_LibraryDB.DTO_s.AuthorDTOs;
using _03_CodeFirst_WebApi_LibraryDB.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _03_CodeFirst_WebApi_LibraryDB.Controllers
{



    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        LibraryDBContext _db;
        public AuthorController(LibraryDBContext db)
        {
            _db = db;
        }
        [HttpGet]
        [Route("GetAll")]
        public ActionResult<IEnumerable<AuthorDTO>> GetAll()
        {
            List<AuthorDTO> authors = _db.Authors.Select(x => new AuthorDTO
            {
                Id=x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName
            }).ToList();

            if (authors == null)
                return NotFound();
            return authors;

        }

        [HttpGet]
        [Route("AuthorDetails")]
        public ActionResult<AuthorDTO> GetAuthor(int id)
        {
            Author author = _db.Authors.FirstOrDefault(x => x.Id == id);
            if (author == null)
                return NotFound();
            AuthorDTO authorDTO = new AuthorDTO()
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName
            };
            return Ok(authorDTO);
        }
    }
}
