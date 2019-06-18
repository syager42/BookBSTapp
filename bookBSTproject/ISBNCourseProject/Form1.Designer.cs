namespace ISBNCourseProject
{
    partial class Form1
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
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelISBN = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAll = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelList = new System.Windows.Forms.Label();
            this.labelAdd = new System.Windows.Forms.Label();
            this.labelRemove = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(117, 33);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(116, 20);
            this.textBoxISBN.TabIndex = 0;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(117, 194);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(116, 20);
            this.textBoxYear.TabIndex = 1;
            // 
            // textBoxRating
            // 
            this.textBoxRating.Location = new System.Drawing.Point(117, 153);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(116, 20);
            this.textBoxRating.TabIndex = 2;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(117, 113);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(116, 20);
            this.textBoxAuthor.TabIndex = 3;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(117, 73);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(116, 20);
            this.textBoxTitle.TabIndex = 4;
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(38, 36);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(63, 13);
            this.labelISBN.TabIndex = 5;
            this.labelISBN.Text = "Book ISBN:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(38, 76);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(58, 13);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Book Title:";
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(38, 156);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(69, 13);
            this.labelRating.TabIndex = 8;
            this.labelRating.Text = "Book Rating:";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(38, 116);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(69, 13);
            this.labelAuthor.TabIndex = 7;
            this.labelAuthor.Text = "Book Author:";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(38, 197);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(60, 13);
            this.labelYear.TabIndex = 9;
            this.labelYear.Text = "Book Year:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(37, 270);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(92, 27);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add Book";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(159, 270);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(92, 27);
            this.buttonFind.TabIndex = 11;
            this.buttonFind.Text = "Find Book";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(286, 270);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(92, 27);
            this.buttonRemove.TabIndex = 12;
            this.buttonRemove.Text = "Remove Book";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAll
            // 
            this.buttonAll.Location = new System.Drawing.Point(502, 270);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(92, 27);
            this.buttonAll.TabIndex = 13;
            this.buttonAll.Text = "See All Books";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(426, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(168, 210);
            this.dataGridView1.TabIndex = 14;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(35, 230);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(46, 13);
            this.labelError.TabIndex = 15;
            this.labelError.Text = "ERROR";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(502, 317);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 27);
            this.buttonClose.TabIndex = 16;
            this.buttonClose.Text = "Close Window";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.ForeColor = System.Drawing.Color.Blue;
            this.labelList.Location = new System.Drawing.Point(514, 246);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(30, 13);
            this.labelList.TabIndex = 17;
            this.labelList.Text = "LIST";
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.ForeColor = System.Drawing.Color.Blue;
            this.labelAdd.Location = new System.Drawing.Point(37, 304);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(70, 13);
            this.labelAdd.TabIndex = 18;
            this.labelAdd.Text = "Add Success";
            // 
            // labelRemove
            // 
            this.labelRemove.AutoSize = true;
            this.labelRemove.ForeColor = System.Drawing.Color.Blue;
            this.labelRemove.Location = new System.Drawing.Point(286, 304);
            this.labelRemove.Name = "labelRemove";
            this.labelRemove.Size = new System.Drawing.Size(91, 13);
            this.labelRemove.TabIndex = 19;
            this.labelRemove.Text = "Remove Success";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 384);
            this.Controls.Add(this.labelRemove);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelISBN);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxRating);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxISBN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Label labelRemove;
    }
}

