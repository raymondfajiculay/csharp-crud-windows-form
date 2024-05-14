namespace windows_form
{
    partial class main_form
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
            this.read_data_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.table_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insert_data_btn = new System.Windows.Forms.Button();
            this.fname_text = new System.Windows.Forms.TextBox();
            this.fname_label = new System.Windows.Forms.Label();
            this.lname_label = new System.Windows.Forms.Label();
            this.lname_text = new System.Windows.Forms.TextBox();
            this.email_label = new System.Windows.Forms.Label();
            this.email_text = new System.Windows.Forms.TextBox();
            this.gender_label = new System.Windows.Forms.Label();
            this.gender_text = new System.Windows.Forms.TextBox();
            this.id_text = new System.Windows.Forms.TextBox();
            this.update_date_btn = new System.Windows.Forms.Button();
            this.delete_data_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // read_data_btn
            // 
            this.read_data_btn.Location = new System.Drawing.Point(1081, 465);
            this.read_data_btn.Name = "read_data_btn";
            this.read_data_btn.Size = new System.Drawing.Size(153, 77);
            this.read_data_btn.TabIndex = 0;
            this.read_data_btn.Text = "Read";
            this.read_data_btn.UseVisualStyleBackColor = true;
            this.read_data_btn.Click += new System.EventHandler(this.read_data_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.table_id,
            this.table_fname,
            this.table_lname,
            this.table_email,
            this.table_gender});
            this.dataGridView1.Location = new System.Drawing.Point(18, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1224, 419);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // table_id
            // 
            this.table_id.HeaderText = "ID";
            this.table_id.MinimumWidth = 8;
            this.table_id.Name = "table_id";
            this.table_id.ReadOnly = true;
            this.table_id.Width = 150;
            // 
            // table_fname
            // 
            this.table_fname.HeaderText = "First Name";
            this.table_fname.MinimumWidth = 8;
            this.table_fname.Name = "table_fname";
            this.table_fname.ReadOnly = true;
            this.table_fname.Width = 150;
            // 
            // table_lname
            // 
            this.table_lname.HeaderText = "Last Name";
            this.table_lname.MinimumWidth = 8;
            this.table_lname.Name = "table_lname";
            this.table_lname.ReadOnly = true;
            this.table_lname.Width = 150;
            // 
            // table_email
            // 
            this.table_email.HeaderText = "Email";
            this.table_email.MinimumWidth = 8;
            this.table_email.Name = "table_email";
            this.table_email.ReadOnly = true;
            this.table_email.Width = 150;
            // 
            // table_gender
            // 
            this.table_gender.HeaderText = "Gender";
            this.table_gender.MinimumWidth = 8;
            this.table_gender.Name = "table_gender";
            this.table_gender.ReadOnly = true;
            this.table_gender.Width = 150;
            // 
            // insert_data_btn
            // 
            this.insert_data_btn.Location = new System.Drawing.Point(902, 465);
            this.insert_data_btn.Name = "insert_data_btn";
            this.insert_data_btn.Size = new System.Drawing.Size(153, 77);
            this.insert_data_btn.TabIndex = 2;
            this.insert_data_btn.Text = "Insert";
            this.insert_data_btn.UseVisualStyleBackColor = true;
            this.insert_data_btn.Click += new System.EventHandler(this.insert_data_btn_Click);
            // 
            // fname_text
            // 
            this.fname_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_text.Location = new System.Drawing.Point(1260, 87);
            this.fname_text.Name = "fname_text";
            this.fname_text.Size = new System.Drawing.Size(289, 35);
            this.fname_text.TabIndex = 3;
            // 
            // fname_label
            // 
            this.fname_label.AutoSize = true;
            this.fname_label.Location = new System.Drawing.Point(1260, 56);
            this.fname_label.Name = "fname_label";
            this.fname_label.Size = new System.Drawing.Size(129, 30);
            this.fname_label.TabIndex = 4;
            this.fname_label.Text = "First Name";
            // 
            // lname_label
            // 
            this.lname_label.AutoSize = true;
            this.lname_label.Location = new System.Drawing.Point(1260, 133);
            this.lname_label.Name = "lname_label";
            this.lname_label.Size = new System.Drawing.Size(86, 20);
            this.lname_label.TabIndex = 6;
            this.lname_label.Text = "Last Name";
            // 
            // lname_text
            // 
            this.lname_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_text.Location = new System.Drawing.Point(1260, 164);
            this.lname_text.Name = "lname_text";
            this.lname_text.Size = new System.Drawing.Size(289, 35);
            this.lname_text.TabIndex = 5;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(1264, 215);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(72, 30);
            this.email_label.TabIndex = 8;
            this.email_label.Text = "Email";
            // 
            // email_text
            // 
            this.email_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_text.Location = new System.Drawing.Point(1264, 246);
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(289, 35);
            this.email_text.TabIndex = 7;
            // 
            // gender_label
            // 
            this.gender_label.AutoSize = true;
            this.gender_label.Location = new System.Drawing.Point(1264, 300);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(95, 30);
            this.gender_label.TabIndex = 10;
            this.gender_label.Text = "Gender";
            // 
            // gender_text
            // 
            this.gender_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_text.Location = new System.Drawing.Point(1264, 331);
            this.gender_text.Name = "gender_text";
            this.gender_text.Size = new System.Drawing.Size(289, 35);
            this.gender_text.TabIndex = 9;
            // 
            // id_text
            // 
            this.id_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_text.Location = new System.Drawing.Point(1260, 387);
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(289, 35);
            this.id_text.TabIndex = 11;
            this.id_text.Visible = false;
            // 
            // update_date_btn
            // 
            this.update_date_btn.Location = new System.Drawing.Point(721, 465);
            this.update_date_btn.Name = "update_date_btn";
            this.update_date_btn.Size = new System.Drawing.Size(153, 77);
            this.update_date_btn.TabIndex = 12;
            this.update_date_btn.Text = "Update";
            this.update_date_btn.UseVisualStyleBackColor = true;
            this.update_date_btn.Click += new System.EventHandler(this.update_date_btn_Click);
            // 
            // delete_data_btn
            // 
            this.delete_data_btn.Location = new System.Drawing.Point(551, 465);
            this.delete_data_btn.Name = "delete_data_btn";
            this.delete_data_btn.Size = new System.Drawing.Size(153, 77);
            this.delete_data_btn.TabIndex = 13;
            this.delete_data_btn.Text = "Delete";
            this.delete_data_btn.UseVisualStyleBackColor = true;
            this.delete_data_btn.Click += new System.EventHandler(this.delete_data_btn_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 588);
            this.Controls.Add(this.delete_data_btn);
            this.Controls.Add(this.update_date_btn);
            this.Controls.Add(this.id_text);
            this.Controls.Add(this.gender_label);
            this.Controls.Add(this.gender_text);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.email_text);
            this.Controls.Add(this.lname_label);
            this.Controls.Add(this.lname_text);
            this.Controls.Add(this.fname_label);
            this.Controls.Add(this.fname_text);
            this.Controls.Add(this.insert_data_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.read_data_btn);
            this.Name = "main_form";
            this.Text = "Employee Management Program";
            this.Load += new System.EventHandler(this.main_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button read_data_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_gender;
        private System.Windows.Forms.Button insert_data_btn;
        private System.Windows.Forms.TextBox fname_text;
        private System.Windows.Forms.Label fname_label;
        private System.Windows.Forms.Label lname_label;
        private System.Windows.Forms.TextBox lname_text;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox email_text;
        private System.Windows.Forms.Label gender_label;
        private System.Windows.Forms.TextBox gender_text;
        private System.Windows.Forms.TextBox id_text;
        private System.Windows.Forms.Button update_date_btn;
        private System.Windows.Forms.Button delete_data_btn;
    }
}

