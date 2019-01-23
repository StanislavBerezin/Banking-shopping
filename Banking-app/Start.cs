using banking_logic;
using banking_logic.Models;
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
            int name;
            bool isDepositValid = int.TryParse(deposit_value.Text, out deposit);
            bool isUsernameValid = int.TryParse(username_value.Text, out name);


            if (username_value.Text == "" || isUsernameValid)
            {
                displayError(true, "Incorrect username");
            }
            else if (!isDepositValid) {
                displayError(true, "enter valid deposit");
            }
            else
            {
                displayError(false, "");

                UserModel user = new UserModel() {
                    userName = username_value.Text,
                    regularAccount = new AccountModel
                    {
                        Balance = Convert.ToInt32(deposit_value.Text)
                    }

                };
                

                Shopping_screen form = new Shopping_screen(user);
                
               
                this.Hide();
                form.ShowDialog();
                this.Close();
                this.Dispose();
            }


        }

        private void displayError(bool visible, string errorMsg)
        {
            error_lbl.Text = errorMsg;
            error_lbl.Visible = visible;
        }
    }
}
