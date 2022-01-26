namespace WindowsFormsApplication_15
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GroupBoxDVaikutis = new System.Windows.Forms.GroupBox();
            this.ButtonDVaikutis = new System.Windows.Forms.Button();
            this.ButtonDVaikutis2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GroupBoxDVaikutis.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(594, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 368);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GroupBoxDVaikutis
            // 
            this.GroupBoxDVaikutis.Controls.Add(this.ButtonDVaikutis2);
            this.GroupBoxDVaikutis.Controls.Add(this.ButtonDVaikutis);
            this.GroupBoxDVaikutis.Location = new System.Drawing.Point(99, 50);
            this.GroupBoxDVaikutis.Name = "GroupBoxDVaikutis";
            this.GroupBoxDVaikutis.Size = new System.Drawing.Size(200, 100);
            this.GroupBoxDVaikutis.TabIndex = 4;
            this.GroupBoxDVaikutis.TabStop = false;
            this.GroupBoxDVaikutis.Text = "GroupBoxDVaikutis";
            this.GroupBoxDVaikutis.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // ButtonDVaikutis
            // 
            this.ButtonDVaikutis.Location = new System.Drawing.Point(6, 19);
            this.ButtonDVaikutis.Name = "ButtonDVaikutis";
            this.ButtonDVaikutis.Size = new System.Drawing.Size(75, 23);
            this.ButtonDVaikutis.TabIndex = 5;
            this.ButtonDVaikutis.Text = "y=x+5";
            this.ButtonDVaikutis.UseVisualStyleBackColor = true;
            this.ButtonDVaikutis.Click += new System.EventHandler(this.ButtonDVaikutis_Click);
            // 
            // ButtonDVaikutis2
            // 
            this.ButtonDVaikutis2.Location = new System.Drawing.Point(106, 19);
            this.ButtonDVaikutis2.Name = "ButtonDVaikutis2";
            this.ButtonDVaikutis2.Size = new System.Drawing.Size(75, 23);
            this.ButtonDVaikutis2.TabIndex = 5;
            this.ButtonDVaikutis2.Text = "y=(x*x)+4";
            this.ButtonDVaikutis2.UseVisualStyleBackColor = true;
            this.ButtonDVaikutis2.Click += new System.EventHandler(this.ButtonDVaikutis2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 415);
            this.Controls.Add(this.GroupBoxDVaikutis);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Funkciju grafiki";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GroupBoxDVaikutis.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GroupBoxDVaikutis;
        private System.Windows.Forms.Button ButtonDVaikutis;
        private System.Windows.Forms.Button ButtonDVaikutis2;
    }
}

