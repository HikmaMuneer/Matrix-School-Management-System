namespace School_Management_System
{
    partial class Teachers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teachers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView_tlist = new System.Windows.Forms.DataGridView();
            this.btn_tdel = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_tregister = new System.Windows.Forms.Button();
            this.btn_tedit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_tsub = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tDob_Picker = new System.Windows.Forms.DateTimePicker();
            this.cmb_tgen = new System.Windows.Forms.ComboBox();
            this.txt_tadd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tlist)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1189, 100);
            this.panel1.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(1138, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(48, 46);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_close.TabIndex = 11;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Teachers";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label7.Location = new System.Drawing.Point(749, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 37);
            this.label7.TabIndex = 41;
            this.label7.Text = "Teachers List";
            // 
            // dataGridView_tlist
            // 
            this.dataGridView_tlist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.dataGridView_tlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tlist.Location = new System.Drawing.Point(495, 162);
            this.dataGridView_tlist.Name = "dataGridView_tlist";
            this.dataGridView_tlist.RowHeadersWidth = 51;
            this.dataGridView_tlist.RowTemplate.Height = 24;
            this.dataGridView_tlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_tlist.Size = new System.Drawing.Size(671, 472);
            this.dataGridView_tlist.TabIndex = 40;
            this.dataGridView_tlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_tlist_CellContentClick);
            // 
            // btn_tdel
            // 
            this.btn_tdel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btn_tdel.FlatAppearance.BorderSize = 0;
            this.btn_tdel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tdel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tdel.ForeColor = System.Drawing.Color.White;
            this.btn_tdel.Location = new System.Drawing.Point(325, 655);
            this.btn_tdel.Name = "btn_tdel";
            this.btn_tdel.Size = new System.Drawing.Size(127, 39);
            this.btn_tdel.TabIndex = 39;
            this.btn_tdel.Text = "Delete";
            this.btn_tdel.UseVisualStyleBackColor = false;
            this.btn_tdel.Click += new System.EventHandler(this.btn_tdel_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(1039, 655);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(127, 39);
            this.btn_back.TabIndex = 38;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_tregister
            // 
            this.btn_tregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btn_tregister.FlatAppearance.BorderSize = 0;
            this.btn_tregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tregister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tregister.ForeColor = System.Drawing.Color.White;
            this.btn_tregister.Location = new System.Drawing.Point(41, 655);
            this.btn_tregister.Name = "btn_tregister";
            this.btn_tregister.Size = new System.Drawing.Size(127, 39);
            this.btn_tregister.TabIndex = 37;
            this.btn_tregister.Text = "Add";
            this.btn_tregister.UseVisualStyleBackColor = false;
            this.btn_tregister.Click += new System.EventHandler(this.btn_tregister_Click);
            // 
            // btn_tedit
            // 
            this.btn_tedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btn_tedit.FlatAppearance.BorderSize = 0;
            this.btn_tedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tedit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tedit.ForeColor = System.Drawing.Color.White;
            this.btn_tedit.Location = new System.Drawing.Point(183, 655);
            this.btn_tedit.Name = "btn_tedit";
            this.btn_tedit.Size = new System.Drawing.Size(127, 39);
            this.btn_tedit.TabIndex = 36;
            this.btn_tedit.Text = "Edit";
            this.btn_tedit.UseVisualStyleBackColor = false;
            this.btn_tedit.Click += new System.EventHandler(this.btn_tedit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(102, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(100, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 23);
            this.label6.TabIndex = 34;
            this.label6.Text = "Subjects";
            // 
            // cmb_tsub
            // 
            this.cmb_tsub.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tsub.FormattingEnabled = true;
            this.cmb_tsub.Items.AddRange(new object[] {
            "Maths",
            "English",
            "Science",
            "Languages",
            "ICT"});
            this.cmb_tsub.Location = new System.Drawing.Point(104, 365);
            this.cmb_tsub.Name = "cmb_tsub";
            this.cmb_tsub.Size = new System.Drawing.Size(267, 31);
            this.cmb_tsub.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(100, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "Date of Birth";
            // 
            // tDob_Picker
            // 
            this.tDob_Picker.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDob_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tDob_Picker.Location = new System.Drawing.Point(104, 298);
            this.tDob_Picker.Name = "tDob_Picker";
            this.tDob_Picker.Size = new System.Drawing.Size(267, 30);
            this.tDob_Picker.TabIndex = 31;
            // 
            // cmb_tgen
            // 
            this.cmb_tgen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tgen.FormattingEnabled = true;
            this.cmb_tgen.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_tgen.Location = new System.Drawing.Point(106, 229);
            this.cmb_tgen.Name = "cmb_tgen";
            this.cmb_tgen.Size = new System.Drawing.Size(265, 31);
            this.cmb_tgen.TabIndex = 30;
            // 
            // txt_tadd
            // 
            this.txt_tadd.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tadd.Location = new System.Drawing.Point(104, 432);
            this.txt_tadd.Multiline = true;
            this.txt_tadd.Name = "txt_tadd";
            this.txt_tadd.Size = new System.Drawing.Size(267, 119);
            this.txt_tadd.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(100, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Address";
            // 
            // txt_tname
            // 
            this.txt_tname.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tname.Location = new System.Drawing.Point(104, 162);
            this.txt_tname.Name = "txt_tname";
            this.txt_tname.Size = new System.Drawing.Size(267, 30);
            this.txt_tname.TabIndex = 27;
            this.txt_tname.TextChanged += new System.EventHandler(this.txt_tname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(104, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Name";
            // 
            // txt_tno
            // 
            this.txt_tno.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tno.Location = new System.Drawing.Point(104, 590);
            this.txt_tno.Name = "txt_tno";
            this.txt_tno.Size = new System.Drawing.Size(267, 30);
            this.txt_tno.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(104, 564);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 23);
            this.label8.TabIndex = 42;
            this.label8.Text = "Phone";
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1189, 742);
            this.Controls.Add(this.txt_tno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView_tlist);
            this.Controls.Add(this.btn_tdel);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_tregister);
            this.Controls.Add(this.btn_tedit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_tsub);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tDob_Picker);
            this.Controls.Add(this.cmb_tgen);
            this.Controls.Add(this.txt_tadd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Teachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teachers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView_tlist;
        private System.Windows.Forms.Button btn_tdel;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_tregister;
        private System.Windows.Forms.Button btn_tedit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_tsub;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker tDob_Picker;
        private System.Windows.Forms.ComboBox cmb_tgen;
        private System.Windows.Forms.TextBox txt_tadd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tno;
        private System.Windows.Forms.Label label8;
    }
}