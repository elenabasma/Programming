
namespace Programming.View
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabPageEnums = new System.Windows.Forms.TabPage();
            this.groupBoxEnumeration = new System.Windows.Forms.GroupBox();
            this.groupBoxSeasonHandle = new System.Windows.Forms.GroupBox();
            this.groupBoxWeekdayParsing = new System.Windows.Forms.GroupBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageClasses = new System.Windows.Forms.TabPage();
            this.groupBoxMovie = new System.Windows.Forms.GroupBox();
            this.groupBoxRectangle = new System.Windows.Forms.GroupBox();
            this.tabPageRectangles = new System.Windows.Forms.TabPage();
            this.controlEnumeration = new Programming.View.Controls.controlEnumeration();
            this.controlSeasonsHandle = new Programming.View.Controls.controlSeasonsHandle();
            this.controlWeekdayParsing = new Programming.View.Controls.controlWeekdayParsing();
            this.controlMovie = new Programming.View.Controls.controlMovies();
            this.controlRectangles = new Programming.View.Controls.controlRectangles();
            this.controlRectanglesCollision = new Programming.View.Controls.controlRectanglesCollision();
            this.tabPageEnums.SuspendLayout();
            this.groupBoxEnumeration.SuspendLayout();
            this.groupBoxSeasonHandle.SuspendLayout();
            this.groupBoxWeekdayParsing.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageClasses.SuspendLayout();
            this.groupBoxMovie.SuspendLayout();
            this.groupBoxRectangle.SuspendLayout();
            this.tabPageRectangles.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageEnums
            // 
            this.tabPageEnums.Controls.Add(this.groupBoxEnumeration);
            this.tabPageEnums.Controls.Add(this.groupBoxSeasonHandle);
            this.tabPageEnums.Controls.Add(this.groupBoxWeekdayParsing);
            this.tabPageEnums.Location = new System.Drawing.Point(4, 25);
            this.tabPageEnums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageEnums.Name = "tabPageEnums";
            this.tabPageEnums.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageEnums.Size = new System.Drawing.Size(891, 503);
            this.tabPageEnums.TabIndex = 0;
            this.tabPageEnums.Text = "Enums";
            this.tabPageEnums.UseVisualStyleBackColor = true;
            // 
            // groupBoxEnumeration
            // 
            this.groupBoxEnumeration.Controls.Add(this.controlEnumeration);
            this.groupBoxEnumeration.Location = new System.Drawing.Point(8, 6);
            this.groupBoxEnumeration.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxEnumeration.Name = "groupBoxEnumeration";
            this.groupBoxEnumeration.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxEnumeration.Size = new System.Drawing.Size(871, 298);
            this.groupBoxEnumeration.TabIndex = 3;
            this.groupBoxEnumeration.TabStop = false;
            this.groupBoxEnumeration.Text = "Enumerations";
            // 
            // groupBoxSeasonHandle
            // 
            this.groupBoxSeasonHandle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxSeasonHandle.Controls.Add(this.controlSeasonsHandle);
            this.groupBoxSeasonHandle.Location = new System.Drawing.Point(445, 310);
            this.groupBoxSeasonHandle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSeasonHandle.Name = "groupBoxSeasonHandle";
            this.groupBoxSeasonHandle.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSeasonHandle.Size = new System.Drawing.Size(434, 180);
            this.groupBoxSeasonHandle.TabIndex = 2;
            this.groupBoxSeasonHandle.TabStop = false;
            this.groupBoxSeasonHandle.Text = "Season Handle";
            // 
            // groupBoxWeekdayParsing
            // 
            this.groupBoxWeekdayParsing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxWeekdayParsing.Controls.Add(this.controlWeekdayParsing);
            this.groupBoxWeekdayParsing.Location = new System.Drawing.Point(8, 310);
            this.groupBoxWeekdayParsing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxWeekdayParsing.Name = "groupBoxWeekdayParsing";
            this.groupBoxWeekdayParsing.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxWeekdayParsing.Size = new System.Drawing.Size(431, 180);
            this.groupBoxWeekdayParsing.TabIndex = 1;
            this.groupBoxWeekdayParsing.TabStop = false;
            this.groupBoxWeekdayParsing.Text = "Weekday Parsing";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageEnums);
            this.tabControl.Controls.Add(this.tabPageClasses);
            this.tabControl.Controls.Add(this.tabPageRectangles);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(899, 532);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageClasses
            // 
            this.tabPageClasses.Controls.Add(this.groupBoxMovie);
            this.tabPageClasses.Controls.Add(this.groupBoxRectangle);
            this.tabPageClasses.Location = new System.Drawing.Point(4, 25);
            this.tabPageClasses.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageClasses.Name = "tabPageClasses";
            this.tabPageClasses.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageClasses.Size = new System.Drawing.Size(891, 503);
            this.tabPageClasses.TabIndex = 1;
            this.tabPageClasses.Text = "Classes";
            this.tabPageClasses.UseVisualStyleBackColor = true;
            // 
            // groupBoxMovie
            // 
            this.groupBoxMovie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxMovie.Controls.Add(this.controlMovie);
            this.groupBoxMovie.Location = new System.Drawing.Point(449, 7);
            this.groupBoxMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxMovie.Name = "groupBoxMovie";
            this.groupBoxMovie.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxMovie.Size = new System.Drawing.Size(430, 482);
            this.groupBoxMovie.TabIndex = 1;
            this.groupBoxMovie.TabStop = false;
            this.groupBoxMovie.Text = "Movies";
            // 
            // groupBoxRectangle
            // 
            this.groupBoxRectangle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxRectangle.Controls.Add(this.controlRectangles);
            this.groupBoxRectangle.Location = new System.Drawing.Point(8, 7);
            this.groupBoxRectangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRectangle.Name = "groupBoxRectangle";
            this.groupBoxRectangle.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRectangle.Size = new System.Drawing.Size(435, 482);
            this.groupBoxRectangle.TabIndex = 0;
            this.groupBoxRectangle.TabStop = false;
            this.groupBoxRectangle.Text = "Rectangles";
            // 
            // tabPageRectangles
            // 
            this.tabPageRectangles.Controls.Add(this.controlRectanglesCollision);
            this.tabPageRectangles.Location = new System.Drawing.Point(4, 25);
            this.tabPageRectangles.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageRectangles.Name = "tabPageRectangles";
            this.tabPageRectangles.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageRectangles.Size = new System.Drawing.Size(891, 503);
            this.tabPageRectangles.TabIndex = 2;
            this.tabPageRectangles.Text = "Rectangles";
            this.tabPageRectangles.UseVisualStyleBackColor = true;
            // 
            // controlEnumeration
            // 
            this.controlEnumeration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlEnumeration.Location = new System.Drawing.Point(4, 19);
            this.controlEnumeration.Margin = new System.Windows.Forms.Padding(5);
            this.controlEnumeration.Name = "controlEnumeration";
            this.controlEnumeration.Size = new System.Drawing.Size(863, 275);
            this.controlEnumeration.TabIndex = 0;
            // 
            // controlSeasonsHandle
            // 
            this.controlSeasonsHandle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlSeasonsHandle.Location = new System.Drawing.Point(3, 17);
            this.controlSeasonsHandle.Margin = new System.Windows.Forms.Padding(5);
            this.controlSeasonsHandle.Name = "controlSeasonsHandle";
            this.controlSeasonsHandle.Size = new System.Drawing.Size(428, 161);
            this.controlSeasonsHandle.TabIndex = 0;
            // 
            // controlWeekdayParsing
            // 
            this.controlWeekdayParsing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlWeekdayParsing.Location = new System.Drawing.Point(3, 17);
            this.controlWeekdayParsing.Margin = new System.Windows.Forms.Padding(5);
            this.controlWeekdayParsing.Name = "controlWeekdayParsing";
            this.controlWeekdayParsing.Size = new System.Drawing.Size(425, 161);
            this.controlWeekdayParsing.TabIndex = 0;
            // 
            // controlMovie
            // 
            this.controlMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlMovie.Location = new System.Drawing.Point(3, 17);
            this.controlMovie.Margin = new System.Windows.Forms.Padding(5);
            this.controlMovie.Name = "controlMovie";
            this.controlMovie.Size = new System.Drawing.Size(424, 463);
            this.controlMovie.TabIndex = 0;
            // 
            // controlRectangles
            // 
            this.controlRectangles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlRectangles.Location = new System.Drawing.Point(3, 17);
            this.controlRectangles.Margin = new System.Windows.Forms.Padding(5);
            this.controlRectangles.Name = "controlRectangles";
            this.controlRectangles.Size = new System.Drawing.Size(429, 463);
            this.controlRectangles.TabIndex = 0;
            // 
            // controlRectanglesCollision
            // 
            this.controlRectanglesCollision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlRectanglesCollision.Location = new System.Drawing.Point(4, 4);
            this.controlRectanglesCollision.Margin = new System.Windows.Forms.Padding(4);
            this.controlRectanglesCollision.Name = "controlRectanglesCollision";
            this.controlRectanglesCollision.Size = new System.Drawing.Size(883, 495);
            this.controlRectanglesCollision.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 532);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(914, 569);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Programming Demo";
            this.tabPageEnums.ResumeLayout(false);
            this.groupBoxEnumeration.ResumeLayout(false);
            this.groupBoxSeasonHandle.ResumeLayout(false);
            this.groupBoxWeekdayParsing.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageClasses.ResumeLayout(false);
            this.groupBoxMovie.ResumeLayout(false);
            this.groupBoxRectangle.ResumeLayout(false);
            this.tabPageRectangles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageEnums;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.GroupBox groupBoxSeasonHandle;
        private System.Windows.Forms.GroupBox groupBoxWeekdayParsing;
        private System.Windows.Forms.TabPage tabPageClasses;
        private System.Windows.Forms.GroupBox groupBoxMovie;
        private System.Windows.Forms.TabPage tabPageRectangles;
        private System.Windows.Forms.GroupBox groupBoxEnumeration;
        private Controls.controlEnumeration controlEnumeration;
        private Controls.controlSeasonsHandle controlSeasonsHandle;
        private Controls.controlWeekdayParsing controlWeekdayParsing;
        private Controls.controlMovies controlMovie;
        private Controls.controlRectanglesCollision controlRectanglesCollision;
        private System.Windows.Forms.GroupBox groupBoxRectangle;
        private Controls.controlRectangles controlRectangles;
    }
}

