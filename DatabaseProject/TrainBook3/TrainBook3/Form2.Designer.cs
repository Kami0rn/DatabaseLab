namespace TrainBook3
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Passenger_head_label = new System.Windows.Forms.Label();
            this.route_Label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tel_book_label = new System.Windows.Forms.Label();
            this.pid_label_book = new System.Windows.Forms.Label();
            this.tel_book = new System.Windows.Forms.TextBox();
            this.pid_print_book = new System.Windows.Forms.TextBox();
            this.book_Name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.book_Name);
            this.panel1.Controls.Add(this.Passenger_head_label);
            this.panel1.Controls.Add(this.route_Label);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.tel_book_label);
            this.panel1.Controls.Add(this.pid_label_book);
            this.panel1.Controls.Add(this.tel_book);
            this.panel1.Controls.Add(this.pid_print_book);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 538);
            this.panel1.TabIndex = 0;
            // 
            // Passenger_head_label
            // 
            this.Passenger_head_label.AutoSize = true;
            this.Passenger_head_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.Passenger_head_label.Location = new System.Drawing.Point(27, 36);
            this.Passenger_head_label.Name = "Passenger_head_label";
            this.Passenger_head_label.Size = new System.Drawing.Size(200, 44);
            this.Passenger_head_label.TabIndex = 7;
            this.Passenger_head_label.Text = "Passenger";
            // 
            // route_Label
            // 
            this.route_Label.AutoSize = true;
            this.route_Label.Location = new System.Drawing.Point(32, 296);
            this.route_Label.Name = "route_Label";
            this.route_Label.Size = new System.Drawing.Size(36, 13);
            this.route_Label.TabIndex = 6;
            this.route_Label.Text = "Route";
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "---None---",
            "North",
            "South",
            "East",
            "NorthEast"});
            this.comboBox1.Location = new System.Drawing.Point(35, 312);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // tel_book_label
            // 
            this.tel_book_label.AutoSize = true;
            this.tel_book_label.Location = new System.Drawing.Point(32, 215);
            this.tel_book_label.Name = "tel_book_label";
            this.tel_book_label.Size = new System.Drawing.Size(81, 13);
            this.tel_book_label.TabIndex = 3;
            this.tel_book_label.Text = "Phone numbers";
            // 
            // pid_label_book
            // 
            this.pid_label_book.AutoSize = true;
            this.pid_label_book.Location = new System.Drawing.Point(32, 139);
            this.pid_label_book.Name = "pid_label_book";
            this.pid_label_book.Size = new System.Drawing.Size(62, 13);
            this.pid_label_book.TabIndex = 2;
            this.pid_label_book.Text = "Personal ID";
            // 
            // tel_book
            // 
            this.tel_book.Location = new System.Drawing.Point(35, 231);
            this.tel_book.Name = "tel_book";
            this.tel_book.Size = new System.Drawing.Size(224, 20);
            this.tel_book.TabIndex = 1;
            // 
            // pid_print_book
            // 
            this.pid_print_book.Location = new System.Drawing.Point(35, 155);
            this.pid_print_book.Name = "pid_print_book";
            this.pid_print_book.Size = new System.Drawing.Size(224, 20);
            this.pid_print_book.TabIndex = 0;
            this.pid_print_book.TextChanged += new System.EventHandler(this.pid_print_book_TextChanged);
            // 
            // book_Name
            // 
            this.book_Name.AutoSize = true;
            this.book_Name.Location = new System.Drawing.Point(32, 452);
            this.book_Name.Name = "book_Name";
            this.book_Name.Size = new System.Drawing.Size(35, 13);
            this.book_Name.TabIndex = 8;
            this.book_Name.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 533);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox pid_print_book;
        private System.Windows.Forms.Label pid_label_book;
        private System.Windows.Forms.TextBox tel_book;
        private System.Windows.Forms.Label tel_book_label;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label route_Label;
        private System.Windows.Forms.Label Passenger_head_label;
        private System.Windows.Forms.Label book_Name;
    }
}