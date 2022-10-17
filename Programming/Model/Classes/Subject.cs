namespace Programming.Model
{
    public class Subject
    {
        private int _mark;
        public Subject(string name,string examDate, int mark)
        {
            Name = name;
            ExamDate = examDate;
            Mark = mark;
        }

        public Subject() { }
        public string Name { get; set; }
        public string ExamDate { get; set; }
        public int Mark
        {
            get { return _mark; }
            set
            {
                Validator.AssertValueInRange(nameof(Mark), value, 2, 5);
                _mark = value;
            }
        }
    }
}