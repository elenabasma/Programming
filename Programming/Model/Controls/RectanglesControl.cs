using System;
using Programming.Model.Geometry;
using System.Windows.Forms;
using Rectangle = Programming.Model.Geometry.Rectangle;
using Programming.Model;

namespace Programming.View.Controls
{
    public partial class controlRectangles : UserControl
    {
        private const int _elementsCount = 5;
        private Rectangle[] _rectangles;
        private Rectangle _currentRectangle;
        public controlRectangles()
        {
            InitializeComponent();

            _rectangles = CreateRectangles();
            listBoxRectangle.SelectedIndex = 0;
        }
        private Rectangle[] CreateRectangles()
        {
            Rectangle[] rectangles = new Rectangle[_elementsCount];
            for (int i = 0; i < _elementsCount; i++)
            {
                _currentRectangle = RectangleFactory.Randomize(300,300);
                rectangles[i] = _currentRectangle;
                listBoxRectangle.Items.Add($"Rectangle {_currentRectangle.Id}");
            }
            return rectangles;
        }

        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            var maxWidthIndex = 0;
            var max = 0;

            for (int i = 0; i < _elementsCount; i++)
            {
                if (rectangles[i].Width > max)
                {
                    max = rectangles[i].Width;
                    maxWidthIndex = i;
                }
            }
            return maxWidthIndex;
        }

        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexRectangle = listBoxRectangle.SelectedIndex;
            _currentRectangle = _rectangles[selectedIndexRectangle];
            textBoxRectangleLenght.Text = _currentRectangle.Lenght.ToString();
            textBoxRectangleWidth.Text = _currentRectangle.Width.ToString();
            textBoxRectangleColor.Text = _currentRectangle.Color;
            textBoxRectangleX.Text = _currentRectangle.Center.X.ToString();
            textBoxRectangleY.Text = _currentRectangle.Center.Y.ToString();
            textBoxRectangleId.Text = _currentRectangle.Id.ToString();
        }

        private void LenghtRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (listBoxRectangle.SelectedIndex == -1) return;

            try
            {
                string currentLength = textBoxRectangleLenght.Text;
                int lenghtRectangle = int.Parse(currentLength);
                _currentRectangle.Lenght = lenghtRectangle;
            }
            catch
            {
                textBoxRectangleLenght.BackColor = AppColors.ErrorColor;
                return;
            }
            textBoxRectangleLenght.BackColor = AppColors.CorrectColor;
        }

        private void WidthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (listBoxRectangle.SelectedIndex == -1) return;

            try
            {
                string currentWidthRectangle = textBoxRectangleWidth.Text;
                int widthRectangle = int.Parse(currentWidthRectangle);
                _currentRectangle.Width = widthRectangle;
            }
            catch
            {
                textBoxRectangleWidth.BackColor = AppColors.ErrorColor;
                return;
            }
            textBoxRectangleWidth.BackColor = AppColors.CorrectColor;
        }

        private void ColorRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            string colorRectangle = textBoxRectangleColor.Text;
            _currentRectangle.Color = colorRectangle;
        }

        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            int findMaxWidthIndex = FindRectangleWithMaxWidth(_rectangles);
            if (listBoxRectangle.SelectedIndex == -1) return;
            listBoxRectangle.SelectedIndex = findMaxWidthIndex;
        }
    }
}
