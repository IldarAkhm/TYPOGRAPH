using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Typograth_Application
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        public void buttonToDo_Click(object sender, EventArgs e)
        {
            mainTextBox.ReadOnly = false;
            mainTextBox.Text = rule_defis(mainTextBox.Text);
            mainTextBox.Text = rule_quotes(mainTextBox.Text);
            mainTextBox.Text = rule_plusMinus(mainTextBox.Text);
            mainTextBox.Text = rule_amper(mainTextBox.Text);
            mainTextBox.Text = rule_P(mainTextBox.Text);
            mainTextBox.Text = rule_Tilde(mainTextBox.Text);
            mainTextBox.Text = rule_Nabla(mainTextBox.Text);
            mainTextBox.Text = FormatPunctuation(mainTextBox.Text);
            mainTextBox.Text = rule_pineapple(mainTextBox.Text);
        }
        public string rule_defis(string str)
        {
            str = str.Replace(" — ", "—");
            return str;
        }
        public string rule_quotes(string str)
        {
            str = str.Replace("''", "«»");
            str = str.Replace("\"\"", "«»");
            return str;
        }
        public string rule_plusMinus(string str)
        {
            str = str.Replace("+-", "±");
            return str;
        }
        public string rule_amper(string str)
        {
            str = str.Replace("&", "&amp;");
            return str;
        }
        public string FormatPunctuation(string str)
        {
            str = Regex.Replace(str, @"\s*,\s*", ", ");
            str = Regex.Replace(str, @"\s*\.\s*", ". ");
            str = Regex.Replace(str, @"\s*-\s*", " - ");
            str = Regex.Replace(str, @"\s*'", "«");
            str = Regex.Replace(str, @"'\s*", "»");
            return str;
        }
        public string rule_P(string str)
        {
            str = str.Replace("script capital p", "℘");
            return str;
        }
        public string rule_Tilde(string str)
        {
            str = str.Replace("tilde", "~");
            return str;
        }
        public string rule_Nabla(string str)
        {
            str = str.Replace("nabla", "∇");
            return str;
        }
        public string rule_pineapple(string str)
        {
            str = str.Replace("pineapple", "  ,#####,\r\n     #_/_|_\\_\\__              ___________\r\n    |   _     _ ```````````|  Ильдар |\r\n    |  / \\  / \\            |  Браво!   |\r\n    | | 0 | 0 |            | Молодец |\r\n    |  \\_/ \\_/             ~~~~~~~~~~~~\r\n    |                       |      |\r\n    |                       |      |\r\n    |                       |      |\r\n    |                       |      |\r\n    |                       |      |\r\n    |                       |      |\r\n    |                       |      |\r\n    |                       |      |\r\n    \\                     / \\    / \\\r\n     \\___________________/   \\__/   ");
            return str;
        }
    }
}
