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
    public partial class Return : Form
    {
        Database db = new Database(); // database connetion 
        String RMID;
        public Return()
        {
            InitializeComponent();
            load(); // load form 

        }


        public void load() // load data in rented movoes view
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

        private void txtMovieID_SelectedIndexChanged(object sender, EventArgs e)  //select movie id for edit and delete the data 
        {

            db.cmd = new SqlCommand("select * from RentedMovies where RMID = '" + txtRMID.Text + "' ", db.con);
            db.con.Open();
            db.dr = db.cmd.ExecuteReader();
            if (db.dr.Read())
            { txtRMID.Text = db.dr["RMID"].ToString();
                txtMovieID.Text = db.dr["MovieIDFK"].ToString();

                txtCustID.Text = db.dr["CustIDFK"].ToString();
                txtFN.Text = db.dr["FM"].ToString();
                txtFN.Text = db.dr["LM"].ToString();
                txtCost.Text = db.dr["Rental_Cost"].ToString();

            }

            else
            {
                MessageBox.Show("not found");
            }
            db.con.Close();
        }

        private void Return_Load(object sender, EventArgs e)
        {

        }
        public void getid(string RMID)
        {
            db.sql = "select * from RentedMovies where RMID = '" + RMID + "' ";
            db.cmd = new SqlCommand(db.sql, db.con);
            db.con.Open();
            db.dr = db.cmd.ExecuteReader();
            while (db.dr.Read())
            {
                txtRMID.Text = db.dr[0].ToString();
                txtMovieID.Text = db.dr[1].ToString();
                txtCustID.Text = db.dr[2].ToString();
                txtFN.Text = db.dr[3].ToString();
                txtLN.Text = db.dr[4].ToString();
               txtCost.Text = db.dr[6].ToString();


            }
            db.con.Close();
        }


        private void dgvRentalMovie_CellContentClick(object sender, DataGridViewCellEventArgs e)  // for update and delete the data 
        {
            if (e.ColumnIndex == dgvRentalMovie.Columns["update"].Index && e.RowIndex >= 0)
            {
                db.Mode = false;
                RMID = dgvRentalMovie.CurrentRow.Cells[0].Value.ToString();
                getid(RMID);
                db.con.Open();
              
                db.con.Close();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)  // return movies 
        {
            string RM = txtRMID.Text;
            string RD = returndate.Value.Date.ToString("yyyy-MM-dd");
            RMID = dgvRentalMovie.CurrentRow.Cells[0].Value.ToString();
            db.sql = " update RentedMovies set DateReturned=@DateReturned where RMID=@RMID";
            db.con.Open();
            db.cmd = new SqlCommand(db.sql, db.con);
            db.cmd.Parameters.AddWithValue("@RMID", RMID);
            db.cmd.Parameters.AddWithValue("@DateReturned", RD);
            db.cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updateddddd");
            db.con.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {  
            txtCustID.Clear();   // clear textoxes 
            txtFN.Clear();
            txtLN.Clear();
            txtCost.Clear();
            txtMovieID.Clear();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.Show();
            this.Hide();
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            Rental R = new Rental();
            R.Show();
            this.Hide();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            Rental R = new Rental();
            R.Show();
            this.Hide();
        }

        private void btnReturm_Click(object sender, EventArgs e)
        {
            load();
        }

        private void lblCost_Click(object sender, EventArgs e)
        {

        }
    }
    }

