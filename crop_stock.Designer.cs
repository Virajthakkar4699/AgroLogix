namespace AgroLogix
{
    partial class crop_stock
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_fieldno = new System.Windows.Forms.ComboBox();
            this.cb_plotno = new System.Windows.Forms.ComboBox();
            this.cb_croptype = new System.Windows.Forms.ComboBox();
            this.tb_qty = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Field No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Plot No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Crop Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Qty(Kg)";
            // 
            // cb_fieldno
            // 
            this.cb_fieldno.FormattingEnabled = true;
            this.cb_fieldno.Location = new System.Drawing.Point(92, 45);
            this.cb_fieldno.Name = "cb_fieldno";
            this.cb_fieldno.Size = new System.Drawing.Size(121, 21);
            this.cb_fieldno.TabIndex = 5;
            this.cb_fieldno.SelectedIndexChanged += new System.EventHandler(this.cb_fieldno_SelectedIndexChanged);
            this.cb_fieldno.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb_fieldno_MouseClick);
            // 
            // cb_plotno
            // 
            this.cb_plotno.FormattingEnabled = true;
            this.cb_plotno.Location = new System.Drawing.Point(92, 77);
            this.cb_plotno.Name = "cb_plotno";
            this.cb_plotno.Size = new System.Drawing.Size(121, 21);
            this.cb_plotno.TabIndex = 6;
            this.cb_plotno.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb_plotno_MouseClick);
            // 
            // cb_croptype
            // 
            this.cb_croptype.FormattingEnabled = true;
            this.cb_croptype.Location = new System.Drawing.Point(92, 110);
            this.cb_croptype.Name = "cb_croptype";
            this.cb_croptype.Size = new System.Drawing.Size(121, 21);
            this.cb_croptype.TabIndex = 7;
            this.cb_croptype.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb_croptype_MouseClick);
            // 
            // tb_qty
            // 
            this.tb_qty.Location = new System.Drawing.Point(92, 142);
            this.tb_qty.Name = "tb_qty";
            this.tb_qty.Size = new System.Drawing.Size(121, 20);
            this.tb_qty.TabIndex = 8;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(92, 179);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(121, 23);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Crop Stck Manager";
            // 
            // crop_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 266);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_qty);
            this.Controls.Add(this.cb_croptype);
            this.Controls.Add(this.cb_plotno);
            this.Controls.Add(this.cb_fieldno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "crop_stock";
            this.Text = "crop_stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_fieldno;
        private System.Windows.Forms.ComboBox cb_plotno;
        private System.Windows.Forms.ComboBox cb_croptype;
        private System.Windows.Forms.TextBox tb_qty;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label5;
    }
}