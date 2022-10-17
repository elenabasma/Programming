using System;
using Programming.Model;
using Programming.Model.Enums;
using System.Windows.Forms;
using Programming.Model.Movies;
using System.Collections.Generic;

namespace Programming.View.Controls
{
    public partial class controlMovies : UserControl
    {
        private const int ElementsCount = 5;
        private List<Movie> _movies;
        private Movie _currentMovie;
        public controlMovies()
        {
            InitializeComponent();

            _movies = InitMovies();
            listBoxMovie.SelectedIndex = 0;
        }

        private List<Movie> InitMovies()
        {
            List<Movie> movies = new List<Movie>();
            var genres = Enum.GetValues(typeof(Genres));

            for (int i = 0; i < ElementsCount; i++)
            {
                _currentMovie = MovieFactory.Random();
                movies.Add(_currentMovie);
                listBoxMovie.Items.Add($"Movie {_currentMovie.Id}");
            }
            return movies;
        }

        private int FindMovieWithMaxRating(List<Movie> movies)
        {
            int maxRatingIndex = 0;
            double max = 0;
            for (int i = 0; i < ElementsCount; i++)
            {
                if (movies[i].Rating > max)
                {
                    max = movies[i].Rating;
                    maxRatingIndex = i;
                }
            }
            return maxRatingIndex;
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexMovie = listBoxMovie.SelectedIndex;
            _currentMovie = _movies[selectedIndexMovie];
            textBoxMovieTitle.Text = _currentMovie.Title;
            textBoxMovieGenre.Text = _currentMovie.Genre;
            textBoxYearOfRelease.Text = _currentMovie.YearOfRelease.ToString();
            textBoxMovieDuration.Text = _currentMovie.DurationMinutes.ToString();
            textBoxMovieRating.Text = _currentMovie.Rating.ToString();
        }

        private void TitleMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            string titleMovie = textBoxMovieTitle.Text;
            _currentMovie.Title = titleMovie;
        }

        private void GenreMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            string genreMovie = textBoxMovieGenre.Text;
            _currentMovie.Genre = genreMovie;
        }

        private void RatingMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentRating = textBoxMovieRating.Text;
                double ratingMovie = double.Parse(currentRating);
                _currentMovie.Rating = ratingMovie;
            }
            catch
            {
                textBoxMovieRating.BackColor = AppColors.ErrorColor;
                return;
            }
            textBoxMovieRating.BackColor = AppColors.CorrectColor;
        }

        private void ReleaseYearMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentReleaseYear = textBoxYearOfRelease.Text;
                int releaseYearMovie = int.Parse(currentReleaseYear);
                _currentMovie.YearOfRelease = releaseYearMovie;
            }
            catch
            {
                textBoxYearOfRelease.BackColor = AppColors.ErrorColor;
                return;
            }
            textBoxYearOfRelease.BackColor = AppColors.CorrectColor;
        }

        private void DurationMinutesMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentDurationMinutes = textBoxMovieDuration.Text;
                int durationMinutesMovie = int.Parse(currentDurationMinutes);
                _currentMovie.DurationMinutes = durationMinutesMovie;
            }
            catch
            {
                textBoxMovieDuration.BackColor = AppColors.ErrorColor;
                return;
            }
            textBoxMovieDuration.BackColor = AppColors.CorrectColor;
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            int findMaxRatingIndex = FindMovieWithMaxRating(_movies);
            listBoxMovie.SelectedIndex = findMaxRatingIndex;
        }
    }
}
