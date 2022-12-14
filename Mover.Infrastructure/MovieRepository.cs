using Mover.Application;
using Mover.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mover.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MoverDbContext _moverDbContext;
        public MovieRepository(MoverDbContext moverDbContext)
        {
            _moverDbContext = moverDbContext;
        }
        public Movie CreateMovie(Movie movie)
        {
            _moverDbContext.Movies.Add(movie);
            _moverDbContext.SaveChanges();
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            return _moverDbContext.Movies.ToList();
        }
    }
}
