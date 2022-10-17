using System;
using System.Windows.Forms;
using Programming.Model;
using Programming.Model.Enums;

namespace Programming.View.Controls
{
    public partial class controlSeasonsHandle : UserControl
    {
        public controlSeasonsHandle()
        {
            InitializeComponent();

            Array seasons = Enum.GetValues(typeof(Seasons));
            foreach (Seasons value in seasons)
            {
                comboBoxSeasons.Items.Add(value);
            }
            comboBoxSeasons.SelectedIndex = 0;
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            switch (comboBoxSeasons.SelectedItem)
            {
                case Seasons.Winter:
                    this.BackColor = System.Drawing.Color.Blue;
                    break;
                case Seasons.Spring:
                    this.BackColor = System.Drawing.Color.Green;
                    break;
                case Seasons.Summer:
                    this.BackColor = System.Drawing.Color.Yellow;
                    break;
                case Seasons.Autumn:
                    this.BackColor = System.Drawing.Color.Orange;
                    break;
            }
        }
    }
}
