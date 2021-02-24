using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Movies_Rental
{
    public partial class Customer : Form
    {
        Database db = new Database(); // Database conncetion from database class
        string CustID;
        public Customer()
        {
            InitializeComponent();
          //dgvcCustomer.DataSource= db.load();
            load();
           
        }

        public void load()  // load customer data in datagrid view 
        {
            db.sql = "select * from Customer";
            db.cmd = new SqlCommand(db.sql, db.con);
           db.con.Open();
            db.dr = db.cmd.ExecuteReader();
            dgvcCustomer.Rows.Clear();

            while (db.dr.Read())
            {
                dgvcCustomer.Rows.Add(db.dr[0], db.dr[1], db.dr[2], db.dr[3], db.dr[4]);
            }
           db.con.Close();
        }
        public void getid(string CustID)  // get customer id for edit and delete the data 
        {
            db.sql = "select * from Customer where CustID = '" +  CustID + "' ";
            db.cmd = new SqlCommand(db.sql, db.con);
            db.con.Open();
            db.dr = db.cmd.ExecuteReader();
            while (db.dr.Read())
            {
               txtCustID.Text = db.dr[0].ToString();
                txtFN.Text = db.dr[1].ToString();
                txtLN.Text= db.dr[2].ToString();
                txtA.Text = db.dr[3].ToString();
                txtM.Text= db.dr[4].ToString();

            }
            db.con.Close();
        }

      

        private void btnMain_Click(object sender, EventArgs e)  // back buttoon redirect to main page 
        {
            this.Hide();
            Main m = new Main();
            m.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==dgvcCustomer.Columns["edit"].Index && e.RowIndex >=0) // edit data in and update the data by choosing Customer id 
            { 
                db.Mode = false;
                CustID = dgvcCustomer.CurrentRow.Cells[0].Value.ToString();
                getid(CustID);
                db.Mode = false;

            }

            else if(e.ColumnIndex == dgvcCustomer.Columns["delete"].Index && e.RowIndex >= 0) 
            {
                db.Mode = false;
                CustID = dgvcCustomer.CurrentRow.Cells[0].Value.ToString();// delete data in the customer table by selecting customer id 
                db.sql = "delete from customer where CustID = @CustID";
                db.con.Open();
                db.cmd = new SqlCommand(db.sql, db.con);
                db.cmd.Parameters.AddWithValue("@CustID", CustID);
                db.cmd.ExecuteNonQuery();
               var result = MessageBox.Show("Are you sure want to delete Customer", "Warning",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

                 // If the no button was pressed ...
    if (result == DialogResult.No)
                {
                    // cancel the closure of the form.
                    load();
                }
                db.con.Close();

            }
        
        }

       

        private void btnAC_Click(object sender, EventArgs e) // btnAc is add customer where abmin can amke new entty and add new customer 
        {
            string CI = txtCustID.Text;
            string FN =  txtFN.Text;
            string LN = txtLN.Text;
            
            string M = txtM.Text;
            string A = txtA.Text;


            if (db.Mode == true)
            {
                db.sql = " insert into Customer(FirstName,LastName,Address,Phone)" + // insert query data is added in the database with the insert query
                     "values(@FirstName,@LastName,@Address,@Phone)";
                db.con.Open();      // connetion open 
                db.cmd = new SqlCommand(db.sql, db.con);
                // cmd.Parameters.AddWithValue("@CustID", CI);
                db.cmd.Parameters.AddWithValue("@FirstName", FN);
                db.cmd.Parameters.AddWithValue("@LastName", LN);
                db.cmd.Parameters.AddWithValue("@Address", A);
                db.cmd.Parameters.AddWithValue("@Phone", M);
                db.cmd.ExecuteNonQuery();
                MessageBox.Show("New Customer Added Successfully.");   // Message box show when customer added 
            }


            else
            {

            }

            db.con.Close(); // connetion close
        }

        private void btnUC_Click(object sender, EventArgs e)  // update customer information bt the update query 
        {
            string CI = txtCustID.Text;
            string FN = txtFN.Text;
            string LN = txtLN.Text;  // making string for each textbox from where values are coming d=for the update 

            string M = txtM.Text;
            string A = txtA.Text;
            CustID = dgvcCustomer.CurrentRow.Cells[0].Value.ToString();
            db.sql = " update Customer set FirstName=@FirstName,LastName=@LastName,Address=@Address,Phone=@Phone where CustID=@CustID";
            db.con.Open();         // connetion open 
            db.cmd = new SqlCommand(db.sql, db.con);
            db.cmd.Parameters.AddWithValue("@CustID", CustID);
            db.cmd.Parameters.AddWithValue("@FirstName", FN);
            db.cmd.Parameters.AddWithValue("@LastName", LN);
            db.cmd.Parameters.AddWithValue("@Address", A);
            db.cmd.Parameters.AddWithValue("@Phone", M);
            db.cmd.ExecuteNonQuery();
            MessageBox.Show("Record is Updated");
            db.con.Close();    // connection close 
        }

      
        private void btnRefresh_Click_1(object sender, EventArgs e) // btn refresh for refresh the data 
        {
          
            load(); 
        }

       
        private void btnMovies_Click(object sender, EventArgs e) // btn movies redirected you in the movies page where movies are appeared
        {
            Movies M = new Movies();
            M.Show();
            this.Hide();
        }

        private void btnRental_Click(object sender, EventArgs e)// btn Rental redirected you in the issue and return  page where rented movies  are appeared
        {
            Rental R = new Rental();
            R.Show();
            this.Hide();
        }

        private void btnIssue_Click(object sender, EventArgs e) // btn issue where movies are issued to customer 
        {
            Rental R = new Rental();
            R.Show();
            this.Hide();
        }

        private void btnReturm_Click(object sender, EventArgs e) // btn return for return the movies 
        {
            Return Ret = new Return();
            Ret.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)   // clear the text boxes for write new entries
        {
            txtCustID.Clear();
            txtFN.Clear();
            txtLN.Clear();
           txtM.Clear();
            txtA.Clear();
 
        }

      
    }
}
