
namespace Programming.View.Controls
{
    partial class controlSeasonsHandle
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
            this.comboBoxSeasons = new System.Windows.Forms.ComboBox();
            this.labelSeason = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxSeasons
            // 
            this.comboBoxSeasons.FormattingEnabled = true;
            this.comboBoxSeasons.Location = new System.Drawing.Point(9, 33);
            this.comboBoxSeasons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSeasons.Name = "comboBoxSeasons";
            this.comboBoxSeasons.Size = new System.Drawing.Size(200, 24);
            this.comboBoxSeasons.TabIndex = 3;
            // 
            // labelSeason
            // 
            this.labelSeason.AutoSize = true;
            this.labelSeason.Location = new System.Drawing.Point(5, 15);
            this.labelSeason.Name = "labelSeason";
            this.labelSeason.Size = new System.Drawing.Size(105, 16);
            this.labelSeason.TabIndex = 2;
            this.labelSeason.Text = "Choose season:";
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(215, 33);
            this.buttonGo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(100, 27);
            this.buttonGo.TabIndex = 9;
            this.buttonGo.Text = "Go!";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // controlSeasonsHandle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.labelSeason);
            this.Controls.Add(this.comboBoxSeasons);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "controlSeasonsHandle";
            this.Size = new System.Drawing.Size(421, 84);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxSeasons;
        private System.Windows.Forms.Label labelSeason;
        private System.Windows.Forms.Button buttonGo;
    }
}
