using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_06
{
    public partial class Form1 : Form
    {
        private List<string> dataList;
        public Form1()
        {
            InitializeComponent();
            dataList = new List<string>();

        }

        private void lstBoxData_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string item = txtInput.Text.Trim(); // Get input from TextBox
            if (!string.IsNullOrEmpty(item))
            {
                dataList.Add(item); // Add item to List
                txtInput.Clear();    // Clear the input TextBox
                DisplayList();       // Refresh the ListBox display
            }
            else
            {
                MessageBox.Show("Please enter a valid item.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string item = txtInput.Text.Trim(); // Get input from TextBox
            if (dataList.Contains(item))
            {
                dataList.Remove(item); // Remove item from List
                txtInput.Clear();      // Clear the input TextBox
                DisplayList();         // Refresh the ListBox display
            }
            else
            {
                MessageBox.Show("Item not found in the list.");
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            dataList.Sort(); // Sort the List alphabetically
            DisplayList();   // Refresh the ListBox display
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DisplayList();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DisplayList()
        {
            lstBoxData.Items.Clear(); // Clear the ListBox
            foreach (var item in dataList)
            {
                lstBoxData.Items.Add(item); // Add items to ListBox
            }

        }
    }
}
