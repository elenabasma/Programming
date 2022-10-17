using System;

namespace Programming.Model
{
    public class Movie
    {
        private static int _MoviesCount;
        private int _yearOfRelease;
        private double _rating;
        private int _durationInMinutes;
        private int _id;
        public Movie()
        {
            _MoviesCount++;
            _id = _MoviesCount;
        }

        public Movie(int yearOfRelease, int durationInMinutes, int rating, string title, string genre)
        {
            YearOfRelease = yearOfRelease;
            DurationMinutes = durationInMinutes;
            Rating = rating;
            Title = title;
            Genre = genre;
            _MoviesCount++;
            _id = _MoviesCount;
        }
        public int Id { get { return _id; } }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int DurationMinutes
        {
            get { return _durationInMinutes; }
            set
            {
                Validator.AssertOnPositiveValue(nameof(DurationMinutes), value);
                _durationInMinutes = value;
            }
        }
        public int YearOfRelease
        {
            get { return _yearOfRelease; }
            set
            {
                Validator.AssertValueInRange(nameof(YearOfRelease), value, 1990, DateTime.Now.Year);
                _yearOfRelease = value;
            }
        }
        public double Rating
        {
            get { return _rating; }
            set
            {
                Validator.AssertValueInRange(nameof(Rating), value, 0, 10);
                _rating = value;
            }
        }
    }
}
