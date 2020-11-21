using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RandomWordSelector
{
    public partial class RandomCountrySelectorForm : Form
    {

        public RandomCountrySelectorForm()
        {
            InitializeComponent();
        }

        private void ChooseFileButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt"
            };
            dialog.ShowDialog();
            if (dialog.FileName == null) return;
            this.PathLabel.Text = dialog.FileName;
            this.AddCountries.Enabled = true;
        }

        private void AddCountries_Click(object sender, EventArgs e)
        {
            var currentCountryList = this.CountryList.Text.Split('\n').ToList();
            var countryList = File.ReadAllLines(this.PathLabel.Text);
            
            for (int i = 0; i < 4; i++)
            {
                if (currentCountryList.Count >= countryList.Length)
                {
                    MessageBox.Show("No more countries to pick from");
                    break;
                }

                currentCountryList.Add(GetNextCountry(currentCountryList, countryList));
            }

            this.CountryList.Text = string.Join(Environment.NewLine,
                currentCountryList.Where(str => str != "").ToArray());
        }

        private static string GetNextCountry(IReadOnlyList<string> currentCountries, IReadOnlyList<string> countryList)
        {
            var random = new Random();
            string country = "";
            while (currentCountries.Contains(country))
            {
                country = countryList[random.Next(0, countryList.Count)];
            }
            return country;
        }
    }
}
