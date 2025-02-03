namespace LibraryManagement
{
    partial class AddBookForm
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
            pictureBoxBookImage = new PictureBox();
            btnUploadImag = new Button();
            textBoxtitle = new TextBox();
            textBoxauthor = new TextBox();
            textBoxpublisher = new TextBox();
            textBoxyear = new TextBox();
            textBoxgenre = new TextBox();
            textBoxcopies = new TextBox();
            btnsave = new Button();
            btncancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBookImage).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(20, 67);
            Title.Name = "Title";
            Title.Size = new Size(38, 20);
            Title.TabIndex = 0;
            Title.Text = "Title";
            Title.Click += Title_Click;
            // 
            // Author
            // 
            Author.AutoSize = true;
            Author.Location = new Point(20, 105);
            Author.Name = "Author";
            Author.Size = new Size(54, 20);
            Author.TabIndex = 1;
            Author.Text = "Author";
            // 
            // Publisher
            // 
            Publisher.AutoSize = true;
            Publisher.Location = new Point(20, 155);
            Publisher.Name = "Publisher";
            Publisher.Size = new Size(69, 20);
            Publisher.TabIndex = 2;
            Publisher.Text = "Publisher";
            Publisher.Click += Publisher_Click;
            // 
            // Year
            // 
            Year.AutoSize = true;
            Year.Location = new Point(491, 70);
            Year.Name = "Year";
            Year.Size = new Size(37, 20);
            Year.TabIndex = 3;
            Year.Text = "Year";
            // 
            // Genre
            // 
            Genre.AutoSize = true;
            Genre.Location = new Point(480, 108);
            Genre.Name = "Genre";
            Genre.Size = new Size(48, 20);
            Genre.TabIndex = 4;
            Genre.Text = "Genre";
            // 
            // CopiesAvailable
            // 
            CopiesAvailable.AutoSize = true;
            CopiesAvailable.Location = new Point(436, 161);
            CopiesAvailable.Name = "CopiesAvailable";
            CopiesAvailable.Size = new Size(120, 20);
            CopiesAvailable.TabIndex = 5;
            CopiesAvailable.Text = "Copies Available";
            CopiesAvailable.Click += CopiesAvailable_Click;
            // 
            // pictureBoxBookImage
            // 
            pictureBoxBookImage.Location = new Point(167, 214);
            pictureBoxBookImage.Name = "pictureBoxBookImage";
            pictureBoxBookImage.Size = new Size(159, 130);
            pictureBoxBookImage.TabIndex = 7;
            pictureBoxBookImage.TabStop = false;
            // 
            // btnUploadImag
            // 
            btnUploadImag.Location = new Point(20, 214);
            btnUploadImag.Name = "btnUploadImag";
            btnUploadImag.Size = new Size(124, 29);
            btnUploadImag.TabIndex = 8;
            btnUploadImag.Text = "Upload Image";
            btnUploadImag.UseVisualStyleBackColor = true;
            btnUploadImag.Click += btnUploadImag_Click;
            // 
            // textBoxtitle
            // 
            textBoxtitle.Location = new Point(95, 67);
            textBoxtitle.Name = "textBoxtitle";
            textBoxtitle.Size = new Size(277, 27);
            textBoxtitle.TabIndex = 9;
            // 
            // textBoxauthor
            // 
            textBoxauthor.Location = new Point(95, 105);
            textBoxauthor.Name = "textBoxauthor";
            textBoxauthor.Size = new Size(277, 27);
            textBoxauthor.TabIndex = 10;
            // 
            // textBoxpublisher
            // 
            textBoxpublisher.Location = new Point(95, 155);
            textBoxpublisher.Name = "textBoxpublisher";
            textBoxpublisher.Size = new Size(277, 27);
            textBoxpublisher.TabIndex = 11;
            textBoxpublisher.TextChanged += textBoxpublisher_TextChanged;
            // 
            // textBoxyear
            // 
            textBoxyear.Location = new Point(543, 70);
            textBoxyear.Name = "textBoxyear";
            textBoxyear.Size = new Size(199, 27);
            textBoxyear.TabIndex = 12;
            // 
            // textBoxgenre
            // 
            textBoxgenre.Location = new Point(543, 105);
            textBoxgenre.Name = "textBoxgenre";
            textBoxgenre.Size = new Size(199, 27);
            textBoxgenre.TabIndex = 13;
            // 
            // textBoxcopies
            // 
            textBoxcopies.Location = new Point(562, 158);
            textBoxcopies.Name = "textBoxcopies";
            textBoxcopies.Size = new Size(180, 27);
            textBoxcopies.TabIndex = 14;
            textBoxcopies.TextChanged += textBoxcopies_TextChanged;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(436, 395);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(94, 29);
            btnsave.TabIndex = 15;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btncancel
            // 
            btncancel.Location = new Point(598, 395);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(94, 29);
            btncancel.TabIndex = 16;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btncancel);
            Controls.Add(btnsave);
            Controls.Add(textBoxcopies);
            Controls.Add(textBoxgenre);
            Controls.Add(textBoxyear);
            Controls.Add(textBoxpublisher);
            Controls.Add(textBoxauthor);
            Controls.Add(textBoxtitle);
            Controls.Add(btnUploadImag);
            Controls.Add(pictureBoxBookImage);
            Controls.Add(CopiesAvailable);
            Controls.Add(Genre);
            Controls.Add(Year);
            Controls.Add(Publisher);
            Controls.Add(Author);
            Controls.Add(Title);
            Name = "AddBookForm";
            Text = "AddBookForm";
            Load += AddBookForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxBookImage).EndInit();
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
        private PictureBox pictureBoxBookImage;
        private Button btnUploadImag;
        private TextBox textBoxtitle;
        private TextBox textBoxauthor;
        private TextBox textBoxpublisher;
        private TextBox textBoxyear;
        private TextBox textBoxgenre;
        private TextBox textBoxcopies;
        private Button btnsave;
        private Button btncancel;
    }
}