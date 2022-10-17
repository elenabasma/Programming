using System;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Controls
{
    public partial class controlWeekdayParsing : UserControl
    {
        public controlWeekdayParsing()
        {
            InitializeComponent();
        }

        private void WeekdayParseButton_Click(object sender, EventArgs e)
        {
            string textWeekdayTextBox = textBoxWeekday.Text;
            Weekday weekday;
            if (Enum.TryParse(textWeekdayTextBox, out weekday))
            {
                labelOutputWeekday.Text = $"Это день недели ({weekday} - {(int)weekday})";
            }
            else
            {
                labelOutputWeekday.Text = "Нет такого дня недели";
            }
        }
    }
}
