using MaterialSkin.Controls;
using Microsoft.Data.Sqlite;

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
    }
}