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
    public partial class Movies : Form
    {
        Database db = new Database();// Database conncetion from database class
        string MovieID;
        public Movies()
        {
            InitializeComponent();
          
            load();

        }
        public void load()// load Movies data in datagrid view 
        {
            db.sql = "select * from Movies";
            db.cmd = new SqlCommand(db.sql, db.con);
            db.con.Open();
            db.dr = db.cmd.ExecuteReader();
            dgvMovie.Rows.Clear();

            while (db.dr.Read())
            {
                dgvMovie.Rows.Add(db.dr[0], db.dr[1], db.dr[2], db.dr[3], db.dr[4], db.dr[5], db.dr[6], db.dr[7]);
            }
            db.con.Close();
        }



        private void btnAM_Click(object sender, EventArgs e)// btnAM is add Movie where abmin can amke new entty and add new Movie 
        {
            load();
            string MI = txtMovieID.Text;
            string T = txtTitle.Text;
            string R = txtRating.Text;
            string D = datetime.Value.Date.ToString("yyyy-MM-dd");


            string RC = txtRC.Text;

            string C = txtCopies.Text;
            string P = txtPlot.Text;
            string G = txtGenre.Text;

            if (db.Mode == true)
            {
                db.sql = " insert into Movies(Title,Rating,Year,Rental_Cost,Copies,Plot,Genre)" +  // insert query data is added in the database with the ins
                    "values(@Title,@Rating,@Year,@Rental_Cost,@Copies,@Plot,@Genre)";
                db.con.Open();   // connection open
                db.cmd = new SqlCommand(db.sql, db.con);
                db.cmd.Parameters.AddWithValue("@MovieID", MI);
                db.cmd.Parameters.AddWithValue("@Title", T);
                db.cmd.Parameters.AddWithValue("@Rating", R);
                db.cmd.Parameters.AddWithValue("@Year", D);
                db.cmd.Parameters.AddWithValue("@Rental_Cost", RC);
                db.cmd.Parameters.AddWithValue("@Copies", C);
                db.cmd.Parameters.AddWithValue("@Plot", P);
                db.cmd.Parameters.AddWithValue("@Genre", G);
                db.cmd.ExecuteNonQuery();
                MessageBox.Show("Record Added");
               

            }


            else
            {

            }

            db.con.Close();   // conecction Close
        }
        public void getid(string MovieID)// get Movie id for edit and delete the data 
        {
            db.sql = "select * from Movies where MovieID = '" + MovieID + "' ";
            db.cmd = new SqlCommand(db.sql, db.con);
            db.con.Open();
            db.dr = db.cmd.ExecuteReader();
            while (db.dr.Read())
            {
                txtMovieID.Text = db.dr[0].ToString();
                txtTitle.Text = db.dr[1].ToString();
                txtRating.Text = db.dr[2].ToString();
              txtYear.Text = db.dr[3].ToString();
               txtRC.Text = db.dr[4].ToString();
                txtCopies.Text = db.dr[5].ToString();
                txtPlot.Text = db.dr[6].ToString();
                txtGenre.Text = db.dr[7].ToString();

            }
            db.con.Close();
        }

        private void btnMain_Click(object sender, EventArgs e)     // back button redirect to main page 
        {
            Main m = new Main();
            m.Show();
            this.Hide();

        }

        private void btnUM_Click(object sender, EventArgs e)    // update Movie information bt the update query 
        {
           
            
                

                string MI = txtMovieID.Text;
                string T = txtTitle.Text;
                string R = txtRating.Text; // making string for each textbox from where values are coming for the update 

                DateTime Year = datetime.Value.Date.ToLocalTime(); // datetime 
                string RC = txtRC.Text;
                string C = txtCopies.Text;
                string P = txtPlot.Text;
                string G = txtGenre.Text;
                MovieID = dgvMovie.CurrentRow.Cells[0].Value.ToString();
                db.sql = " update Movies set Title=@Title,Rating=@Rating,Year=@Year,Rental_Cost=@Rental_Cost,Copies=@Copies,Plot=@Plot,Genre=@Genre where MovieID=@MovieID";
                db.con.Open();     // connetion open 
                db.cmd = new SqlCommand(db.sql, db.con);
                db.cmd.Parameters.AddWithValue("@MovieID", MovieID);
                db.cmd.Parameters.AddWithValue("@Title", T);
                db.cmd.Parameters.AddWithValue("@Rating", R);
                db.cmd.Parameters.AddWithValue("@Year", Year);
                db.cmd.Parameters.AddWithValue("@Rental_Cost", RC);
                db.cmd.Parameters.AddWithValue("@Copies", C);
                db.cmd.Parameters.AddWithValue("@Plot", P);
                db.cmd.Parameters.AddWithValue("@Genre", G);
                db.cmd.ExecuteNonQuery();
                MessageBox.Show("Record Is Updated");
                db.con.Close();  // connection close
            

        }

        private void dgvMovie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvMovie.Columns["edit"].Index && e.RowIndex >= 0)
            {
                db.Mode = false;
                MovieID = dgvMovie.CurrentRow.Cells[0].Value.ToString();
                getid(MovieID);
                db.Mode = false;

            }

            else if (e.ColumnIndex == dgvMovie.Columns["delete"].Index && e.RowIndex >= 0)
            {
                db.Mode = false;
                MovieID = dgvMovie.CurrentRow.Cells[0].Value.ToString();
                db.sql = "delete from Movies where MovieID =@MovieID";
                db.con.Open();
                db.cmd = new SqlCommand(db.sql, db.con);
                db.cmd.Parameters.AddWithValue("@MovieID", MovieID);
                db.cmd.ExecuteNonQuery();
               MessageBox.Show("Record Deleteeeee");
                db.con.Close();




            }


            //    int index = e.RowIndex;
            //    DataGridViewRow row = dgvMovie.Rows[index];
            //    //    MessageBox.Show(row.Cells[5].Value.ToString());
            //    txtMovieID.Text = row.Cells[0].Value.ToString();
            //    txtTitle.Text = row.Cells[1].Value.ToString();
            //    txtRating.Text = row.Cells[2].Value.ToString();
            //    txtYear.Text = row.Cells[3].Value.ToString();
            //    txtRC.Text = row.Cells[4].Value.ToString();
            //    txtCopies.Text = row.Cells[5].Value.ToString();
            //    txtPlot.Text = row.Cells[6].Value.ToString();
            //    txtGenre.Text = row.Cells[7].Value.ToString();

        }

        private void btnRefresh_Click(object sender, EventArgs e)  // btn refresh for refresh the data 
        {
            Movies refresh = new Movies();
            refresh.Show();
            this.Hide();
        }

      
        private void datetime_ValueChanged(object sender, EventArgs e) //  movie cost depent on the  movie year of release 
        {
            if (datetime.Value.Date <= DateTime.Now.Date.AddYears(-5))
            {

                txtRC.Text = "2";
            }
            else
            {
                txtRC.Text = "5";
            }
        }

        private void btnRC_Click(object sender, EventArgs e) // btn for clear all the value from textboxes
        {
            txtMovieID.Clear();
            txtTitle.Clear();
            txtRating.Clear();
            txtYear.Clear();
            txtRC.Clear();
            txtPlot.Clear();
            txtCopies.Clear();
            txtGenre.Clear();
           
        }

        private void btnRental_Click(object sender, EventArgs e)// btn Rental redirected you in the issue and return  page where rented movies
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

        private void btnCustomer_Click(object sender, EventArgs e) // btn customer page 
        {
            Customer c = new Customer();
            c.Show();
            this.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)// btn return where return movies 
        {
            Return R= new Return();
            R.Show();
            this.Hide();

        }

    } 

    }
    

