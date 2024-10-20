using System.ComponentModel.DataAnnotations;

namespace MovieStoreMvc.Models.Domain
{
    public class MovieGenre
    {
        //One to many because one movie can have many genre
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int GenreId { get; set; }
    }
}
