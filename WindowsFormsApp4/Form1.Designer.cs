namespace WindowsFormsApp4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBoxAvailableBooks = new System.Windows.Forms.ListBox();
            this.listBoxCheckedOutBooks = new System.Windows.Forms.ListBox();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // listBoxAvailableBooks
            // 
            this.listBoxAvailableBooks.FormattingEnabled = true;
            this.listBoxAvailableBooks.Location = new System.Drawing.Point(12, 12);
            this.listBoxAvailableBooks.Name = "listBoxAvailableBooks";
            this.listBoxAvailableBooks.Size = new System.Drawing.Size(300, 200);
            this.listBoxAvailableBooks.TabIndex = 0;

            // 
            // listBoxCheckedOutBooks
            // 
            this.listBoxCheckedOutBooks.FormattingEnabled = true;
            this.listBoxCheckedOutBooks.Location = new System.Drawing.Point(318, 12);
            this.listBoxCheckedOutBooks.Name = "listBoxCheckedOutBooks";
            this.listBoxCheckedOutBooks.Size = new System.Drawing.Size(300, 200);
            this.listBoxCheckedOutBooks.TabIndex = 1;

            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Location = new System.Drawing.Point(12, 220);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(300, 40);
            this.buttonCheckOut.TabIndex = 2;
            this.buttonCheckOut.Text = "Выдать книгу";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            this.buttonCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);

            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(318, 220);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(300, 40);
            this.buttonReturn.TabIndex = 3;
            this.buttonReturn.Text = "Вернуть книгу";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 280);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonCheckOut);
            this.Controls.Add(this.listBoxCheckedOutBooks);
            this.Controls.Add(this.listBoxAvailableBooks);
            this.Name = "Form1";
            this.Text = "Библиотека";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox listBoxAvailableBooks;
        private System.Windows.Forms.ListBox listBoxCheckedOutBooks;
        private System.Windows.Forms.Button buttonCheckOut;
        private System.Windows.Forms.Button buttonReturn;
    }
}
