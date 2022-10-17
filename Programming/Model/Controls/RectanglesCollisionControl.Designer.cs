
namespace Programming.View.Controls
{
    partial class controlRectanglesCollision
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

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRemoveSelectedRectangle = new System.Windows.Forms.Button();
            this.buttonAddRectangle = new System.Windows.Forms.Button();
            this.textBoxRectangleSelectedLenght = new System.Windows.Forms.TextBox();
            this.labelRectangleSelectedLenght = new System.Windows.Forms.Label();
            this.textBoxRectangleSelectedWidth = new System.Windows.Forms.TextBox();
            this.labelRectangleSelectedWidth = new System.Windows.Forms.Label();
            this.textBoxRectangleSelectedY = new System.Windows.Forms.TextBox();
            this.labelRectangleSelectedY = new System.Windows.Forms.Label();
            this.textBoxRectangleSelectedX = new System.Windows.Forms.TextBox();
            this.labelRectangleSelectedX = new System.Windows.Forms.Label();
            this.labelRectangleSelectedId = new System.Windows.Forms.Label();
            this.textBoxRectangleSelectedId = new System.Windows.Forms.TextBox();
            this.labelSelectedRectangle = new System.Windows.Forms.Label();
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.labelRectangles = new System.Windows.Forms.Label();
            this.listBoxRectangles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonRemoveSelectedRectangle
            // 
            this.buttonRemoveSelectedRectangle.FlatAppearance.BorderSize = 0;
            this.buttonRemoveSelectedRectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.buttonRemoveSelectedRectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonRemoveSelectedRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveSelectedRectangle.Image = global::Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
            this.buttonRemoveSelectedRectangle.Location = new System.Drawing.Point(123, 169);
            this.buttonRemoveSelectedRectangle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveSelectedRectangle.Name = "buttonRemoveSelectedRectangle";
            this.buttonRemoveSelectedRectangle.Size = new System.Drawing.Size(100, 32);
            this.buttonRemoveSelectedRectangle.TabIndex = 31;
            this.buttonRemoveSelectedRectangle.UseVisualStyleBackColor = true;
            this.buttonRemoveSelectedRectangle.Click += new System.EventHandler(this.RemoveButton_Click);
            this.buttonRemoveSelectedRectangle.MouseEnter += new System.EventHandler(this.RemoveButton_MouseEnter);
            this.buttonRemoveSelectedRectangle.MouseLeave += new System.EventHandler(this.RemoveButton_MouseLeave);
            // 
            // buttonAddRectangle
            // 
            this.buttonAddRectangle.FlatAppearance.BorderSize = 0;
            this.buttonAddRectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.buttonAddRectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonAddRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddRectangle.Image = global::Programming.Properties.Resources.rectangle_add_24x24_uncolor;
            this.buttonAddRectangle.Location = new System.Drawing.Point(15, 169);
            this.buttonAddRectangle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddRectangle.Name = "buttonAddRectangle";
            this.buttonAddRectangle.Size = new System.Drawing.Size(100, 32);
            this.buttonAddRectangle.TabIndex = 30;
            this.buttonAddRectangle.UseVisualStyleBackColor = true;
            this.buttonAddRectangle.Click += new System.EventHandler(this.AddButton_Click);
            this.buttonAddRectangle.MouseEnter += new System.EventHandler(this.AddButton_MouseEnter);
            this.buttonAddRectangle.MouseLeave += new System.EventHandler(this.AddButton_MouseLeave);
            // 
            // textBoxRectangleSelectedLenght
            // 
            this.textBoxRectangleSelectedLenght.Location = new System.Drawing.Point(73, 361);
            this.textBoxRectangleSelectedLenght.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRectangleSelectedLenght.Name = "textBoxRectangleSelectedLenght";
            this.textBoxRectangleSelectedLenght.Size = new System.Drawing.Size(132, 22);
            this.textBoxRectangleSelectedLenght.TabIndex = 29;
            this.textBoxRectangleSelectedLenght.TextChanged += new System.EventHandler(this.RectanglesLenghtTextBox_TextChanged);
            // 
            // labelRectangleSelectedLenght
            // 
            this.labelRectangleSelectedLenght.AutoSize = true;
            this.labelRectangleSelectedLenght.Location = new System.Drawing.Point(16, 367);
            this.labelRectangleSelectedLenght.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRectangleSelectedLenght.Name = "labelRectangleSelectedLenght";
            this.labelRectangleSelectedLenght.Size = new System.Drawing.Size(50, 16);
            this.labelRectangleSelectedLenght.TabIndex = 28;
            this.labelRectangleSelectedLenght.Text = "Lenght:";
            // 
            // textBoxRectangleSelectedWidth
            // 
            this.textBoxRectangleSelectedWidth.Location = new System.Drawing.Point(73, 331);
            this.textBoxRectangleSelectedWidth.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRectangleSelectedWidth.Name = "textBoxRectangleSelectedWidth";
            this.textBoxRectangleSelectedWidth.Size = new System.Drawing.Size(132, 22);
            this.textBoxRectangleSelectedWidth.TabIndex = 27;
            this.textBoxRectangleSelectedWidth.TextChanged += new System.EventHandler(this.RectanglesWidthTextBox_TextChanged);
            // 
            // labelRectangleSelectedWidth
            // 
            this.labelRectangleSelectedWidth.AutoSize = true;
            this.labelRectangleSelectedWidth.Location = new System.Drawing.Point(20, 337);
            this.labelRectangleSelectedWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRectangleSelectedWidth.Name = "labelRectangleSelectedWidth";
            this.labelRectangleSelectedWidth.Size = new System.Drawing.Size(44, 16);
            this.labelRectangleSelectedWidth.TabIndex = 26;
            this.labelRectangleSelectedWidth.Text = "Width:";
            // 
            // textBoxRectangleSelectedY
            // 
            this.textBoxRectangleSelectedY.Location = new System.Drawing.Point(73, 301);
            this.textBoxRectangleSelectedY.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRectangleSelectedY.Name = "textBoxRectangleSelectedY";
            this.textBoxRectangleSelectedY.Size = new System.Drawing.Size(132, 22);
            this.textBoxRectangleSelectedY.TabIndex = 25;
            this.textBoxRectangleSelectedY.TextChanged += new System.EventHandler(this.RectanglesYTextBox_TextChanged);
            // 
            // labelRectangleSelectedY
            // 
            this.labelRectangleSelectedY.AutoSize = true;
            this.labelRectangleSelectedY.Location = new System.Drawing.Point(48, 307);
            this.labelRectangleSelectedY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRectangleSelectedY.Name = "labelRectangleSelectedY";
            this.labelRectangleSelectedY.Size = new System.Drawing.Size(19, 16);
            this.labelRectangleSelectedY.TabIndex = 24;
            this.labelRectangleSelectedY.Text = "Y:";
            // 
            // textBoxRectangleSelectedX
            // 
            this.textBoxRectangleSelectedX.Location = new System.Drawing.Point(73, 271);
            this.textBoxRectangleSelectedX.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRectangleSelectedX.Name = "textBoxRectangleSelectedX";
            this.textBoxRectangleSelectedX.Size = new System.Drawing.Size(132, 22);
            this.textBoxRectangleSelectedX.TabIndex = 23;
            this.textBoxRectangleSelectedX.TextChanged += new System.EventHandler(this.RectanglesXTextBox_TextChanged);
            // 
            // labelRectangleSelectedX
            // 
            this.labelRectangleSelectedX.AutoSize = true;
            this.labelRectangleSelectedX.Location = new System.Drawing.Point(46, 274);
            this.labelRectangleSelectedX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRectangleSelectedX.Name = "labelRectangleSelectedX";
            this.labelRectangleSelectedX.Size = new System.Drawing.Size(18, 16);
            this.labelRectangleSelectedX.TabIndex = 22;
            this.labelRectangleSelectedX.Text = "X:";
            // 
            // labelRectangleSelectedId
            // 
            this.labelRectangleSelectedId.AutoSize = true;
            this.labelRectangleSelectedId.Location = new System.Drawing.Point(46, 247);
            this.labelRectangleSelectedId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRectangleSelectedId.Name = "labelRectangleSelectedId";
            this.labelRectangleSelectedId.Size = new System.Drawing.Size(21, 16);
            this.labelRectangleSelectedId.TabIndex = 21;
            this.labelRectangleSelectedId.Text = "Id:";
            // 
            // textBoxRectangleSelectedId
            // 
            this.textBoxRectangleSelectedId.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxRectangleSelectedId.Location = new System.Drawing.Point(73, 241);
            this.textBoxRectangleSelectedId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRectangleSelectedId.Name = "textBoxRectangleSelectedId";
            this.textBoxRectangleSelectedId.ReadOnly = true;
            this.textBoxRectangleSelectedId.Size = new System.Drawing.Size(132, 22);
            this.textBoxRectangleSelectedId.TabIndex = 20;
            // 
            // labelSelectedRectangle
            // 
            this.labelSelectedRectangle.AutoSize = true;
            this.labelSelectedRectangle.Location = new System.Drawing.Point(12, 221);
            this.labelSelectedRectangle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectedRectangle.Name = "labelSelectedRectangle";
            this.labelSelectedRectangle.Size = new System.Drawing.Size(129, 16);
            this.labelSelectedRectangle.TabIndex = 19;
            this.labelSelectedRectangle.Text = "Selected Rectangle:";
            // 
            // panelCanvas
            // 
            this.panelCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCanvas.Location = new System.Drawing.Point(398, 29);
            this.panelCanvas.Margin = new System.Windows.Forms.Padding(15);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(470, 451);
            this.panelCanvas.TabIndex = 18;
            // 
            // labelRectangles
            // 
            this.labelRectangles.AutoSize = true;
            this.labelRectangles.Location = new System.Drawing.Point(12, 9);
            this.labelRectangles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRectangles.Name = "labelRectangles";
            this.labelRectangles.Size = new System.Drawing.Size(79, 16);
            this.labelRectangles.TabIndex = 17;
            this.labelRectangles.Text = "Rectangles:";
            // 
            // listBoxRectangles
            // 
            this.listBoxRectangles.FormattingEnabled = true;
            this.listBoxRectangles.ItemHeight = 16;
            this.listBoxRectangles.Location = new System.Drawing.Point(15, 29);
            this.listBoxRectangles.Margin = new System.Windows.Forms.Padding(15, 4, 4, 4);
            this.listBoxRectangles.Name = "listBoxRectangles";
            this.listBoxRectangles.Size = new System.Drawing.Size(364, 132);
            this.listBoxRectangles.TabIndex = 16;
            this.listBoxRectangles.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // controlRectanglesCollision
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.buttonRemoveSelectedRectangle);
            this.Controls.Add(this.buttonAddRectangle);
            this.Controls.Add(this.textBoxRectangleSelectedLenght);
            this.Controls.Add(this.labelRectangleSelectedLenght);
            this.Controls.Add(this.textBoxRectangleSelectedWidth);
            this.Controls.Add(this.labelRectangleSelectedWidth);
            this.Controls.Add(this.textBoxRectangleSelectedY);
            this.Controls.Add(this.labelRectangleSelectedY);
            this.Controls.Add(this.textBoxRectangleSelectedX);
            this.Controls.Add(this.labelRectangleSelectedX);
            this.Controls.Add(this.labelRectangleSelectedId);
            this.Controls.Add(this.textBoxRectangleSelectedId);
            this.Controls.Add(this.labelSelectedRectangle);
            this.Controls.Add(this.panelCanvas);
            this.Controls.Add(this.labelRectangles);
            this.Controls.Add(this.listBoxRectangles);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "controlRectanglesCollision";
            this.Size = new System.Drawing.Size(883, 495);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRemoveSelectedRectangle;
        private System.Windows.Forms.Button buttonAddRectangle;
        private System.Windows.Forms.TextBox textBoxRectangleSelectedLenght;
        private System.Windows.Forms.Label labelRectangleSelectedLenght;
        private System.Windows.Forms.TextBox textBoxRectangleSelectedWidth;
        private System.Windows.Forms.Label labelRectangleSelectedWidth;
        private System.Windows.Forms.TextBox textBoxRectangleSelectedY;
        private System.Windows.Forms.Label labelRectangleSelectedY;
        private System.Windows.Forms.TextBox textBoxRectangleSelectedX;
        private System.Windows.Forms.Label labelRectangleSelectedX;
        private System.Windows.Forms.Label labelRectangleSelectedId;
        private System.Windows.Forms.TextBox textBoxRectangleSelectedId;
        private System.Windows.Forms.Label labelSelectedRectangle;
        private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.Label labelRectangles;
        private System.Windows.Forms.ListBox listBoxRectangles;
    }
}
