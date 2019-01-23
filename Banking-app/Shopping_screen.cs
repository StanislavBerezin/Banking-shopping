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
    public partial class Shopping_screen : Form
    {


        private UserModel user;
        private List<string> shops = new List<string> { "Tech","Coles" };

        public Shopping_screen(UserModel user)
        {
            this.user = user;
            InitializeComponent();
            name_value.Text = user.userName;
            balance_value.Text = Convert.ToString(user.regularAccount.Balance) + '$';
            populateDummyData();


        }

        private void populateDummyData()
        {
            shop_selection.DataSource = shops;
            shop_items.DataSource = shop_items;
        }

        private void deposit_btn_Click(object sender, EventArgs e)
        {
            DepositForm form = new DepositForm(user);
            this.Hide();
            form.ShowDialog();
            this.Dispose();
            this.Close();
        }
    }
}
