namespace FormUI
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerLabel = new System.Windows.Forms.Label();
            this.allPeopleLabel = new System.Windows.Forms.Label();
            this.yearsExperienceLabel = new System.Windows.Forms.Label();
            this.filteredListLabel = new System.Windows.Forms.Label();
            this.filteredPeopleList = new System.Windows.Forms.ListBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.YearsExperienceUpDown = new System.Windows.Forms.NumericUpDown();
            this.dropDownBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.YearsExperienceUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(23, 18);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(279, 46);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Linq101 Demo";
            // 
            // allPeopleLabel
            // 
            this.allPeopleLabel.AutoSize = true;
            this.allPeopleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allPeopleLabel.Location = new System.Drawing.Point(34, 94);
            this.allPeopleLabel.Name = "allPeopleLabel";
            this.allPeopleLabel.Size = new System.Drawing.Size(135, 31);
            this.allPeopleLabel.TabIndex = 1;
            this.allPeopleLabel.Text = "All People";
            // 
            // yearsExperienceLabel
            // 
            this.yearsExperienceLabel.AutoSize = true;
            this.yearsExperienceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearsExperienceLabel.Location = new System.Drawing.Point(34, 214);
            this.yearsExperienceLabel.Name = "yearsExperienceLabel";
            this.yearsExperienceLabel.Size = new System.Drawing.Size(227, 31);
            this.yearsExperienceLabel.TabIndex = 2;
            this.yearsExperienceLabel.Text = "Years Experience";
            // 
            // filteredListLabel
            // 
            this.filteredListLabel.AutoSize = true;
            this.filteredListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filteredListLabel.Location = new System.Drawing.Point(447, 94);
            this.filteredListLabel.Name = "filteredListLabel";
            this.filteredListLabel.Size = new System.Drawing.Size(155, 31);
            this.filteredListLabel.TabIndex = 3;
            this.filteredListLabel.Text = "Filtered List";
            // 
            // filteredPeopleList
            // 
            this.filteredPeopleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filteredPeopleList.FormattingEnabled = true;
            this.filteredPeopleList.ItemHeight = 31;
            this.filteredPeopleList.Location = new System.Drawing.Point(453, 141);
            this.filteredPeopleList.Name = "filteredPeopleList";
            this.filteredPeopleList.Size = new System.Drawing.Size(312, 283);
            this.filteredPeopleList.TabIndex = 4;
            // 
            // updateButton
            // 
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(70, 360);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(191, 53);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // YearsExperienceUpDown
            // 
            this.YearsExperienceUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearsExperienceUpDown.Location = new System.Drawing.Point(40, 267);
            this.YearsExperienceUpDown.Name = "YearsExperienceUpDown";
            this.YearsExperienceUpDown.Size = new System.Drawing.Size(120, 38);
            this.YearsExperienceUpDown.TabIndex = 6;
            // 
            // dropDownBox
            // 
            this.dropDownBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownBox.FormattingEnabled = true;
            this.dropDownBox.Location = new System.Drawing.Point(40, 141);
            this.dropDownBox.Name = "dropDownBox";
            this.dropDownBox.Size = new System.Drawing.Size(262, 39);
            this.dropDownBox.TabIndex = 7;
            this.dropDownBox.SelectedIndexChanged += new System.EventHandler(this.dropDownBox_SelectedIndexChanged);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dropDownBox);
            this.Controls.Add(this.YearsExperienceUpDown);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.filteredPeopleList);
            this.Controls.Add(this.filteredListLabel);
            this.Controls.Add(this.yearsExperienceLabel);
            this.Controls.Add(this.allPeopleLabel);
            this.Controls.Add(this.headerLabel);
            this.Name = "Dashboard";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.YearsExperienceUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label allPeopleLabel;
        private System.Windows.Forms.Label yearsExperienceLabel;
        private System.Windows.Forms.Label filteredListLabel;
        private System.Windows.Forms.ListBox filteredPeopleList;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.NumericUpDown YearsExperienceUpDown;
        private System.Windows.Forms.ComboBox dropDownBox;
    }
}

