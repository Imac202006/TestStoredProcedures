using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestStoredProcedures.Controller;
using TestStoredProcedures.Helper;
using TestStoredProcedures.Model;
using TestStoredProcedures.View;
using static TestStoredProcedures.Helper.HelperLog;

namespace TestStoredProcedures
{
    public partial class MainForm : Form
    {
        private int selectedId = 0;
        private readonly HelperDBConn helperDBConn;

        public MainForm()
        {
            helperDBConn = new HelperDBConn();
            InitializeComponent();
            HelperLog.logAction = LogError;
            GetCarData();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string carBrand = BrandTxtBox.Text;
                string carName = NameTxtBox.Text;
                DateTime manufactureDate = ManufactureDtPicker.Value;

                new HelperCar().AddCar(new ModelCar(
                    carBrand,
                    carName,
                    manufactureDate
                    ));

                GetCarData();
                HelperMsgBox.PromptMsgBoxOK($"Insert new car [{carBrand} - {carName} - {manufactureDate}] successfully.", "Insert New Car");
            }
            catch (Exception ex)
            {
                HelperLog.logAction.Invoke("Click Add Button action fail.", ex);
            }
        }

        private void GetCarData()
        {
            string sql = HelperCar.GetAllCarQuery();
            DataTable dataTable = helperDBConn.GetDataTable(sql);
            DataGVCar.DataSource = dataTable;
        }

        private void LogError(string message, Exception exception)
        {
            string messageStr = GenerateMessage(HelperLog.LogTypeError, message, exception.ToString());

            ErrorMsgTxtBox.AppendText(messageStr + Environment.NewLine);
        }

        private static string GenerateMessage(string logType, string message, string exception)
        {
            return $"{logType} - {DateTime.Now} - {message} - Exception: {exception}";
        }

        private void ClearErrMsgBtn_Click(object sender, EventArgs e)
        {
            ErrorMsgTxtBox.Clear();
        }

        private void DataGVCar_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = DataGVCar.SelectedRows[0].Index;

                selectedId = Convert.ToInt32(DataGVCar.SelectedRows[0].Cells["Id"].Value);
                BrandTxtBox.Text = DataGVCar.SelectedRows[0].Cells["Brand"].Value.ToString();
                NameTxtBox.Text = DataGVCar.SelectedRows[0].Cells["Model"].Value.ToString();
                ManufactureDtPicker.Value = DateTime.Parse(DataGVCar.SelectedRows[0].Cells["ManufactureDate"].Value.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fail to load the car information. {ex}");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = HelperMsgBox.PromptMsgBoxYesNo("Are you sure to update this car?", "Update Confirmation");

                if (!result)
                {
                    return;
                }

                //Run query
                new HelperCar().UpdateCarById(selectedId, BrandTxtBox.Text, NameTxtBox.Text, ManufactureDtPicker.Value);

                GetCarData();

                HelperMsgBox.PromptMsgBoxOK($"Update the car successfully.", "Update Car");

                Clear();
            }
            catch (Exception ex)
            {
                HelperLog.logAction.Invoke("Click Update Button action fail.", ex);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = HelperMsgBox.PromptMsgBoxYesNo("Are you sure to delete this car?", "Delete Confirmation");

                if (!result)
                {
                    return;
                }

                // Check if a row is selected
                if (DataGVCar.SelectedRows.Count > 0)
                {
                    // Get the selected row index
                    int selectedIndex = DataGVCar.SelectedRows[0].Index;
                    int recordId = Convert.ToInt32(DataGVCar.SelectedRows[0].Cells["Id"].Value);

                    // If the DataGridView is bound to a DataTable or similar, remove from the data source
                    DataTable dt = (DataTable)DataGVCar.DataSource;

                    //Run query
                    new HelperCar().DeleteCarById(recordId);

                    //Remove from the data grid
                    dt.Rows[selectedIndex].Delete();

                    // Refresh the DataGridView to reflect changes
                    DataGVCar.DataSource = dt;

                    HelperMsgBox.PromptMsgBoxOK($"Delete the selected car successfully.", "Delete Car");
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.");
                }
            }
            catch (Exception ex)
            {
                HelperLog.logAction.Invoke("Click Delete Button action fail.", ex);
            }

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            selectedId = 0;
            BrandTxtBox.Text = "";
            NameTxtBox.Text = "";
            ManufactureDtPicker.Value = HelperDateTime.GetUtcNow();
        }
    }
}
