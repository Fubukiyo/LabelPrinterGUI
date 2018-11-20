namespace PrintConsoleGUI
{
    partial class Printer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Printer));
            this.print = new System.Windows.Forms.Button();
            this.input1 = new System.Windows.Forms.TextBox();
            this.printText = new System.Windows.Forms.Label();
            this.printAmount = new System.Windows.Forms.Label();
            this.pAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(238, 54);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(75, 23);
            this.print.TabIndex = 2;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(12, 25);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(301, 20);
            this.input1.TabIndex = 0;
            // 
            // printText
            // 
            this.printText.AutoSize = true;
            this.printText.BackColor = System.Drawing.SystemColors.Control;
            this.printText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printText.Location = new System.Drawing.Point(9, 9);
            this.printText.Name = "printText";
            this.printText.Size = new System.Drawing.Size(78, 13);
            this.printText.TabIndex = 2;
            this.printText.Text = "Enter your text:";
            // 
            // printAmount
            // 
            this.printAmount.AutoSize = true;
            this.printAmount.Location = new System.Drawing.Point(12, 59);
            this.printAmount.Name = "printAmount";
            this.printAmount.Size = new System.Drawing.Size(46, 13);
            this.printAmount.TabIndex = 3;
            this.printAmount.Text = "Amount:";
            // 
            // pAmount
            // 
            this.pAmount.Location = new System.Drawing.Point(64, 56);
            this.pAmount.Name = "pAmount";
            this.pAmount.Size = new System.Drawing.Size(28, 20);
            this.pAmount.TabIndex = 1;
            this.pAmount.Text = "2";
            // 
            // Printer
            // 
            this.AcceptButton = this.print;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(325, 89);
            this.Controls.Add(this.pAmount);
            this.Controls.Add(this.printAmount);
            this.Controls.Add(this.printText);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.print);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Printer";
            this.Text = "Printer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button print;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.Label printText;
        private System.Windows.Forms.Label printAmount;
        private System.Windows.Forms.TextBox pAmount;
    }
}

