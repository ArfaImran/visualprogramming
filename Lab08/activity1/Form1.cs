using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Lab8_Activity1

{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            //handling user data input 
            string gender, hobby, st = "";
            if (customerName.Text == "")
            {
                MessageBox.Show("Please enter customer Name");
                return;
            }

            if (radioMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            if (checkBoxReading.Checked)
            {
                hobby = "Reading";
            }
            else
            {
                hobby = "Writing";
            }
            if (radioButtonMarried.Checked)
            {
                //status = "Married";
                st = "1";


            }
            else
            {
                //status = "UnMarried";
                st = "0";

            }
            string Connection = "Data Source=DESKTOP-6CLP6M9\\SQLEXPRESS;Initial Catalog=CustomerDB;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection con = new SqlConnection(Connection);

            con.Open();

            string query = "insert into CustomerTable values('" + customerName.Text + "','" + countryName.Text + "','" + gender + "','" + hobby + "'," + st + ");";
            SqlCommand sqlCommand = new SqlCommand(query, con);
            sqlCommand.ExecuteNonQuery();
            con.Close();

            //frmCustomerPreview objPreview = new frmCustomerPreview();
            //objPreview.setValues(customerName.Text, countryName.Text, gender, hobby, status);
            //objPreview.Show();






        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void countryName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Connection = "Data Source=DESKTOP-6CLP6M9\\SQLEXPRESS;Initial Catalog=CustomerDB;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection con = new SqlConnection(Connection);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >-1) { 
                string selectedValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                customerName.Text = selectedValue;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string CustomerName = customerName.Text;
            string Connection = "Data Source=DESKTOP-6CLP6M9\\SQLEXPRESS;Initial Catalog=CustomerDB;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection con = new SqlConnection(Connection);
            con.Open();
            string query = "DELETE FROM CustomerTable WHERE CustomerName = '" + CustomerName + "'";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            con.Close();

        }

        private void Preview_Click(object sender, EventArgs e)
        {

            try
            {
                string Connection = "Data Source=DESKTOP-6CLP6M9\\SQLEXPRESS;Initial Catalog=CustomerDB;Integrated Security=True;Trust Server Certificate=True";
                SqlConnection con = new SqlConnection(Connection);
                con.Open();
                string query3 = "select * from CustomerTable";
                SqlCommand cmd3 = new SqlCommand(query3, con);
                var reader = cmd3.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                dataGridView1.DataSource = table;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string gender, hobby, st;
            //string status;
            if (radioMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            if (checkBoxReading.Checked)
            {
                hobby = "Reading";
            }
            else
            {
                hobby = "Writing";
            }
            if (radioButtonMarried.Checked)
            {
                //status = "Married";
                st = "1";


            }
            else
            {
                //status = "UnMarried";
                st = "0";

            }
            string Connection = "Data Source=DESKTOP-6CLP6M9\\SQLEXPRESS;Initial Catalog=CustomerDB;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection con = new SqlConnection(Connection);
            con.Open();
      
            string query = "Update CustomerTable set country='" + countryName.Text + "',gender='"+gender+"',hobby='"+hobby+"',status='"+st+"' where customerName='"+ customerName.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(query, con);
            sqlCommand.ExecuteNonQuery();
            con.Close() ;
        }
    }
}
