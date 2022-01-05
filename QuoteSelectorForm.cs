using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitterBotForm
{
    public partial class QuoteSelectorForm : Form
    {
        string selectedQuote = "";
        public string SelectedQuote
        {
            get { return selectedQuote; }
            set { selectedQuote = value; }
        }
        public QuoteSelectorForm()
        {
            InitializeComponent();
        }

        private void QuoteLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            selectedQuote = "";
            this.Close();
        }

        private void SelectGoBTN_Click(object sender, EventArgs e)
        {
            selectedQuote = QuoteLB.SelectedItem.ToString();
            this.Close();
        }
    }
}
