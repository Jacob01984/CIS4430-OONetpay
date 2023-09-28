namespace OONetpay
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.numYOS = new System.Windows.Forms.NumericUpDown();
            this.txtPayrate = new System.Windows.Forms.TextBox();
            this.numHours = new System.Windows.Forms.NumericUpDown();
            this.Name11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.txtFed = new System.Windows.Forms.TextBox();
            this.txtSs = new System.Windows.Forms.TextBox();
            this.txtMed = new System.Windows.Forms.TextBox();
            this.txtTotalDed = new System.Windows.Forms.TextBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.GrossPay = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numYOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(67, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 23);
            this.txtName.TabIndex = 0;
            // 
            // numYOS
            // 
            this.numYOS.Location = new System.Drawing.Point(67, 169);
            this.numYOS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numYOS.Name = "numYOS";
            this.numYOS.Size = new System.Drawing.Size(120, 23);
            this.numYOS.TabIndex = 1;
            this.numYOS.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtPayrate
            // 
            this.txtPayrate.Location = new System.Drawing.Point(67, 124);
            this.txtPayrate.Name = "txtPayrate";
            this.txtPayrate.Size = new System.Drawing.Size(100, 23);
            this.txtPayrate.TabIndex = 2;
            // 
            // numHours
            // 
            this.numHours.Location = new System.Drawing.Point(67, 86);
            this.numHours.Name = "numHours";
            this.numHours.Size = new System.Drawing.Size(120, 23);
            this.numHours.TabIndex = 3;
            // 
            // Name11
            // 
            this.Name11.AutoSize = true;
            this.Name11.Location = new System.Drawing.Point(12, 54);
            this.Name11.Name = "Name11";
            this.Name11.Size = new System.Drawing.Size(39, 15);
            this.Name11.TabIndex = 4;
            this.Name11.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Payrate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yrs of ser";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(67, 296);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(100, 40);
            this.btnProcess.TabIndex = 8;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // txtGross
            // 
            this.txtGross.Location = new System.Drawing.Point(523, 46);
            this.txtGross.Name = "txtGross";
            this.txtGross.Size = new System.Drawing.Size(128, 23);
            this.txtGross.TabIndex = 9;
            this.txtGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFed
            // 
            this.txtFed.Location = new System.Drawing.Point(567, 85);
            this.txtFed.Name = "txtFed";
            this.txtFed.Size = new System.Drawing.Size(84, 23);
            this.txtFed.TabIndex = 10;
            this.txtFed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSs
            // 
            this.txtSs.Location = new System.Drawing.Point(567, 124);
            this.txtSs.Name = "txtSs";
            this.txtSs.Size = new System.Drawing.Size(84, 23);
            this.txtSs.TabIndex = 11;
            this.txtSs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMed
            // 
            this.txtMed.Location = new System.Drawing.Point(567, 168);
            this.txtMed.Name = "txtMed";
            this.txtMed.Size = new System.Drawing.Size(84, 23);
            this.txtMed.TabIndex = 12;
            this.txtMed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalDed
            // 
            this.txtTotalDed.Location = new System.Drawing.Point(523, 209);
            this.txtTotalDed.Name = "txtTotalDed";
            this.txtTotalDed.Size = new System.Drawing.Size(128, 23);
            this.txtTotalDed.TabIndex = 13;
            this.txtTotalDed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(523, 246);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(128, 23);
            this.txtLong.TabIndex = 14;
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(523, 313);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(128, 23);
            this.txtPay.TabIndex = 15;
            // 
            // GrossPay
            // 
            this.GrossPay.AutoSize = true;
            this.GrossPay.Location = new System.Drawing.Point(409, 46);
            this.GrossPay.Name = "GrossPay";
            this.GrossPay.Size = new System.Drawing.Size(58, 15);
            this.GrossPay.TabIndex = 16;
            this.GrossPay.Text = "Gross Pay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Federal Tax";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Social Tax";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Medical";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(409, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Total Deduction";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(409, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Longivity Pay";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(409, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Net Pay";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GrossPay);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.txtTotalDed);
            this.Controls.Add(this.txtMed);
            this.Controls.Add(this.txtSs);
            this.Controls.Add(this.txtFed);
            this.Controls.Add(this.txtGross);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name11);
            this.Controls.Add(this.numHours);
            this.Controls.Add(this.txtPayrate);
            this.Controls.Add(this.numYOS);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numYOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtName;
        private NumericUpDown numYOS;
        private TextBox txtPayrate;
        private NumericUpDown numHours;
        private Label Name11;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnProcess;
        private TextBox txtGross;
        private TextBox txtFed;
        private TextBox txtSs;
        private TextBox txtMed;
        private TextBox txtTotalDed;
        private TextBox txtLong;
        private TextBox txtPay;
        private Label GrossPay;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}