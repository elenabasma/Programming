using System;
using Programming.Model.Enums;

namespace Programming.Model.Movies
{
    public static class MovieFactory
    {
        private static Random random;
        static MovieFactory()
        {
            random = new Random();
        }
        public static Movie Random()
        {
            var genres = Enum.GetValues(typeof(Genres));
            Movie movie = new Movie();
            movie.Rating = random.Next(101) / 10.0;
            movie.YearOfRelease = random.Next(1990, DateTime.Now.Year);
            movie.Genre = genres.GetValue(random.Next(0, genres.Length)).ToString();
            movie.Title = $"Movie {movie.Genre} {movie.YearOfRelease}";
            movie.DurationMinutes = random.Next(40, 200);
            return movie;
        }
    }
}
