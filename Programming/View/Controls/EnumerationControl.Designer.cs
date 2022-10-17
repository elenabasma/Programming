
namespace Programming.View.Controls
{
    partial class controlEnumeration
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
        private void InitializeComponent()
        {
            this.textBoxIntValue = new System.Windows.Forms.TextBox();
            this.labelIntValue = new System.Windows.Forms.Label();
            this.listBoxValues = new System.Windows.Forms.ListBox();
            this.listBoxEnums = new System.Windows.Forms.ListBox();
            this.labelChooseValue = new System.Windows.Forms.Label();
            this.labelChooseEnumeration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxIntValue
            // 
            this.textBoxIntValue.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxIntValue.Location = new System.Drawing.Point(292, 27);
            this.textBoxIntValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIntValue.Name = "textBoxIntValue";
            this.textBoxIntValue.ReadOnly = true;
            this.textBoxIntValue.Size = new System.Drawing.Size(91, 22);
            this.textBoxIntValue.TabIndex = 5;
            // 
            // labelIntValue
            // 
            this.labelIntValue.AutoSize = true;
            this.labelIntValue.Location = new System.Drawing.Point(289, 9);
            this.labelIntValue.Name = "labelIntValue";
            this.labelIntValue.Size = new System.Drawing.Size(59, 16);
            this.labelIntValue.TabIndex = 4;
            this.labelIntValue.Text = "Int value:";
            // 
            // listBoxValues
            // 
            this.listBoxValues.FormattingEnabled = true;
            this.listBoxValues.ItemHeight = 16;
            this.listBoxValues.Location = new System.Drawing.Point(149, 27);
            this.listBoxValues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxValues.Name = "listBoxValues";
            this.listBoxValues.Size = new System.Drawing.Size(137, 228);
            this.listBoxValues.TabIndex = 3;
            this.listBoxValues.SelectedIndexChanged += new System.EventHandler(this.ValueListBox_SelectedIndexChanged);
            // 
            // listBoxEnums
            // 
            this.listBoxEnums.FormattingEnabled = true;
            this.listBoxEnums.ItemHeight = 16;
            this.listBoxEnums.Location = new System.Drawing.Point(6, 27);
            this.listBoxEnums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxEnums.Name = "listBoxEnums";
            this.listBoxEnums.Size = new System.Drawing.Size(137, 228);
            this.listBoxEnums.TabIndex = 2;
            this.listBoxEnums.Click += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // labelChooseValue
            // 
            this.labelChooseValue.AutoSize = true;
            this.labelChooseValue.Location = new System.Drawing.Point(146, 9);
            this.labelChooseValue.Name = "labelChooseValue";
            this.labelChooseValue.Size = new System.Drawing.Size(93, 16);
            this.labelChooseValue.TabIndex = 1;
            this.labelChooseValue.Text = "Choose value:";
            // 
            // labelChooseEnumeration
            // 
            this.labelChooseEnumeration.AutoSize = true;
            this.labelChooseEnumeration.Location = new System.Drawing.Point(3, 9);
            this.labelChooseEnumeration.Name = "labelChooseEnumeration";
            this.labelChooseEnumeration.Size = new System.Drawing.Size(134, 16);
            this.labelChooseEnumeration.TabIndex = 0;
            this.labelChooseEnumeration.Text = "Choose enumeration:";
            // 
            // controlEnumeration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxIntValue);
            this.Controls.Add(this.labelIntValue);
            this.Controls.Add(this.labelChooseEnumeration);
            this.Controls.Add(this.listBoxValues);
            this.Controls.Add(this.listBoxEnums);
            this.Controls.Add(this.labelChooseValue);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "controlEnumeration";
            this.Size = new System.Drawing.Size(441, 277);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIntValue;
        private System.Windows.Forms.Label labelIntValue;
        private System.Windows.Forms.ListBox listBoxValues;
        private System.Windows.Forms.ListBox listBoxEnums;
        private System.Windows.Forms.Label labelChooseValue;
        private System.Windows.Forms.Label labelChooseEnumeration;
    }
}
