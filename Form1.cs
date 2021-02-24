using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies_Rental
{
    public partial class Form1 : Form
    {
        string username = "admin";  // set strings for login 
        string password = "admin123";

        public Form1()
        {
            InitializeComponent();
        }

      

        private void btnlogin_Click(object sender, EventArgs e) //btnlogin if condition when both strings fill the textbox the login succesfull, otherwise message show incorect details
        {
            if (txtuname.Text == username && txtpassword.Text == password)

            {
                Main m = new Main();
                m.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invaild details");
                txtpassword.Clear();
                txtuname.Clear();
            }

        }

        private void btncancel_Click(object sender, EventArgs e) // btnCancel whne press on cancel both text box clear for fill new details
        {
            txtpassword.Clear();
            txtuname.Clear();
        }


      
    }
}
