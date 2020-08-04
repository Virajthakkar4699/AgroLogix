namespace AgroLogix
{
    partial class emp_rpt
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
            this.label5 = new System.Windows.Forms.Label();
            this.cb_employee = new System.Windows.Forms.ComboBox();
            this.cb_fieldno = new System.Windows.Forms.ComboBox();
            this.cb_plotno = new System.Windows.Forms.ComboBox();
            this.dg_empwise = new System.Windows.Forms.DataGridView();
            this.dg_plotwise = new System.Windows.Forms.DataGridView();
            this.btn_view_emp = new System.Windows.Forms.Button();
            this.brn_view_plot = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_empwise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_plotwise)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 310);
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
            this.label1.Location = new System.Drawing.Point(43, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Field No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Plot No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Employee Wise Report";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(349, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Plot Wise Report";
            // 
            // cb_employee
            // 
            this.cb_employee.FormattingEnabled = true;
            this.cb_employee.Location = new System.Drawing.Point(130, 94);
            this.cb_employee.Name = "cb_employee";
            this.cb_employee.Size = new System.Drawing.Size(121, 21);
            this.cb_employee.TabIndex = 6;
            this.cb_employee.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb_employee_MouseClick);
            // 
            // cb_fieldno
            // 
            this.cb_fieldno.FormattingEnabled = true;
            this.cb_fieldno.Location = new System.Drawing.Point(412, 71);
            this.cb_fieldno.Name = "cb_fieldno";
            this.cb_fieldno.Size = new System.Drawing.Size(121, 21);
            this.cb_fieldno.TabIndex = 7;
            this.cb_fieldno.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb_fieldno_MouseClick);
            // 
            // cb_plotno
            // 
            this.cb_plotno.FormattingEnabled = true;
            this.cb_plotno.Location = new System.Drawing.Point(412, 94);
            this.cb_plotno.Name = "cb_plotno";
            this.cb_plotno.Size = new System.Drawing.Size(121, 21);
            this.cb_plotno.TabIndex = 8;
            this.cb_plotno.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb_plotno_MouseClick);
            // 
            // dg_empwise
            // 
            this.dg_empwise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_empwise.Location = new System.Drawing.Point(46, 137);
            this.dg_empwise.Name = "dg_empwise";
            this.dg_empwise.Size = new System.Drawing.Size(240, 150);
            this.dg_empwise.TabIndex = 9;
            // 
            // dg_plotwise
            // 
            this.dg_plotwise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_plotwise.Location = new System.Drawing.Point(348, 137);
            this.dg_plotwise.Name = "dg_plotwise";
            this.dg_plotwise.Size = new System.Drawing.Size(240, 150);
            this.dg_plotwise.TabIndex = 10;
            // 
            // btn_view_emp
            // 
            this.btn_view_emp.Location = new System.Drawing.Point(130, 293);
            this.btn_view_emp.Name = "btn_view_emp";
            this.btn_view_emp.Size = new System.Drawing.Size(75, 23);
            this.btn_view_emp.TabIndex = 11;
            this.btn_view_emp.Text = "View";
            this.btn_view_emp.UseVisualStyleBackColor = true;
            this.btn_view_emp.Click += new System.EventHandler(this.btn_view_emp_Click);
            // 
            // brn_view_plot
            // 
            this.brn_view_plot.Location = new System.Drawing.Point(431, 293);
            this.brn_view_plot.Name = "brn_view_plot";
            this.brn_view_plot.Size = new System.Drawing.Size(75, 23);
            this.brn_view_plot.TabIndex = 12;
            this.brn_view_plot.Text = "View";
            this.brn_view_plot.UseVisualStyleBackColor = true;
            this.brn_view_plot.Click += new System.EventHandler(this.brn_view_plot_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(212, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Attendance Reports";
            // 
            // emp_rpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 345);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.brn_view_plot);
            this.Controls.Add(this.btn_view_emp);
            this.Controls.Add(this.dg_plotwise);
            this.Controls.Add(this.dg_empwise);
            this.Controls.Add(this.cb_plotno);
            this.Controls.Add(this.cb_fieldno);
            this.Controls.Add(this.cb_employee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "emp_rpt";
            this.Text = "emp_rpt";
            ((System.ComponentModel.ISupportInitialize)(this.dg_empwise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_plotwise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_employee;
        private System.Windows.Forms.ComboBox cb_fieldno;
        private System.Windows.Forms.ComboBox cb_plotno;
        private System.Windows.Forms.DataGridView dg_empwise;
        private System.Windows.Forms.DataGridView dg_plotwise;
        private System.Windows.Forms.Button btn_view_emp;
        private System.Windows.Forms.Button brn_view_plot;
        private System.Windows.Forms.Label label6;
    }
}