
namespace Programming.View.Controls
{
    partial class controlWeekdayParsing
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
            this.labelOutputWeekday = new System.Windows.Forms.Label();
            this.buttonWeekdayParse = new System.Windows.Forms.Button();
            this.textBoxWeekday = new System.Windows.Forms.TextBox();
            this.labelParsing = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelOutputWeekday
            // 
            this.labelOutputWeekday.AutoSize = true;
            this.labelOutputWeekday.Location = new System.Drawing.Point(5, 58);
            this.labelOutputWeekday.Name = "labelOutputWeekday";
            this.labelOutputWeekday.Size = new System.Drawing.Size(0, 16);
            this.labelOutputWeekday.TabIndex = 10;
            // 
            // buttonWeekdayParse
            // 
            this.buttonWeekdayParse.Location = new System.Drawing.Point(300, 29);
            this.buttonWeekdayParse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonWeekdayParse.Name = "buttonWeekdayParse";
            this.buttonWeekdayParse.Size = new System.Drawing.Size(108, 26);
            this.buttonWeekdayParse.TabIndex = 8;
            this.buttonWeekdayParse.Text = "Parse";
            this.buttonWeekdayParse.UseVisualStyleBackColor = true;
            this.buttonWeekdayParse.Click += new System.EventHandler(this.WeekdayParseButton_Click);
            // 
            // textBoxWeekday
            // 
            this.textBoxWeekday.Location = new System.Drawing.Point(9, 31);
            this.textBoxWeekday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxWeekday.Name = "textBoxWeekday";
            this.textBoxWeekday.Size = new System.Drawing.Size(285, 22);
            this.textBoxWeekday.TabIndex = 6;
            // 
            // labelParsing
            // 
            this.labelParsing.AutoSize = true;
            this.labelParsing.Location = new System.Drawing.Point(5, 12);
            this.labelParsing.Name = "labelParsing";
            this.labelParsing.Size = new System.Drawing.Size(144, 16);
            this.labelParsing.TabIndex = 1;
            this.labelParsing.Text = "Type value for parsing:";
            // 
            // controlWeekdayParsing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonWeekdayParse);
            this.Controls.Add(this.labelParsing);
            this.Controls.Add(this.textBoxWeekday);
            this.Controls.Add(this.labelOutputWeekday);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "controlWeekdayParsing";
            this.Size = new System.Drawing.Size(421, 84);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelOutputWeekday;
        private System.Windows.Forms.Button buttonWeekdayParse;
        private System.Windows.Forms.TextBox textBoxWeekday;
        private System.Windows.Forms.Label labelParsing;
    }
}
