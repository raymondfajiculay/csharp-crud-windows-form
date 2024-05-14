using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace windows_form
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            //Clear and Refresh Table first before query
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string ConString = "datasource=localhost;username=root;password=password";
            string Query = "SELECT * FROM employee.userdata";
            MySqlConnection conn = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(Query, conn);
            MySqlDataReader myReader;

            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string id = myReader.GetString("id");
                    string fname = myReader.GetString("first_name");
                    string lname = myReader.GetString("last_name");
                    string email = myReader.GetString("email");
                    string gender = myReader.GetString("gender");

                    dataGridView1.Rows.Add(id, fname, lname, email, gender);
                }
            }
            catch (Exception ex)
            {

            }

            conn.Close();
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void read_data_btn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void insert_data_btn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fname_text.Text) || String.IsNullOrEmpty(lname_text.Text))
            {
                MessageBox.Show("Value is required", "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string connectionString = "datasource=localhost;username=root;password=password";
                string query = "INSERT INTO employee.userdata (first_name, last_name, email, gender) VALUES (@FirstName, @LastName, @Email, @Gender)";

               using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters and their values
                        command.Parameters.AddWithValue("@FirstName", fname_text.Text);
                        command.Parameters.AddWithValue("@LastName", lname_text.Text);
                        command.Parameters.AddWithValue("@Email", email_text.Text);
                        command.Parameters.AddWithValue("@Gender", gender_text.Text);

                        try
                        {
                            connection.Open();
                            int rowAffected = command.ExecuteNonQuery();
                            MessageBox.Show("Insert success", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while connecting :" + ex, "Message info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        fname_text.Text = "";
                        lname_text.Text = "";
                        email_text.Text = "";
                        gender_text.Text = "";
                        connection.Close();
                        LoadData();
                    }
                }

               
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string idvalue = row.Cells[0].Value.ToString();
                string fnamevalue = row.Cells[1].Value.ToString();
                string lnamevalue = row.Cells[2].Value.ToString();
                string emailvalue = row.Cells[3].Value.ToString();
                string gendervalue = row.Cells[4].Value.ToString();
            
                id_text.Text = idvalue;
                fname_text.Text = fnamevalue;
                lname_text.Text = lnamevalue;
                email_text.Text = emailvalue;
                gender_text.Text = gendervalue;
            }
        }

        private void update_date_btn_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(fname_text.Text) || String.IsNullOrEmpty(lname_text.Text))
            {
                MessageBox.Show("Value is required", "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string connectionString = "datasource=localhost;username=root;password=password";
                string query = "UPDATE employee.userdata SET first_name = @FirstName, last_name = @LastName, email = @Email, gender = @Gender WHERE id = @Id";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters and their values
                        command.Parameters.AddWithValue("@Id", id_text.Text);
                        command.Parameters.AddWithValue("@FirstName", fname_text.Text);
                        command.Parameters.AddWithValue("@LastName", lname_text.Text);
                        command.Parameters.AddWithValue("@Email", email_text.Text);
                        command.Parameters.AddWithValue("@Gender", gender_text.Text);

                        try
                        {
                            connection.Open();
                            int rowAffected = command.ExecuteNonQuery();
                            MessageBox.Show("Updated success", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while connecting :" + ex, "Message info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        fname_text.Text = "";
                        lname_text.Text = "";
                        email_text.Text = "";
                        gender_text.Text = "";
                        connection.Close();
                        LoadData();
                    }
                }


            }
        }

        private void delete_data_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this data?", "Message Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialogResult == DialogResult.Yes)
            {
                string connectionString = "datasource=localhost;username=root;password=password";
                string query = "DELETE FROM employee.userdata WHERE id = @Id";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters and their values
                        command.Parameters.AddWithValue("@Id", id_text.Text);

                        try
                        {
                            connection.Open();
                            int rowAffected = command.ExecuteNonQuery();
                            MessageBox.Show("Deleted success", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while connecting :" + ex, "Message info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        fname_text.Text = "";
                        lname_text.Text = "";
                        email_text.Text = "";
                        gender_text.Text = "";
                        connection.Close();
                        LoadData();
                    }
                }
            }
            else
            {

            }

        }
    }
}
