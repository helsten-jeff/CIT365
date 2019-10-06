using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Helsten
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        
        private void Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuoteForm = new AddQuote();
            viewAddQuoteForm.Tag = this;
            viewAddQuoteForm.Show(this);
            Hide();
        }
        private void Button2_Click_1(object sender, EventArgs e)
        {
            ViewAllQuotes viewViewQuotesForm = new ViewAllQuotes();
            viewViewQuotesForm.Tag = this;
            viewViewQuotesForm.Show(this);
            Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SearchQuotes viewSearchQuotesForm = new SearchQuotes();
            viewSearchQuotesForm.Tag = this;
            viewSearchQuotesForm.Show(this);
            Hide();
        }
    }
}
