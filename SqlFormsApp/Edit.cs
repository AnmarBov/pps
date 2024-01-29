using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SqlFormsApp
{
    public partial class Edit : Form
    {
        private Form1 parentForm;
        int selected = 0;
        string connectionString = "Data Source=DESKTOP-B708273;Initial Catalog=psdsarcDatabase;Integrated Security=True;";
        string old = "";
        public Edit(Form1 form1, String oldText, int index)
        {
            InitializeComponent();
            label2.Text = oldText;
            selected = index;
            parentForm = form1;
            old = oldText;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE steps SET steps_title = @NewStepTitle WHERE steps_title = @OldStepTitle";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {

                    command.Parameters.AddWithValue("@NewStepTitle", textBox1.Text);
                    command.Parameters.AddWithValue("@OldStepTitle", old);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Data updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No rows updated. Step with ID   not found.");
                    }
                }
            }
            parentForm.get_Data_From_Sql();

            this.Close();
        }
    }
}
