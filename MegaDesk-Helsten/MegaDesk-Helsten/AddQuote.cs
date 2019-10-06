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
    public partial class AddQuote : Form
    {
        Desk d = new Desk();
        public AddQuote()
        {
            InitializeComponent();

        }

        private void ValidateDeskDepth()
        {

            if (deskDepth.Value < d.depthMin  || deskDepth.Value > d.depthMax)
            {
                deskDepth.BackColor = Color.PaleVioletRed;
                depthError.ForeColor = Color.PaleVioletRed;
                depthError.Text = "Please enter a number from 12 to 48";
            } else
            {
                deskDepth.BackColor = Color.White;
                depthError.ForeColor = Color.Black;
                depthError.Text = "( 12\" - 48\" )";
            }
        }

        private void ValidateDeskWidth()
        {
            if (deskWidth.Value < d.widthMin || deskWidth.Value > d.widthMax)
            {
                deskWidth.BackColor = Color.PaleVioletRed;
                widthError.ForeColor = Color.PaleVioletRed;
                widthError.Text = "Please enter a number from 24 to 96";
            }
            else
            {
                deskWidth.BackColor = Color.White;
                widthError.ForeColor = Color.Black;
                widthError.Text = "( 24\" - 96\" )";
            }
        }

        private void ValidateNewQuote()
        {
            string materialInputText = material.Text.ToLower();

            ValidateDeskWidth();
            ValidateDeskDepth();


            if (customerName.Text == string.Empty)
            {
                customerName.BackColor = Color.PaleVioletRed;
                customerNameError.ForeColor = Color.PaleVioletRed;
                customerNameError.Text = "Please enter a customer name";
            }
            if (drawerCount.Value < 0 || drawerCount.Value > 7)
            {
                drawerCount.BackColor = Color.PaleVioletRed;
                drawerCountError.ForeColor = Color.PaleVioletRed;
                drawerCountError.Text = "Please enter a number from 0 to 7";
            }

            if (materialInputText != "laminate oak" && materialInputText != "rosewood" && materialInputText != "veneer" && materialInputText != "pine")
            {
                material.BackColor = Color.PaleVioletRed;
                materialError.ForeColor = Color.PaleVioletRed;
                materialError.Text = "Please type one of the following: Laminate Oak, Rosewood, Veneer, or Pine";
            }

            if (rushOrder.Value != 3 && rushOrder.Value != 5 && rushOrder.Value != 7 && rushOrder.Value != 14)
            {
                rushOrder.BackColor = Color.PaleVioletRed;
                rushOrderError.ForeColor = Color.PaleVioletRed;
                rushOrderError.Text = "Please enter days for a rush order from 0 to 7, or 14 for normal production";
            }

        }

        private void DeskWidth_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SubmitQuote_Click(object sender, EventArgs e)
        {
            ValidateNewQuote();
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ValidateDeskWidth();
        }

        private void LaminatOakRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void DeskDepth_ValueChanged(object sender, EventArgs e)
        {
            ValidateDeskDepth();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuView = new MainMenu();
            mainMenuView.Tag = this;
            mainMenuView.Show(this);
            Hide();
        }
    }
}
