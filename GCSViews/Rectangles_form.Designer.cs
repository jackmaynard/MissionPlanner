namespace MissionPlanner.GCSViews.UCR_Rectangles //new line
{
    partial class Rectangles_form
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
            this.textBox1_window = new System.Windows.Forms.TextBox();
            this.textBox2_window = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_latitude = new System.Windows.Forms.TextBox();
            this.textBox_lon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1_window
            // 
            this.textBox1_window.Location = new System.Drawing.Point(12, 156);
            this.textBox1_window.Name = "textBox1_window";
            this.textBox1_window.Size = new System.Drawing.Size(100, 20);
            this.textBox1_window.TabIndex = 0;
            this.textBox1_window.Text = "Window X ";
            this.textBox1_window.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2_window
            // 
            this.textBox2_window.Location = new System.Drawing.Point(175, 155);
            this.textBox2_window.Name = "textBox2_window";
            this.textBox2_window.Size = new System.Drawing.Size(100, 20);
            this.textBox2_window.TabIndex = 1;
            this.textBox2_window.Text = "Window Y";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 183);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Length";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(174, 182);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Width";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox_latitude
            // 
            this.textBox_latitude.Location = new System.Drawing.Point(12, 13);
            this.textBox_latitude.Name = "textBox_latitude";
            this.textBox_latitude.Size = new System.Drawing.Size(100, 20);
            this.textBox_latitude.TabIndex = 5;
            this.textBox_latitude.Text = "X latitude";
            // 
            // textBox_lon
            // 
            this.textBox_lon.Location = new System.Drawing.Point(174, 12);
            this.textBox_lon.Name = "textBox_lon";
            this.textBox_lon.Size = new System.Drawing.Size(100, 20);
            this.textBox_lon.TabIndex = 6;
            this.textBox_lon.Text = "Y Latitude";
            // 
            // Rectangles_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox_lon);
            this.Controls.Add(this.textBox_latitude);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2_window);
            this.Controls.Add(this.textBox1_window);
            this.Name = "Rectangles_form";
            this.Text = "Rectangles_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_window;
        private System.Windows.Forms.TextBox textBox2_window;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_latitude;
        private System.Windows.Forms.TextBox textBox_lon;
    }
}