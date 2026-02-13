using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EquipmentTracker.Domain;
using EquipmentTracker.Infrastructure;

namespace CPE223L_GALANIDA.PACLIBAR.MACUNTE_QUIZ2
{       
    public partial class Form1 : Form
    {
        private List<Equipment> _equipmentList = new();

        public Form1()
        {
            InitializeComponent();
            LoadPrograms();
        }

        private void LoadPrograms()
        {
            using var _context = new AppDbContext();
               
            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataSource = null;
            dataGridView.DataSource = _equipmentList;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBoxSerialNumber.Text, out var serial))
            {
                MessageBox.Show("Serial number must be a valid integer.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Enum.TryParse<Category>(txtBoxCategory.Text, true, out var parsedCategory))
            {
                MessageBox.Show("Category is invalid. Use one of: " + string.Join(", ", Enum.GetNames(typeof(Category))), "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var equipment = new Equipment
            {
                Model = txtBoxModel.Text,
                SerialNumber = serial, // use parsed int
                Category = parsedCategory
            };

            try
            {
                using var _context = new AppDbContext();
                _context.Equipments.Add(equipment);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save equipment: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _equipmentList.Add(equipment);

            dataGridView.DataSource = null;
            dataGridView.DataSource = _equipmentList;
        }
    }
}
