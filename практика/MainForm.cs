using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MoscowDataViewer
{
    public partial class MainForm : Form
    {
        // Класс для представления данных
        class LocationData
        {
            public string Address { get; set; }
            public string AdmDistrict { get; set; }
            public string CityDistrict { get; set; }
            public double Latitude { get; set; }
            public double Longitude { get; set; }
        }

        private List<LocationData> data;

        public MainForm()
        {
            InitializeComponent();
            ApplyDarkTheme();
        }

        private void ApplyDarkTheme()
        {
            this.BackColor = Color.FromArgb(45, 45, 48);
            this.ForeColor = Color.White;
            listViewData.BackColor = Color.FromArgb(30, 30, 30);
            listViewData.ForeColor = Color.White;
            btnLoadFile.BackColor = Color.FromArgb(28, 28, 28);
            btnLoadFile.ForeColor = Color.White;
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Файл не найден: " + filePath, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] lines = File.ReadAllLines(filePath);

                if (lines.Length <= 1)
                {
                    MessageBox.Show("Файл не содержит данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                data = lines.Skip(1).Select(line =>
                {
                    var parts = line.Split(';').Select(p => p.Trim('"')).ToArray();

                    if (parts.Length != 5)
                    {
                        MessageBox.Show("Неправильный формат строки: " + line, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }

                    try
                    {
                        return new LocationData
                        {
                            Address = parts[0],
                            AdmDistrict = parts[1],
                            CityDistrict = parts[2],
                            Latitude = double.Parse(parts[3], CultureInfo.InvariantCulture),
                            Longitude = double.Parse(parts[4], CultureInfo.InvariantCulture)
                        };
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Ошибка формата данных в строке: " + line + "\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }).Where(record => record != null).ToList();

                PopulateAdmDistricts();
                DisplayData(data);
            }
        }

        private void PopulateAdmDistricts()
        {
            var admDistricts = data.Select(d => d.AdmDistrict).Distinct().OrderBy(d => d).ToList();
            admDistricts.Insert(0, "Все");
            cmbAdmDistrict.DataSource = admDistricts;
        }

        private void cmbAdmDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedAdmDistrict = cmbAdmDistrict.SelectedItem.ToString();

            if (selectedAdmDistrict == "Все")
            {
                PopulateCityDistricts();
            }
            else
            {
                var cityDistricts = data.Where(d => d.AdmDistrict == selectedAdmDistrict)
                                        .Select(d => d.CityDistrict)
                                        .Distinct()
                                        .OrderBy(d => d)
                                        .ToList();
                cityDistricts.Insert(0, "Все");
                cmbCityDistrict.DataSource = cityDistricts;
            }

            FilterData();
        }

        private void PopulateCityDistricts()
        {
            var cityDistricts = data.Select(d => d.CityDistrict).Distinct().OrderBy(d => d).ToList();
            cityDistricts.Insert(0, "Все");
            cmbCityDistrict.DataSource = cityDistricts;
        }

        private void cmbCityDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void FilterData()
        {
            var filteredData = data;

            string selectedAdmDistrict = cmbAdmDistrict.SelectedItem.ToString();
            string selectedCityDistrict = cmbCityDistrict.SelectedItem.ToString();

            if (selectedAdmDistrict != "Все")
            {
                filteredData = filteredData.Where(d => d.AdmDistrict == selectedAdmDistrict).ToList();
            }

            if (selectedCityDistrict != "Все")
            {
                filteredData = filteredData.Where(d => d.CityDistrict == selectedCityDistrict).ToList();
            }

            DisplayData(filteredData);
        }

        private void DisplayData(List<LocationData> data)
        {
            listViewData.Items.Clear();
            foreach (var row in data)
            {
                var listViewItem = new ListViewItem(new[] { row.Address, row.AdmDistrict, row.CityDistrict, row.Latitude.ToString(), row.Longitude.ToString() });
                listViewData.Items.Add(listViewItem);
            }
        }
    }
}
