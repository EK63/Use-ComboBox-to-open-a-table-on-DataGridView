using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;

namespace ComboData
{
    public partial class frmMain : Form
    {
        //SQL Connection
        SqlConnection connection;
        String connectionString;
        DataTable tblfruitTable = new DataTable();

        public frmMain()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["ComboData.Properties.Settings.PicklistConnectionString"].ConnectionString;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            PopulateFruit();
        }

        private void PopulateFruit()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("Select FruitId,FruitName,FruitDescription,FruitTableName  FROM tblFruit", connection))
            {
                adapter.Fill(tblfruitTable);

                //Insert the Default Item to DataTable.
                DataRow row = tblfruitTable.NewRow();
                row[0] = 0;
                row[1] = "Please select";
                tblfruitTable.Rows.InsertAt(row, 0);

                // ComboBox display and value definition
                cboSelectFruit.DisplayMember    = "FruitName";
                cboSelectFruit.ValueMember      = "FruitDescription";

                cboSelectFruit.DataSource = tblfruitTable;
            }
        }

        private void cboSelectFruit_Select(object sender, EventArgs e)
        {
            //Out put of the selection
            lblPickListValue.Text       = cboSelectFruit.Text;
            lblPickListDescription.Text = cboSelectFruit.SelectedValue.ToString(); // this is the hover text

            //Opening of the DataGridView
            int rowIndex = cboSelectFruit.SelectedIndex;
            if (rowIndex >= 0)
            {
                // Display tbl name to be opened
                lblPickListFileName.Text = tblfruitTable.Rows[rowIndex]["FruitTableName"].ToString();

                //Open DataGridView
                using (connection = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * FROM " + tblfruitTable.Rows[rowIndex]["FruitTableName"].ToString(), connection))
                {
                    DataTable dgvTableToUse = new DataTable();
                    adapter.Fill(dgvTableToUse);

                    dgvUtilityTable.DataSource = dgvTableToUse;
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
