using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_Activity1
{
    public partial class frmCustomerPreview : Form
    {
        public frmCustomerPreview()
        {
            InitializeComponent();
        }

        private void frmCustomerPreview_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmCustomerPreview_Load_1(object sender, EventArgs e)
        {

        }
        public void setValues(string name, string country, string gender, string hobby, string status) { 
         labelName.Text = name;
         labelCountry.Text = country;
            labelGender.Text = gender;
            labelHobbies.Text = hobby;
            labelStatus.Text = status;
        
        }
    }
}
