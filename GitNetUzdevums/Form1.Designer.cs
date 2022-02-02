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
            this.GroupBoxVKalnins = new System.Windows.Forms.GroupBox();
            this.ButtonVKalnins = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.GroupBoxVKalnins.SuspendLayout();
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
            // GroupBoxVKalnins
            // 
            this.GroupBoxVKalnins.Controls.Add(this.ButtonVKalnins);
            this.GroupBoxVKalnins.Location = new System.Drawing.Point(18, 80);
            this.GroupBoxVKalnins.Name = "GroupBoxVKalnins";
            this.GroupBoxVKalnins.Size = new System.Drawing.Size(200, 53);
            this.GroupBoxVKalnins.TabIndex = 4;
            this.GroupBoxVKalnins.TabStop = false;
            this.GroupBoxVKalnins.Text = "Valters Kalniņš";
            // 
            // ButtonVKalnins
            // 
            this.ButtonVKalnins.Location = new System.Drawing.Point(6, 19);
            this.ButtonVKalnins.Name = "ButtonVKalnins";
            this.ButtonVKalnins.Size = new System.Drawing.Size(182, 23);
            this.ButtonVKalnins.TabIndex = 2;
            this.ButtonVKalnins.Text = "y = 6sin(400x)";
            this.ButtonVKalnins.UseVisualStyleBackColor = true;
            this.ButtonVKalnins.Click += new System.EventHandler(this.ButtonVKalnins_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 415);
            this.Controls.Add(this.GroupBoxVKalnins);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Funkciju grafiki";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.GroupBoxVKalnins.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox GroupBoxVKalnins;
        private System.Windows.Forms.Button ButtonVKalnins;
    }
}

