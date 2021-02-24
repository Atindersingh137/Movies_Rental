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

    public partial class Rental : Form
    {
        Return R = new Return();
        Database db = new Database(); //Database conncetion from database class
        string RMID;
        public Rental()
        {
            InitializeComponent();
        
            load();
            movieload();
            customerload();

        }

    

        public void movieload()
        {
            db.cmd = new SqlCommand("select * from Movies", db.con);
            db.con.Open();
           db. dr = db.cmd.ExecuteReader();
            while (db.dr.Read())
            {
                txtMovieID.Items.Add(db.dr["MovieID"].ToString());
            }
            db.con.Close();
        }
        public void customerload()
        {
           db. cmd = new SqlCommand("select * from Customer", db.con);
            db.con.Open();
           db. dr = db.cmd.ExecuteReader();
            while (db.dr.Read())
            {
                txtCustID.Items.Add(db.dr["CustID"].ToString());
            }
            db.con.Close();
        }
       
        public void load()
        {
            db.sql = "select * from RentedMovies";
            db.cmd = new SqlCommand(db.sql, db.con);
            db.con.Open();
            db.dr = db.cmd.ExecuteReader();
            dgvRentalMovie.Rows.Clear();

            while (db.dr.Read())
            {
                dgvRentalMovie.Rows.Add(db.dr[0], db.dr[1], db.dr[2], db.dr[3], db.dr[4], db.dr[5], db.dr[6], db.dr[7]);
            }
            db.con.Close();
        }
        public void getid(string RMID)
        {
            db.sql = "select * from RentedMovies where RMID = '" + RMID + "' ";
            db.cmd = new SqlCommand(db.sql, db.con);
            db.con.Open();
            db.dr = db.cmd.ExecuteReader();
            //while (db.dr.Read())
            //{
            //    txtMovieID.Text = db.dr[1].ToString();
            //    txtCustID.Text = db.dr[2].ToString();
            //    txtFN.Text = db.dr[3].ToString();
            //    txtLN.Text = db.dr[4].ToString();
            //    txtCost.Text = db.dr[6].ToString();
                     //}
            db.con.Close();
        }

        private void dgvcCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dgvRentalMovie.Rows[index];

            if (e.ColumnIndex == dgvRentalMovie.Rows[index].Index && e.RowIndex >= 0)
            {
                db.Mode = false;
                db.sql = "select * from RentedMovies where RMID = '" + RMID + "' ";
                db.cmd = new SqlCommand(db.sql, db.con);
                db.con.Open();
                db.dr = db.cmd.ExecuteReader();
                while (db.dr.Read())
                {
                    txtMovieID.Text = db.dr[1].ToString();
                    txtCustID.Text = db.dr[2].ToString();
                    txtFN.Text = db.dr[3].ToString();
                    txtLN.Text = db.dr[4].ToString();
                    txtCost.Text = db.dr[6].ToString();
                        }
                db.con.Close();
            }

            if (e.ColumnIndex == dgvRentalMovie.Columns["delete"].Index && e.RowIndex >= 0)
            {
                db.Mode = false;
                RMID = dgvRentalMovie.CurrentRow.Cells[0].Value.ToString();
                db.sql = "delete from RentedMovies where RMID = @RMID";
                db.con.Open();
                db.cmd = new SqlCommand(db.sql, db.con);
                db.cmd.Parameters.AddWithValue("@RMID", RMID);
                db.cmd.ExecuteNonQuery();
                var result = MessageBox.Show("Are you sure want to delete Customer", "Warning",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question);

                // If the no button was pressed ...
                if (result == DialogResult.No)
                {
                    // cancel the closure of the form.
                    R.Show();
                   
                }
                db.con.Close();


            }
        }



        private void txtCustID_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            {
                db.cmd = new SqlCommand("select * from Customer where CustID = '" + txtCustID.Text + "' ", db.con);
                db.con.Open();
                db.dr = db.cmd.ExecuteReader();
                if (db.dr.Read())
                {
                    txtFN.Text = db.dr["FirstName"].ToString();
                    txtLN.Text = db.dr["LastName"].ToString();

                }

                else
                {
                    MessageBox.Show("not found");
                }
                db.con.Close();
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            Main M = new Main();

            M.Show();

        }

      
        private void txtMovieID_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.cmd = new SqlCommand("select * from Movies where MovieID = '" + txtMovieID.Text + "' ", db.con);
            db.con.Open();
            db.dr = db.cmd.ExecuteReader();
            if (db.dr.Read())
            {
               
                txtCost.Text = db.dr["Rental_Cost"].ToString();

            }

            else
            {
                MessageBox.Show("not found");
            }
            db.con.Close();
        }

        private void btnIssue_Click_1(object sender, EventArgs e)
        {
            string MI = txtMovieID.Text;
            string CI = txtCustID.Text;
            string FN = txtFN.Text;
            string LN = txtLN.Text;
            string D = dateTime.Value.Date.ToString("yyyy-MM-dd");
            string C = txtCost.Text;
            // string RD = returndate.Value.Date.ToString("yyyy-MM-dd");



            if (db.Mode == true)
            {


                db.sql = " insert into RentedMovies(MovieIDFK,CustIDFK,FirstName,LastName,Cost,DateRented)" +
                    "values(@MovieIDFK,@CustIDFK,@FirstName,@LastName,@Cost,@DateRented)";
                db.con.Open();
                db.cmd = new SqlCommand(db.sql, db.con);
                db.cmd.Parameters.AddWithValue("@MovieIDFK", MI);
                db.cmd.Parameters.AddWithValue("@CustIDFK", CI);
                db.cmd.Parameters.AddWithValue("@FirstName", FN);
                db.cmd.Parameters.AddWithValue("@LastName", LN);
                db.cmd.Parameters.AddWithValue("@Cost", C);
                db.cmd.Parameters.AddWithValue("@DateRented", D);
                //  db.cmd.Parameters.AddWithValue("@DateReturned", RD);

                db.cmd.ExecuteNonQuery();
                MessageBox.Show("Record Added");

                db.con.Close();


            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load();
        }

      
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customer C = new Customer();
            C.Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnReturm_Click(object sender, EventArgs e)
        {
            
            R.Show();
            this.Hide();

        }

        private void Rental_Load(object sender, EventArgs e)
        {

        }
    }
    }

