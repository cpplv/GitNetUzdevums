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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBoxKStals = new System.Windows.Forms.GroupBox();
            this.ButtonKStals2 = new System.Windows.Forms.Button();
            this.ButtonKStals = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.GroupBoxKStals.SuspendLayout();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "y=sinx";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "y=x*x";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 53);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Andrejs Liepiņš";
            // 
            // GroupBoxKStals
            // 
            this.GroupBoxKStals.Controls.Add(this.ButtonKStals);
            this.GroupBoxKStals.Controls.Add(this.ButtonKStals2);
            this.GroupBoxKStals.Location = new System.Drawing.Point(12, 80);
            this.GroupBoxKStals.Name = "GroupBoxKStals";
            this.GroupBoxKStals.Size = new System.Drawing.Size(200, 57);
            this.GroupBoxKStals.TabIndex = 4;
            this.GroupBoxKStals.TabStop = false;
            this.GroupBoxKStals.Text = "Kristaps Štāls";
            // 
            // ButtonKStals2
            // 
            this.ButtonKStals2.Location = new System.Drawing.Point(119, 19);
            this.ButtonKStals2.Name = "ButtonKStals2";
            this.ButtonKStals2.Size = new System.Drawing.Size(75, 23);
            this.ButtonKStals2.TabIndex = 0;
            this.ButtonKStals2.Text = "y=cosx";
            this.ButtonKStals2.UseVisualStyleBackColor = true;
            this.ButtonKStals2.Click += new System.EventHandler(this.button3_Click);
            // 
            // ButtonKStals
            // 
            this.ButtonKStals.Location = new System.Drawing.Point(6, 19);
            this.ButtonKStals.Name = "ButtonKStals";
            this.ButtonKStals.Size = new System.Drawing.Size(75, 23);
            this.ButtonKStals.TabIndex = 1;
            this.ButtonKStals.Text = "y=x^3";
            this.ButtonKStals.UseVisualStyleBackColor = true;
            this.ButtonKStals.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 415);
            this.Controls.Add(this.GroupBoxKStals);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Funkciju grafiki";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.GroupBoxKStals.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox GroupBoxKStals;
        private System.Windows.Forms.Button ButtonKStals2;
        private System.Windows.Forms.Button ButtonKStals;
    }
}

