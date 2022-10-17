
namespace Programming.View.Controls
{
    partial class controlMovies
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов
        private void InitializeComponent()
        {
            this.labelMovieDuration = new System.Windows.Forms.Label();
            this.textBoxMovieDuration = new System.Windows.Forms.TextBox();
            this.labelYearOfRelease = new System.Windows.Forms.Label();
            this.textBoxYearOfRelease = new System.Windows.Forms.TextBox();
            this.buttonMovieFind = new System.Windows.Forms.Button();
            this.labelMovieRating = new System.Windows.Forms.Label();
            this.labelMovieGenre = new System.Windows.Forms.Label();
            this.labelMovieTitle = new System.Windows.Forms.Label();
            this.textBoxMovieRating = new System.Windows.Forms.TextBox();
            this.textBoxMovieGenre = new System.Windows.Forms.TextBox();
            this.textBoxMovieTitle = new System.Windows.Forms.TextBox();
            this.listBoxMovie = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelMovieDuration
            // 
            this.labelMovieDuration.AutoSize = true;
            this.labelMovieDuration.Location = new System.Drawing.Point(217, 207);
            this.labelMovieDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMovieDuration.Name = "labelMovieDuration";
            this.labelMovieDuration.Size = new System.Drawing.Size(60, 16);
            this.labelMovieDuration.TabIndex = 9;
            this.labelMovieDuration.Text = "Duration:";
            // 
            // textBoxMovieDuration
            // 
            this.textBoxMovieDuration.Location = new System.Drawing.Point(220, 227);
            this.textBoxMovieDuration.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMovieDuration.Name = "textBoxMovieDuration";
            this.textBoxMovieDuration.Size = new System.Drawing.Size(132, 22);
            this.textBoxMovieDuration.TabIndex = 8;
            this.textBoxMovieDuration.TextChanged += new System.EventHandler(this.DurationMinutesMovieTextBox_TextChanged);
            // 
            // labelYearOfRelease
            // 
            this.labelYearOfRelease.AutoSize = true;
            this.labelYearOfRelease.Location = new System.Drawing.Point(217, 161);
            this.labelYearOfRelease.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYearOfRelease.Name = "labelYearOfRelease";
            this.labelYearOfRelease.Size = new System.Drawing.Size(102, 16);
            this.labelYearOfRelease.TabIndex = 7;
            this.labelYearOfRelease.Text = "Year of release:";
            // 
            // textBoxYearOfRelease
            // 
            this.textBoxYearOfRelease.Location = new System.Drawing.Point(220, 181);
            this.textBoxYearOfRelease.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxYearOfRelease.Name = "textBoxYearOfRelease";
            this.textBoxYearOfRelease.Size = new System.Drawing.Size(132, 22);
            this.textBoxYearOfRelease.TabIndex = 6;
            this.textBoxYearOfRelease.TextChanged += new System.EventHandler(this.ReleaseYearMovieTextBox_TextChanged);
            // 
            // buttonMovieFind
            // 
            this.buttonMovieFind.Location = new System.Drawing.Point(220, 399);
            this.buttonMovieFind.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMovieFind.Name = "buttonMovieFind";
            this.buttonMovieFind.Size = new System.Drawing.Size(132, 28);
            this.buttonMovieFind.TabIndex = 1;
            this.buttonMovieFind.Text = "Find";
            this.buttonMovieFind.UseVisualStyleBackColor = true;
            this.buttonMovieFind.Click += new System.EventHandler(this.FindMovieButton_Click);
            // 
            // labelMovieRating
            // 
            this.labelMovieRating.AutoSize = true;
            this.labelMovieRating.Location = new System.Drawing.Point(217, 115);
            this.labelMovieRating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMovieRating.Name = "labelMovieRating";
            this.labelMovieRating.Size = new System.Drawing.Size(49, 16);
            this.labelMovieRating.TabIndex = 5;
            this.labelMovieRating.Text = "Rating:";
            // 
            // labelMovieGenre
            // 
            this.labelMovieGenre.AutoSize = true;
            this.labelMovieGenre.Location = new System.Drawing.Point(217, 69);
            this.labelMovieGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMovieGenre.Name = "labelMovieGenre";
            this.labelMovieGenre.Size = new System.Drawing.Size(47, 16);
            this.labelMovieGenre.TabIndex = 4;
            this.labelMovieGenre.Text = "Genre:";
            // 
            // labelMovieTitle
            // 
            this.labelMovieTitle.AutoSize = true;
            this.labelMovieTitle.Location = new System.Drawing.Point(217, 23);
            this.labelMovieTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMovieTitle.Name = "labelMovieTitle";
            this.labelMovieTitle.Size = new System.Drawing.Size(36, 16);
            this.labelMovieTitle.TabIndex = 1;
            this.labelMovieTitle.Text = "Title:";
            // 
            // textBoxMovieRating
            // 
            this.textBoxMovieRating.Location = new System.Drawing.Point(220, 135);
            this.textBoxMovieRating.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMovieRating.Name = "textBoxMovieRating";
            this.textBoxMovieRating.Size = new System.Drawing.Size(132, 22);
            this.textBoxMovieRating.TabIndex = 3;
            this.textBoxMovieRating.TextChanged += new System.EventHandler(this.RatingMovieTextBox_TextChanged);
            // 
            // textBoxMovieGenre
            // 
            this.textBoxMovieGenre.Location = new System.Drawing.Point(220, 89);
            this.textBoxMovieGenre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMovieGenre.Name = "textBoxMovieGenre";
            this.textBoxMovieGenre.Size = new System.Drawing.Size(132, 22);
            this.textBoxMovieGenre.TabIndex = 2;
            this.textBoxMovieGenre.TextChanged += new System.EventHandler(this.GenreMovieTextBox_TextChanged);
            // 
            // textBoxMovieTitle
            // 
            this.textBoxMovieTitle.Location = new System.Drawing.Point(220, 43);
            this.textBoxMovieTitle.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMovieTitle.Name = "textBoxMovieTitle";
            this.textBoxMovieTitle.Size = new System.Drawing.Size(132, 22);
            this.textBoxMovieTitle.TabIndex = 1;
            this.textBoxMovieTitle.TextChanged += new System.EventHandler(this.TitleMovieTextBox_TextChanged);
            // 
            // listBoxMovie
            // 
            this.listBoxMovie.FormattingEnabled = true;
            this.listBoxMovie.ItemHeight = 16;
            this.listBoxMovie.Location = new System.Drawing.Point(9, 23);
            this.listBoxMovie.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxMovie.Name = "listBoxMovie";
            this.listBoxMovie.Size = new System.Drawing.Size(200, 404);
            this.listBoxMovie.TabIndex = 0;
            this.listBoxMovie.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // controlMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonMovieFind);
            this.Controls.Add(this.textBoxMovieDuration);
            this.Controls.Add(this.labelMovieDuration);
            this.Controls.Add(this.listBoxMovie);
            this.Controls.Add(this.textBoxYearOfRelease);
            this.Controls.Add(this.labelYearOfRelease);
            this.Controls.Add(this.labelMovieTitle);
            this.Controls.Add(this.textBoxMovieTitle);
            this.Controls.Add(this.labelMovieGenre);
            this.Controls.Add(this.textBoxMovieRating);
            this.Controls.Add(this.labelMovieRating);
            this.Controls.Add(this.textBoxMovieGenre);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "controlMovies";
            this.Size = new System.Drawing.Size(421, 482);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMovieDuration;
        private System.Windows.Forms.TextBox textBoxMovieDuration;
        private System.Windows.Forms.Label labelYearOfRelease;
        private System.Windows.Forms.TextBox textBoxYearOfRelease;
        private System.Windows.Forms.Button buttonMovieFind;
        private System.Windows.Forms.Label labelMovieRating;
        private System.Windows.Forms.Label labelMovieGenre;
        private System.Windows.Forms.Label labelMovieTitle;
        private System.Windows.Forms.TextBox textBoxMovieRating;
        private System.Windows.Forms.TextBox textBoxMovieGenre;
        private System.Windows.Forms.TextBox textBoxMovieTitle;
        private System.Windows.Forms.ListBox listBoxMovie;
    }
}
