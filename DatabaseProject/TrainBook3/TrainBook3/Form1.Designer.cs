namespace TrainBook3
{
    partial class registerTab
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
            this.lastName_txt = new System.Windows.Forms.TextBox();
            this.firstName_txt = new System.Windows.Forms.TextBox();
            this.firstName_label = new System.Windows.Forms.Label();
            this.lastName_label = new System.Windows.Forms.Label();
            this.Age_txt = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.gender_comboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Insert_Btn_Regis = new System.Windows.Forms.Button();
            this.clear_Btn_Regis = new System.Windows.Forms.Button();
            this.gender_Label = new System.Windows.Forms.Label();
            this.Booking_head_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lastName_txt
            // 
            this.lastName_txt.Location = new System.Drawing.Point(33, 155);
            this.lastName_txt.Name = "lastName_txt";
            this.lastName_txt.Size = new System.Drawing.Size(166, 20);
            this.lastName_txt.TabIndex = 1;
            this.lastName_txt.TextChanged += new System.EventHandler(this.lastName_TextChanged);
            // 
            // firstName_txt
            // 
            this.firstName_txt.Location = new System.Drawing.Point(33, 89);
            this.firstName_txt.Name = "firstName_txt";
            this.firstName_txt.Size = new System.Drawing.Size(166, 20);
            this.firstName_txt.TabIndex = 2;
            this.firstName_txt.TextChanged += new System.EventHandler(this.firstName_TextChanged);
            // 
            // firstName_label
            // 
            this.firstName_label.AutoSize = true;
            this.firstName_label.BackColor = System.Drawing.Color.Gray;
            this.firstName_label.ForeColor = System.Drawing.Color.White;
            this.firstName_label.Location = new System.Drawing.Point(30, 73);
            this.firstName_label.Name = "firstName_label";
            this.firstName_label.Size = new System.Drawing.Size(52, 13);
            this.firstName_label.TabIndex = 3;
            this.firstName_label.Text = "Firstname";
            // 
            // lastName_label
            // 
            this.lastName_label.AutoSize = true;
            this.lastName_label.BackColor = System.Drawing.Color.Gray;
            this.lastName_label.ForeColor = System.Drawing.Color.White;
            this.lastName_label.Location = new System.Drawing.Point(30, 139);
            this.lastName_label.Name = "lastName_label";
            this.lastName_label.Size = new System.Drawing.Size(53, 13);
            this.lastName_label.TabIndex = 4;
            this.lastName_label.Text = "Lastname";
            // 
            // Age_txt
            // 
            this.Age_txt.Location = new System.Drawing.Point(34, 278);
            this.Age_txt.Name = "Age_txt";
            this.Age_txt.Size = new System.Drawing.Size(35, 20);
            this.Age_txt.TabIndex = 5;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.ForeColor = System.Drawing.Color.White;
            this.ageLabel.Location = new System.Drawing.Point(34, 262);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(26, 13);
            this.ageLabel.TabIndex = 6;
            this.ageLabel.Text = "Age";
            // 
            // gender_comboBox
            // 
            this.gender_comboBox.FormattingEnabled = true;
            this.gender_comboBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.gender_comboBox.Items.AddRange(new object[] {
            "--None--",
            "Male",
            "Female",
            "Other"});
            this.gender_comboBox.Location = new System.Drawing.Point(33, 221);
            this.gender_comboBox.Name = "gender_comboBox";
            this.gender_comboBox.Size = new System.Drawing.Size(86, 21);
            this.gender_comboBox.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.Booking_head_label);
            this.panel1.Controls.Add(this.Insert_Btn_Regis);
            this.panel1.Controls.Add(this.clear_Btn_Regis);
            this.panel1.Controls.Add(this.gender_Label);
            this.panel1.Controls.Add(this.Age_txt);
            this.panel1.Controls.Add(this.ageLabel);
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 455);
            this.panel1.TabIndex = 8;
            // 
            // Insert_Btn_Regis
            // 
            this.Insert_Btn_Regis.Location = new System.Drawing.Point(34, 366);
            this.Insert_Btn_Regis.Name = "Insert_Btn_Regis";
            this.Insert_Btn_Regis.Size = new System.Drawing.Size(75, 23);
            this.Insert_Btn_Regis.TabIndex = 9;
            this.Insert_Btn_Regis.Text = "Insert";
            this.Insert_Btn_Regis.UseVisualStyleBackColor = true;
            this.Insert_Btn_Regis.Click += new System.EventHandler(this.button1_Click);
            // 
            // clear_Btn_Regis
            // 
            this.clear_Btn_Regis.Location = new System.Drawing.Point(34, 324);
            this.clear_Btn_Regis.Name = "clear_Btn_Regis";
            this.clear_Btn_Regis.Size = new System.Drawing.Size(75, 23);
            this.clear_Btn_Regis.TabIndex = 9;
            this.clear_Btn_Regis.Text = "Clear";
            this.clear_Btn_Regis.UseVisualStyleBackColor = true;
            this.clear_Btn_Regis.Click += new System.EventHandler(this.clear_Btn_Regis_Click);
            // 
            // gender_Label
            // 
            this.gender_Label.AutoSize = true;
            this.gender_Label.ForeColor = System.Drawing.Color.White;
            this.gender_Label.Location = new System.Drawing.Point(34, 206);
            this.gender_Label.Name = "gender_Label";
            this.gender_Label.Size = new System.Drawing.Size(42, 13);
            this.gender_Label.TabIndex = 8;
            this.gender_Label.Text = "Gender";
            // 
            // Booking_head_label
            // 
            this.Booking_head_label.AutoSize = true;
            this.Booking_head_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.Booking_head_label.ForeColor = System.Drawing.SystemColors.Window;
            this.Booking_head_label.Location = new System.Drawing.Point(26, 13);
            this.Booking_head_label.Name = "Booking_head_label";
            this.Booking_head_label.Size = new System.Drawing.Size(156, 44);
            this.Booking_head_label.TabIndex = 9;
            this.Booking_head_label.Text = "Booking";
            // 
            // registerTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(361, 450);
            this.Controls.Add(this.gender_comboBox);
            this.Controls.Add(this.lastName_label);
            this.Controls.Add(this.firstName_label);
            this.Controls.Add(this.firstName_txt);
            this.Controls.Add(this.lastName_txt);
            this.Controls.Add(this.panel1);
            this.Name = "registerTab";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox lastName_txt;
        private System.Windows.Forms.TextBox firstName_txt;
        private System.Windows.Forms.Label firstName_label;
        private System.Windows.Forms.Label lastName_label;
        private System.Windows.Forms.TextBox Age_txt;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.ComboBox gender_comboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label gender_Label;
        private System.Windows.Forms.Button clear_Btn_Regis;
        private System.Windows.Forms.Button Insert_Btn_Regis;
        private System.Windows.Forms.Label Booking_head_label;
    }
}

