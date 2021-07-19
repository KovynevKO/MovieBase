using MovieBase.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBase.Models.Repository
{
    public interface IMovieRepository : IRepository<Movie>
    {
        public IQueryable<Movie> GetMovies();
        public Task<Movie> GetMovieFullInfo(int id);
    }

    
}
