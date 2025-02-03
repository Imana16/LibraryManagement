namespace LibraryManagement
{
    partial class EditBook
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
            Title = new Label();
            Author = new Label();
            Publisher = new Label();
            Year = new Label();
            Genre = new Label();
            CopiesAvailable = new Label();
            btnsave = new Button();
            btncancel = new Button();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtPublisher = new TextBox();
            txtYear = new TextBox();
            txtGenre = new TextBox();
            txtCopies = new TextBox();
            BookImage = new PictureBox();
            btnUploadImag = new Button();
            textImagepath = new TextBox();
            ((System.ComponentModel.ISupportInitialize)BookImage).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(36, 66);
            Title.Name = "Title";
            Title.Size = new Size(38, 20);
            Title.TabIndex = 0;
            Title.Text = "Title";
            // 
            // Author
            // 
            Author.AutoSize = true;
            Author.Location = new Point(27, 154);
            Author.Name = "Author";
            Author.Size = new Size(54, 20);
            Author.TabIndex = 1;
            Author.Text = "Author";
            // 
            // Publisher
            // 
            Publisher.AutoSize = true;
            Publisher.Location = new Point(27, 112);
            Publisher.Name = "Publisher";
            Publisher.Size = new Size(69, 20);
            Publisher.TabIndex = 2;
            Publisher.Text = "Publisher";
            // 
            // Year
            // 
            Year.AutoSize = true;
            Year.Location = new Point(435, 157);
            Year.Name = "Year";
            Year.Size = new Size(37, 20);
            Year.TabIndex = 3;
            Year.Text = "Year";
            // 
            // Genre
            // 
            Genre.AutoSize = true;
            Genre.Location = new Point(435, 115);
            Genre.Name = "Genre";
            Genre.Size = new Size(48, 20);
            Genre.TabIndex = 4;
            Genre.Text = "Genre";
            // 
            // CopiesAvailable
            // 
            CopiesAvailable.AutoSize = true;
            CopiesAvailable.Location = new Point(424, 70);
            CopiesAvailable.Name = "CopiesAvailable";
            CopiesAvailable.Size = new Size(120, 20);
            CopiesAvailable.TabIndex = 5;
            CopiesAvailable.Text = "Copies Available";
            CopiesAvailable.Click += CopiesAvailable_Click;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(442, 396);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(94, 29);
            btnsave.TabIndex = 7;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btncancel
            // 
            btncancel.Location = new Point(593, 396);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(94, 29);
            btncancel.TabIndex = 8;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(80, 67);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(272, 27);
            txtTitle.TabIndex = 9;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(113, 157);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(271, 27);
            txtAuthor.TabIndex = 10;
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(113, 112);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(258, 27);
            txtPublisher.TabIndex = 11;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(538, 154);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(237, 27);
            txtYear.TabIndex = 12;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(535, 112);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(240, 27);
            txtGenre.TabIndex = 13;
            // 
            // txtCopies
            // 
            txtCopies.Location = new Point(556, 66);
            txtCopies.Name = "txtCopies";
            txtCopies.Size = new Size(219, 27);
            txtCopies.TabIndex = 14;
            // 
            // BookImage
            // 
            BookImage.BorderStyle = BorderStyle.FixedSingle;
            BookImage.Location = new Point(189, 210);
            BookImage.Name = "BookImage";
            BookImage.Size = new Size(208, 95);
            BookImage.TabIndex = 15;
            BookImage.TabStop = false;
            BookImage.Click += BookImage_Click;
            // 
            // btnUploadImag
            // 
            btnUploadImag.Location = new Point(45, 237);
            btnUploadImag.Name = "btnUploadImag";
            btnUploadImag.Size = new Size(116, 29);
            btnUploadImag.TabIndex = 16;
            btnUploadImag.Text = "Upload Image";
            btnUploadImag.UseVisualStyleBackColor = true;
            btnUploadImag.Click += btnUploadImag_Click;
            // 
            // textImagepath
            // 
            textImagepath.Location = new Point(189, 331);
            textImagepath.Name = "textImagepath";
            textImagepath.Size = new Size(544, 27);
            textImagepath.TabIndex = 17;
            // 
            // EditBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textImagepath);
            Controls.Add(btnUploadImag);
            Controls.Add(BookImage);
            Controls.Add(txtCopies);
            Controls.Add(txtGenre);
            Controls.Add(txtYear);
            Controls.Add(txtPublisher);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(btncancel);
            Controls.Add(btnsave);
            Controls.Add(CopiesAvailable);
            Controls.Add(Genre);
            Controls.Add(Year);
            Controls.Add(Publisher);
            Controls.Add(Author);
            Controls.Add(Title);
            Name = "EditBook";
            Text = "EditBook";
            Load += EditBook_Load;
            ((System.ComponentModel.ISupportInitialize)BookImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label Author;
        private Label Publisher;
        private Label Year;
        private Label Genre;
        private Label CopiesAvailable;
        private Button btnsave;
        private Button btncancel;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtPublisher;
        private TextBox txtYear;
        private TextBox txtGenre;
        private TextBox txtCopies;
        private PictureBox BookImage;
        private Button btnUploadImag;
        private TextBox textImagepath;
    }
}