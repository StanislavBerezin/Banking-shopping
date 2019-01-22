namespace Banking_app
{
    partial class Shopping_screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.name_value = new System.Windows.Forms.Label();
            this.balance_value = new System.Windows.Forms.Label();
            this.balance_lbl = new System.Windows.Forms.Label();
            this.customers_cart = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.shop_selection = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.shop_items = new System.Windows.Forms.ListBox();
            this.deposit_btn = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.checkout_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shopping centre";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.Location = new System.Drawing.Point(9, 105);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(64, 21);
            this.name_lbl.TabIndex = 1;
            this.name_lbl.Text = "Name: ";
            // 
            // name_value
            // 
            this.name_value.AutoSize = true;
            this.name_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_value.Location = new System.Drawing.Point(89, 105);
            this.name_value.Name = "name_value";
            this.name_value.Size = new System.Drawing.Size(67, 20);
            this.name_value.TabIndex = 2;
            this.name_value.Text = "<name>";
            // 
            // balance_value
            // 
            this.balance_value.AutoSize = true;
            this.balance_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance_value.Location = new System.Drawing.Point(89, 142);
            this.balance_value.Name = "balance_value";
            this.balance_value.Size = new System.Drawing.Size(83, 20);
            this.balance_value.TabIndex = 4;
            this.balance_value.Text = "<balance>";
            // 
            // balance_lbl
            // 
            this.balance_lbl.AutoSize = true;
            this.balance_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance_lbl.Location = new System.Drawing.Point(9, 142);
            this.balance_lbl.Name = "balance_lbl";
            this.balance_lbl.Size = new System.Drawing.Size(74, 21);
            this.balance_lbl.TabIndex = 3;
            this.balance_lbl.Text = "Balance:";
            // 
            // customers_cart
            // 
            this.customers_cart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customers_cart.FormattingEnabled = true;
            this.customers_cart.ItemHeight = 21;
            this.customers_cart.Location = new System.Drawing.Point(12, 250);
            this.customers_cart.Name = "customers_cart";
            this.customers_cart.Size = new System.Drawing.Size(157, 193);
            this.customers_cart.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Your cart";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // shop_selection
            // 
            this.shop_selection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shop_selection.FormattingEnabled = true;
            this.shop_selection.Location = new System.Drawing.Point(315, 166);
            this.shop_selection.Name = "shop_selection";
            this.shop_selection.Size = new System.Drawing.Size(157, 29);
            this.shop_selection.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(333, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Choose a shop";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(367, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Items";
            // 
            // shop_items
            // 
            this.shop_items.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shop_items.FormattingEnabled = true;
            this.shop_items.ItemHeight = 21;
            this.shop_items.Location = new System.Drawing.Point(252, 250);
            this.shop_items.Name = "shop_items";
            this.shop_items.Size = new System.Drawing.Size(283, 193);
            this.shop_items.TabIndex = 11;
            // 
            // deposit_btn
            // 
            this.deposit_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deposit_btn.Location = new System.Drawing.Point(12, 12);
            this.deposit_btn.Name = "deposit_btn";
            this.deposit_btn.Size = new System.Drawing.Size(71, 27);
            this.deposit_btn.TabIndex = 13;
            this.deposit_btn.Text = "Deposit";
            this.deposit_btn.UseVisualStyleBackColor = true;
            this.deposit_btn.Click += new System.EventHandler(this.deposit_btn_Click);
            // 
            // logout_button
            // 
            this.logout_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_button.Location = new System.Drawing.Point(477, 12);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(87, 27);
            this.logout_button.TabIndex = 14;
            this.logout_button.Text = "Log out";
            this.logout_button.UseVisualStyleBackColor = true;
            // 
            // checkout_button
            // 
            this.checkout_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkout_button.Location = new System.Drawing.Point(93, 12);
            this.checkout_button.Name = "checkout_button";
            this.checkout_button.Size = new System.Drawing.Size(100, 27);
            this.checkout_button.TabIndex = 15;
            this.checkout_button.Text = "Check out";
            this.checkout_button.UseVisualStyleBackColor = true;
            // 
            // Shopping_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 460);
            this.Controls.Add(this.checkout_button);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.deposit_btn);
            this.Controls.Add(this.shop_items);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shop_selection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customers_cart);
            this.Controls.Add(this.balance_value);
            this.Controls.Add(this.balance_lbl);
            this.Controls.Add(this.name_value);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.label1);
            this.Name = "Shopping_screen";
            this.Text = "Shopping_screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label name_value;
        private System.Windows.Forms.Label balance_value;
        private System.Windows.Forms.Label balance_lbl;
        private System.Windows.Forms.ListBox customers_cart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox shop_selection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox shop_items;
        private System.Windows.Forms.Button deposit_btn;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button checkout_button;
    }
}