using banking_logic;
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
    public partial class DepositForm : Form
    {
        private UserModel user;
        public DepositForm(UserModel user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void cleanUpForm()
        {
            
        }

        private void continue_btn_Click(object sender, EventArgs e)
        {
            user.regularAccount.Balance = Convert.ToInt32(deposit_value.Text);
            Shopping_screen form = new Shopping_screen(user);
            this.Hide();
            form.ShowDialog();
            this.Close();
            this.Dispose();

        }
    }
}
