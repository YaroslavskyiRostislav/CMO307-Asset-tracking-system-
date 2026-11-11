using AssetTracker.Data;
using AssetTracker.Models;
using MySql.Data.MySqlClient;
namespace AssetTracker;

public partial class AddAssetForm : Form
{
    public AddAssetForm()
    {
        InitializeComponent();
    }

    private void AddAssetForm_Load(object sender, EventArgs e)
    {
        try
        {
            cboEmployee.DataSource = new EmployeeRepository().GetAll();
            cboEmployee.SelectedIndex = -1;
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Could not load employees: " + ex.Message);
        }
    }


    private void txtSystemName_TextChanged(object sender, EventArgs e)
    {

    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtSystemName.Text) ||
            string.IsNullOrWhiteSpace(txtModel.Text) ||
            string.IsNullOrWhiteSpace(txtManufacturer.Text) ||
            string.IsNullOrWhiteSpace(txtType.Text) ||
            string.IsNullOrWhiteSpace(txtIpAddress.Text) ||
            cboEmployee.SelectedIndex == -1)
        {
            MessageBox.Show("Please fill in all fields and choose an employee.");
            return;
        }

        var asset = new Asset
        {
            SystemName = txtSystemName.Text.Trim(),
            Model = txtModel.Text.Trim(),
            Manufacturer = txtManufacturer.Text.Trim(),
            AssetType = txtType.Text.Trim(),
            IpAddress = txtIpAddress.Text.Trim(),
            PurchaseDate = dtpPurchaseDate.Checked ? dtpPurchaseDate.Value.Date : (DateTime?)null,
            Notes = txtNotes.Text.Trim(),
            ResponsibleEmployee = (Employee)cboEmployee.SelectedItem
        };

        try
        {
            new AssetRepository().Add(asset);
            MessageBox.Show("Asset saved. ID: " + asset.AssetId);
            ClearForm();
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Database error: " + ex.Message);
        }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        ClearForm();
    }

    private void ClearForm()
    {
        txtSystemName.Clear();
        txtModel.Clear();
        txtManufacturer.Clear();
        txtType.Clear();
        txtIpAddress.Clear();
        txtNotes.Clear();
        dtpPurchaseDate.Checked = false;
        cboEmployee.SelectedIndex = -1;
    }
}

