using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_app
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void startShopping_btn_Click(object sender, EventArgs e)
        {
            int deposit;
            bool isDepositValid = int.TryParse(deposit_value.Text, out deposit);
            bool isUsernameValid = username_value.Text is String;


            if (username_value.Text == "" || !isUsernameValid)
            {
                displayError(true, "You havent entered a username");
            }
            else if (!isDepositValid) {
                displayError(true, "enter valid deposit");
            }
            else
            {
                displayError(false, "");
            }
        }

        private void displayError(bool visible, string errorMsg)
        {
            error_lbl.Text = errorMsg;
            error_lbl.Visible = visible;
        }
    }
}
