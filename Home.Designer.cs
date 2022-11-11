
namespace LibraryManagement
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnStudentlogin = new System.Windows.Forms.Button();
            this.btnLibrarianlogin = new System.Windows.Forms.Button();
            this.btnabout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStudentlogin
            // 
            this.btnStudentlogin.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnStudentlogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStudentlogin.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentlogin.Location = new System.Drawing.Point(223, 204);
            this.btnStudentlogin.Name = "btnStudentlogin";
            this.btnStudentlogin.Size = new System.Drawing.Size(262, 39);
            this.btnStudentlogin.TabIndex = 0;
            this.btnStudentlogin.Text = "Log As a Student";
            this.btnStudentlogin.UseVisualStyleBackColor = false;
            this.btnStudentlogin.Click += new System.EventHandler(this.btnStudentlogin_Click);
            // 
            // btnLibrarianlogin
            // 
            this.btnLibrarianlogin.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnLibrarianlogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLibrarianlogin.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrarianlogin.Location = new System.Drawing.Point(223, 246);
            this.btnLibrarianlogin.Name = "btnLibrarianlogin";
            this.btnLibrarianlogin.Size = new System.Drawing.Size(262, 39);
            this.btnLibrarianlogin.TabIndex = 1;
            this.btnLibrarianlogin.Text = "Log As a Librarian";
            this.btnLibrarianlogin.UseVisualStyleBackColor = false;
            this.btnLibrarianlogin.Click += new System.EventHandler(this.btnLibrarianlogin_Click);
            // 
            // btnabout
            // 
            this.btnabout.BackColor = System.Drawing.SystemColors.Control;
            this.btnabout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnabout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnabout.ForeColor = System.Drawing.Color.Red;
            this.btnabout.Location = new System.Drawing.Point(672, 413);
            this.btnabout.Name = "btnabout";
            this.btnabout.Size = new System.Drawing.Size(78, 35);
            this.btnabout.TabIndex = 2;
            this.btnabout.Text = "About";
            this.btnabout.UseVisualStyleBackColor = false;
            this.btnabout.Click += new System.EventHandler(this.btnabout_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(714, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnabout;
            this.ClientSize = new System.Drawing.Size(751, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnabout);
            this.Controls.Add(this.btnLibrarianlogin);
            this.Controls.Add(this.btnStudentlogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudentlogin;
        private System.Windows.Forms.Button btnLibrarianlogin;
        private System.Windows.Forms.Button btnabout;
        private System.Windows.Forms.Button button1;
    }
}