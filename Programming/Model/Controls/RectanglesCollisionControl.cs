using System;
using Programming.Model.Geometry;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Rectangle = Programming.Model.Geometry.Rectangle;
using Programming.Model;

namespace Programming.View.Controls
{
    public partial class controlRectanglesCollision : UserControl
    {
        private List<Rectangle> _rectangles;
        private Rectangle _currentRectangle;
        public controlRectanglesCollision()
        {
            InitializeComponent();

            _rectangles = new List<Rectangle>();
        }
        private string SetRectangleDescription(Rectangle rectangle)
        {
            return $"{rectangle.Id}: " +
                   $"(X: {rectangle.Center.X};" +
                   $" Y: {rectangle.Center.Y};" +
                   $" W: {rectangle.Width};" +
                   $" H: {rectangle.Lenght})";
        }

        private void FindCollision()
        {
            for (int k = 0; k < _rectangles.Count; k++)
            {
                panelCanvas.Controls[k].BackColor = AppColors.NonCollision;
            }

            for (int i = 0; i < _rectangles.Count - 1; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        panelCanvas.Controls[i].BackColor = AppColors.InCollision;
                        panelCanvas.Controls[j].BackColor = AppColors.InCollision;
                    }
                }
            }
        }

        private void ClearRectangleInfo()
        {
            listBoxRectangles.Items.Clear();
            textBoxRectangleSelectedId.Clear();
            textBoxRectangleSelectedX.Clear();
            textBoxRectangleSelectedY.Clear();
            textBoxRectangleSelectedWidth.Clear();
            textBoxRectangleSelectedLenght.Clear();
        }

        private Panel InitPanel()
        {
            Panel rectanglePanel = new Panel
            {
                Width = _currentRectangle.Width,
                Height = _currentRectangle.Lenght,
                Location = new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y),
                BackColor = AppColors.NonCollision
            };

            return rectanglePanel;
        }

        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            int index = _rectangles.IndexOf(rectangle);

            if (index == -1) return;

            listBoxRectangles.Items[index] = SetRectangleDescription(rectangle);
        }

        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            buttonAddRectangle.Image = Properties.Resources.rectangle_add_24x24;
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            buttonAddRectangle.Image = Properties.Resources.rectangle_add_24x24_uncolor;
        }

        private void RemoveButton_MouseEnter(object sender, EventArgs e)
        {
            buttonRemoveSelectedRectangle.Image = Properties.Resources.rectangle_remove_24x24;
        }

        private void RemoveButton_MouseLeave(object sender, EventArgs e)
        {
            buttonRemoveSelectedRectangle.Image = Properties.Resources.rectangle_remove_24x24_uncolor;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentRectangle = RectangleFactory.Randomize(panelCanvas.Width, panelCanvas.Height);
            _rectangles.Add(_currentRectangle);
            listBoxRectangles.Items.Add(SetRectangleDescription(_currentRectangle));

            Panel rectanglePanel = InitPanel();
            panelCanvas.Controls.Add(rectanglePanel);
            listBoxRectangles.SelectedIndex = _rectangles.Count - 1;
            FindCollision();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = listBoxRectangles.SelectedIndex;

            if (index == -1) return;

            _rectangles.RemoveAt(index);
            panelCanvas.Controls.RemoveAt(index);

            ClearRectangleInfo();

            foreach (var rectangle in _rectangles)
            {
                listBoxRectangles.Items.Add(SetRectangleDescription(rectangle));
                listBoxRectangles.SelectedIndex = 0;
            }

            FindCollision();
        }

        private void RectanglesXTextBox_TextChanged(object sender, EventArgs e)
        {
            if (listBoxRectangles.SelectedIndex == -1) return;

            try
            {
                string currentXRectangle = textBoxRectangleSelectedX.Text;
                int xRectangleValue = int.Parse(currentXRectangle);
                _currentRectangle.Center.X = xRectangleValue;
                panelCanvas.Controls[listBoxRectangles.SelectedIndex].Location =
                    new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
                FindCollision();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                textBoxRectangleSelectedX.BackColor = AppColors.ErrorColor;
                return;
            }
            textBoxRectangleSelectedX.BackColor = AppColors.CorrectColor;
        }

        private void RectanglesYTextBox_TextChanged(object sender, EventArgs e)
        {
            if (listBoxRectangles.SelectedIndex == -1) return;

            try
            {
                string currentYRectangle = textBoxRectangleSelectedY.Text;
                int yRectangleValue = int.Parse(currentYRectangle);
                _currentRectangle.Center.Y = yRectangleValue;
                panelCanvas.Controls[listBoxRectangles.SelectedIndex].Location =
                    new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
                FindCollision();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                textBoxRectangleSelectedY.BackColor = AppColors.ErrorColor;
                return;
            }
            textBoxRectangleSelectedY.BackColor = AppColors.CorrectColor;
        }

        private void RectanglesWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (listBoxRectangles.SelectedIndex == -1) return;

            try
            {
                string currentWidthRectangle = textBoxRectangleSelectedWidth.Text;
                int widthRectangleValue = int.Parse(currentWidthRectangle);
                _currentRectangle.Width = widthRectangleValue;
                panelCanvas.Controls[listBoxRectangles.SelectedIndex].Width = _currentRectangle.Width;
                FindCollision();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                textBoxRectangleSelectedWidth.BackColor = AppColors.ErrorColor;
                return;
            }
            textBoxRectangleSelectedWidth.BackColor = AppColors.CorrectColor;
        }

        private void RectanglesLenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            if (listBoxRectangles.SelectedIndex == -1) return;

            try
            {
                string currentLenghtRectangle = textBoxRectangleSelectedLenght.Text;
                int lenghtRectangleValue = int.Parse(currentLenghtRectangle);
                _currentRectangle.Lenght = lenghtRectangleValue;
                panelCanvas.Controls[listBoxRectangles.SelectedIndex].Height = _currentRectangle.Lenght;
                FindCollision();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                textBoxRectangleSelectedLenght.BackColor = AppColors.ErrorColor;
                return;
            }
            textBoxRectangleSelectedLenght.BackColor = AppColors.CorrectColor;
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRectangles.SelectedItem == null) return;

            int index = listBoxRectangles.SelectedIndex;
            _currentRectangle = _rectangles[index];
            textBoxRectangleSelectedId.Text = _currentRectangle.Id.ToString();
            textBoxRectangleSelectedX.Text = _currentRectangle.Center.X.ToString();
            textBoxRectangleSelectedY.Text = _currentRectangle.Center.Y.ToString();
            textBoxRectangleSelectedWidth.Text = _currentRectangle.Width.ToString();
            textBoxRectangleSelectedLenght.Text = _currentRectangle.Lenght.ToString();
        }
    }
}
