namespace Programming.Model
{
    public class Song
    {
        private string _songTitle;
        private string _singer;
        private int _durationInSeconds;

        public Song() { }

        public Song(string signer, string songTitle, int durationInSeconds)
        {
            Signer = signer;
            SongTitle = songTitle;
            DurationInSeconds = durationInSeconds;
        }
        public string Signer { get; set; }
        public string SongTitle { get; set; }
        public int DurationInSeconds
        {
            get { return _durationInSeconds; }
            set
            {
                Validator.AssertOnPositiveValue(nameof(DurationInSeconds), value);
                _durationInSeconds = value;
            }
        }
    }
}
