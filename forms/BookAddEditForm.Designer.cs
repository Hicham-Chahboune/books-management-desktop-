
namespace ENSAS_Book.forms
{
    partial class BookAddEditForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookAddEditForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTitleForm = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCategorie = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNbPages = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDatePublished = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateBook = new System.Windows.Forms.Button();
            this.txtImageCover = new System.Windows.Forms.PictureBox();
            this.btnUploadCover = new System.Windows.Forms.Button();
            this.txtImageCoverPath = new System.Windows.Forms.Label();
            this.errorManagment = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImageCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorManagment)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtTitleForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 46);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(654, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 29);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtTitleForm
            // 
            this.txtTitleForm.AutoSize = true;
            this.txtTitleForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTitleForm.ForeColor = System.Drawing.Color.White;
            this.txtTitleForm.Location = new System.Drawing.Point(64, 9);
            this.txtTitleForm.Name = "txtTitleForm";
            this.txtTitleForm.Size = new System.Drawing.Size(131, 21);
            this.txtTitleForm.TabIndex = 2;
            this.txtTitleForm.Text = "Add New Book :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCategorie);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNbPages);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDatePublished);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 426);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // txtCategorie
            // 
            this.txtCategorie.BackColor = System.Drawing.Color.MintCream;
            this.txtCategorie.FormattingEnabled = true;
            this.txtCategorie.Location = new System.Drawing.Point(15, 360);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(272, 23);
            this.txtCategorie.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(15, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Categorie :";
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.Color.MintCream;
            this.txtAuthor.FormattingEnabled = true;
            this.txtAuthor.Location = new System.Drawing.Point(15, 302);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(272, 23);
            this.txtAuthor.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(15, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Author :";
            // 
            // txtNbPages
            // 
            this.txtNbPages.BackColor = System.Drawing.Color.MintCream;
            this.txtNbPages.Location = new System.Drawing.Point(217, 216);
            this.txtNbPages.Name = "txtNbPages";
            this.txtNbPages.Size = new System.Drawing.Size(70, 23);
            this.txtNbPages.TabIndex = 15;
            this.txtNbPages.Validating += new System.ComponentModel.CancelEventHandler(this.txtNbPages_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(217, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nb.Pages :";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.MintCream;
            this.txtPrice.Location = new System.Drawing.Point(142, 216);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(51, 23);
            this.txtPrice.TabIndex = 13;
            this.txtPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrice_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(142, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Price :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtDatePublished
            // 
            this.txtDatePublished.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDatePublished.Location = new System.Drawing.Point(15, 216);
            this.txtDatePublished.Name = "txtDatePublished";
            this.txtDatePublished.Size = new System.Drawing.Size(109, 23);
            this.txtDatePublished.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(15, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Published Date :";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.MintCream;
            this.txtDescription.Location = new System.Drawing.Point(15, 111);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(272, 60);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(15, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description :";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.MintCream;
            this.txtTitle.Location = new System.Drawing.Point(15, 43);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(272, 23);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitle_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(15, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Title :";
            // 
            // btnCreateBook
            // 
            this.btnCreateBook.BackColor = System.Drawing.Color.LightGray;
            this.btnCreateBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateBook.FlatAppearance.BorderSize = 0;
            this.btnCreateBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBook.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnCreateBook.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateBook.Image")));
            this.btnCreateBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateBook.Location = new System.Drawing.Point(500, 447);
            this.btnCreateBook.Name = "btnCreateBook";
            this.btnCreateBook.Size = new System.Drawing.Size(156, 43);
            this.btnCreateBook.TabIndex = 9;
            this.btnCreateBook.Text = "Create  Book";
            this.btnCreateBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateBook.UseVisualStyleBackColor = false;
            this.btnCreateBook.Click += new System.EventHandler(this.btnCreateBook_Click);
            // 
            // txtImageCover
            // 
            this.txtImageCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImageCover.Location = new System.Drawing.Point(347, 74);
            this.txtImageCover.Name = "txtImageCover";
            this.txtImageCover.Size = new System.Drawing.Size(309, 351);
            this.txtImageCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtImageCover.TabIndex = 10;
            this.txtImageCover.TabStop = false;
            this.txtImageCover.Click += new System.EventHandler(this.txtImageCover_Click);
            // 
            // btnUploadCover
            // 
            this.btnUploadCover.BackColor = System.Drawing.Color.LightGray;
            this.btnUploadCover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadCover.FlatAppearance.BorderSize = 0;
            this.btnUploadCover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadCover.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnUploadCover.Image = ((System.Drawing.Image)(resources.GetObject("btnUploadCover.Image")));
            this.btnUploadCover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUploadCover.Location = new System.Drawing.Point(532, 387);
            this.btnUploadCover.Name = "btnUploadCover";
            this.btnUploadCover.Size = new System.Drawing.Size(115, 33);
            this.btnUploadCover.TabIndex = 11;
            this.btnUploadCover.Text = "Upload";
            this.btnUploadCover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUploadCover.UseVisualStyleBackColor = false;
            this.btnUploadCover.Click += new System.EventHandler(this.btnUploadCover_Click);
            // 
            // txtImageCoverPath
            // 
            this.txtImageCoverPath.AutoSize = true;
            this.txtImageCoverPath.Location = new System.Drawing.Point(335, 432);
            this.txtImageCoverPath.Name = "txtImageCoverPath";
            this.txtImageCoverPath.Size = new System.Drawing.Size(12, 15);
            this.txtImageCoverPath.TabIndex = 12;
            this.txtImageCoverPath.Text = "_";
            this.txtImageCoverPath.Visible = false;
            // 
            // errorManagment
            // 
            this.errorManagment.ContainerControl = this;
            // 
            // BookAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(689, 526);
            this.Controls.Add(this.txtImageCoverPath);
            this.Controls.Add(this.btnUploadCover);
            this.Controls.Add(this.txtImageCover);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCreateBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookAddEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookAddEditForm";
            this.Load += new System.EventHandler(this.BookAddEditForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImageCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorManagment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtTitleForm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtDatePublished;
        private System.Windows.Forms.Button btnCreateBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNbPages;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox txtCategorie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txtAuthor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox txtImageCover;
        private System.Windows.Forms.Button btnUploadCover;
        private System.Windows.Forms.Label txtImageCoverPath;
        private System.Windows.Forms.ErrorProvider errorManagment;
    }
}