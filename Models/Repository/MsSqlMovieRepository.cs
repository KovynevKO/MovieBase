using Microsoft.EntityFrameworkCore;
using MovieBase.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MovieBase.Models.Repository
{
    public class MsSqlMovieRepository : MsSqlRepository<Movie>, IMovieRepository
    {
        public MsSqlMovieRepository(ApplicationDbContext context) : base(context) { }

        public IQueryable<Movie> GetMovies()
        {
            return db.Movies;
        }

        public async Task<Movie> GetMovieFullInfo(int id)
        {
            return await db.Movies.Include(m => m.Images).Include(m => m.ServicesRating).
                Include(m => m.Countries).Include(m => m.Genres).Include(m => m.MovieRewards).ThenInclude(m => m.Reward).
                Include(m => m.Evaluations).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
