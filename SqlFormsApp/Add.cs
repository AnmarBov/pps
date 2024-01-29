using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace SqlFormsApp
{
    public partial class Add : Form
    {
        string connectionString = "Data Source=DESKTOP-B708273;Initial Catalog=psdsarcDatabase;Integrated Security=True;";

        private Form1 parentForm;
        public Add(Form1 form1)
        {
            InitializeComponent();
            parentForm = form1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO steps (steps_title) VALUES (@NewStepTitle)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@NewStepTitle", textBox1.Text);

                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            parentForm.get_Data_From_Sql();
           
            this.Close();   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
