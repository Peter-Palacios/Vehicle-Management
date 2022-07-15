using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6._2
{
    public partial class Form1 : Form
    {
        CarRepository repository;
        public Form1()
        {
            InitializeComponent();
        }

        private void CarGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            repository = new CarRepository();
            CarGrid.DataSource = repository.Getinfo();
            btnSubmit.Enabled = false;
            btnUpdate.Enabled = false;
            comboMake.Items.AddRange(new string[] { "Jaguar", "BMW", "Hyundai", "Ford", "Toyota", "Tesla", "Mario Kart", "Jeep" });


            DateTimePickerYear.Format = DateTimePickerFormat.Custom;
            DateTimePickerYear.CustomFormat = "yyyy";
            //DateTimePickerYear.ShowUpDown = true;

            txtModel.ReadOnly = true;
            txtPrice.ReadOnly = true;
            txtVin.ReadOnly = true;
           // txtYear.ReadOnly = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           // txtMake.Clear();
            txtModel.Clear();
            txtPrice.Clear();
           // txtVin.Clear();
           // txtYear.Clear();
            txtModel.ReadOnly = false;
            txtPrice.ReadOnly = false;
            txtVin.ReadOnly = false;

            //txtYear.ReadOnly = false;
            //comboMake.Items.AddRange(new string[] { "Jaguar", "BMW", "Hyundai", "Ford", "Toyota", "Tesla", "Mario Kart" });

            btnSubmit.Enabled = true;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtVin.Text)&&!string.IsNullOrWhiteSpace(comboMake.SelectedItem.ToString())&&!string.IsNullOrWhiteSpace(txtModel.Text))
            {
                var newcar = new CarInfo();
                newcar.Make = comboMake.SelectedItem.ToString();
                newcar.Model = txtModel.Text;
                newcar.Vin = txtVin.Text;
                newcar.Year = DateTimePickerYear.Value.Year;
                newcar.Price = Convert.ToDecimal(txtPrice.Text);
                repository.AddRecord(newcar);
            }

            RefreshData();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var vin = CarGrid.CurrentRow.Cells[0].Value;
            var carupdate = repository.FindCar((string) vin);
            txtVin.Text = carupdate.Vin;
           
            txtModel.Text = carupdate.Model;
            txtPrice.Text = carupdate.Price.ToString();
            // txtYear.Text = carupdate.Year.ToString();
            
            comboMake.SelectedItem = carupdate.Make;



            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var vin = txtVin.Text;
            var carupdate = repository.FindCar((string)vin);
            carupdate.Make = comboMake.SelectedItem.ToString();
            carupdate.Model = txtModel.Text;
            carupdate.Vin = txtVin.Text;
            carupdate.Price = Convert.ToDecimal(txtPrice.Text);
            carupdate.Year = DateTimePickerYear.Value.Year;
            repository.UpdateRecord(vin, carupdate);

            RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var vin = CarGrid.CurrentRow.Cells[0].Value;
            var cardel = repository.FindCar((string)vin);
            repository.DeleteRecord(cardel);
            
            RefreshData();
            MessageBox.Show("Record of car is Deleted");

            
        }
        public void RefreshData()
        {
            
            comboMake.DataSource = null;
            comboMake.SelectedIndex = -1;
            txtPrice.Clear();
            txtVin.Clear();
            //txtYear.Clear();
            CarGrid.DataSource = null;
            CarGrid.DataSource = repository.Getinfo();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
           
            //CarGrid.DataSource = null;
            //CarGrid.DataSource = repository.Getinfo();
        }

        private void lblVin_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePickerYear_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void lblModel_Click(object sender, EventArgs e)
        {

        }

        private void txtVin_Validating(object sender, CancelEventArgs e)
        {
            

        }

        private void txtVin_Validated(object sender, EventArgs e)
        {
            if (txtVin.Text == string.Empty)
            {
                MessageBox.Show("Vin cannot be left empty");
                txtModel.ReadOnly = true;
                txtPrice.ReadOnly = true;
            }
            else
            {
                txtModel.ReadOnly = false;
                txtPrice.ReadOnly = false;
            }
        }

        private void comboMake_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePickerYear_Validated(object sender, EventArgs e)
        {
            if(DateTimePickerYear.Value.Year > DateTime.Now.Year)
            {
                MessageBox.Show("Invalid Year Selection");

                btnSubmit.Enabled = false;

            }
            btnSubmit.Enabled = true;
        }
    }
}
