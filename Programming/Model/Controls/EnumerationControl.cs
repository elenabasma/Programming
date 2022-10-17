using System;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Controls
{
    public partial class controlEnumeration : UserControl
    {
        public controlEnumeration()
        {
            InitializeComponent();

            Array typeValues = Enum.GetValues(typeof(Enums));
            foreach (Enums value in typeValues)
            {
                listBoxEnums.Items.Add(value);
            }
            listBoxEnums.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxValues.Items.Clear();
            Array enumValues;

            switch ((Enums)listBoxEnums.SelectedItem)
            {
                case Enums.Weekday:
                    enumValues = Enum.GetValues(typeof(Weekday));
                    break;

                case Enums.Genres:
                    enumValues = Enum.GetValues(typeof(Genres));
                    break;

                case Enums.Colors:
                    enumValues = Enum.GetValues(typeof(Colors));
                    break;

                case Enums.StudyForm:
                    enumValues = Enum.GetValues(typeof(StudyForm));
                    break;

                case Enums.SmartphoneManufacturers:
                    enumValues = Enum.GetValues(typeof(SmartphoneManufacturers));
                    break;

                case Enums.Seasons:
                    enumValues = Enum.GetValues(typeof(Seasons));
                    break;

                default:
                    throw new NotImplementedException();
            }
            foreach (var value in enumValues)
            {
                listBoxValues.Items.Add(value);
            }
        }
        private void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxValues.SelectedItem == null) return;

            textBoxIntValue.Text = ((int)listBoxValues.SelectedItem).ToString();
        }
    }
}
