using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // include library for show the window form properties 
using System.Data.SqlClient;

namespace Movies_Rental
{
    public partial class Main : Form // Main form
    {
        Database db = new Database(); //  connection with Database class 

       
        Form1 f = new Form1();     // Form 1 Login page 
        Customer c = new Customer();  // customer page 
        Movies M = new Movies();// movie PAge
        Rental R = new Rental(); // rental page for issue and retun the movie

        public Main()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e) // Customer page will appear by click btnCustomer 
        {
            c.Show();
          
            this.Hide();

        }

        private void btnMovie_Click(object sender, EventArgs e) // Movie Page will appear by click btnMovie
        {
           
            M.Show();
            this.Hide();
        }

        private void btnRental_Click(object sender, EventArgs e)// rental page will appear by click btnRental 
        {
      
            R.Show();
            this.Hide();

        }


        private void btnLO_Click(object sender, EventArgs e)   // Log out button  function run this from close and login page appear.
        {
           
            f.Show();
            this.Hide();
          
        }

        private void btnCPM_Click(object sender, EventArgs e) //CPM( check popular movie ) show movie popular movie id in the mesage box 
        {
            MessageBox.Show("Movie ID Number : " + db.TOPMovie() + "  is On Top.");
        }

        private void btnCTC_Click(object sender, EventArgs e) // CTC(  check Top customer Name ) sjow top customer details in the meassage   box
        {
            MessageBox.Show(db.TopCustomer() + " is our Best Customer ");
        }

       
    }
}
