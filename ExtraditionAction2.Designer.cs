
namespace WindowsFormsApp8
{
    partial class ExtraditionAction2
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
            this.buttonExtraditionReturn = new System.Windows.Forms.Button();
            this.listBoxReaders = new System.Windows.Forms.ListBox();
            this.listBoxExtradions = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonExtraditionReturn
            // 
            this.buttonExtraditionReturn.Location = new System.Drawing.Point(145, 262);
            this.buttonExtraditionReturn.Name = "buttonExtraditionReturn";
            this.buttonExtraditionReturn.Size = new System.Drawing.Size(145, 44);
            this.buttonExtraditionReturn.TabIndex = 5;
            this.buttonExtraditionReturn.Text = "Вернуть книгу";
            this.buttonExtraditionReturn.UseVisualStyleBackColor = true;
            this.buttonExtraditionReturn.Click += new System.EventHandler(this.buttonExtraditionReturn_Click);
            // 
            // listBoxReaders
            // 
            this.listBoxReaders.FormattingEnabled = true;
            this.listBoxReaders.ItemHeight = 20;
            this.listBoxReaders.Location = new System.Drawing.Point(13, 14);
            this.listBoxReaders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxReaders.Name = "listBoxReaders";
            this.listBoxReaders.Size = new System.Drawing.Size(194, 224);
            this.listBoxReaders.TabIndex = 4;
            this.listBoxReaders.SelectedIndexChanged += new System.EventHandler(this.listBoxReaders_SelectedIndexChanged);
            // 
            // listBoxExtradions
            // 
            this.listBoxExtradions.FormattingEnabled = true;
            this.listBoxExtradions.ItemHeight = 20;
            this.listBoxExtradions.Location = new System.Drawing.Point(228, 14);
            this.listBoxExtradions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxExtradions.Name = "listBoxExtradions";
            this.listBoxExtradions.Size = new System.Drawing.Size(194, 224);
            this.listBoxExtradions.TabIndex = 3;
            this.listBoxExtradions.SelectedIndexChanged += new System.EventHandler(this.listBoxExtradions_SelectedIndexChanged);
            // 
            // ExtraditionAction2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 325);
            this.Controls.Add(this.buttonExtraditionReturn);
            this.Controls.Add(this.listBoxReaders);
            this.Controls.Add(this.listBoxExtradions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ExtraditionAction2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Возврат книг";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExtraditionReturn;
        private System.Windows.Forms.ListBox listBoxReaders;
        private System.Windows.Forms.ListBox listBoxExtradions;
    }
}