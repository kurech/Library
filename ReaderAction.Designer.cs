
namespace WindowsFormsApp8
{
    partial class ReaderAction
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
            this.listViewReaders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxSearchViaFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddReader = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewReaders
            // 
            this.listViewReaders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewReaders.HideSelection = false;
            this.listViewReaders.Location = new System.Drawing.Point(13, 40);
            this.listViewReaders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewReaders.Name = "listViewReaders";
            this.listViewReaders.Size = new System.Drawing.Size(885, 436);
            this.listViewReaders.TabIndex = 1;
            this.listViewReaders.UseCompatibleStateImageBehavior = false;
            this.listViewReaders.View = System.Windows.Forms.View.Details;
            this.listViewReaders.SelectedIndexChanged += new System.EventHandler(this.listViewReaders_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "№ билета";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Фамилия";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Имя";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Отчество";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Адрес";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Номер телефона";
            this.columnHeader6.Width = 200;
            // 
            // textBoxSearchViaFullName
            // 
            this.textBoxSearchViaFullName.Location = new System.Drawing.Point(272, 5);
            this.textBoxSearchViaFullName.Name = "textBoxSearchViaFullName";
            this.textBoxSearchViaFullName.Size = new System.Drawing.Size(186, 26);
            this.textBoxSearchViaFullName.TabIndex = 4;
            this.textBoxSearchViaFullName.TextChanged += new System.EventHandler(this.textBoxSearchViaFullName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поиск книг по фамилии и имени";
            // 
            // buttonAddReader
            // 
            this.buttonAddReader.Location = new System.Drawing.Point(782, 5);
            this.buttonAddReader.Name = "buttonAddReader";
            this.buttonAddReader.Size = new System.Drawing.Size(112, 28);
            this.buttonAddReader.TabIndex = 5;
            this.buttonAddReader.Text = "Добавить";
            this.buttonAddReader.UseVisualStyleBackColor = true;
            this.buttonAddReader.Click += new System.EventHandler(this.buttonAddReader_Click);
            // 
            // ReaderAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 492);
            this.Controls.Add(this.buttonAddReader);
            this.Controls.Add(this.textBoxSearchViaFullName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewReaders);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReaderAction";
            this.Text = "Действия над читателями";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView listViewReaders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox textBoxSearchViaFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddReader;
    }
}