
namespace Movies_Rental
{
    partial class Main
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
            this.btnCustomer = new System.Windows.Forms.Button();
            this.CPM = new System.Windows.Forms.Button();
            this.btnRental = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnMovie = new System.Windows.Forms.Button();
            this.btnCTC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCustomer.Location = new System.Drawing.Point(98, 29);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(143, 48);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // CPM
            // 
            this.CPM.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPM.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CPM.Location = new System.Drawing.Point(357, 96);
            this.CPM.Name = "CPM";
            this.CPM.Size = new System.Drawing.Size(145, 31);
            this.CPM.TabIndex = 1;
            this.CPM.Text = "Check Popular Movie";
            this.CPM.UseVisualStyleBackColor = false;
            this.CPM.Click += new System.EventHandler(this.btnCPM_Click);
            // 
            // btnRental
            // 
            this.btnRental.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRental.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRental.Location = new System.Drawing.Point(98, 164);
            this.btnRental.Name = "btnRental";
            this.btnRental.Size = new System.Drawing.Size(143, 48);
            this.btnRental.TabIndex = 1;
            this.btnRental.Text = "Rental";
            this.btnRental.UseVisualStyleBackColor = false;
            this.btnRental.Click += new System.EventHandler(this.btnRental_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button4.Location = new System.Drawing.Point(462, 212);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 27);
            this.button4.TabIndex = 1;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnLO_Click);
            // 
            // btnMovie
            // 
            this.btnMovie.BackColor = System.Drawing.Color.White;
            this.btnMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMovie.Location = new System.Drawing.Point(98, 96);
            this.btnMovie.Name = "btnMovie";
            this.btnMovie.Size = new System.Drawing.Size(143, 48);
            this.btnMovie.TabIndex = 1;
            this.btnMovie.Text = "Movies";
            this.btnMovie.UseVisualStyleBackColor = false;
            this.btnMovie.Click += new System.EventHandler(this.btnMovie_Click);
            // 
            // btnCTC
            // 
            this.btnCTC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTC.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCTC.Location = new System.Drawing.Point(357, 41);
            this.btnCTC.Name = "btnCTC";
            this.btnCTC.Size = new System.Drawing.Size(136, 31);
            this.btnCTC.TabIndex = 2;
            this.btnCTC.Text = "Check Top Customer";
            this.btnCTC.UseVisualStyleBackColor = false;
            this.btnCTC.Click += new System.EventHandler(this.btnCTC_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(562, 251);
            this.Controls.Add(this.btnCTC);
            this.Controls.Add(this.btnMovie);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnRental);
            this.Controls.Add(this.CPM);
            this.Controls.Add(this.btnCustomer);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button CPM;
        private System.Windows.Forms.Button btnRental;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnMovie;
        private System.Windows.Forms.Button btnCTC;
    }
}