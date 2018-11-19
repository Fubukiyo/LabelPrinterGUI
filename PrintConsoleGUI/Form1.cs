/* Created by Jared Gabel, for use by whomever finds it useful.
 * November 5th, 2018.
 */

using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PrintConsoleGUI
{
    public partial class Printer : Form
    {
        
        public Printer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string input = "";

        private void print_Click(object sender, EventArgs e)
        {
            input = input1.Text;
            string toPrint = "${" + Environment.NewLine + "^CT~~CD,~CC^~CT~" + Environment.NewLine + "^XA~TA000~JSN^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR2,2~SD20^JUS^LRN^CI0^XZ" + Environment.NewLine + "^XA" + Environment.NewLine + "^MMT" + Environment.NewLine + "^PW600" + Environment.NewLine + "^LL0150" + Environment.NewLine + "^LS0" + Environment.NewLine + "^FT536,102^A0I,42,40^FH\\^FD" + input + "^FS" + Environment.NewLine + "^BY2,3,45^FT570,39^BCI,,N,N" + Environment.NewLine + "^FD>:" + input + "^FS" + Environment.NewLine + "^PQ1,0,1,Y^XZ" + Environment.NewLine +  "}$";

            System.IO.File.WriteAllText("label.txt", toPrint);

            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("label.txt");
            psi.Verb = "print";
            Process.Start(psi);

            input1.Text = "";
        }
    }
}
