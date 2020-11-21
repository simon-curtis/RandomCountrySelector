namespace RandomWordSelector
{
    partial class RandomCountrySelectorForm
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
            this.ChooseFileButton = new System.Windows.Forms.Button();
            this.AddCountries = new System.Windows.Forms.Button();
            this.CountryList = new System.Windows.Forms.TextBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChooseFileButton
            // 
            this.ChooseFileButton.Location = new System.Drawing.Point(39, 44);
            this.ChooseFileButton.Name = "ChooseFileButton";
            this.ChooseFileButton.Size = new System.Drawing.Size(235, 69);
            this.ChooseFileButton.TabIndex = 1;
            this.ChooseFileButton.Text = "Choose File";
            this.ChooseFileButton.UseVisualStyleBackColor = true;
            this.ChooseFileButton.Click += new System.EventHandler(this.ChooseFileButton_Click);
            // 
            // AddCountries
            // 
            this.AddCountries.Enabled = false;
            this.AddCountries.Location = new System.Drawing.Point(39, 142);
            this.AddCountries.Name = "AddCountries";
            this.AddCountries.Size = new System.Drawing.Size(235, 69);
            this.AddCountries.TabIndex = 1;
            this.AddCountries.Text = "Add Countries";
            this.AddCountries.UseVisualStyleBackColor = true;
            this.AddCountries.Click += new System.EventHandler(this.AddCountries_Click);
            // 
            // CountryList
            // 
            this.CountryList.Location = new System.Drawing.Point(39, 245);
            this.CountryList.Multiline = true;
            this.CountryList.Name = "CountryList";
            this.CountryList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CountryList.Size = new System.Drawing.Size(1150, 748);
            this.CountryList.TabIndex = 2;
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(308, 63);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(203, 32);
            this.PathLabel.TabIndex = 3;
            this.PathLabel.Text = "Select file path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 1029);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.CountryList);
            this.Controls.Add(this.AddCountries);
            this.Controls.Add(this.ChooseFileButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ChooseFileButton;
        private System.Windows.Forms.Button AddCountries;
        private System.Windows.Forms.TextBox CountryList;
        private System.Windows.Forms.Label PathLabel;
    }
}

