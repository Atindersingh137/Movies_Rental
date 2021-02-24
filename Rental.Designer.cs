
namespace Movies_Rental
{
    partial class Rental
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRentalMovie = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCustID = new System.Windows.Forms.ComboBox();
            this.txtMovieID = new System.Windows.Forms.ComboBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txttoday = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.moviename = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.lblReturn = new System.Windows.Forms.Button();
            this.btnReturm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.pbCustomer = new System.Windows.Forms.PictureBox();
            this.lblheadimg = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pbfooter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalMovie)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfooter)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRentalMovie
            // 
            this.dgvRentalMovie.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRentalMovie.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRentalMovie.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRentalMovie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRentalMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentalMovie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column7,
            this.Column5,
            this.delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRentalMovie.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRentalMovie.Location = new System.Drawing.Point(328, 173);
            this.dgvRentalMovie.Name = "dgvRentalMovie";
            this.dgvRentalMovie.Size = new System.Drawing.Size(958, 230);
            this.dgvRentalMovie.TabIndex = 1;
            this.dgvRentalMovie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcCustomer_CellContentClick);
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Rental_ID";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Movie id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Customer id";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "FirstName";
            this.Column3.Name = "Column3";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "LastName";
            this.Column6.Name = "Column6";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Date Rented";
            this.Column4.Name = "Column4";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Cost";
            this.Column7.Name = "Column7";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date Returned";
            this.Column5.Name = "Column5";
            // 
            // delete
            // 
            this.delete.HeaderText = "Delete";
            this.delete.Name = "delete";
            this.delete.Text = "Delete";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Ivory;
            this.groupBox1.Controls.Add(this.txtCustID);
            this.groupBox1.Controls.Add(this.txtMovieID);
            this.groupBox1.Controls.Add(this.dateTime);
            this.groupBox1.Controls.Add(this.txtCost);
            this.groupBox1.Controls.Add(this.lblCost);
            this.groupBox1.Controls.Add(this.txttoday);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.moviename);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFN);
            this.groupBox1.Controls.Add(this.txtLN);
            this.groupBox1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 341);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Issue Movie To Customer";
            // 
            // txtCustID
            // 
            this.txtCustID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCustID.FormattingEnabled = true;
            this.txtCustID.Location = new System.Drawing.Point(115, 82);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(143, 20);
            this.txtCustID.TabIndex = 21;
            this.txtCustID.SelectedIndexChanged += new System.EventHandler(this.txtCustID_SelectedIndexChanged_1);
            // 
            // txtMovieID
            // 
            this.txtMovieID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMovieID.FormattingEnabled = true;
            this.txtMovieID.Location = new System.Drawing.Point(115, 28);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(143, 20);
            this.txtMovieID.TabIndex = 20;
            this.txtMovieID.SelectedIndexChanged += new System.EventHandler(this.txtMovieID_SelectedIndexChanged);
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(115, 258);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(143, 19);
            this.dateTime.TabIndex = 14;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(115, 217);
            this.txtCost.Multiline = true;
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(143, 24);
            this.txtCost.TabIndex = 13;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCost.Location = new System.Drawing.Point(8, 211);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(42, 21);
            this.lblCost.TabIndex = 12;
            this.lblCost.Text = "Cost";
            // 
            // txttoday
            // 
            this.txttoday.AutoSize = true;
            this.txttoday.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttoday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txttoday.Location = new System.Drawing.Point(8, 254);
            this.txttoday.Name = "txttoday";
            this.txttoday.Size = new System.Drawing.Size(41, 21);
            this.txttoday.TabIndex = 10;
            this.txttoday.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(6, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Last Name";
            // 
            // moviename
            // 
            this.moviename.AutoSize = true;
            this.moviename.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moviename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.moviename.Location = new System.Drawing.Point(7, 28);
            this.moviename.Name = "moviename";
            this.moviename.Size = new System.Drawing.Size(70, 21);
            this.moviename.TabIndex = 8;
            this.moviename.Text = "Movie ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(6, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(6, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer ID";
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(115, 130);
            this.txtFN.Multiline = true;
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(143, 24);
            this.txtFN.TabIndex = 1;
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(115, 175);
            this.txtLN.Multiline = true;
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(143, 24);
            this.txtLN.TabIndex = 1;
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.SystemColors.Window;
            this.btnMain.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnMain.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMain.Location = new System.Drawing.Point(666, 423);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(95, 37);
            this.btnMain.TabIndex = 4;
            this.btnMain.Text = "Back";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Window;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(531, 423);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 37);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.SystemColors.Window;
            this.btnIssue.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIssue.Location = new System.Drawing.Point(360, 423);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(149, 37);
            this.btnIssue.TabIndex = 15;
            this.btnIssue.Text = "Issue Movie";
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click_1);
            // 
            // lblReturn
            // 
            this.lblReturn.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblReturn.Font = new System.Drawing.Font("PMingLiU-ExtB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturn.ForeColor = System.Drawing.Color.Red;
            this.lblReturn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblReturn.Location = new System.Drawing.Point(147, 43);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(229, 47);
            this.lblReturn.TabIndex = 36;
            this.lblReturn.Text = "Isuue";
            this.lblReturn.UseVisualStyleBackColor = false;
            // 
            // btnReturm
            // 
            this.btnReturm.BackColor = System.Drawing.Color.Black;
            this.btnReturm.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturm.ForeColor = System.Drawing.Color.Red;
            this.btnReturm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReturm.Location = new System.Drawing.Point(1049, 88);
            this.btnReturm.Name = "btnReturm";
            this.btnReturm.Size = new System.Drawing.Size(99, 37);
            this.btnReturm.TabIndex = 35;
            this.btnReturm.Text = "Return";
            this.btnReturm.UseVisualStyleBackColor = false;
            this.btnReturm.Click += new System.EventHandler(this.btnReturm_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(918, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 37);
            this.button1.TabIndex = 34;
            this.button1.Text = "Issue";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.Black;
            this.btnCustomer.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.Red;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCustomer.Location = new System.Drawing.Point(737, 88);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(116, 37);
            this.btnCustomer.TabIndex = 32;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // pbCustomer
            // 
            this.pbCustomer.Image = global::Movies_Rental.Properties.Resources.background;
            this.pbCustomer.Location = new System.Drawing.Point(12, -2);
            this.pbCustomer.Name = "pbCustomer";
            this.pbCustomer.Size = new System.Drawing.Size(1342, 141);
            this.pbCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCustomer.TabIndex = 31;
            this.pbCustomer.TabStop = false;
            // 
            // lblheadimg
            // 
            this.lblheadimg.AutoSize = true;
            this.lblheadimg.BackColor = System.Drawing.Color.Black;
            this.lblheadimg.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheadimg.ForeColor = System.Drawing.Color.Red;
            this.lblheadimg.Location = new System.Drawing.Point(1088, 592);
            this.lblheadimg.Name = "lblheadimg";
            this.lblheadimg.Size = new System.Drawing.Size(172, 22);
            this.lblheadimg.TabIndex = 39;
            this.lblheadimg.Text = "Video Rental Project";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlText;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1032, 629);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 31);
            this.label7.TabIndex = 38;
            this.label7.Text = "Develop by Atinder Singh";
            // 
            // pbfooter
            // 
            this.pbfooter.Image = global::Movies_Rental.Properties.Resources.background;
            this.pbfooter.Location = new System.Drawing.Point(52, 516);
            this.pbfooter.Name = "pbfooter";
            this.pbfooter.Size = new System.Drawing.Size(1386, 160);
            this.pbfooter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbfooter.TabIndex = 37;
            this.pbfooter.TabStop = false;
            // 
            // Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1362, 688);
            this.Controls.Add(this.lblheadimg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbfooter);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.btnReturm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.pbCustomer);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvRentalMovie);
            this.Name = "Rental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Rental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalMovie)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfooter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRentalMovie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txttoday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label moviename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.ComboBox txtMovieID;
        private System.Windows.Forms.ComboBox txtCustID;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button lblReturn;
        private System.Windows.Forms.Button btnReturm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.PictureBox pbCustomer;
        private System.Windows.Forms.Label lblheadimg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbfooter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}