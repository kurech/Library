
namespace WindowsFormsApp8
{
    partial class ExtraditionAction
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
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.listBoxReaders = new System.Windows.Forms.ListBox();
            this.buttonExtradition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxBooks
            // 
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.ItemHeight = 20;
            this.listBoxBooks.Location = new System.Drawing.Point(233, 14);
            this.listBoxBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.Size = new System.Drawing.Size(194, 224);
            this.listBoxBooks.TabIndex = 0;
            this.listBoxBooks.SelectedIndexChanged += new System.EventHandler(this.listBoxBooks_SelectedIndexChanged);
            // 
            // listBoxReaders
            // 
            this.listBoxReaders.FormattingEnabled = true;
            this.listBoxReaders.ItemHeight = 20;
            this.listBoxReaders.Location = new System.Drawing.Point(18, 14);
            this.listBoxReaders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxReaders.Name = "listBoxReaders";
            this.listBoxReaders.Size = new System.Drawing.Size(194, 224);
            this.listBoxReaders.TabIndex = 1;
            this.listBoxReaders.SelectedIndexChanged += new System.EventHandler(this.listBoxReaders_SelectedIndexChanged);
            // 
            // buttonExtradition
            // 
            this.buttonExtradition.Location = new System.Drawing.Point(150, 262);
            this.buttonExtradition.Name = "buttonExtradition";
            this.buttonExtradition.Size = new System.Drawing.Size(145, 44);
            this.buttonExtradition.TabIndex = 2;
            this.buttonExtradition.Text = "Выдать книгу";
            this.buttonExtradition.UseVisualStyleBackColor = true;
            this.buttonExtradition.Click += new System.EventHandler(this.buttonExtradition_Click);
            // 
            // ExtraditionAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 329);
            this.Controls.Add(this.buttonExtradition);
            this.Controls.Add(this.listBoxReaders);
            this.Controls.Add(this.listBoxBooks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ExtraditionAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выдача книги";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.ListBox listBoxReaders;
        private System.Windows.Forms.Button buttonExtradition;
    }
}