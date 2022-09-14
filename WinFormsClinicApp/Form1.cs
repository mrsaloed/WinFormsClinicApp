using MaterialSkin.Controls;
using Microsoft.Data.Sqlite;
using System.Data;

namespace WinFormsClinicApp
{
    public partial class MainForm : MaterialForm
    {

        private string dbPath;
        private static string dbConectionLabelString = "Подключение к БД: ";
        private DataBase db;
        private bool connectionOK = false;
        public MainForm()
        {
            InitializeComponent();
            customerDataGridView.ReadOnly = true;
            animalsDataGridView.ReadOnly = true;
        }

        private void bdConnectButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "db files (*.db)|*.db|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    dbPath = openFileDialog.FileName;
                    try
                    {
                        db = DataBase.Instance();
                        db.CheckDb(dbPath);
                        dbConnectionLabel.Text = dbConectionLabelString + " Установлено";
                        connectionOK = true;
                    }
                    catch (SqliteException ex)
                    {
                        connectionOK = false;
                        dbConnectionLabel.Text = dbConectionLabelString + " Не установлено. Ошибка " + ex.Message; 
                    }
                    
                }
            }
        }

        private void materialTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!connectionOK)
            {
                MessageBox.Show("Выберите файл базы данных!", "Ошибка", MessageBoxButtons.OK);
                materialTabControl.SelectedTab = materialTabControl.TabPages[0];
            }
            else
            {
                if (materialTabControl.SelectedTab == materialTabControl.TabPages[1])
                {
                    customerDataGridView.DataSource = db.GetCustomers();
                }
                if (materialTabControl.SelectedTab == materialTabControl.TabPages[2])
                {
                    animalsDataGridView.DataSource = db.GetAnimals();
                }
            }
        }

        private void customerDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int customerId = Convert.ToInt32(customerDataGridView[0, e.RowIndex].Value);
                materialTabControl.SelectedTab = materialTabControl.TabPages[2];
                animalsDataGridView.DataSource = db.GetCustomersAnimals(customerId);
            }
        }

        private void customerIdTextBox_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = customerDataGridView.DataSource;
            bs.Filter = "Id LIKE '%" + customerIdTextBox.Text + "%'";
            customerDataGridView.DataSource = bs.DataSource;
            //(customerDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"Id LIKE '%{customerIdTextBox.Text}%'";
        }

        private void customerSurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            (customerDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"F LIKE '%{customerSurnameTextBox.Text}%'";
        }

        private void customerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            (customerDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"I LIKE '%{customerNameTextBox.Text}%'";
        }

        private void customerPatronymicTextBox_TextChanged(object sender, EventArgs e)
        {
            (customerDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"O LIKE '%{customerPatronymicTextBox.Text}%";
        }
    }
}