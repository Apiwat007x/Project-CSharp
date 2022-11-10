namespace Myshop
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Edit = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Image = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.TextBox();
            this.searchh = new System.Windows.Forms.Label();
            this.lab_path = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbamount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 194);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(427, 446);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(501, 72);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(501, 149);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.White;
            this.Edit.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Location = new System.Drawing.Point(172, 644);
            this.Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(111, 54);
            this.Edit.TabIndex = 7;
            this.Edit.Text = "แก้ไข";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(12, 11);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(110, 47);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "ย้อนกลับ";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // History
            // 
            this.History.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.History.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History.Location = new System.Drawing.Point(700, 677);
            this.History.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(138, 53);
            this.History.TabIndex = 11;
            this.History.Text = "ประวัติ";
            this.History.UseVisualStyleBackColor = false;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Add.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(34, 645);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(111, 54);
            this.Add.TabIndex = 12;
            this.Add.Text = "เพิ่ม";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Delete.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(308, 645);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(111, 54);
            this.Delete.TabIndex = 13;
            this.Delete.Text = "ลบ";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(576, 255);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Image
            // 
            this.Image.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Image.Location = new System.Drawing.Point(652, 189);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(96, 40);
            this.Image.TabIndex = 16;
            this.Image.Text = "รูปภาพ";
            this.Image.UseVisualStyleBackColor = true;
            this.Image.Click += new System.EventHandler(this.Image_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("TH SarabunPSK", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.name.Location = new System.Drawing.Point(529, 30);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(88, 40);
            this.name.TabIndex = 18;
            this.name.Text = "ชื่อสินค้า";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.BackColor = System.Drawing.Color.Transparent;
            this.price.Font = new System.Drawing.Font("TH SarabunPSK", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.price.Location = new System.Drawing.Point(544, 109);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(59, 40);
            this.price.TabIndex = 19;
            this.price.Text = "ราคา";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(142, 109);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(168, 22);
            this.Search.TabIndex = 20;
            this.Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Search_KeyPress);
            // 
            // searchh
            // 
            this.searchh.AutoSize = true;
            this.searchh.BackColor = System.Drawing.Color.Transparent;
            this.searchh.Font = new System.Drawing.Font("TH SarabunPSK", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchh.Location = new System.Drawing.Point(195, 66);
            this.searchh.Name = "searchh";
            this.searchh.Size = new System.Drawing.Size(65, 40);
            this.searchh.TabIndex = 21;
            this.searchh.Text = "ค้นหา";
            // 
            // lab_path
            // 
            this.lab_path.Location = new System.Drawing.Point(576, 596);
            this.lab_path.Name = "lab_path";
            this.lab_path.Size = new System.Drawing.Size(245, 22);
            this.lab_path.TabIndex = 22;
            this.lab_path.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(690, 72);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(152, 22);
            this.textBox3.TabIndex = 23;
            // 
            // lbamount
            // 
            this.lbamount.AutoSize = true;
            this.lbamount.BackColor = System.Drawing.Color.Transparent;
            this.lbamount.Font = new System.Drawing.Font("TH SarabunPSK", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbamount.ForeColor = System.Drawing.Color.Black;
            this.lbamount.Location = new System.Drawing.Point(721, 36);
            this.lbamount.Name = "lbamount";
            this.lbamount.Size = new System.Drawing.Size(76, 34);
            this.lbamount.TabIndex = 24;
            this.lbamount.Text = "จำนวน";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(869, 755);
            this.Controls.Add(this.lbamount);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lab_path);
            this.Controls.Add(this.searchh);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.price);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.History);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.Shown += new System.EventHandler(this.admin_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button History;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Image;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label searchh;
        private System.Windows.Forms.TextBox lab_path;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbamount;
    }
}