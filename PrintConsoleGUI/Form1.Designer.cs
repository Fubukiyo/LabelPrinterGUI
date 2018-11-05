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
            this.print = new System.Windows.Forms.Button();
            this.input1 = new System.Windows.Forms.TextBox();
            this.printText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(238, 54);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(75, 23);
            this.print.TabIndex = 1;
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
            // Printer
            // 
            this.AcceptButton = this.print;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(325, 89);
            this.Controls.Add(this.printText);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.print);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
    }
}

