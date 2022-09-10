
namespace ENSAS_Book
{
    partial class AuthorForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateAuthor = new System.Windows.Forms.Button();
            this.btnSaveAuthor = new System.Windows.Forms.Button();
            this.txtGenderF = new System.Windows.Forms.RadioButton();
            this.txtGenderM = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvAuthors = new System.Windows.Forms.DataGridView();
            this.txtNbAuthors = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(59, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Author";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateAuthor);
            this.groupBox1.Controls.Add(this.btnSaveAuthor);
            this.groupBox1.Controls.Add(this.txtGenderF);
            this.groupBox1.Controls.Add(this.txtGenderM);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 337);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnUpdateAuthor
            // 
            this.btnUpdateAuthor.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateAuthor.FlatAppearance.BorderSize = 0;
            this.btnUpdateAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAuthor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateAuthor.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateAuthor.Image")));
            this.btnUpdateAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateAuthor.Location = new System.Drawing.Point(15, 243);
            this.btnUpdateAuthor.Name = "btnUpdateAuthor";
            this.btnUpdateAuthor.Size = new System.Drawing.Size(109, 43);
            this.btnUpdateAuthor.TabIndex = 10;
            this.btnUpdateAuthor.Text = "Update";
            this.btnUpdateAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateAuthor.UseVisualStyleBackColor = false;
            this.btnUpdateAuthor.Click += new System.EventHandler(this.btnUpdateAuthor_Click);
            // 
            // btnSaveAuthor
            // 
            this.btnSaveAuthor.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSaveAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAuthor.FlatAppearance.BorderSize = 0;
            this.btnSaveAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAuthor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnSaveAuthor.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAuthor.Image")));
            this.btnSaveAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveAuthor.Location = new System.Drawing.Point(160, 243);
            this.btnSaveAuthor.Name = "btnSaveAuthor";
            this.btnSaveAuthor.Size = new System.Drawing.Size(109, 43);
            this.btnSaveAuthor.TabIndex = 9;
            this.btnSaveAuthor.Text = "Save";
            this.btnSaveAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveAuthor.UseVisualStyleBackColor = false;
            this.btnSaveAuthor.Click += new System.EventHandler(this.btnSaveAuthor_Click);
            // 
            // txtGenderF
            // 
            this.txtGenderF.AutoSize = true;
            this.txtGenderF.Location = new System.Drawing.Point(171, 201);
            this.txtGenderF.Name = "txtGenderF";
            this.txtGenderF.Size = new System.Drawing.Size(31, 19);
            this.txtGenderF.TabIndex = 8;
            this.txtGenderF.Text = "F";
            this.txtGenderF.UseVisualStyleBackColor = true;
            // 
            // txtGenderM
            // 
            this.txtGenderM.AutoSize = true;
            this.txtGenderM.Checked = true;
            this.txtGenderM.Location = new System.Drawing.Point(99, 202);
            this.txtGenderM.Name = "txtGenderM";
            this.txtGenderM.Size = new System.Drawing.Size(36, 19);
            this.txtGenderM.TabIndex = 3;
            this.txtGenderM.TabStop = true;
            this.txtGenderM.Text = "M";
            this.txtGenderM.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(15, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gender :";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.MintCream;
            this.txtEmail.Location = new System.Drawing.Point(15, 135);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(254, 23);
            this.txtEmail.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(15, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email :";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.MintCream;
            this.txtName.Location = new System.Drawing.Point(15, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(254, 23);
            this.txtName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(15, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(326, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(375, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "List of  Authors :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dgvAuthors
            // 
            this.dgvAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAuthors.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAuthors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAuthors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAuthors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAuthors.ColumnHeadersHeight = 33;
            this.dgvAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAuthors.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAuthors.EnableHeadersVisualStyles = false;
            this.dgvAuthors.Location = new System.Drawing.Point(326, 65);
            this.dgvAuthors.Name = "dgvAuthors";
            this.dgvAuthors.RowTemplate.Height = 40;
            this.dgvAuthors.Size = new System.Drawing.Size(739, 358);
            this.dgvAuthors.TabIndex = 5;
            this.dgvAuthors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuthors_CellContentClick);
            this.dgvAuthors.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuthors_CellDoubleClick);
            this.dgvAuthors.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuthors_CellMouseEnter);
            // 
            // txtNbAuthors
            // 
            this.txtNbAuthors.AutoSize = true;
            this.txtNbAuthors.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNbAuthors.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtNbAuthors.Location = new System.Drawing.Point(513, 13);
            this.txtNbAuthors.Name = "txtNbAuthors";
            this.txtNbAuthors.Size = new System.Drawing.Size(0, 25);
            this.txtNbAuthors.TabIndex = 6;
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtNbAuthors);
            this.Controls.Add(this.dgvAuthors);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "AuthorForm";
            this.Size = new System.Drawing.Size(1068, 446);
            this.Load += new System.EventHandler(this.AuthorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton txtGenderF;
        private System.Windows.Forms.RadioButton txtGenderM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveAuthor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvAuthors;
        private System.Windows.Forms.Label txtNbAuthors;
        private System.Windows.Forms.Button btnUpdateAuthor;
    }
}
