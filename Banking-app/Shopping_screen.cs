﻿using banking_logic;
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
    public partial class Shopping_screen : Form
    {


        private UserModel user;

        public Shopping_screen(UserModel user)
        {
            this.user = user;
            InitializeComponent();
            name_value.Text = user.userName;
            balance_value.Text = Convert.ToString(user.regularAccount.Balance) + '$';

        }

        private void deposit_btn_Click(object sender, EventArgs e)
        {
            DepositForm form = new DepositForm(user);
            form.ShowDialog();
        }
    }
}
