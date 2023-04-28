
namespace WindowsFormsApp8
{
    partial class AddBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNameBook = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPublishing = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxYearOfPublishing = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxAuthors = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование книги";
            // 
            // textBoxNameBook
            // 
            this.textBoxNameBook.Location = new System.Drawing.Point(196, 26);
            this.textBoxNameBook.Name = "textBoxNameBook";
            this.textBoxNameBook.Size = new System.Drawing.Size(191, 26);
            this.textBoxNameBook.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Издательство";
            // 
            // comboBoxPublishing
            // 
            this.comboBoxPublishing.FormattingEnabled = true;
            this.comboBoxPublishing.Location = new System.Drawing.Point(196, 58);
            this.comboBoxPublishing.Name = "comboBoxPublishing";
            this.comboBoxPublishing.Size = new System.Drawing.Size(191, 28);
            this.comboBoxPublishing.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Год издания";
            // 
            // textBoxYearOfPublishing
            // 
            this.textBoxYearOfPublishing.Location = new System.Drawing.Point(196, 92);
            this.textBoxYearOfPublishing.Name = "textBoxYearOfPublishing";
            this.textBoxYearOfPublishing.Size = new System.Drawing.Size(191, 26);
            this.textBoxYearOfPublishing.TabIndex = 5;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(196, 124);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(191, 26);
            this.textBoxGenre.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Жанр";
            // 
            // comboBoxAuthors
            // 
            this.comboBoxAuthors.FormattingEnabled = true;
            this.comboBoxAuthors.Location = new System.Drawing.Point(196, 156);
            this.comboBoxAuthors.Name = "comboBoxAuthors";
            this.comboBoxAuthors.Size = new System.Drawing.Size(191, 28);
            this.comboBoxAuthors.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Автор";
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(115, 203);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(163, 45);
            this.buttonAddBook.TabIndex = 10;
            this.buttonAddBook.Text = "Добавить";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 270);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.comboBoxAuthors);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxYearOfPublishing);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxPublishing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNameBook);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddBook";
            this.Text = "Добавление книги";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNameBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPublishing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxYearOfPublishing;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxAuthors;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddBook;
    }
}