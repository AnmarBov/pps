using System.Text;
using System.Data.SqlClient;
using Spire.Xls;
using System.Xml.Linq;

namespace SqlFormsApp
{
    public partial class Form1 : Form
    {
        // Connection string with Windows Authentication
        string connectionString = "Data Source=DESKTOP-B708273;Initial Catalog=psdsarcDatabase;Integrated Security=True;";
        public int select = 0;
        public Form1()
        {
            InitializeComponent();
            get_Data_From_Sql();

        }
        public void get_Data_From_Sql()
        {
            checkedListBox1.Items.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT steps_title FROM steps"; // Replace YourTableName with your actual table name

                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            checkedListBox1.Items.Add(reader["steps_title"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (one.Checked)
            {
                // Clear items from the ListBox
                listBox1.Items.Clear();

                // Iterate through items in the CheckedListBox
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    // Check if the item is checked
                    if (checkedListBox1.GetItemChecked(i))
                    {
                        // Add the checked item to the ListBox
                        listBox1.Items.Add(checkedListBox1.Items[i]);
                    }
                }
            }
            if (two.Checked)
            {
                // Clear items from the ListBox
                listBox2.Items.Clear();

                // Iterate through items in the CheckedListBox
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    // Check if the item is checked
                    if (checkedListBox1.GetItemChecked(i))
                    {
                        // Add the checked item to the ListBox
                        listBox2.Items.Add(checkedListBox1.Items[i]);
                    }
                }
            }
        }
        public void UpdateCheckedListBoxItemText(int index, string newText)
        {

            checkedListBox1.Items[index] = newText;
        }

        public void AddCheckedListBoxItem(string newItem)
        {

            checkedListBox1.Items.Add(newItem);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            StringBuilder checkedItemsText = new StringBuilder();
            int index = 0;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                // Check if the item is checked
                if (checkedListBox1.GetItemChecked(i))
                {
                    checkedItemsText.Append(checkedListBox1.Items[i]);
                    index = i;
                    select = index;
                }
            }
            Edit edit = new Edit(this, checkedItemsText.ToString(), index);
            edit.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Add add = new Add(this);
            add.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            StringBuilder checkedItemsText = new StringBuilder();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                // Check if the item is checked
                if (checkedListBox1.GetItemChecked(i))
                {
                    checkedItemsText.Append(checkedListBox1.Items[i]);
                }
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();
                    string deleteQuery = "DELETE FROM steps WHERE steps_title = @StepTitle";
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@StepTitle", checkedItemsText.ToString());
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Data updated successfully.");
                            get_Data_From_Sql();
                        }
                        else
                        {
                            Console.WriteLine("No rows updated. Step with ID   not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (one.Checked)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else if (two.Checked)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }

        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\NMr\\Desktop\\img\\newTemp.xlsx"; // Replace with your actual file path
            Workbook workbook = new Workbook();

            //Remove default worksheets
            workbook.LoadFromFile(filePath);


            //Write data to specific cells
            
            if (one.Checked)
            {
                //Add a worksheet and name it
                Worksheet worksheet = workbook.Worksheets.Add("Sheet1");

                Worksheet sheet = workbook.Worksheets["Sheet1"];
                int lastRow = sheet.LastRow + 1;
                foreach (var checkedItem in listBox1.Items)
                {

                    //int index = checkedListBox1.Items.IndexOf(checkedItem);
                    worksheet.Range[lastRow, 1].Value = checkedItem.ToString();
                    Console.WriteLine(lastRow + " " + checkedItem.ToString());
                    lastRow = sheet.LastRow + 1;

                }
                //Auto fit column width
                worksheet.AllocatedRange.AutoFitColumns();
            }
            if (two.Checked)
            {
                Worksheet worksheet = workbook.Worksheets.Add("Sheet2");

                Worksheet sheet = workbook.Worksheets["Sheet2"];
                int lastRow = sheet.LastRow + 1;
                foreach (var checkedItem in listBox2.Items)
                {

                    //int index = checkedListBox1.Items.IndexOf(checkedItem);
                    worksheet.Range[lastRow, 1].Value = checkedItem.ToString();
                    Console.WriteLine(lastRow + " " + checkedItem.ToString());
                    lastRow = sheet.LastRow + 1;

                }
                //Auto fit column width
                worksheet.AllocatedRange.AutoFitColumns();
            }
            


            //Save to an Excel file
            workbook.Save();
        }
    }
}






