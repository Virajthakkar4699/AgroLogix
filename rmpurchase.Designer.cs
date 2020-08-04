namespace AgroLogix
{
    partial class rmpurchase
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_log = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_vendor_name = new System.Windows.Forms.TextBox();
            this.tb_invoice_id = new System.Windows.Forms.TextBox();
            this.tb_amount = new System.Windows.Forms.TextBox();
            this.tb_qty = new System.Windows.Forms.TextBox();
            this.cb_rmproduct = new System.Windows.Forms.ComboBox();
            this.cb_rmcategory = new System.Windows.Forms.ComboBox();
            this.tb_invoiceid = new System.Windows.Forms.TextBox();
            this.tb_vendorname = new System.Windows.Forms.TextBox();
            this.tb_vendorid = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_qty = new System.Windows.Forms.Label();
            this.lb_price = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_log
            // 
            this.btn_log.Location = new System.Drawing.Point(465, 278);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(121, 23);
            this.btn_log.TabIndex = 52;
            this.btn_log.Text = "See Log";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(114, 278);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(121, 23);
            this.btn_save.TabIndex = 51;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(286, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(473, 174);
            this.dataGridView1.TabIndex = 50;
            // 
            // tb_vendor_name
            // 
            this.tb_vendor_name.Location = new System.Drawing.Point(365, 65);
            this.tb_vendor_name.Name = "tb_vendor_name";
            this.tb_vendor_name.Size = new System.Drawing.Size(121, 20);
            this.tb_vendor_name.TabIndex = 49;
            this.tb_vendor_name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_vendor_name_MouseClick);
            this.tb_vendor_name.TextChanged += new System.EventHandler(this.tb_vendor_name_TextChanged);
            this.tb_vendor_name.Enter += new System.EventHandler(this.tb_vendor_name_Enter);
            // 
            // tb_invoice_id
            // 
            this.tb_invoice_id.Location = new System.Drawing.Point(365, 43);
            this.tb_invoice_id.Name = "tb_invoice_id";
            this.tb_invoice_id.Size = new System.Drawing.Size(121, 20);
            this.tb_invoice_id.TabIndex = 48;
            this.tb_invoice_id.TextChanged += new System.EventHandler(this.tb_invoice_id_TextChanged);
            // 
            // tb_amount
            // 
            this.tb_amount.Location = new System.Drawing.Point(114, 252);
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.Size = new System.Drawing.Size(121, 20);
            this.tb_amount.TabIndex = 47;
            this.tb_amount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_amount_MouseClick);
            // 
            // tb_qty
            // 
            this.tb_qty.Location = new System.Drawing.Point(114, 202);
            this.tb_qty.Name = "tb_qty";
            this.tb_qty.Size = new System.Drawing.Size(121, 20);
            this.tb_qty.TabIndex = 46;
            this.tb_qty.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_qty_MouseClick);
            // 
            // cb_rmproduct
            // 
            this.cb_rmproduct.FormattingEnabled = true;
            this.cb_rmproduct.Location = new System.Drawing.Point(114, 175);
            this.cb_rmproduct.Name = "cb_rmproduct";
            this.cb_rmproduct.Size = new System.Drawing.Size(121, 21);
            this.cb_rmproduct.TabIndex = 44;
            this.cb_rmproduct.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb_rmproduct_MouseClick);
            // 
            // cb_rmcategory
            // 
            this.cb_rmcategory.FormattingEnabled = true;
            this.cb_rmcategory.Location = new System.Drawing.Point(114, 148);
            this.cb_rmcategory.Name = "cb_rmcategory";
            this.cb_rmcategory.Size = new System.Drawing.Size(121, 21);
            this.cb_rmcategory.TabIndex = 43;
            this.cb_rmcategory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb_rmcategory_MouseClick);
            // 
            // tb_invoiceid
            // 
            this.tb_invoiceid.Location = new System.Drawing.Point(114, 122);
            this.tb_invoiceid.Name = "tb_invoiceid";
            this.tb_invoiceid.Size = new System.Drawing.Size(121, 20);
            this.tb_invoiceid.TabIndex = 42;
            // 
            // tb_vendorname
            // 
            this.tb_vendorname.Location = new System.Drawing.Point(114, 95);
            this.tb_vendorname.Name = "tb_vendorname";
            this.tb_vendorname.Size = new System.Drawing.Size(121, 20);
            this.tb_vendorname.TabIndex = 41;
            this.tb_vendorname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_vendorname_MouseClick);
            // 
            // tb_vendorid
            // 
            this.tb_vendorid.Location = new System.Drawing.Point(114, 69);
            this.tb_vendorid.Name = "tb_vendorid";
            this.tb_vendorid.Size = new System.Drawing.Size(121, 20);
            this.tb_vendorid.TabIndex = 40;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(286, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Invoice ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(286, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Vendor ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Vendor ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Amount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Qty:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Select RM Product:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Select RM Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Vendor Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Bill ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Date:";
            // 
            // lb_qty
            // 
            this.lb_qty.AutoSize = true;
            this.lb_qty.Location = new System.Drawing.Point(241, 205);
            this.lb_qty.Name = "lb_qty";
            this.lb_qty.Size = new System.Drawing.Size(21, 13);
            this.lb_qty.TabIndex = 53;
            this.lb_qty.Text = "qty";
            // 
            // lb_price
            // 
            this.lb_price.Location = new System.Drawing.Point(140, 225);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(69, 24);
            this.lb_price.TabIndex = 54;
            this.lb_price.Text = "Price:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(297, 23);
            this.label6.TabIndex = 55;
            this.label6.Text = "Raw Material Purchase Invoice";
            // 
            // rmpurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 348);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.lb_qty);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_vendor_name);
            this.Controls.Add(this.tb_invoice_id);
            this.Controls.Add(this.tb_amount);
            this.Controls.Add(this.tb_qty);
            this.Controls.Add(this.cb_rmproduct);
            this.Controls.Add(this.cb_rmcategory);
            this.Controls.Add(this.tb_invoiceid);
            this.Controls.Add(this.tb_vendorname);
            this.Controls.Add(this.tb_vendorid);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "rmpurchase";
            this.Text = "rmpurchase";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_vendor_name;
        private System.Windows.Forms.TextBox tb_invoice_id;
        private System.Windows.Forms.TextBox tb_amount;
        private System.Windows.Forms.TextBox tb_qty;
        private System.Windows.Forms.ComboBox cb_rmproduct;
        private System.Windows.Forms.ComboBox cb_rmcategory;
        private System.Windows.Forms.TextBox tb_invoiceid;
        private System.Windows.Forms.TextBox tb_vendorname;
        private System.Windows.Forms.TextBox tb_vendorid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_qty;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label label6;
    }
}