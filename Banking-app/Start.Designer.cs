namespace Banking_app
{
    partial class Start
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
            this.startShopping_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.username_value = new System.Windows.Forms.TextBox();
            this.username_lbl = new System.Windows.Forms.Label();
            this.deposit_lbl = new System.Windows.Forms.Label();
            this.deposit_value = new System.Windows.Forms.TextBox();
            this.error_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startShopping_btn
            // 
            this.startShopping_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startShopping_btn.Location = new System.Drawing.Point(92, 192);
            this.startShopping_btn.Name = "startShopping_btn";
            this.startShopping_btn.Size = new System.Drawing.Size(234, 70);
            this.startShopping_btn.TabIndex = 13;
            this.startShopping_btn.Text = "Start shopping";
            this.startShopping_btn.UseVisualStyleBackColor = true;
            this.startShopping_btn.Click += new System.EventHandler(this.startShopping_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Welcome to banking app";
            // 
            // username_value
            // 
            this.username_value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_value.Location = new System.Drawing.Point(207, 79);
            this.username_value.Name = "username_value";
            this.username_value.Size = new System.Drawing.Size(100, 29);
            this.username_value.TabIndex = 15;
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lbl.Location = new System.Drawing.Point(115, 82);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(84, 21);
            this.username_lbl.TabIndex = 16;
            this.username_lbl.Text = "Username:";
            // 
            // deposit_lbl
            // 
            this.deposit_lbl.AutoSize = true;
            this.deposit_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deposit_lbl.Location = new System.Drawing.Point(115, 117);
            this.deposit_lbl.Name = "deposit_lbl";
            this.deposit_lbl.Size = new System.Drawing.Size(70, 21);
            this.deposit_lbl.TabIndex = 18;
            this.deposit_lbl.Text = "Deposit: ";
            // 
            // deposit_value
            // 
            this.deposit_value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deposit_value.Location = new System.Drawing.Point(207, 114);
            this.deposit_value.Name = "deposit_value";
            this.deposit_value.Size = new System.Drawing.Size(100, 29);
            this.deposit_value.TabIndex = 17;
            // 
            // error_lbl
            // 
            this.error_lbl.AutoSize = true;
            this.error_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_lbl.ForeColor = System.Drawing.Color.Red;
            this.error_lbl.Location = new System.Drawing.Point(115, 156);
            this.error_lbl.Name = "error_lbl";
            this.error_lbl.Size = new System.Drawing.Size(69, 21);
            this.error_lbl.TabIndex = 19;
            this.error_lbl.Text = "<error>";
            this.error_lbl.Visible = false;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 286);
            this.Controls.Add(this.error_lbl);
            this.Controls.Add(this.deposit_lbl);
            this.Controls.Add(this.deposit_value);
            this.Controls.Add(this.username_lbl);
            this.Controls.Add(this.username_value);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startShopping_btn);
            this.Name = "Start";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startShopping_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username_value;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Label deposit_lbl;
        private System.Windows.Forms.TextBox deposit_value;
        private System.Windows.Forms.Label error_lbl;
    }
}

